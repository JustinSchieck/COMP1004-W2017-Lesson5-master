﻿using System;
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
    public partial class CalculatorForm : Form
    {
        // 3. create a reference to the previous form
        public Form previousForm;
        public String CalculatorFormLayout { get; set; }

        // PRIVATE INSTANCE VARIABLES
        private string _operand1;
        private string _operand2;
        private bool _isCalculatorClear;
        private string _calculatorFormLayout;
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();

            this._clearCalculator();
            this.CalculatorFormLayout = "";
        }

        public string CalculatorFormLayout {
            get
            {
                return this._calculatorFormLayout;
            }

            set
            {
                this._calculatorFormLayout = value;
                Debug.WriteLine("Calculator Form Changed");
            }
        }
    
        /// <summary>
        /// This method clears the calculator app and resets the variables
        /// </summary>
        private void _clearCalculator()
        {
            this._operand1 = "";
            this._operand2 = "";
            this._isCalculatorClear = true;
            ResultTextBox.Text = "0";
        }


        /// <summary>
        /// Event Handler for all Calculator Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _calculatorButton_Click(object sender, EventArgs e)
        {
            Button CalculatorButton = sender as Button;

            switch (CalculatorButton.Tag.ToString())
            {
                case "Operand":
                    if (this._isCalculatorClear)
                    {
                        ResultTextBox.Text = CalculatorButton.Text;
                        this._isCalculatorClear = false;
                    }
                    else
                    {
                        ResultTextBox.Text += CalculatorButton.Text;
                    }
                    break;
                case "Operator":
                    break;
                case "Other":
                    break;
            }
        }

        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {


            DialogResult result = MessageBox.Show("Are You Sure?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.previousForm.Close();
            }
            else
            {
                e.Cancel = true;
            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Step 1: Creates a new form
            AboutForm aboutForm = new AboutForm();

            //Step 2: Show the about form with showDialog(a modal method to display the form)
            aboutForm.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            //Step 1: Creates a new form
            OptionsForm optionsForm = new OptionsForm();

            optionsForm.PreviousForm = this;

            optionsForm.CalculatorLayout = this.CalculatorFormLayout;

            //Step 2: Show the about form with showDialog(a modal method to display the form)
            result = optionsForm.ShowDialog();

            Debug.WriteLine(result.ToString());
        }
    }
}
