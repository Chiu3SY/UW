using System;
using System.Data; // 用于表达式计算
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddButtonClickHandlers(); // 添加按钮点击事件处理程序
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = ""; // 初始化显示为空
        }

        // 数字按钮和操作符按钮点击事件
        private void Button_Click(object sender, EventArgs e)
        {
            //Button button = sender as Button;
            //var temp = button.Text[button.Text.Length - 1];
            //string input = temp.ToString();

            //// 简单括号匹配规则
            //if (input == "(")
            //{
            //    // 如果前面是数字或关闭括号，自动补上操作符
            //    if (textBox1.Text.Length > 0 &&
            //        (char.IsDigit(textBox1.Text[^1]) || textBox1.Text[^1] == ')'))
            //    {
            //        textBox1.Text += "*";
            //    }
            //}
            //else if (input == ")")
            //{
            //    // 确保括号匹配前提下，才能添加关闭括号
            //    int openCount = textBox1.Text.Split('(').Length - 1;
            //    int closeCount = textBox1.Text.Split(')').Length - 1;

            //    if (closeCount < openCount)
            //    {
            //        textBox1.Text += input;
            //    }
            //    return;
            //}
            //else if (input == "C" || input == "=") return;

            //// 直接追加文本
            //textBox1.Text += input;

            Button button = sender as Button;
            string lastchar = button.Text[button.Text.Length - 1].ToString();
            if (lastchar == "=" || lastchar == "C") return;
            else if (lastchar == "+" || lastchar == "-" || lastchar == "*" || lastchar == "/")
            {
                if (textBox1.Text[^1].ToString() == lastchar) {
                    string temp1 = textBox1.Text[^1]
                            .ToString();
                    return;
                }
                    
                textBox1.Text += lastchar;
            }
            else if (lastchar == "(")
            {
                if (textBox1.Text.Length > 0 && (char.IsDigit(textBox1.Text[textBox1.Text.Length - 1]) || textBox1.Text[textBox1.Text.Length - 1].ToString() == ")"))
                {
                    textBox1.Text += "*";
                }
                textBox1.Text += lastchar;
            }
            else if (lastchar == ")")
            {
                if ((textBox1.Text.Split("(").Length - 1) > textBox1.Text.Split(")").Length - 1)
                {
                    textBox1.Text += lastchar;
                }
            }
            else { textBox1.Text += lastchar; }

        }
        

        // 清空按钮
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //DataTable dt = new DataTable();
            //object output = dt.Compute("(1+1)(2+2)", "");
            //textBox1.Text = output.ToString();
        }

        // 计算按钮
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox1.Text;

                // 使用 DataTable 计算表达式的值
                DataTable table = new DataTable();
                object result = table.Compute(expression, ""); // 计算表达式
                textBox1.Text = result.ToString(); // 显示结果
            }
            catch (Exception ex)
            {
                MessageBox.Show($"计算错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
        }

        // 添加按钮点击事件处理程序
        private void AddButtonClickHandlers()
        {
            // 获取所有按钮控件
            var buttons = this.Controls.OfType<Button>();

            // 为每个按钮添加点击事件处理程序
            foreach (var button in buttons)
            {
                button.Click += Button_Click;
            }
        }
    }
}
