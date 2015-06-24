namespace SimulatorIOSDeveloper
{
    partial class ShopForm
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
            this.ProductsBox = new System.Windows.Forms.GroupBox();
            this.StoreBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // ProductsBox
            // 
            this.ProductsBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProductsBox.Location = new System.Drawing.Point(12, 12);
            this.ProductsBox.Name = "ProductsBox";
            this.ProductsBox.Size = new System.Drawing.Size(168, 393);
            this.ProductsBox.TabIndex = 0;
            this.ProductsBox.TabStop = false;
            this.ProductsBox.Text = "Products";
            // 
            // StoreBox
            // 
            this.StoreBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.StoreBox.Location = new System.Drawing.Point(192, 12);
            this.StoreBox.Name = "StoreBox";
            this.StoreBox.Size = new System.Drawing.Size(177, 393);
            this.StoreBox.TabIndex = 1;
            this.StoreBox.TabStop = false;
            this.StoreBox.Text = "Store Home";
            this.StoreBox.Enter += new System.EventHandler(this.StoreBox_Enter);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(381, 417);
            this.Controls.Add(this.StoreBox);
            this.Controls.Add(this.ProductsBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductsBox;
        private System.Windows.Forms.GroupBox StoreBox;
    }
}