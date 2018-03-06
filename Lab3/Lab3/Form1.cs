using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        Color ValidColor = Color.ForestGreen;
        Color InvalidColor = Color.Firebrick;

        FormViewModel viewModel;
        IntervalValidator validator;
        CoefValidator coefValidator;
        CoefValidator angleValidator;
        RenderingContext renderingContext;

        public Form1()
        {
            InitializeComponent();
            viewModel = new FormViewModel();
            validator = new IntervalValidator();
            coefValidator = new CoefValidator
            {
                Name ="Коефіцієнт",
                MinAvailableLimit = -1E5F,
                MaxAvailableLimit = 1E5F
            };
            angleValidator = new CoefValidator
            {
                Name ="Кут",
                MinAvailableLimit = -1E5F,
                MaxAvailableLimit = 1E5F
            };

            ViewModelInit();
            CheckInterval();
            CheckCoef();

            //init render
            renderingContext = new RenderingContext
            {
                MinX = viewModel.MinX,
                MaxX = viewModel.MaxX,
                FuncCoef = viewModel.A,
                RotationAngle = 0,
                MirroringAngle = 0,
                RotatePerFrameOZ = 0.5f,
                RotatePerFrameOY = 1,
                AxisColor = Color.DarkGray,
                GridColor = Color.LightGray,
                MarksColor = Color.FromKnownColor(KnownColor.ControlText),
                MinAvailableX = validator.MinAvailableLimit,
                MaxAvailableX = validator.MaxAvailableLimit,
                Function = (x, a) => (float)( a * Math.Pow(x, 2))
            };
            openGLControl.RenderingContext = renderingContext;

            lblFunc.Text =
                viewModel.A == 0 ? "y = 0" :
                viewModel.A == 1 ? "y = x^2" :
                    $"y = {viewModel.A} * x^2";
        }

        /// <summary>
        ///     Binding ViewModel properties to Form components.
        /// </summary>
        private void ViewModelInit()
        {
            viewModel.PropertyChanged +=
                (obj, e) =>
                {
                    if (e.PropertyName == "MinX")
                        tbMinX.Text = viewModel.MinX.ToString();
                    else if (e.PropertyName == "MaxX")
                        tbMaxX.Text = viewModel.MaxX.ToString();
                    else if (e.PropertyName == "IntervalError"
                            || e.PropertyName == "CoefError"
                            || e.PropertyName == "AngleError")
                        lblError.Text =
                            viewModel.IntervalError + 
                            Environment.NewLine + Environment.NewLine + 
                            viewModel.CoefError +
                            Environment.NewLine + Environment.NewLine +
                            viewModel.AngleError;
                };
            viewModel.MinX = -8;
            viewModel.MaxX = 8;
            viewModel.A = 1.0F;
            tbA.Text = viewModel.A.ToString();
            viewModel.Angle = 0;
            tbAngle.Text = viewModel.Angle.ToString();
            viewModel.IntervalError = "";
            viewModel.CoefError = "";
        }

        private void CheckInterval()
        {
            var result = validator.IsLimitValid(tbMinX.Text, tbMaxX.Text);

            //set color of text box undelines
            if (result.IsMinXValid)
            {
                pMinXUnderline.BackColor = ValidColor;
                viewModel.MinX = result.MinX;
            }
            else
                pMinXUnderline.BackColor = InvalidColor;

            if (result.IsMaxXValid)
            {
                pMaxXUnderline.BackColor = ValidColor;
                viewModel.MaxX = result.MaxX;
            }
            else
                pMaxXUnderline.BackColor = InvalidColor;

            //error text
            viewModel.IntervalError = result.Error;
            //is button enabled
            btnRender.Enabled = result.Error == "";
        }

        private void CheckCoef()
        {
            var result = coefValidator.IsCoefValid(tbA.Text);

            //set color of text box undelines
            if (result.IsCoefValid)
            {
                pAUnderline.BackColor = ValidColor;
                viewModel.A = result.Coef;
            }
            else
                pAUnderline.BackColor = InvalidColor;

            //error text
            viewModel.CoefError = result.Error;
            //is button enabled
            btnApplyCoef.Enabled = result.Error == "";
        }

        private void CheckAngle()
        {
            var result = angleValidator.IsCoefValid(tbAngle.Text);

            //set color of text box undelines
            if (result.IsCoefValid)
            {
                pAngleUnderline.BackColor = ValidColor;
                viewModel.Angle = result.Coef;
            }
            else
                pAngleUnderline.BackColor = InvalidColor;

            //error text
            viewModel.AngleError = result.Error;
            //is button enabled
            btnTurn.Enabled = result.Error == "";
        }


        private void tbMinX_TextChanged(object sender, EventArgs e)
        {
            CheckInterval();
        }

        private void tbMaxX_TextChanged(object sender, EventArgs e)
        {
            CheckInterval();
        }
        

        private void tbA_TextChanged(object sender, EventArgs e)
        {
            CheckCoef();
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            renderingContext.MinX = viewModel.MinX;
            renderingContext.MaxX = viewModel.MaxX;
            renderingContext.GridResized = true;

            openGLControl.Render();
        }

        private void btnApplyCoef_Click(object sender, EventArgs e)
        {
            renderingContext.FuncCoef = viewModel.A;
            lblFunc.Text =
                viewModel.A == 0 ? "y = 0" :
                viewModel.A == 1 ? "y = x^2" :
                    $"y = {viewModel.A} * x^2";
            openGLControl.Render();
        }

        private void tbAngle_TextChanged(object sender, EventArgs e)
        {
            CheckAngle();
        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            renderingContext.RotationAngle += viewModel.Angle;
            lblAngle.Text = $"α = {renderingContext.RotationAngle}°";
            openGLControl.Render();
        }
    }
}
