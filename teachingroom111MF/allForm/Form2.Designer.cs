namespace teachingroom111MF.allForm
{
    partial class Form2
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
            this.ucCountNumber1 = new teachingroom111MF.userControl.ucCountNumber();
            this.ucCountNumber2 = new teachingroom111MF.userControl.ucCountNumber();
            this.ucCountNumber3 = new teachingroom111MF.userControl.ucCountNumber();
            this.SuspendLayout();
            // 
            // ucCountNumber1
            // 
            this.ucCountNumber1.Counts = "10";
            this.ucCountNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCountNumber1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ucCountNumber1.InforText = "Total Products";
            this.ucCountNumber1.Location = new System.Drawing.Point(42, 31);
            this.ucCountNumber1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucCountNumber1.Name = "ucCountNumber1";
            this.ucCountNumber1.Photos = "https://cdn-icons-png.flaticon.com/512/4129/4129528.png";
            this.ucCountNumber1.Size = new System.Drawing.Size(264, 114);
            this.ucCountNumber1.TabIndex = 0;
            // 
            // ucCountNumber2
            // 
            this.ucCountNumber2.Counts = "Number";
            this.ucCountNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCountNumber2.InforText = "Information";
            this.ucCountNumber2.Location = new System.Drawing.Point(314, 31);
            this.ucCountNumber2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucCountNumber2.Name = "ucCountNumber2";
            this.ucCountNumber2.Photos = "https://www.pikpng.com/pngl/m/541-5410770_png-file-svg-categories-icon-png-clipar" +
    "t.png";
            this.ucCountNumber2.Size = new System.Drawing.Size(264, 114);
            this.ucCountNumber2.TabIndex = 1;
            // 
            // ucCountNumber3
            // 
            this.ucCountNumber3.Counts = "Number";
            this.ucCountNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCountNumber3.InforText = "Information";
            this.ucCountNumber3.Location = new System.Drawing.Point(586, 31);
            this.ucCountNumber3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucCountNumber3.Name = "ucCountNumber3";
            this.ucCountNumber3.Photos = "https://img.freepik.com/premium-vector/image-icon-represents-visual-element-used-" +
    "symbolize-photos-pictures-graphics_142112-6442.jpg";
            this.ucCountNumber3.Size = new System.Drawing.Size(264, 114);
            this.ucCountNumber3.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.ucCountNumber3);
            this.Controls.Add(this.ucCountNumber2);
            this.Controls.Add(this.ucCountNumber1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private userControl.ucCountNumber ucCountNumber1;
        private userControl.ucCountNumber ucCountNumber2;
        private userControl.ucCountNumber ucCountNumber3;
    }
}