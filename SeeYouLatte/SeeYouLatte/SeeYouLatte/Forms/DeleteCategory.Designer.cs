namespace SeeYouLatte.Forms
{
    partial class DeleteCategory
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
            this.cmbCategoriesforDeletion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCategoriesforDeletion
            // 
            this.cmbCategoriesforDeletion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriesforDeletion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriesforDeletion.FormattingEnabled = true;
            this.cmbCategoriesforDeletion.Location = new System.Drawing.Point(104, 55);
            this.cmbCategoriesforDeletion.Name = "cmbCategoriesforDeletion";
            this.cmbCategoriesforDeletion.Size = new System.Drawing.Size(176, 27);
            this.cmbCategoriesforDeletion.TabIndex = 1;
            this.cmbCategoriesforDeletion.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriesforDeletion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Location = new System.Drawing.Point(104, 119);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(176, 39);
            this.btnDeleteCategory.TabIndex = 3;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // DeleteCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 223);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoriesforDeletion);
            this.Name = "DeleteCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteCategory";
            this.Load += new System.EventHandler(this.DeleteCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoriesforDeletion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteCategory;
    }
}