namespace COMP1004_W2017_Lesson5
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FunctionOptionsBox = new System.Windows.Forms.GroupBox();
            this.ExponentBox = new System.Windows.Forms.CheckBox();
            this.SquareRootCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ScientificButton = new System.Windows.Forms.RadioButton();
            this.StandardButton = new System.Windows.Forms.RadioButton();
            this.FontButton = new System.Windows.Forms.Button();
            this.CalculatorFontDialog = new System.Windows.Forms.FontDialog();
            this.FunctionOptionsBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptButton.Location = new System.Drawing.Point(12, 350);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(136, 50);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this._acceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(273, 350);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(145, 50);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // FunctionOptionsBox
            // 
            this.FunctionOptionsBox.Controls.Add(this.ExponentBox);
            this.FunctionOptionsBox.Controls.Add(this.SquareRootCheck);
            this.FunctionOptionsBox.Location = new System.Drawing.Point(13, 13);
            this.FunctionOptionsBox.Name = "FunctionOptionsBox";
            this.FunctionOptionsBox.Size = new System.Drawing.Size(202, 133);
            this.FunctionOptionsBox.TabIndex = 2;
            this.FunctionOptionsBox.TabStop = false;
            this.FunctionOptionsBox.Text = "Functions";
            // 
            // ExponentBox
            // 
            this.ExponentBox.AutoSize = true;
            this.ExponentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExponentBox.Location = new System.Drawing.Point(6, 84);
            this.ExponentBox.Name = "ExponentBox";
            this.ExponentBox.Size = new System.Drawing.Size(136, 33);
            this.ExponentBox.TabIndex = 1;
            this.ExponentBox.Text = "Exponent";
            this.ExponentBox.UseVisualStyleBackColor = true;
            // 
            // SquareRootCheck
            // 
            this.SquareRootCheck.AutoSize = true;
            this.SquareRootCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareRootCheck.Location = new System.Drawing.Point(7, 45);
            this.SquareRootCheck.Name = "SquareRootCheck";
            this.SquareRootCheck.Size = new System.Drawing.Size(170, 33);
            this.SquareRootCheck.TabIndex = 0;
            this.SquareRootCheck.Text = "Square Root";
            this.SquareRootCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScientificButton);
            this.groupBox1.Controls.Add(this.StandardButton);
            this.groupBox1.Location = new System.Drawing.Point(221, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layout";
            // 
            // ScientificButton
            // 
            this.ScientificButton.AutoSize = true;
            this.ScientificButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScientificButton.Location = new System.Drawing.Point(7, 84);
            this.ScientificButton.Name = "ScientificButton";
            this.ScientificButton.Size = new System.Drawing.Size(131, 33);
            this.ScientificButton.TabIndex = 1;
            this.ScientificButton.Text = "Scientific";
            this.ScientificButton.UseVisualStyleBackColor = true;
            this.ScientificButton.CheckedChanged += new System.EventHandler(this.StandardButton_CheckedChanged);
            // 
            // StandardButton
            // 
            this.StandardButton.AutoSize = true;
            this.StandardButton.Checked = true;
            this.StandardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardButton.Location = new System.Drawing.Point(7, 45);
            this.StandardButton.Name = "StandardButton";
            this.StandardButton.Size = new System.Drawing.Size(131, 33);
            this.StandardButton.TabIndex = 0;
            this.StandardButton.TabStop = true;
            this.StandardButton.Text = "Standard";
            this.StandardButton.UseVisualStyleBackColor = true;
            this.StandardButton.CheckedChanged += new System.EventHandler(this.StandardButton_CheckedChanged);
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(12, 263);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(136, 50);
            this.FontButton.TabIndex = 4;
            this.FontButton.Text = "Font";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this._fontButton_Click);
            // 
            // CalculatorFontDialog
            // 
            this.CalculatorFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorFontDialog.MaxSize = 24;
            this.CalculatorFontDialog.MinSize = 10;
            // 
            // OptionsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(430, 412);
            this.ControlBox = false;
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FunctionOptionsBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsForm";
            this.FunctionOptionsBox.ResumeLayout(false);
            this.FunctionOptionsBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox FunctionOptionsBox;
        private System.Windows.Forms.CheckBox ExponentBox;
        private System.Windows.Forms.CheckBox SquareRootCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ScientificButton;
        private System.Windows.Forms.RadioButton StandardButton;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.FontDialog CalculatorFontDialog;
    }
}