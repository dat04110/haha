namespace asmsql
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btedit = new System.Windows.Forms.Button();
            this.btshow = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsp = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btadd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtip = new System.Windows.Forms.TextBox();
            this.Import_Price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            this.SuspendLayout();
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(29, 214);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(259, 61);
            this.btedit.TabIndex = 7;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btshow
            // 
            this.btshow.Location = new System.Drawing.Point(29, 41);
            this.btshow.Name = "btshow";
            this.btshow.Size = new System.Drawing.Size(259, 61);
            this.btshow.TabIndex = 0;
            this.btshow.Text = "Show";
            this.btshow.UseVisualStyleBackColor = true;
            this.btshow.Click += new System.EventHandler(this.btshow_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(29, 288);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(259, 61);
            this.btdelete.TabIndex = 8;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(29, 369);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(259, 61);
            this.btsearch.TabIndex = 9;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // dtgrv
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrv.Location = new System.Drawing.Point(383, 179);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.RowHeadersWidth = 51;
            this.dtgrv.RowTemplate.Height = 24;
            this.dtgrv.Size = new System.Drawing.Size(833, 355);
            this.dtgrv.TabIndex = 5;
            this.dtgrv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Food_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Food_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selling_Price";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(392, 77);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(141, 22);
            this.txtid.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(564, 77);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(140, 22);
            this.txtname.TabIndex = 2;
            // 
            // txtsp
            // 
            this.txtsp.Location = new System.Drawing.Point(731, 77);
            this.txtsp.Name = "txtsp";
            this.txtsp.Size = new System.Drawing.Size(147, 22);
            this.txtsp.TabIndex = 3;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(897, 77);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(141, 22);
            this.txtquantity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(911, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Inventory_Quantity";
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(29, 131);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(258, 61);
            this.btadd.TabIndex = 6;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(692, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 35);
            this.label5.TabIndex = 32;
            this.label5.Text = "Food Management";
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(1062, 77);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(141, 22);
            this.txtip.TabIndex = 5;
            // 
            // Import_Price
            // 
            this.Import_Price.AutoSize = true;
            this.Import_Price.Location = new System.Drawing.Point(1088, 41);
            this.Import_Price.Name = "Import_Price";
            this.Import_Price.Size = new System.Drawing.Size(82, 16);
            this.Import_Price.TabIndex = 34;
            this.Import_Price.Text = "Import_Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 573);
            this.Controls.Add(this.Import_Price);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsp);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrv);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btshow);
            this.Controls.Add(this.btedit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food_Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btshow;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.DataGridView dtgrv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsp;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label Import_Price;
    }
}

