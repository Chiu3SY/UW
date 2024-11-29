using System.Security.AccessControl;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;

using employee_manage_system_new.Models;
using employee_manage_system_new.tools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace employee_manage_system_new
{
    public partial class Form1 : Form
    {
        public static string SavePath = @"C:\Users\3SY\source\repos\employee_manage_system_new\employee_manage_system_new\bin\Debug\test.txt";
        private List<int> idList = new List<int>();
        List<IncomeInfo> incomeList = new List<IncomeInfo>();
        ListViewItem curItem;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCboItems();
        }
        /// <summary>
        /// 加载保存内容
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void LoadCboItems()
        {
            List<IncomeInfo> list = new List<IncomeInfo>();

            if (File.Exists(SavePath))
            {
                List<string> lines = new List<string>();
                if (File.Exists(SavePath))
                {
                    lines = File.ReadLines(SavePath).ToList();
                }

                if (lines.Count > 0)
                {
                    for (int i = 0; i < lines.Count; i++)
                    {
                        //工号，姓名，性别，岗位，级别，入职时间，出生时间，籍贯，薪资
                        string[] arr = lines[i].Split(';');
                        IncomeInfo info = new IncomeInfo()
                        {
                            Id = int.Parse(arr[0]),
                            Name = arr[1],
                            Gender = arr[2],
                            Job = arr[3],
                            Level = arr[4],
                            Dateofentry = DateTime.Parse(arr[5]),
                            Birth = DateTime.Parse(arr[6]),
                            Nationality = arr[7],
                            Salary = decimal.Parse(arr[8])
                        };
                        list.Add(info);
                        incomeList.Add(info);
                        idList.Add(info.Id);
                    }
                }
            }

            if (list.Count > 0)
            {
                foreach (IncomeInfo item in list)
                {
                    ListViewItem li = CreateLvItem(item);
                    listView1.Items.Add(li);
                }
            }
        }
        /// <summary>
        /// 确认增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // 信息接收
            int id = int.Parse(textBoxID.Text.Trim());
            string name = textBoxName.Text.Trim();
            string gender = textBoxGender.Text.Trim();
            string itemName1 = comboBoxJob.Text.Trim();
            string itemName2 = comboBoxLevel.Text.Trim();
            DateTime selectedDate1 = dateTimePicker1.Value;
            DateTime selectedDate2 = dateTimePicker2.Value;
            string na = textBoxNa.Text.Trim();
            decimal money = 0.00M;
            decimal.TryParse(textBoxSalary.Text.Trim(), out money);

            // 信息检查
            if (string.IsNullOrEmpty(textBoxID.Text))
            {
                MessageHelper.Error("记录提交", "员工工号不能为空！");
                textBoxID.Focus();
                return;
            }

            if (money <= 0)
            {
                MessageHelper.Error("记录提交", "收入不能小于0！");
                textBoxSalary.Focus();
                return;
            }

            if (idList.Contains(id))
            {
                MessageHelper.Error("记录提交", "员工工号必须唯一！");
                textBoxID.Focus();
                return;
            }
            idList.Add(id);

            IncomeInfo incomeInfo = new IncomeInfo()
            {
                Id = id,
                Name = name,
                Gender = gender,
                Job = itemName1,
                Level = itemName2,
                Dateofentry = selectedDate1,
                Birth = selectedDate2,
                Nationality = na,
                Salary = money
            };

            // 创建ListViewItem项
            ListViewItem li = CreateLvItem(incomeInfo);
            listView1.Items.Add(li);
            incomeList.Add(incomeInfo);
            //保存到文件
            string item = id + ";" + name + ";" + gender + ";" + itemName1 + ";" + itemName2 + ";" + selectedDate1 + ";" + selectedDate2 + ";" + na + ";" + money.ToString("0.00");
            if (!File.Exists(SavePath))
            {
                File.Create(SavePath).Close();
            }
            WriteMsg(item, SavePath, true);
        }

        private void WriteMsg(string value, string filePath, bool bAppend)
        {
            using (StreamWriter sw = new StreamWriter(filePath, bAppend))
            {
                sw.WriteLine(value);
            }
        }

        /// <summary>
        /// CreateLvItem
        /// </summary>
        /// <param name="incomeInfo"></param>
        /// <returns></returns>
        private ListViewItem CreateLvItem(IncomeInfo incomeInfo)
        {
            ListViewItem li = new ListViewItem();
            li.Text = incomeInfo.Id.ToString();
            li.SubItems.Add(incomeInfo.Name);
            li.SubItems.Add(incomeInfo.Gender);
            li.SubItems.Add(incomeInfo.Job);
            li.SubItems.Add(incomeInfo.Level);
            li.SubItems.Add(incomeInfo.Dateofentry.ToString());
            li.SubItems.Add(incomeInfo.Birth.ToString());
            li.SubItems.Add(incomeInfo.Nationality);
            li.SubItems.Add("￥" + incomeInfo.Salary.ToString("0.00"));
            return li;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selItem = listView1.SelectedItems[0];
                curItem = selItem;//当前选择项  ListVIewItem
                textBoxID.Text = curItem.Text;
                textBoxName.Text = curItem.SubItems[1].Text;
                textBoxGender.Text = curItem.SubItems[2].Text;
                comboBoxJob.Text = curItem.SubItems[3].Text;
                comboBoxLevel.Text = curItem.SubItems[4].Text;
                dateTimePicker1.Value = DateTime.Parse(curItem.SubItems[5].Text);
                dateTimePicker2.Value = DateTime.Parse(curItem.SubItems[6].Text);
                textBoxNa.Text = curItem.SubItems[7].Text;
                textBoxSalary.Text = curItem.SubItems[8].Text.Substring(1);
            }
        }
        /// <summary>
        /// 按工号查
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxIdS.Text.Trim());
            if (idList.Contains(id))
            {
                for (int i = 0; i < incomeList.Count; i++)
                {
                    if (incomeList[i].Id == id)
                    {
                        IncomeInfo info = incomeList[i];
                        textBoxID.Text = info.Id.ToString();
                        textBoxName.Text = info.Name;
                        textBoxGender.Text = info.Gender;
                        comboBoxJob.Text = info.Job;
                        comboBoxLevel.Text = info.Level;
                        dateTimePicker1.Value = info.Dateofentry;
                        dateTimePicker2.Value = info.Birth;
                        textBoxNa.Text = info.Nationality;
                        textBoxSalary.Text = info.Salary.ToString("0.00");
                    }
                }
            }
            else
            {
                MessageHelper.Error("查询", "未找到该员工！");
            }
        }
        /// <summary>
        /// 确认删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            var selecteditem = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageHelper.Confirm("确定删除", "确定删除");
                if (dr == DialogResult.OK)
                {
                    listView1.Items.Remove(selecteditem);
                    int id = int.Parse(selecteditem.Text);
                    idList.Remove(id);
                    for (int i = 0; i < incomeList.Count; i++)
                    {
                        if (incomeList[i].Id == id)
                        {
                            incomeList.RemoveAt(i);
                            break;
                        }
                    }
                    cleantxt();
                }
            }
            //更新文件
            if (File.Exists(SavePath))
            {
                File.Create(SavePath).Close();
                foreach (IncomeInfo item in incomeList)
                {
                    string itemin = item.Id + ";" + item.Name + ";" + item.Gender + ";" + item.Job + ";" + item.Level + ";" + item.Dateofentry + ";" + item.Birth + ";" + item.Nationality + ";" + item.Salary.ToString("0.00");
                    WriteMsg(itemin, SavePath, true);
                }
            }
        }

        private void cleantxt()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxGender.Text = "";
            comboBoxJob.Text = "";
            comboBoxLevel.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            textBoxNa.Text = "";
            textBoxSalary.Text = "";
        }
        /// <summary>
        /// 保存修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id = int.Parse(textBoxID.Text.Trim());
                var selectedItem = listView1.SelectedItems[0];
                curItem = selectedItem;
                //更新idList
                idList.Remove(int.Parse(curItem.Text));
                idList.Add(id);
                //更新ListView

                listView1.Items.Remove(selectedItem);
                ListViewItem updatedItem = CreateLvItem(new IncomeInfo()
                {
                    Id = id,
                    Name = textBoxName.Text.Trim(),
                    Gender = textBoxGender.Text.Trim(),
                    Job = comboBoxJob.Text.Trim(),
                    Level = comboBoxLevel.Text.Trim(),
                    Dateofentry = dateTimePicker1.Value,
                    Birth = dateTimePicker2.Value,
                    Nationality = textBoxNa.Text.Trim(),
                    Salary = decimal.Parse(textBoxSalary.Text.Trim())
                });
                listView1.Items.Add(updatedItem);

                //更新incomeList
                foreach (IncomeInfo item in incomeList)
                {
                    if (item.Id == int.Parse(curItem.Text))
                    {
                        int index = incomeList.IndexOf(item);
                        incomeList.Insert(index + 1, new IncomeInfo()
                        {
                            Id = id,
                            Name = textBoxName.Text.Trim(),
                            Gender = textBoxGender.Text.Trim(),
                            Job = comboBoxJob.Text.Trim(),
                            Level = comboBoxLevel.Text.Trim(),
                            Dateofentry = dateTimePicker1.Value,
                            Birth = dateTimePicker2.Value,
                            Nationality = textBoxNa.Text.Trim(),
                            Salary = decimal.Parse(textBoxSalary.Text.Trim())
                        });
                        incomeList.RemoveAt(index);
                        break;
                    }
                }
                //更新文件
                if (File.Exists(SavePath))
                {
                    File.Create(SavePath).Close();
                    foreach (IncomeInfo item in incomeList)
                    {
                        string itemin = item.Id + ";" + item.Name + ";" + item.Gender + ";" + item.Job + ";" + item.Level + ";" + item.Dateofentry + ";" + item.Birth + ";" + item.Nationality + ";" + item.Salary.ToString("0.00");
                        WriteMsg(itemin, SavePath, true);
                    }
                }
            }
            else { MessageHelper.Error("修改", "请选择要修改的员工！"); }
        }
        /// <summary>
        /// 薪资排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            incomeList.Sort((x, y) => x.Salary.CompareTo(y.Salary));

            listView1.Items.Clear();
            foreach (IncomeInfo item in incomeList)
            {
                ListViewItem li = CreateLvItem(item);
                listView1.Items.Add(li);
            }
        }
    }
}
