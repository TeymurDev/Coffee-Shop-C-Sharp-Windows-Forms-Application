namespace SeeYouLatteStaff.Forms
{
    partial class Barista
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
            this.dgvBarista = new System.Windows.Forms.DataGridView();
            this.btnReady = new System.Windows.Forms.Button();
            this.lsbOrderDetails = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBarista
            // 
            this.dgvBarista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarista.BackgroundColor = System.Drawing.Color.White;
            this.dgvBarista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBarista.GridColor = System.Drawing.Color.LimeGreen;
            this.dgvBarista.Location = new System.Drawing.Point(0, 257);
            this.dgvBarista.Name = "dgvBarista";
            this.dgvBarista.Size = new System.Drawing.Size(800, 193);
            this.dgvBarista.TabIndex = 0;
            this.dgvBarista.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBarista_RowHeaderMouseClick);
            this.dgvBarista.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBarista_RowHeaderMouseDoubleClick);
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.Tomato;
            this.btnReady.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.ForeColor = System.Drawing.Color.White;
            this.btnReady.Location = new System.Drawing.Point(84, 12);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(629, 58);
            this.btnReady.TabIndex = 1;
            this.btnReady.Text = "ORDER IS READY";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // lsbOrderDetails
            // 
            this.lsbOrderDetails.BackColor = System.Drawing.Color.LimeGreen;
            this.lsbOrderDetails.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbOrderDetails.ForeColor = System.Drawing.Color.White;
            this.lsbOrderDetails.FormattingEnabled = true;
            this.lsbOrderDetails.ItemHeight = 18;
            this.lsbOrderDetails.Location = new System.Drawing.Point(0, 135);
            this.lsbOrderDetails.Name = "lsbOrderDetails";
            this.lsbOrderDetails.Size = new System.Drawing.Size(800, 76);
            this.lsbOrderDetails.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(332, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Details List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(332, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pending Orders List";
            // 
            // Barista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbOrderDetails);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.dgvBarista);
            this.Name = "Barista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barista";
            this.Load += new System.EventHandler(this.Barista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBarista;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.ListBox lsbOrderDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}