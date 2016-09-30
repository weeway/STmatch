using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace 毕业导师自动分配
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //定义老师可选择的学生数数组
        int[] teacherSelectNum = new int[300];
        //定义学生选择老师数组
        int[,] studentSelectTeacher = new int[1000, 5];
        //老师总数
        int TeacherNum = 30;
        //学生总数
        int StudentNum = 100;
        /// <summary>
        /// 窗口载入时生成随机数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            //随机数对象
            Random rd = new Random(); 
            int num = 0;
            for (int i = 0; i < TeacherNum; i++)
            {
                TreeNode tr = new TreeNode();
                //老师数据随机生成
                teacherSelectNum[i] = rd.Next(0, 9);
                num = num + teacherSelectNum[i];
                tr.Text = "导师" + i;
                //添加到树根节点
                TeacherTree.Nodes.Add(tr);
            
            }
            //在文本框显示
            for (int i = 0; i < TeacherNum; i++)
            {
                TeacherData.Text = TeacherData.Text + teacherSelectNum[i].ToString() + "\r\n";
            }
            //显示老师可选择学生的总数
            textBox1.Text = num.ToString();
            //学生随机生成
            for (int i = 0; i < StudentNum; i++)
            {
                TreeNode tr = new TreeNode();
                tr.Text = "学生" + i;
                StudentTree.Nodes.Add(tr);
                for (int j = 0; j < 5; j++)
                {
                    //学生数据随机生成
                    studentSelectTeacher[i, j] = rd.Next(0, TeacherNum);
                    TreeNode studentSelect = new TreeNode();
                    //在树节点显示
                    studentSelect.Text = "导师" + studentSelectTeacher[i, j];
                    tr.Nodes.Add(studentSelect);

                }
            }
            //文本框显示
            for (int i = 0; i < StudentNum; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    StudentData.Text = StudentData.Text + studentSelectTeacher[i, j].ToString() + "\r\n";
                }
            }

        }
        /// <summary>
        /// 对数据进行智能匹配
        /// 按绩点排名,学生按照志愿选择导师
        /// 若导师有空位.则选中,否则下一志愿
        /// 如此反复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            //学生标号
            int studentNumber;
            //导师标号
            int teacherNumber;
            for (int i = 0; i < StudentNum; i++)
            {
                int j = 0;
                
                for (; j < 5; j++)
                {
                    studentNumber = i;
                    teacherNumber = studentSelectTeacher[i, j];
                    //如果导师有名额 选中该导师
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
                //全部满,则添加到未分配的学生中
                if (j >= 5)
                {
                    TreeNode tr = new TreeNode("学生" + i);
                    StuTeaNotF.Nodes.Add(tr);
                }
            }  
            //遍历树,得到未分配的导师
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
        /// <summary>
        ///生成随机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 将文本框内的数据生成树状表并显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataIn_Click(object sender, EventArgs e)
        {
            DataIn.Enabled = false;
            TeacherData.ReadOnly = true;
            StudentData.ReadOnly = true;
            Start.Enabled = true;
            //分割文本数据
             string[] studentDataTmp = StudentData.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
             string[] teacherDataTmp= TeacherData.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            //得到学生总数
             StudentNum = studentDataTmp.Length / 5;
             StudentN.Text = StudentNum.ToString();
            //导师总数
             TeacherNum = teacherDataTmp.Length-1;
             TeacherN.Text = TeacherNum.ToString();
            //学生选择的导师
             for (int i = 0; i < studentDataTmp.Length/5; i++)
             {
                 for (int j = 0; j < 5; j++)
                 {
                     studentSelectTeacher[i, j] = Convert.ToInt32( studentDataTmp[j + i * 5]);
                 }
             }
            //导师可选的名额数
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
             //添加到树节点
             for (int i = 0; i < TeacherNum; i++)
             {
                 TreeNode tr = new TreeNode();
                 num = num + teacherSelectNum[i];
                 tr.Text = "导师" + i;
                 TeacherTree.Nodes.Add(tr);
             }
            //显示总数
             textBox1.Text = num.ToString();
            //添加学生树节点
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
               

                 }
             }

        }
        /// <summary>
        /// 手动输入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandIn_Click(object sender, EventArgs e)
        {
            TeacherData.ReadOnly = false;
            StudentData.ReadOnly = false;
            DataIn.Enabled = true;
        }
        OpenFileDialog teaFileIn = new OpenFileDialog();
        /// <summary>
        /// 文件导入
        /// 导入老师的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileIn_Click(object sender, EventArgs e)
        {
            teaFileIn.Multiselect = false;
            teaFileIn.Filter = "文本|*.txt";
            teaFileIn.Title = "请选择导师的文件";
            teaFileIn.ShowDialog();
            if (teaFileIn.FileName == "")
            {
                return;
            }
            //读取文件中的数据
            StreamReader rm = new StreamReader(teaFileIn.FileName, System.Text.Encoding.UTF8);
            //导师数据文本框显示
            TeacherData.Text=rm.ReadToEnd();
            rm.Close();

        }
        OpenFileDialog stuFileIn = new OpenFileDialog();
        /// <summary>
        /// 文件导入
        /// 导入学生的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StuFileIn_Click(object sender, EventArgs e)
        {
            stuFileIn.Multiselect = false;
            stuFileIn.Filter = "文本|*.txt";
            stuFileIn.Title = "请选择学生的文件";
            stuFileIn.ShowDialog();
            if (stuFileIn.FileName == "")
            {
                return;
            }
            StreamReader rm = new StreamReader(stuFileIn.FileName, System.Text.Encoding.UTF8);
            //在学生数据文本框中显示
            StudentData.Text = rm.ReadToEnd();
            rm.Close();
        }


    }
}
