using System;
using System.Data; // ���ڱ��ʽ����
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddButtonClickHandlers(); // ��Ӱ�ť����¼��������
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = ""; // ��ʼ����ʾΪ��
        }

        // ���ְ�ť�Ͳ�������ť����¼�
        private void Button_Click(object sender, EventArgs e)
        {
            //Button button = sender as Button;
            //var temp = button.Text[button.Text.Length - 1];
            //string input = temp.ToString();

            //// ������ƥ�����
            //if (input == "(")
            //{
            //    // ���ǰ�������ֻ�ر����ţ��Զ����ϲ�����
            //    if (textBox1.Text.Length > 0 &&
            //        (char.IsDigit(textBox1.Text[^1]) || textBox1.Text[^1] == ')'))
            //    {
            //        textBox1.Text += "*";
            //    }
            //}
            //else if (input == ")")
            //{
            //    // ȷ������ƥ��ǰ���£�������ӹر�����
            //    int openCount = textBox1.Text.Split('(').Length - 1;
            //    int closeCount = textBox1.Text.Split(')').Length - 1;

            //    if (closeCount < openCount)
            //    {
            //        textBox1.Text += input;
            //    }
            //    return;
            //}
            //else if (input == "C" || input == "=") return;

            //// ֱ��׷���ı�
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
        

        // ��հ�ť
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //DataTable dt = new DataTable();
            //object output = dt.Compute("(1+1)(2+2)", "");
            //textBox1.Text = output.ToString();
        }

        // ���㰴ť
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox1.Text;

                // ʹ�� DataTable ������ʽ��ֵ
                DataTable table = new DataTable();
                object result = table.Compute(expression, ""); // ������ʽ
                textBox1.Text = result.ToString(); // ��ʾ���
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�������{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
        }

        // ��Ӱ�ť����¼��������
        private void AddButtonClickHandlers()
        {
            // ��ȡ���а�ť�ؼ�
            var buttons = this.Controls.OfType<Button>();

            // Ϊÿ����ť��ӵ���¼��������
            foreach (var button in buttons)
            {
                button.Click += Button_Click;
            }
        }
    }
}
