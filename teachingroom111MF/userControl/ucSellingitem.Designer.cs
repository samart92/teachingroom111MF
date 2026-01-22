namespace teachingroom111MF.userControl
{
    partial class ucSellingitem
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
            this.btnclose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstrack = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblProName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(293, 9);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(36, 36);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(185, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstrack
            // 
            this.btnSubstrack.Location = new System.Drawing.Point(221, 9);
            this.btnSubstrack.Name = "btnSubstrack";
            this.btnSubstrack.Size = new System.Drawing.Size(36, 36);
            this.btnSubstrack.TabIndex = 2;
            this.btnSubstrack.Text = "-";
            this.btnSubstrack.UseVisualStyleBackColor = true;
            this.btnSubstrack.Click += new System.EventHandler(this.btnSubstrack_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(257, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "%";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblProName
            // 
            this.lblProName.AutoSize = true;
            this.lblProName.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProName.Location = new System.Drawing.Point(3, 0);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(85, 27);
            this.lblProName.TabIndex = 4;
            this.lblProName.Text = "Pro Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(3, 33);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 27);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "$ 20 X 1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(120, 14);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 27);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "$20.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucSellingitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSubstrack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnclose);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ucSellingitem";
            this.Size = new System.Drawing.Size(337, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstrack;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label lblProName;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblTotal;
    }
}
