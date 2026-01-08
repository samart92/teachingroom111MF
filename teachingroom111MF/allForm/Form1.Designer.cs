namespace teachingroom111MF
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
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.ucCountNumber1 = new teachingroom111MF.userControl.ucCountNumber();
            this.SuspendLayout();
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(109, 93);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(256, 37);
            this.txtinput.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(259, 136);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(106, 37);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "show";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // ucCountNumber1
            // 
            this.ucCountNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCountNumber1.InforText = "Number of User";
            this.ucCountNumber1.Location = new System.Drawing.Point(122, 219);
            this.ucCountNumber1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucCountNumber1.Name = "ucCountNumber1";
           // this.ucCountNumber1.Number = "10";
            this.ucCountNumber1.Photos = "https://img.freepik.com/premium-vector/image-icon-represents-visual-element-used-" +
    "symbolize-photos-pictures-graphics_142112-6442.jpg";
            this.ucCountNumber1.Size = new System.Drawing.Size(264, 114);
            this.ucCountNumber1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 347);
            this.Controls.Add(this.ucCountNumber1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtinput);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnCheck;
        private userControl.ucCountNumber ucCountNumber1;
    }
}

