namespace RelatedShareholder
{
    partial class RelationData
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRelatedID = new System.Windows.Forms.TextBox();
            this.txtRelationPerson = new System.Windows.Forms.TextBox();
            this.txtRelatedCompany = new System.Windows.Forms.TextBox();
            this.txtRelatedType = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttClear = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttShowRelationType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "เลขที่ ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "รหัสบุคคนผู้เกี่ยวข้อง";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ชื่อบุคคลผู้เกี่ยวข้อง";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "บริษัท ที่เกี่ยวข้อง";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "RelatedType";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "วันที่";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(68, 22);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(63, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtRelatedID
            // 
            this.txtRelatedID.BackColor = System.Drawing.SystemColors.Info;
            this.txtRelatedID.Location = new System.Drawing.Point(247, 22);
            this.txtRelatedID.Name = "txtRelatedID";
            this.txtRelatedID.ReadOnly = true;
            this.txtRelatedID.Size = new System.Drawing.Size(112, 20);
            this.txtRelatedID.TabIndex = 7;
            // 
            // txtRelationPerson
            // 
            this.txtRelationPerson.BackColor = System.Drawing.SystemColors.Info;
            this.txtRelationPerson.Location = new System.Drawing.Point(510, 22);
            this.txtRelationPerson.Name = "txtRelationPerson";
            this.txtRelationPerson.Size = new System.Drawing.Size(263, 20);
            this.txtRelationPerson.TabIndex = 8;
            // 
            // txtRelatedCompany
            // 
            this.txtRelatedCompany.BackColor = System.Drawing.SystemColors.Info;
            this.txtRelatedCompany.Location = new System.Drawing.Point(247, 60);
            this.txtRelatedCompany.Name = "txtRelatedCompany";
            this.txtRelatedCompany.Size = new System.Drawing.Size(287, 20);
            this.txtRelatedCompany.TabIndex = 9;
            // 
            // txtRelatedType
            // 
            this.txtRelatedType.BackColor = System.Drawing.SystemColors.Info;
            this.txtRelatedType.Location = new System.Drawing.Point(633, 60);
            this.txtRelatedType.Name = "txtRelatedType";
            this.txtRelatedType.Size = new System.Drawing.Size(117, 20);
            this.txtRelatedType.TabIndex = 10;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(68, 60);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(81, 20);
            this.txtDate.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(750, 362);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttAdd.Location = new System.Drawing.Point(22, 464);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 27);
            this.bttAdd.TabIndex = 13;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttClear
            // 
            this.bttClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bttClear.Location = new System.Drawing.Point(103, 464);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(75, 27);
            this.bttClear.TabIndex = 14;
            this.bttClear.Text = "Clear";
            this.bttClear.UseVisualStyleBackColor = false;
            this.bttClear.Click += new System.EventHandler(this.bttClear_Click);
            // 
            // bttUpdate
            // 
            this.bttUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttUpdate.Location = new System.Drawing.Point(616, 464);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(75, 27);
            this.bttUpdate.TabIndex = 15;
            this.bttUpdate.Text = "Update";
            this.bttUpdate.UseVisualStyleBackColor = false;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.Red;
            this.bttDelete.Location = new System.Drawing.Point(697, 464);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 27);
            this.bttDelete.TabIndex = 16;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttShowRelationType
            // 
            this.bttShowRelationType.Image = global::RelatedShareholder.Properties.Resources._1;
            this.bttShowRelationType.Location = new System.Drawing.Point(752, 58);
            this.bttShowRelationType.Name = "bttShowRelationType";
            this.bttShowRelationType.Size = new System.Drawing.Size(21, 23);
            this.bttShowRelationType.TabIndex = 42;
            this.bttShowRelationType.UseVisualStyleBackColor = true;
            this.bttShowRelationType.Click += new System.EventHandler(this.bttShowRelationType_Click);
            // 
            // RelationData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 503);
            this.Controls.Add(this.bttShowRelationType);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttClear);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtRelatedType);
            this.Controls.Add(this.txtRelatedCompany);
            this.Controls.Add(this.txtRelationPerson);
            this.Controls.Add(this.txtRelatedID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RelationData";
            this.Text = "RelationData";
            this.Load += new System.EventHandler(this.RelationData_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRelatedID;
        private System.Windows.Forms.TextBox txtRelationPerson;
        private System.Windows.Forms.TextBox txtRelatedCompany;
        private System.Windows.Forms.TextBox txtRelatedType;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttClear;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttShowRelationType;
    }
}