namespace 毕业导师自动分配
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("导师和分配情况");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("学生选择情况");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("未被分配的学生");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("分配的学生对应导师");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TeacherTree = new System.Windows.Forms.TreeView();
            this.StudentTree = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StuTeaNotF = new System.Windows.Forms.TreeView();
            this.StuAndTeacher = new System.Windows.Forms.TreeView();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Rand = new System.Windows.Forms.Button();
            this.TeacherData = new System.Windows.Forms.TextBox();
            this.StudentData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataIn = new System.Windows.Forms.Button();
            this.HandIn = new System.Windows.Forms.Button();
            this.TeacherN = new System.Windows.Forms.TextBox();
            this.StudentN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TeacherTree
            // 
            this.TeacherTree.Location = new System.Drawing.Point(-3, 3);
            this.TeacherTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TeacherTree.Name = "TeacherTree";
            treeNode1.Name = "节点0";
            treeNode1.Text = "导师和分配情况";
            this.TeacherTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.TeacherTree.Size = new System.Drawing.Size(216, 805);
            this.TeacherTree.TabIndex = 0;
            // 
            // StudentTree
            // 
            this.StudentTree.Location = new System.Drawing.Point(208, 3);
            this.StudentTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentTree.Name = "StudentTree";
            treeNode2.Name = "节点0";
            treeNode2.Text = "学生选择情况";
            this.StudentTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.StudentTree.Size = new System.Drawing.Size(216, 805);
            this.StudentTree.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 814);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(148, 28);
            this.textBox1.TabIndex = 2;
            // 
            // StuTeaNotF
            // 
            this.StuTeaNotF.Location = new System.Drawing.Point(420, 3);
            this.StuTeaNotF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StuTeaNotF.Name = "StuTeaNotF";
            treeNode3.Name = "节点0";
            treeNode3.Text = "未被分配的学生";
            this.StuTeaNotF.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.StuTeaNotF.Size = new System.Drawing.Size(216, 805);
            this.StuTeaNotF.TabIndex = 3;
            // 
            // StuAndTeacher
            // 
            this.StuAndTeacher.Location = new System.Drawing.Point(632, 3);
            this.StuAndTeacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StuAndTeacher.Name = "StuAndTeacher";
            treeNode4.Name = "节点0";
            treeNode4.Text = "分配的学生对应导师";
            this.StuAndTeacher.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.StuAndTeacher.Size = new System.Drawing.Size(216, 805);
            this.StuAndTeacher.TabIndex = 4;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(542, 813);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(112, 34);
            this.Start.TabIndex = 5;
            this.Start.Text = "开始匹配";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(-8, 818);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "老师可以带学生总数:";
            // 
            // Rand
            // 
            this.Rand.Location = new System.Drawing.Point(420, 813);
            this.Rand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rand.Name = "Rand";
            this.Rand.Size = new System.Drawing.Size(112, 34);
            this.Rand.TabIndex = 7;
            this.Rand.Text = "生成随机";
            this.Rand.UseVisualStyleBackColor = true;
            this.Rand.Click += new System.EventHandler(this.Rand_Click);
            // 
            // TeacherData
            // 
            this.TeacherData.Location = new System.Drawing.Point(849, 45);
            this.TeacherData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TeacherData.Multiline = true;
            this.TeacherData.Name = "TeacherData";
            this.TeacherData.ReadOnly = true;
            this.TeacherData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TeacherData.Size = new System.Drawing.Size(262, 354);
            this.TeacherData.TabIndex = 8;
            // 
            // StudentData
            // 
            this.StudentData.Location = new System.Drawing.Point(849, 435);
            this.StudentData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentData.Multiline = true;
            this.StudentData.Name = "StudentData";
            this.StudentData.ReadOnly = true;
            this.StudentData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StudentData.Size = new System.Drawing.Size(262, 356);
            this.StudentData.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(855, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "导师带的学生数:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(855, 405);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "学生选择的导师:";
            // 
            // DataIn
            // 
            this.DataIn.Location = new System.Drawing.Point(860, 813);
            this.DataIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataIn.Name = "DataIn";
            this.DataIn.Size = new System.Drawing.Size(112, 34);
            this.DataIn.TabIndex = 12;
            this.DataIn.Text = "导入数据";
            this.DataIn.UseVisualStyleBackColor = true;
            this.DataIn.Click += new System.EventHandler(this.DataIn_Click);
            // 
            // HandIn
            // 
            this.HandIn.Location = new System.Drawing.Point(736, 813);
            this.HandIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HandIn.Name = "HandIn";
            this.HandIn.Size = new System.Drawing.Size(112, 34);
            this.HandIn.TabIndex = 13;
            this.HandIn.Text = "手动输入";
            this.HandIn.UseVisualStyleBackColor = true;
            this.HandIn.Click += new System.EventHandler(this.HandIn_Click);
            // 
            // TeacherN
            // 
            this.TeacherN.Location = new System.Drawing.Point(234, 860);
            this.TeacherN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TeacherN.Name = "TeacherN";
            this.TeacherN.Size = new System.Drawing.Size(148, 28);
            this.TeacherN.TabIndex = 14;
            // 
            // StudentN
            // 
            this.StudentN.Location = new System.Drawing.Point(234, 903);
            this.StudentN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentN.Name = "StudentN";
            this.StudentN.Size = new System.Drawing.Size(148, 28);
            this.StudentN.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(87, 867);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "老师总人数:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(86, 909);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "学生总人数:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 952);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StudentN);
            this.Controls.Add(this.TeacherN);
            this.Controls.Add(this.HandIn);
            this.Controls.Add(this.DataIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentData);
            this.Controls.Add(this.TeacherData);
            this.Controls.Add(this.Rand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.StuAndTeacher);
            this.Controls.Add(this.StuTeaNotF);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StudentTree);
            this.Controls.Add(this.TeacherTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TeacherTree;
        private System.Windows.Forms.TreeView StudentTree;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView StuTeaNotF;
        private System.Windows.Forms.TreeView StuAndTeacher;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rand;
        private System.Windows.Forms.TextBox TeacherData;
        private System.Windows.Forms.TextBox StudentData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DataIn;
        private System.Windows.Forms.Button HandIn;
        private System.Windows.Forms.TextBox TeacherN;
        private System.Windows.Forms.TextBox StudentN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

