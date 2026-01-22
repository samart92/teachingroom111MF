namespace teachingroom111MF.allForm
{
    partial class frmOrder
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
            this.flpCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.flpProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpSelling = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpCategory
            // 
            this.flpCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCategory.Location = new System.Drawing.Point(0, 0);
            this.flpCategory.Name = "flpCategory";
            this.flpCategory.Size = new System.Drawing.Size(1096, 53);
            this.flpCategory.TabIndex = 0;
            // 
            // flpProduct
            // 
            this.flpProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProduct.Location = new System.Drawing.Point(0, 53);
            this.flpProduct.Name = "flpProduct";
            this.flpProduct.Size = new System.Drawing.Size(751, 692);
            this.flpProduct.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flpSelling);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(751, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 692);
            this.panel1.TabIndex = 2;
            // 
            // flpSelling
            // 
            this.flpSelling.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpSelling.Location = new System.Drawing.Point(0, 0);
            this.flpSelling.Name = "flpSelling";
            this.flpSelling.Size = new System.Drawing.Size(345, 541);
            this.flpSelling.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 567);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 125);
            this.panel2.TabIndex = 1;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 745);
            this.Controls.Add(this.flpProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpCategory);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCategory;
        public System.Windows.Forms.FlowLayoutPanel flpProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.FlowLayoutPanel flpSelling;
    }
}