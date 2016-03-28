namespace InClassCSharp328
{
    partial class Form1
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
            this.tbAddressLineOne = new System.Windows.Forms.TextBox();
            this.tbAddressLineTwo = new System.Windows.Forms.TextBox();
            this.tbCityInput = new System.Windows.Forms.TextBox();
            this.tbStateInput = new System.Windows.Forms.TextBox();
            this.tbZipCodeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStandardize = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.lblStructured = new System.Windows.Forms.Label();
            this.tbSZipCode = new System.Windows.Forms.TextBox();
            this.tbSState = new System.Windows.Forms.TextBox();
            this.tbSCity = new System.Windows.Forms.TextBox();
            this.tbSAddressLineTwo = new System.Windows.Forms.TextBox();
            this.tbSAddressLineOne = new System.Windows.Forms.TextBox();
            this.btnStructure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAddressLineOne
            // 
            this.tbAddressLineOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddressLineOne.Location = new System.Drawing.Point(12, 32);
            this.tbAddressLineOne.Name = "tbAddressLineOne";
            this.tbAddressLineOne.Size = new System.Drawing.Size(303, 26);
            this.tbAddressLineOne.TabIndex = 0;
            // 
            // tbAddressLineTwo
            // 
            this.tbAddressLineTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddressLineTwo.Location = new System.Drawing.Point(12, 64);
            this.tbAddressLineTwo.Name = "tbAddressLineTwo";
            this.tbAddressLineTwo.Size = new System.Drawing.Size(303, 26);
            this.tbAddressLineTwo.TabIndex = 1;
            // 
            // tbCityInput
            // 
            this.tbCityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCityInput.Location = new System.Drawing.Point(12, 96);
            this.tbCityInput.Name = "tbCityInput";
            this.tbCityInput.Size = new System.Drawing.Size(131, 26);
            this.tbCityInput.TabIndex = 2;
            // 
            // tbStateInput
            // 
            this.tbStateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStateInput.Location = new System.Drawing.Point(149, 96);
            this.tbStateInput.Name = "tbStateInput";
            this.tbStateInput.Size = new System.Drawing.Size(66, 26);
            this.tbStateInput.TabIndex = 3;
            // 
            // tbZipCodeInput
            // 
            this.tbZipCodeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZipCodeInput.Location = new System.Drawing.Point(221, 96);
            this.tbZipCodeInput.Name = "tbZipCodeInput";
            this.tbZipCodeInput.Size = new System.Drawing.Size(94, 26);
            this.tbZipCodeInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Address";
            // 
            // btnStandardize
            // 
            this.btnStandardize.Location = new System.Drawing.Point(306, 150);
            this.btnStandardize.Name = "btnStandardize";
            this.btnStandardize.Size = new System.Drawing.Size(144, 30);
            this.btnStandardize.TabIndex = 6;
            this.btnStandardize.Text = "Standardize";
            this.btnStandardize.UseVisualStyleBackColor = true;
            this.btnStandardize.Click += new System.EventHandler(this.btnStandardize_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(306, 186);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(144, 30);
            this.btnReadFile.TabIndex = 7;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Location = new System.Drawing.Point(306, 222);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(144, 30);
            this.btnExitProgram.TabIndex = 8;
            this.btnExitProgram.Text = "Exit Program";
            this.btnExitProgram.UseVisualStyleBackColor = true;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // lblStructured
            // 
            this.lblStructured.AutoSize = true;
            this.lblStructured.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStructured.Location = new System.Drawing.Point(517, 9);
            this.lblStructured.Name = "lblStructured";
            this.lblStructured.Size = new System.Drawing.Size(147, 20);
            this.lblStructured.TabIndex = 14;
            this.lblStructured.Text = "Structured Address";
            // 
            // tbSZipCode
            // 
            this.tbSZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSZipCode.Location = new System.Drawing.Point(649, 96);
            this.tbSZipCode.Name = "tbSZipCode";
            this.tbSZipCode.Size = new System.Drawing.Size(94, 26);
            this.tbSZipCode.TabIndex = 13;
            // 
            // tbSState
            // 
            this.tbSState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSState.Location = new System.Drawing.Point(577, 96);
            this.tbSState.Name = "tbSState";
            this.tbSState.Size = new System.Drawing.Size(66, 26);
            this.tbSState.TabIndex = 12;
            // 
            // tbSCity
            // 
            this.tbSCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSCity.Location = new System.Drawing.Point(440, 96);
            this.tbSCity.Name = "tbSCity";
            this.tbSCity.Size = new System.Drawing.Size(131, 26);
            this.tbSCity.TabIndex = 11;
            // 
            // tbSAddressLineTwo
            // 
            this.tbSAddressLineTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSAddressLineTwo.Location = new System.Drawing.Point(440, 64);
            this.tbSAddressLineTwo.Name = "tbSAddressLineTwo";
            this.tbSAddressLineTwo.Size = new System.Drawing.Size(303, 26);
            this.tbSAddressLineTwo.TabIndex = 10;
            // 
            // tbSAddressLineOne
            // 
            this.tbSAddressLineOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSAddressLineOne.Location = new System.Drawing.Point(440, 32);
            this.tbSAddressLineOne.Name = "tbSAddressLineOne";
            this.tbSAddressLineOne.Size = new System.Drawing.Size(303, 26);
            this.tbSAddressLineOne.TabIndex = 9;
            // 
            // btnStructure
            // 
            this.btnStructure.Location = new System.Drawing.Point(550, 172);
            this.btnStructure.Name = "btnStructure";
            this.btnStructure.Size = new System.Drawing.Size(144, 30);
            this.btnStructure.TabIndex = 15;
            this.btnStructure.Text = "Structure";
            this.btnStructure.UseVisualStyleBackColor = true;
            this.btnStructure.Click += new System.EventHandler(this.btnStructure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 264);
            this.Controls.Add(this.btnStructure);
            this.Controls.Add(this.lblStructured);
            this.Controls.Add(this.tbSZipCode);
            this.Controls.Add(this.tbSState);
            this.Controls.Add(this.tbSCity);
            this.Controls.Add(this.tbSAddressLineTwo);
            this.Controls.Add(this.tbSAddressLineOne);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnStandardize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbZipCodeInput);
            this.Controls.Add(this.tbStateInput);
            this.Controls.Add(this.tbCityInput);
            this.Controls.Add(this.tbAddressLineTwo);
            this.Controls.Add(this.tbAddressLineOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddressLineOne;
        private System.Windows.Forms.TextBox tbAddressLineTwo;
        private System.Windows.Forms.TextBox tbCityInput;
        private System.Windows.Forms.TextBox tbStateInput;
        private System.Windows.Forms.TextBox tbZipCodeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStandardize;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnExitProgram;
        private System.Windows.Forms.Label lblStructured;
        private System.Windows.Forms.TextBox tbSZipCode;
        private System.Windows.Forms.TextBox tbSState;
        private System.Windows.Forms.TextBox tbSCity;
        private System.Windows.Forms.TextBox tbSAddressLineTwo;
        private System.Windows.Forms.TextBox tbSAddressLineOne;
        private System.Windows.Forms.Button btnStructure;
    }
}

