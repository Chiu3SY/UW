using System.Diagnostics.Metrics;

namespace delegate_test
{
    public partial class btnAddPerson : Form
    {
        //���������������Ҫ��������¼��أ���counter��static?
        //����ӿ�������¼��Ķ���
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
            lblAlert.Text = $"Ŀǰ����{e}�ˣ�������������!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter.AddPerson();
            lblCount.Text = counter.CurrentCount.ToString();
        }

        private void Counter_numberexceed(object? sender, int e)
        {
            lblAlert.Text = $"Ŀǰ����{e}�ˣ����������������!";
        }

        private void btnRemovePerson_Click(object sender, EventArgs e)
        {
            counter.RemovePerson();
            lblCount.Text = counter.CurrentCount.ToString();
        }
    }
}
