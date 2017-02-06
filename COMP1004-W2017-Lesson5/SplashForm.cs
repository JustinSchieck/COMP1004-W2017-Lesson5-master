using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson5
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {

            // 1. Instantiate the next form
            CalculatorForm calculatorForm = new CalculatorForm();

            // 2. pass a reference to the current form to the next form
            calculatorForm.previousForm = this;

            this.SplashFormTimer.Enabled = false;
            calculatorForm.Show();
            this.Hide();


        }
    }
}
