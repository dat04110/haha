namespace asmsql
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtauthority = new System.Windows.Forms.TextBox();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.btsearch = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btshow = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.txtgmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtauthority
            // 
            this.txtauthority.Location = new System.Drawing.Point(1083, 353);
            this.txtauthority.Name = "txtauthority";
            this.txtauthority.Size = new System.Drawing.Size(198, 22);
            this.txtauthority.TabIndex = 27;
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(1083, 279);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(198, 22);
            this.txtposition.TabIndex = 26;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(1083, 207);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(198, 22);
            this.txtname.TabIndex = 25;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(1083, 125);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(198, 22);
            this.txtid.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1158, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Authority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1158, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1132, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Employee_Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1132, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Employee_ID";
            // 
            // dtgrv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrv.Location = new System.Drawing.Point(303, 77);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.RowHeadersWidth = 51;
            this.dtgrv.RowTemplate.Height = 24;
            this.dtgrv.Size = new System.Drawing.Size(734, 457);
            this.dtgrv.TabIndex = 19;
            this.dtgrv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_CellContentClick);
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(25, 395);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(223, 61);
            this.btsearch.TabIndex = 18;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(25, 314);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(223, 61);
            this.btdelete.TabIndex = 17;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btshow
            // 
            this.btshow.Location = new System.Drawing.Point(24, 77);
            this.btshow.Name = "btshow";
            this.btshow.Size = new System.Drawing.Size(223, 61);
            this.btshow.TabIndex = 16;
            this.btshow.Text = "Show";
            this.btshow.UseVisualStyleBackColor = true;
            this.btshow.Click += new System.EventHandler(this.btshow_Click);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(25, 240);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(223, 61);
            this.btedit.TabIndex = 15;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(25, 159);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(223, 61);
            this.btadd.TabIndex = 14;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // txtgmail
            // 
            this.txtgmail.Location = new System.Drawing.Point(1083, 434);
            this.txtgmail.Name = "txtgmail";
            this.txtgmail.Size = new System.Drawing.Size(198, 22);
            this.txtgmail.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1158, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Gmail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(504, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 35);
            this.label6.TabIndex = 33;
            this.label6.Text = "Employee Management";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 563);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgmail);
            this.Controls.Add(this.txtauthority);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrv);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btshow);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btadd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Management";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtauthority;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrv;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btshow;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox txtgmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}