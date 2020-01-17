namespace SeeYouLatteStaff.Forms
{
    partial class Cashier
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
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.flpCashier = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nupCount = new System.Windows.Forms.NumericUpDown();
            this.nupPrice = new System.Windows.Forms.NumericUpDown();
            this.nudTotalPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(39, 149);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(230, 30);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(298, 149);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(230, 30);
            this.cmbProduct.TabIndex = 1;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Count";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(41, 336);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(230, 54);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "Add product to order";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFinishOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishOrder.ForeColor = System.Drawing.Color.White;
            this.btnFinishOrder.Location = new System.Drawing.Point(298, 336);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(230, 54);
            this.btnFinishOrder.TabIndex = 10;
            this.btnFinishOrder.Text = "Finish order";
            this.btnFinishOrder.UseVisualStyleBackColor = false;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // flpCashier
            // 
            this.flpCashier.Location = new System.Drawing.Point(606, 138);
            this.flpCashier.Name = "flpCashier";
            this.flpCashier.Size = new System.Drawing.Size(359, 270);
            this.flpCashier.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(996, 46);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cashier";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(875, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Price";
            // 
            // nupCount
            // 
            this.nupCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCount.Location = new System.Drawing.Point(298, 243);
            this.nupCount.Name = "nupCount";
            this.nupCount.Size = new System.Drawing.Size(230, 27);
            this.nupCount.TabIndex = 15;
            // 
            // nupPrice
            // 
            this.nupPrice.DecimalPlaces = 2;
            this.nupPrice.Enabled = false;
            this.nupPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPrice.Location = new System.Drawing.Point(41, 243);
            this.nupPrice.Name = "nupPrice";
            this.nupPrice.Size = new System.Drawing.Size(230, 27);
            this.nupPrice.TabIndex = 16;
            // 
            // nudTotalPrice
            // 
            this.nudTotalPrice.DecimalPlaces = 2;
            this.nudTotalPrice.Enabled = false;
            this.nudTotalPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTotalPrice.Location = new System.Drawing.Point(735, 102);
            this.nudTotalPrice.Name = "nudTotalPrice";
            this.nudTotalPrice.Size = new System.Drawing.Size(230, 27);
            this.nudTotalPrice.TabIndex = 17;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.nudTotalPrice);
            this.Controls.Add(this.nupPrice);
            this.Controls.Add(this.nupCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flpCashier);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.cmbCategory);
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.FlowLayoutPanel flpCashier;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupCount;
        private System.Windows.Forms.NumericUpDown nupPrice;
        private System.Windows.Forms.NumericUpDown nudTotalPrice;
    }
}