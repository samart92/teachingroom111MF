namespace teachingroom111MF.userControl
{
    partial class ucCountNumber
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
            this.ptbimage = new System.Windows.Forms.PictureBox();
            this.lblInform = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimage)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbimage
            // 
            this.ptbimage.ImageLocation = "https://img.freepik.com/premium-vector/image-icon-represents-visual-element-used-" +
    "symbolize-photos-pictures-graphics_142112-6442.jpg";
            this.ptbimage.Location = new System.Drawing.Point(159, 7);
            this.ptbimage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbimage.Name = "ptbimage";
            this.ptbimage.Size = new System.Drawing.Size(93, 98);
            this.ptbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbimage.TabIndex = 0;
            this.ptbimage.TabStop = false;
            // 
            // lblInform
            // 
            this.lblInform.AutoSize = true;
            this.lblInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInform.Location = new System.Drawing.Point(12, 11);
            this.lblInform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInform.Name = "lblInform";
            this.lblInform.Size = new System.Drawing.Size(82, 18);
            this.lblInform.TabIndex = 1;
            this.lblInform.Text = "Information";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(9, 65);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(87, 25);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Number";
            // 
            // ucCountNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblInform);
            this.Controls.Add(this.ptbimage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucCountNumber";
            this.Size = new System.Drawing.Size(264, 114);
            ((System.ComponentModel.ISupportInitialize)(this.ptbimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbimage;
        private System.Windows.Forms.Label lblInform;
        private System.Windows.Forms.Label lblCount;
    }
}
