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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("10");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("2");
            this.ProductsBox = new System.Windows.Forms.GroupBox();
            this.StoreBox = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProductsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsBox
            // 
            this.ProductsBox.Controls.Add(this.listView1);
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
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.ProductsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductsBox;
        private System.Windows.Forms.GroupBox StoreBox;
        private System.Windows.Forms.ListView listView1;
    }
}