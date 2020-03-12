namespace RelatedShareholder
{
    partial class ShowShareholder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearchCompany = new System.Windows.Forms.TextBox();
            this.bttSearchCompany = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttRelationName = new System.Windows.Forms.Button();
            this.txtRelationName = new System.Windows.Forms.TextBox();
            this.bttPrinReport = new System.Windows.Forms.Button();
            this.bttExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtSearchCompany
            // 
            this.txtSearchCompany.ForeColor = System.Drawing.Color.Black;
            this.txtSearchCompany.Location = new System.Drawing.Point(770, 49);
            this.txtSearchCompany.Name = "txtSearchCompany";
            this.txtSearchCompany.Size = new System.Drawing.Size(137, 20);
            this.txtSearchCompany.TabIndex = 20;
            // 
            // bttSearchCompany
            // 
            this.bttSearchCompany.Location = new System.Drawing.Point(913, 45);
            this.bttSearchCompany.Name = "bttSearchCompany";
            this.bttSearchCompany.Size = new System.Drawing.Size(54, 23);
            this.bttSearchCompany.TabIndex = 23;
            this.bttSearchCompany.Text = "Show";
            this.bttSearchCompany.UseVisualStyleBackColor = true;
            this.bttSearchCompany.Click += new System.EventHandler(this.bttSearchCompany_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(769, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "ค้นหา บริษัทที่เกี่ยวข้อง";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "ค้นหา ชื่อผู้เกี่ยวข้อง";
            // 
            // bttRelationName
            // 
            this.bttRelationName.Location = new System.Drawing.Point(589, 46);
            this.bttRelationName.Name = "bttRelationName";
            this.bttRelationName.Size = new System.Drawing.Size(52, 23);
            this.bttRelationName.TabIndex = 28;
            this.bttRelationName.Text = "Show";
            this.bttRelationName.UseVisualStyleBackColor = true;
            this.bttRelationName.Click += new System.EventHandler(this.bttRelationName_Click);
            // 
            // txtRelationName
            // 
            this.txtRelationName.ForeColor = System.Drawing.Color.Black;
            this.txtRelationName.Location = new System.Drawing.Point(446, 49);
            this.txtRelationName.Name = "txtRelationName";
            this.txtRelationName.Size = new System.Drawing.Size(137, 20);
            this.txtRelationName.TabIndex = 27;
            // 
            // bttPrinReport
            // 
            this.bttPrinReport.Image = global::RelatedShareholder.Properties.Resources.icon_printer;
            this.bttPrinReport.Location = new System.Drawing.Point(14, 10);
            this.bttPrinReport.Name = "bttPrinReport";
            this.bttPrinReport.Size = new System.Drawing.Size(64, 61);
            this.bttPrinReport.TabIndex = 30;
            this.bttPrinReport.UseVisualStyleBackColor = true;
            this.bttPrinReport.Click += new System.EventHandler(this.bttPrinReport_Click);
            // 
            // bttExcel
            // 
            this.bttExcel.Image = global::RelatedShareholder.Properties.Resources.Remicrosoft_excel_2013_12_535x535;
            this.bttExcel.Location = new System.Drawing.Point(1092, 14);
            this.bttExcel.Name = "bttExcel";
            this.bttExcel.Size = new System.Drawing.Size(47, 53);
            this.bttExcel.TabIndex = 24;
            this.bttExcel.UseVisualStyleBackColor = true;
            this.bttExcel.Click += new System.EventHandler(this.bttExcel_Click);
            // 
            // ShowShareholder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 581);
            this.Controls.Add(this.bttPrinReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttRelationName);
            this.Controls.Add(this.txtRelationName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttExcel);
            this.Controls.Add(this.bttSearchCompany);
            this.Controls.Add(this.txtSearchCompany);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowShareholder";
            this.Text = "ShowShareholder";
            this.Load += new System.EventHandler(this.ShowShareholder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchCompany;
        private System.Windows.Forms.Button bttSearchCompany;
        private System.Windows.Forms.Button bttExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttRelationName;
        private System.Windows.Forms.TextBox txtRelationName;
        private System.Windows.Forms.Button bttPrinReport;
    }
}