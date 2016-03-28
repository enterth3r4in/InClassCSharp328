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
            this.SuspendLayout();
            // 
            // tbAddressLineOne
            // 
            this.tbAddressLineOne.Location = new System.Drawing.Point(12, 12);
            this.tbAddressLineOne.Name = "tbAddressLineOne";
            this.tbAddressLineOne.Size = new System.Drawing.Size(100, 20);
            this.tbAddressLineOne.TabIndex = 0;
            // 
            // tbAddressLineTwo
            // 
            this.tbAddressLineTwo.Location = new System.Drawing.Point(12, 38);
            this.tbAddressLineTwo.Name = "tbAddressLineTwo";
            this.tbAddressLineTwo.Size = new System.Drawing.Size(100, 20);
            this.tbAddressLineTwo.TabIndex = 1;
            // 
            // tbCityInput
            // 
            this.tbCityInput.Location = new System.Drawing.Point(12, 64);
            this.tbCityInput.Name = "tbCityInput";
            this.tbCityInput.Size = new System.Drawing.Size(100, 20);
            this.tbCityInput.TabIndex = 2;
            // 
            // tbStateInput
            // 
            this.tbStateInput.Location = new System.Drawing.Point(149, 64);
            this.tbStateInput.Name = "tbStateInput";
            this.tbStateInput.Size = new System.Drawing.Size(100, 20);
            this.tbStateInput.TabIndex = 3;
            // 
            // tbZipCodeInput
            // 
            this.tbZipCodeInput.Location = new System.Drawing.Point(283, 64);
            this.tbZipCodeInput.Name = "tbZipCodeInput";
            this.tbZipCodeInput.Size = new System.Drawing.Size(100, 20);
            this.tbZipCodeInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 403);
            this.Controls.Add(this.tbZipCodeInput);
            this.Controls.Add(this.tbStateInput);
            this.Controls.Add(this.tbCityInput);
            this.Controls.Add(this.tbAddressLineTwo);
            this.Controls.Add(this.tbAddressLineOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddressLineOne;
        private System.Windows.Forms.TextBox tbAddressLineTwo;
        private System.Windows.Forms.TextBox tbCityInput;
        private System.Windows.Forms.TextBox tbStateInput;
        private System.Windows.Forms.TextBox tbZipCodeInput;
    }
}

