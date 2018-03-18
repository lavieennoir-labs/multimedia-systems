using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class FigureInputForm : Form
    {
        public Figure CreatedFigure;
        Color figureColor;
        public event EventHandler<Figure> FigureCreated;

        public FigureInputForm()
        {
            InitializeComponent();
            cbType.SelectedIndex = 0;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex < 2)
            {
                lblBaseR.Text = "Радіус";
                lblTopR.Visible = false;
                tbTopR.Visible = false;
            }
            else
            {
                lblBaseR.Text = "Радіус основи";
                lblTopR.Visible = true;
                tbTopR.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;
            double z = 0;
            double height = 0;
            double baseR = 0;
            double topR = 0;
            if (!Double.TryParse(tbX.Text, out x))
            {
                MessageBox.Show("X має бути числом!");
                return;
            }
            if (!Double.TryParse(tbY.Text, out y))
            {
                MessageBox.Show("Y має бути числом!");
                return;
            }
            if (!Double.TryParse(tbZ.Text, out z))
            {
                MessageBox.Show("z має бути числом!");
                return;
            }
            if (!Double.TryParse(tbHeight.Text, out height))
            {
                MessageBox.Show("Висота має бути числом!");
                return;
            }
            if (cbType.SelectedIndex < 2)
            {
                if (!Double.TryParse(tbBaseR.Text, out baseR))
                {
                    MessageBox.Show("Радіус має бути числом!");
                    return;
                }
            }
            else
            {
                if (!Double.TryParse(tbBaseR.Text, out baseR))
                {
                    MessageBox.Show("Радіус основи має бути числом!");
                    return;
                }
                if (!Double.TryParse(tbTopR.Text, out topR))
                {
                    MessageBox.Show("Радіус верхівки має бути числом!");
                    return;
                }
            }

            CreatedFigure = new Figure()
            {
                Type = (Figure.FigureType)cbType.SelectedIndex,
                Color = figureColor,
                X = x,
                Y = y,
                Z = z,
                Height = height,
                BaseRadius = baseR,
                TopRadius = topR
            };
            FigureCreated.Invoke(this, CreatedFigure);
            Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var result = colorDialog.ShowDialog();

            if (result != DialogResult.OK)
                return;
            figureColor = colorDialog.Color;
            pColor.BackColor = figureColor;
        }
    }
}
