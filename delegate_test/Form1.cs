using System.Diagnostics.Metrics;

namespace delegate_test
{
    public partial class btnAddPerson : Form
    {
        //如果还有其他的类要订阅这个事件呢，把counter类static?
        //抽象接口来添加事件的订阅
        private Counter counter;
        public btnAddPerson()
        {
            InitializeComponent();
            counter = new Counter();
            counter.NumberExceed += Counter_numberexceed;
            counter.NumberBelowed += Counter_numberBlower;
            lblAlert.Text = string.Empty;
            lblCount.Text = "0";
        }

        private void Counter_numberBlower(object? sender, int e)
        {
            lblAlert.Text = $"目前已有{e}人，符合人数限制!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter.AddPerson();
            lblCount.Text = counter.CurrentCount.ToString();
        }

        private void Counter_numberexceed(object? sender, int e)
        {
            lblAlert.Text = $"目前已有{e}人，超过最大人数限制!";
        }

        private void btnRemovePerson_Click(object sender, EventArgs e)
        {
            counter.RemovePerson();
            lblCount.Text = counter.CurrentCount.ToString();
        }
    }
}
