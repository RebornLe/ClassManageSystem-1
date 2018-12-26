namespace CmsUI
{
    partial class ScoolManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CourseList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cno = new System.Windows.Forms.TextBox();
            this.CourseRemove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.CourseCancel = new System.Windows.Forms.Button();
            this.CourseAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.ComboBox();
            this.Deptno = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1169, 515);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1161, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "课程信息管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1161, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "教室信息管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(791, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "教师信息管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(791, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "申请信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CourseList);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(837, 478);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "列表";
            // 
            // CourseList
            // 
            this.CourseList.AllowUserToAddRows = false;
            this.CourseList.AllowUserToDeleteRows = false;
            this.CourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.CourseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseList.Location = new System.Drawing.Point(4, 22);
            this.CourseList.Margin = new System.Windows.Forms.Padding(4);
            this.CourseList.MultiSelect = false;
            this.CourseList.Name = "CourseList";
            this.CourseList.ReadOnly = true;
            this.CourseList.RowTemplate.Height = 23;
            this.CourseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseList.Size = new System.Drawing.Size(829, 452);
            this.CourseList.TabIndex = 0;
            this.CourseList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseList_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Deptno);
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Credit);
            this.groupBox1.Controls.Add(this.Cno);
            this.groupBox1.Controls.Add(this.CourseRemove);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label0);
            this.groupBox1.Controls.Add(this.CourseCancel);
            this.groupBox1.Controls.Add(this.CourseAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Cname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(849, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(308, 475);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加\\修改";
            // 
            // Cno
            // 
            this.Cno.Location = new System.Drawing.Point(90, 36);
            this.Cno.Margin = new System.Windows.Forms.Padding(4);
            this.Cno.Name = "Cno";
            this.Cno.Size = new System.Drawing.Size(210, 25);
            this.Cno.TabIndex = 12;
            // 
            // CourseRemove
            // 
            this.CourseRemove.Location = new System.Drawing.Point(42, 418);
            this.CourseRemove.Margin = new System.Windows.Forms.Padding(4);
            this.CourseRemove.Name = "CourseRemove";
            this.CourseRemove.Size = new System.Drawing.Size(224, 29);
            this.CourseRemove.TabIndex = 4;
            this.CourseRemove.Text = "删除课程";
            this.CourseRemove.UseVisualStyleBackColor = true;
            this.CourseRemove.Click += new System.EventHandler(this.CourseRemove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(23, 388);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "提示：双击表格项可以在此处进行修改";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(8, 46);
            this.label0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(67, 15);
            this.label0.TabIndex = 11;
            this.label0.Text = "课程号：";
            // 
            // CourseCancel
            // 
            this.CourseCancel.Location = new System.Drawing.Point(166, 343);
            this.CourseCancel.Margin = new System.Windows.Forms.Padding(4);
            this.CourseCancel.Name = "CourseCancel";
            this.CourseCancel.Size = new System.Drawing.Size(100, 29);
            this.CourseCancel.TabIndex = 7;
            this.CourseCancel.Text = "取消";
            this.CourseCancel.UseVisualStyleBackColor = true;
            this.CourseCancel.Click += new System.EventHandler(this.CourseCancel_Click);
            // 
            // CourseAdd
            // 
            this.CourseAdd.Location = new System.Drawing.Point(42, 343);
            this.CourseAdd.Margin = new System.Windows.Forms.Padding(4);
            this.CourseAdd.Name = "CourseAdd";
            this.CourseAdd.Size = new System.Drawing.Size(100, 29);
            this.CourseAdd.TabIndex = 6;
            this.CourseAdd.Text = "添加";
            this.CourseAdd.UseVisualStyleBackColor = true;
            this.CourseAdd.Click += new System.EventHandler(this.CourseAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "学分：";
            // 
            // Cname
            // 
            this.Cname.Location = new System.Drawing.Point(91, 95);
            this.Cname.Margin = new System.Windows.Forms.Padding(4);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(210, 25);
            this.Cname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程名：";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cno";
            this.Column1.HeaderText = "课程号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cname";
            this.Column2.HeaderText = "课程名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "credit";
            this.Column3.HeaderText = "学分";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "category";
            this.Column4.HeaderText = "课程类型";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "deptno";
            this.Column5.HeaderText = "开课院系号";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Credit
            // 
            this.Credit.Location = new System.Drawing.Point(91, 158);
            this.Credit.Margin = new System.Windows.Forms.Padding(4);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(210, 25);
            this.Credit.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "课程类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "开课院系号：";
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "全校选修",
            "专业选修",
            "专业必修",
            "人文修养",
            "艺术教育"});
            this.Category.Location = new System.Drawing.Point(91, 221);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(210, 23);
            this.Category.TabIndex = 16;
            // 
            // Deptno
            // 
            this.Deptno.FormattingEnabled = true;
            this.Deptno.Location = new System.Drawing.Point(91, 276);
            this.Deptno.Name = "Deptno";
            this.Deptno.Size = new System.Drawing.Size(210, 23);
            this.Deptno.TabIndex = 17;
            // 
            // ScoolManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 515);
            this.Controls.Add(this.tabControl1);
            this.Name = "ScoolManager";
            this.Text = "后台管理系统";
            this.Load += new System.EventHandler(this.ScoolManager_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView CourseList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Cno;
        private System.Windows.Forms.Button CourseRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button CourseCancel;
        private System.Windows.Forms.Button CourseAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Credit;
        private System.Windows.Forms.ComboBox Deptno;
        private System.Windows.Forms.ComboBox Category;
    }
}