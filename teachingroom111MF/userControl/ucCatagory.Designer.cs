namespace teachingroom111MF.userControl
{
    partial class ucCatagory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCatagory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCatagory
            // 
            this.btnCatagory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCatagory.Location = new System.Drawing.Point(0, 0);
            this.btnCatagory.Name = "btnCatagory";
            this.btnCatagory.Size = new System.Drawing.Size(120, 40);
            this.btnCatagory.TabIndex = 0;
            this.btnCatagory.Text = "ALL";
            this.btnCatagory.UseVisualStyleBackColor = true;
            this.btnCatagory.Click += new System.EventHandler(this.btnCatagory_Click);
            // 
            // ucCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCatagory);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "ucCatagory";
            this.Size = new System.Drawing.Size(120, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCatagory;
    }
}
