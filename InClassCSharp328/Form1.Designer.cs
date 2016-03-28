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
            this.btnStandardize.Location = new System.Drawing.Point(269, 178);
            this.btnStandardize.Name = "btnStandardize";
            this.btnStandardize.Size = new System.Drawing.Size(144, 44);
            this.btnStandardize.TabIndex = 6;
            this.btnStandardize.Text = "Standardize";
            this.btnStandardize.UseVisualStyleBackColor = true;
            this.btnStandardize.Click += new System.EventHandler(this.btnStandardize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 264);
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
    }
}

