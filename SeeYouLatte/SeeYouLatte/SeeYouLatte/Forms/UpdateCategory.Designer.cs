namespace SeeYouLatte.Forms
{
    partial class UpdateCategory
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
            this.cmbUpdatedCategory = new System.Windows.Forms.ComboBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbUpdatedCategory
            // 
            this.cmbUpdatedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdatedCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUpdatedCategory.FormattingEnabled = true;
            this.cmbUpdatedCategory.Location = new System.Drawing.Point(110, 124);
            this.cmbUpdatedCategory.Name = "cmbUpdatedCategory";
            this.cmbUpdatedCategory.Size = new System.Drawing.Size(269, 27);
            this.cmbUpdatedCategory.TabIndex = 1;
            this.cmbUpdatedCategory.SelectedIndexChanged += new System.EventHandler(this.cmbUpdatedCategory_SelectedIndexChanged);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.Location = new System.Drawing.Point(110, 181);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(269, 43);
            this.btnUpdateCategory.TabIndex = 2;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category";
            // 
            // txtUpdateCategory
            // 
            this.txtUpdateCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateCategory.Location = new System.Drawing.Point(110, 61);
            this.txtUpdateCategory.Name = "txtUpdateCategory";
            this.txtUpdateCategory.Size = new System.Drawing.Size(269, 27);
            this.txtUpdateCategory.TabIndex = 4;
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 256);
            this.Controls.Add(this.txtUpdateCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.cmbUpdatedCategory);
            this.Name = "UpdateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCategory";
            this.Load += new System.EventHandler(this.UpdateCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbUpdatedCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdateCategory;
    }
}