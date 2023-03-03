namespace ArtAdimissionTestApp
{
    partial class artTestForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.generateNumberButton = new System.Windows.Forms.Button();
            this.testMetodButton = new System.Windows.Forms.Button();
            this.randomNumberTextBox = new System.Windows.Forms.TextBox();
            this.testResultTextBox = new System.Windows.Forms.RichTextBox();
            this.testNumberTextBox = new System.Windows.Forms.TextBox();
            this.testLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.callNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.callNumberNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // generateNumberButton
            // 
            this.generateNumberButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.generateNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateNumberButton.Location = new System.Drawing.Point(41, 41);
            this.generateNumberButton.Name = "generateNumberButton";
            this.generateNumberButton.Size = new System.Drawing.Size(194, 53);
            this.generateNumberButton.TabIndex = 0;
            this.generateNumberButton.Text = "Generar Número";
            this.generateNumberButton.UseVisualStyleBackColor = false;
            this.generateNumberButton.Click += new System.EventHandler(this.GenerateButtonClick);
            // 
            // testMetodButton
            // 
            this.testMetodButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.testMetodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testMetodButton.Location = new System.Drawing.Point(41, 175);
            this.testMetodButton.Name = "testMetodButton";
            this.testMetodButton.Size = new System.Drawing.Size(194, 57);
            this.testMetodButton.TabIndex = 1;
            this.testMetodButton.Text = "Probar Método";
            this.testMetodButton.UseVisualStyleBackColor = false;
            this.testMetodButton.Click += new System.EventHandler(this.TestMetodButtonClick);
            // 
            // randomNumberTextBox
            // 
            this.randomNumberTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.randomNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomNumberTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.randomNumberTextBox.Location = new System.Drawing.Point(377, 41);
            this.randomNumberTextBox.Name = "randomNumberTextBox";
            this.randomNumberTextBox.ReadOnly = true;
            this.randomNumberTextBox.Size = new System.Drawing.Size(57, 53);
            this.randomNumberTextBox.TabIndex = 2;
            this.randomNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // testResultTextBox
            // 
            this.testResultTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.testResultTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.testResultTextBox.Location = new System.Drawing.Point(253, 118);
            this.testResultTextBox.Name = "testResultTextBox";
            this.testResultTextBox.Size = new System.Drawing.Size(292, 149);
            this.testResultTextBox.TabIndex = 3;
            this.testResultTextBox.Text = "";
            // 
            // testNumberTextBox
            // 
            this.testNumberTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.testNumberTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.testNumberTextBox.Location = new System.Drawing.Point(165, 118);
            this.testNumberTextBox.Name = "testNumberTextBox";
            this.testNumberTextBox.Size = new System.Drawing.Size(70, 20);
            this.testNumberTextBox.TabIndex = 4;
            this.testNumberTextBox.Text = "1000";
            this.testNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel.Location = new System.Drawing.Point(38, 121);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(121, 13);
            this.testLabel.TabIndex = 5;
            this.testLabel.Text = "Número de pruebas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "El porcentaje de cada número debería estar en torno al 14.28%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "N° de llamados a Gen1To5";
            // 
            // callNumberNumericUpDown
            // 
            this.callNumberNumericUpDown.BackColor = System.Drawing.SystemColors.WindowText;
            this.callNumberNumericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.callNumberNumericUpDown.Location = new System.Drawing.Point(195, 143);
            this.callNumberNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.callNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.callNumberNumericUpDown.Name = "callNumberNumericUpDown";
            this.callNumberNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.callNumberNumericUpDown.TabIndex = 8;
            this.callNumberNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.callNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // artTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(560, 291);
            this.Controls.Add(this.callNumberNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.testNumberTextBox);
            this.Controls.Add(this.testResultTextBox);
            this.Controls.Add(this.randomNumberTextBox);
            this.Controls.Add(this.testMetodButton);
            this.Controls.Add(this.generateNumberButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "artTestForm";
            this.Text = "ART TEST";
            ((System.ComponentModel.ISupportInitialize)(this.callNumberNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateNumberButton;
        private System.Windows.Forms.Button testMetodButton;
        private System.Windows.Forms.TextBox randomNumberTextBox;
        private System.Windows.Forms.RichTextBox testResultTextBox;
        private System.Windows.Forms.TextBox testNumberTextBox;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown callNumberNumericUpDown;
    }
}

