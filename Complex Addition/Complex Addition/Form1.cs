using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complex_Addition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            double r1 = Convert.ToDouble(r1textbox.Text);
            double r2 = Convert.ToDouble(r2textbox.Text);
            double i1 = Convert.ToDouble(i1textbox.Text);
            double i2 = Convert.ToDouble(i2textbox.Text);

            Complex c1 = new Complex(r1, i1);
            Complex c2 = new Complex(r2, i2);

            Complex result = c1 + c2;

            ansLabel.Text = result.ToString();
        }

        private void SubtractButton_Click_1(object sender, EventArgs e)
        {
            double r1 = Convert.ToDouble(r1textbox.Text);
            double r2 = Convert.ToDouble(r2textbox.Text);
            double i1 = Convert.ToDouble(i1textbox.Text);
            double i2 = Convert.ToDouble(i2textbox.Text);

            Complex c1 = new Complex(r1, i1);
            Complex c2 = new Complex(r2, i2);

            Complex result = c1 - c2;

            ansLabel.Text = result.ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            double r1 = Convert.ToDouble(r1textbox.Text);
            double r2 = Convert.ToDouble(r2textbox.Text);
            double i1 = Convert.ToDouble(i1textbox.Text);
            double i2 = Convert.ToDouble(i2textbox.Text);

            Complex c1 = new Complex(r1, i1);
            Complex c2 = new Complex(r2, i2);

            Complex result = c1 * c2;

            ansLabel.Text = result.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            r1textbox.Text = String.Empty;
            r2textbox.Text = String.Empty;
            i1textbox.Text = String.Empty;
            i2textbox.Text = String.Empty;
            ansLabel.Text = "0";
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            double r1 = Convert.ToDouble(r1textbox.Text);
            double r2 = Convert.ToDouble(r2textbox.Text);
            double i1 = Convert.ToDouble(i1textbox.Text);
            double i2 = Convert.ToDouble(i2textbox.Text);

            Complex c1 = new Complex(r1, i1);
            Complex c2 = new Complex(r2, i2);

            Complex result = c1 / c2;

            ansLabel.Text = result.ToString();
        }
    }
}
