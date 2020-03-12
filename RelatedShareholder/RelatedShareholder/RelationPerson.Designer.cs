namespace RelatedShareholder
{
    partial class RelationPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShareholderID = new System.Windows.Forms.TextBox();
            this.txtRelatedID = new System.Windows.Forms.TextBox();
            this.txtRelatedPerson = new System.Windows.Forms.TextBox();
            this.txtRelatedTypeStatus = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttClear = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttSearchStatus = new System.Windows.Forms.Button();
            this.txtReID = new System.Windows.Forms.TextBox();
            this.lbDat = new System.Windows.Forms.Label();
            this.bttRelationData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสผู้ถือหุ้น";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "รหัสบุคคนผู้เกี่ยวข้อง";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "บุคคนผู้เกี่ยวข้อง";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "สถานะความสำพันธ์";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remark";
            // 
            // txtShareholderID
            // 
            this.txtShareholderID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtShareholderID.Location = new System.Drawing.Point(119, 14);
            this.txtShareholderID.Name = "txtShareholderID";
            this.txtShareholderID.ReadOnly = true;
            this.txtShareholderID.Size = new System.Drawing.Size(120, 20);
            this.txtShareholderID.TabIndex = 1;
            // 
            // txtRelatedID
            // 
            this.txtRelatedID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRelatedID.Location = new System.Drawing.Point(119, 47);
            this.txtRelatedID.Name = "txtRelatedID";
            this.txtRelatedID.ReadOnly = true;
            this.txtRelatedID.Size = new System.Drawing.Size(60, 20);
            this.txtRelatedID.TabIndex = 2;
            // 
            // txtRelatedPerson
            // 
            this.txtRelatedPerson.BackColor = System.Drawing.SystemColors.Info;
            this.txtRelatedPerson.Location = new System.Drawing.Point(358, 14);
            this.txtRelatedPerson.Name = "txtRelatedPerson";
            this.txtRelatedPerson.Size = new System.Drawing.Size(315, 20);
            this.txtRelatedPerson.TabIndex = 2;
            // 
            // txtRelatedTypeStatus
            // 
            this.txtRelatedTypeStatus.BackColor = System.Drawing.SystemColors.Info;
            this.txtRelatedTypeStatus.Location = new System.Drawing.Point(358, 47);
            this.txtRelatedTypeStatus.Name = "txtRelatedTypeStatus";
            this.txtRelatedTypeStatus.ReadOnly = true;
            this.txtRelatedTypeStatus.Size = new System.Drawing.Size(93, 20);
            this.txtRelatedTypeStatus.TabIndex = 3;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(540, 47);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(133, 20);
            this.txtRemark.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(660, 374);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttAdd.Location = new System.Drawing.Point(13, 477);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 31);
            this.bttAdd.TabIndex = 11;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttClear
            // 
            this.bttClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bttClear.Location = new System.Drawing.Point(94, 477);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(75, 31);
            this.bttClear.TabIndex = 12;
            this.bttClear.Text = "Clear";
            this.bttClear.UseVisualStyleBackColor = false;
            this.bttClear.Click += new System.EventHandler(this.bttClear_Click);
            // 
            // bttUpdate
            // 
            this.bttUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttUpdate.Location = new System.Drawing.Point(517, 477);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(75, 31);
            this.bttUpdate.TabIndex = 13;
            this.bttUpdate.Text = "Update";
            this.bttUpdate.UseVisualStyleBackColor = false;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.Red;
            this.bttDelete.Location = new System.Drawing.Point(598, 477);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 31);
            this.bttDelete.TabIndex = 14;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttSearchStatus
            // 
            this.bttSearchStatus.Image = global::RelatedShareholder.Properties.Resources._1;
            this.bttSearchStatus.Location = new System.Drawing.Point(455, 45);
            this.bttSearchStatus.Name = "bttSearchStatus";
            this.bttSearchStatus.Size = new System.Drawing.Size(21, 23);
            this.bttSearchStatus.TabIndex = 16;
            this.bttSearchStatus.UseVisualStyleBackColor = true;
            this.bttSearchStatus.Click += new System.EventHandler(this.bttSearchStatus_Click);
            // 
            // txtReID
            // 
            this.txtReID.BackColor = System.Drawing.SystemColors.Info;
            this.txtReID.Location = new System.Drawing.Point(194, 47);
            this.txtReID.MaxLength = 2;
            this.txtReID.Name = "txtReID";
            this.txtReID.Size = new System.Drawing.Size(45, 20);
            this.txtReID.TabIndex = 1;
            // 
            // lbDat
            // 
            this.lbDat.AutoSize = true;
            this.lbDat.Location = new System.Drawing.Point(182, 52);
            this.lbDat.Name = "lbDat";
            this.lbDat.Size = new System.Drawing.Size(10, 13);
            this.lbDat.TabIndex = 19;
            this.lbDat.Text = "-";
            // 
            // bttRelationData
            // 
            this.bttRelationData.Location = new System.Drawing.Point(297, 477);
            this.bttRelationData.Name = "bttRelationData";
            this.bttRelationData.Size = new System.Drawing.Size(88, 31);
            this.bttRelationData.TabIndex = 22;
            this.bttRelationData.Text = "Relation Data";
            this.bttRelationData.UseVisualStyleBackColor = true;
            this.bttRelationData.Click += new System.EventHandler(this.bttRelationData_Click);
            // 
            // RelationPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 520);
            this.Controls.Add(this.bttRelationData);
            this.Controls.Add(this.lbDat);
            this.Controls.Add(this.txtReID);
            this.Controls.Add(this.bttSearchStatus);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttClear);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtRelatedTypeStatus);
            this.Controls.Add(this.txtRelatedPerson);
            this.Controls.Add(this.txtRelatedID);
            this.Controls.Add(this.txtShareholderID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RelationPerson";
            this.Text = "RelationPerson";
            this.Load += new System.EventHandler(this.RelationPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtShareholderID;
        private System.Windows.Forms.TextBox txtRelatedID;
        private System.Windows.Forms.TextBox txtRelatedPerson;
        private System.Windows.Forms.TextBox txtRelatedTypeStatus;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttClear;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttSearchStatus;
        private System.Windows.Forms.TextBox txtReID;
        private System.Windows.Forms.Label lbDat;
        private System.Windows.Forms.Button bttRelationData;
    }
}