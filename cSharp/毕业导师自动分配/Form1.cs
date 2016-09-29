using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 毕业导师自动分配
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] teacherSelectNum = new int[300];
        int[,] studentSelectTeacher = new int[1000, 5];
        int TeacherNum = 30;
        int StudentNum = 100;

        private void Form1_Load(object sender, EventArgs e)
        {
            DataIn.Enabled = false;
            TeacherTree.Nodes.Clear();
            StudentTree.Nodes.Clear();
            StuTeaNotF.Nodes.Clear();
            StuAndTeacher.Nodes.Clear();
            TeacherTree.Nodes.Add(new TreeNode("导师和分配情况"));
            StudentTree.Nodes.Add(new TreeNode("学生选择情况"));
            StuTeaNotF.Nodes.Add(new TreeNode("未被分配的学生"));
            StuAndTeacher.Nodes.Add(new TreeNode("分配的学生对应导师"));
         
            Random rd = new Random();
            int num = 0;
            for (int i = 0; i < TeacherNum; i++)
            {
                TreeNode tr = new TreeNode();
                teacherSelectNum[i] = rd.Next(0, 9);
                num = num + teacherSelectNum[i];
                tr.Text = "导师" + i;
                TeacherTree.Nodes.Add(tr);
            
            }
            for (int i = 0; i < TeacherNum; i++)
            {
                TeacherData.Text = TeacherData.Text + teacherSelectNum[i].ToString() + "\r\n";
            }
            textBox1.Text = num.ToString();
            for (int i = 0; i < StudentNum; i++)
            {
                TreeNode tr = new TreeNode();
                tr.Text = "学生" + i;
                StudentTree.Nodes.Add(tr);
                for (int j = 0; j < 5; j++)
                {
                    studentSelectTeacher[i, j] = rd.Next(0, TeacherNum);
                    TreeNode studentSelect = new TreeNode();
                    studentSelect.Text = "导师" + studentSelectTeacher[i, j];
                    tr.Nodes.Add(studentSelect);
                    /*   foreach(TreeNode node in TeacherTree.Nodes)
                       {
                           if (node.Text=="导师"+studentSelectTeacher[i,j])
                           {

                                 node.Nodes.Add(new TreeNode("学生"+i)); 
                           }
                       }*/

                }
            }
            for (int i = 0; i < StudentNum; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    StudentData.Text = StudentData.Text + studentSelectTeacher[i, j].ToString() + "\r\n";
                }
            }

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            int studentNumber;
            int teacherNumber;
            for (int i = 0; i < StudentNum; i++)
            {
                int j = 0;
                for (; j < 5; j++)
                {
                    studentNumber = i;
                    teacherNumber = studentSelectTeacher[i, j];
                    if (teacherSelectNum[teacherNumber] > 0)
                    {
                        foreach (TreeNode node in TeacherTree.Nodes)
                        {
                            if (node.Text == "导师" + teacherNumber)
                            {

                                node.Nodes.Add(new TreeNode("学生" + i));
                                StuAndTeacher.Nodes.Add(new TreeNode("学生" + i + "--" + node.Text));
                            }
                        }
                        teacherSelectNum[teacherNumber]--;
                        break;
                    }

                }
                if (j >= 5)
                {
                    TreeNode tr = new TreeNode("学生" + i);
                    StuTeaNotF.Nodes.Add(tr);
                }
            }  
            TreeNode tr1 = new TreeNode("未分配的导师");
            StuTeaNotF.Nodes.Add(tr1);
            foreach (TreeNode node in TeacherTree.Nodes)
            {
                if (node.Nodes.Count == 0)
                {
                    if(node.Text!="导师和分配情况")
                    {
                            TreeNode tr2 = new TreeNode(node.Text);
                          StuTeaNotF.Nodes.Add(tr2);
                    }
                  
                }
            }
          


        }

        private void Rand_Click(object sender, EventArgs e)
        {
            TeacherData.Text = "";
            StudentData.Text = "";
            Start.Enabled = true;
            if(TeacherN.Text!="")
            {
                TeacherNum =Convert.ToInt32( TeacherN.Text);
            }
            else
            {
                MessageBox.Show("输入导师人数");
                TeacherN.Focus();
                return;
            }
            if(StudentN.Text!="")
            {
                StudentNum = Convert.ToInt32(StudentN.Text);
                
            }
            else
            {
                MessageBox.Show("输入学生人数");
                StudentN.Focus();
                return;
            }
            Form1_Load(sender, e);
        }

        private void DataIn_Click(object sender, EventArgs e)
        {
            DataIn.Enabled = false;
            TeacherData.ReadOnly = true;
            StudentData.ReadOnly = true;
            Start.Enabled = true;
            string[] studentDataTmp = StudentData.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
             string[] teacherDataTmp= TeacherData.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
             StudentNum = studentDataTmp.Length / 5;
             StudentN.Text = StudentNum.ToString();
             TeacherNum = teacherDataTmp.Length-1;
             TeacherN.Text = TeacherNum.ToString();
             for (int i = 0; i < studentDataTmp.Length/5; i++)
             {
                 for (int j = 0; j < 5; j++)
                 {
                     studentSelectTeacher[i, j] = Convert.ToInt32( studentDataTmp[j + i * 5]);
                 }
             }
             for (int i = 0; i < teacherDataTmp.Length-1; i++)
             {
                 teacherSelectNum[i] = Convert.ToInt32(teacherDataTmp[i]);
             }
             TeacherTree.Nodes.Clear();
             StudentTree.Nodes.Clear();
             StuTeaNotF.Nodes.Clear();
             StuAndTeacher.Nodes.Clear();
             TeacherTree.Nodes.Add(new TreeNode("导师和分配情况"));
             StudentTree.Nodes.Add(new TreeNode("学生选择情况"));
             StuTeaNotF.Nodes.Add(new TreeNode("未被分配的学生"));
             StuAndTeacher.Nodes.Add(new TreeNode("分配的学生对应导师"));
             int num = 0;
             for (int i = 0; i < TeacherNum; i++)
             {
                 TreeNode tr = new TreeNode();
                 num = num + teacherSelectNum[i];
                 tr.Text = "导师" + i;
                 TeacherTree.Nodes.Add(tr);
             }
             textBox1.Text = num.ToString();
             for (int i = 0; i < StudentNum; i++)
             {
                 TreeNode tr = new TreeNode();
                 tr.Text = "学生" + i;
                 StudentTree.Nodes.Add(tr);
                 for (int j = 0; j < 5; j++)
                 {
                     TreeNode studentSelect = new TreeNode();
                     studentSelect.Text = "导师" + studentSelectTeacher[i, j];
                     tr.Nodes.Add(studentSelect);
                     /*   foreach(TreeNode node in TeacherTree.Nodes)
                        {
                            if (node.Text=="导师"+studentSelectTeacher[i,j])
                            {

                                  node.Nodes.Add(new TreeNode("学生"+i)); 
                            }
                        }*/

                 }
             }

        }

        private void HandIn_Click(object sender, EventArgs e)
        {
            TeacherData.ReadOnly = false;
            StudentData.ReadOnly = false;
            DataIn.Enabled = true;
        }


    }
}
