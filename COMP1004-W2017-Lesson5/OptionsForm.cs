using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson5
{
    public partial class OptionsForm : Form
    {
        /// <summary>
        /// Options form controls for all the options for the calculator 
        /// </summary>


            //Constructors
      public OptionsForm()
        {
            InitializeComponent();
        }

        //Public Properties++++++++++++++++++++++++++++++++++++++++++++++++
        public string CalculatorLayout { get; set; }
        public bool isExponentActive { get; set; }
        public bool isSquareRootActive { get; set; }

        public CalculatorForm PreviousForm { get; set; }

        //Private Methods ================================================


        //Event Handlers==================================================

        /// <summary>
        /// Cancel Button Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Accept button Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _acceptButton_Click(object sender, EventArgs e)
        {

            this.PreviousForm.CalculatorFormLayout = this.CalculatorLayout;
            this.Close();
        }

        /// <summary>
        /// Font Button Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _fontButton_Click(object sender, EventArgs e)
        {
            CalculatorFontDialog.ShowDialog();
            //this.Close();
        }

        private void StandardButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton calculatorRadioButton = sender as RadioButton;
            this.CalculatorLayout = calculatorRadioButton.Text;
            Debug.WriteLine(this.CalculatorLayout);
        }

        
    }
}
