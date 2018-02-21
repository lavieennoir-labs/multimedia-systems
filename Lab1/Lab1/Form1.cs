using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {

        Color ValidColor = Color.ForestGreen;
        Color InvalidColor = Color.Firebrick;

        FormViewModel viewModel;
        IntervalValidator validator;
        RenderingContext renderingContext;

        public Form1()
        {
            InitializeComponent();
            viewModel = new FormViewModel();
            validator = new IntervalValidator();
            
            //bind viewmodel to view
            viewModel.PropertyChanged += 
                (obj, e) => 
                {
                    if (e.PropertyName == "MinX")
                        tbMinX.Text = viewModel.MinX.ToString();
                    else if (e.PropertyName == "MaxX")
                        tbMaxX.Text = viewModel.MaxX.ToString();
                };
            viewModel.MinX = -8;
            viewModel.MaxX = 8;

            CheckInterval();

            //setup render
            renderingContext = new RenderingContext
            {
                MinX = viewModel.MinX,
                MaxX = viewModel.MaxX,
                AxisColor = Color.DarkGray,
                GridColor = Color.LightGray,
                MarksColor = Color.FromKnownColor(KnownColor.ControlText),
                MinAvailableX = validator.MinAvailableLimit,
                MaxAvailableX = validator.MaxAvailableLimit,
                Function = (x) => (float)(Math.Pow(x, 3) + 3)
            };
            openGLControl.RenderingContext = renderingContext;
        }

        private void CheckInterval()
        {
            var result = validator.IsLimitValid(tbMinX.Text, tbMaxX.Text);

            //set color of text box undelines
            if (result.IsMinXValid)
            {
                pMinXUnderline.BackColor = ValidColor;
                viewModel.MinX = Int32.Parse(tbMinX.Text);
            }
            else
                pMinXUnderline.BackColor = InvalidColor;

            if (result.IsMaxXValid)
            {
                pMaxXUnderline.BackColor = ValidColor;
                viewModel.MaxX = Int32.Parse(tbMaxX.Text);
            }
            else
                pMaxXUnderline.BackColor = InvalidColor;

            //error text
            lblError.Text = result.Error;
            //is button enabled
            btnRender.Enabled = result.Error == "";
        }


        private void tbMinX_TextChanged(object sender, EventArgs e)
        {
            CheckInterval();
        }

        private void tbMaxX_TextChanged(object sender, EventArgs e)
        {
            CheckInterval();
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            renderingContext.MinX = viewModel.MinX;
            renderingContext.MaxX = viewModel.MaxX;
            renderingContext.GridResized = true;

            openGLControl.Render();
        }
    }
}
