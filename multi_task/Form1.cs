namespace multi_task
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
            StartDataCollection();
        }

        private void StartDataCollection()
        {
            Task.Run(() => CollectData());
        }

        private void CollectData()
        {
            while (true)
            {
                Random random = new Random();
                int collectedData = random.Next(0, 101);
                string collectedEvent = "automatic";
                ListViewItem item = new ListViewItem(collectedData.ToString());
                item.SubItems.Add(collectedEvent);

                if (listView1.InvokeRequired)
                {
                    listView1.BeginInvoke(new Action(() => listView1.Items.Add(item)));
                    listView1.BeginInvoke(new Action(() => listView1.EnsureVisible(listView1.Items.Count - 1)));
                    if(collectedData > 90)
                    {
                        listView1.BeginInvoke(new Action(() => item.BackColor = Color.Red));
                        listView1.BeginInvoke(new Action(() => item.ForeColor = Color.White));
                    }
                    else if(collectedData < 20)
                    {
                        listView1.BeginInvoke(new Action(() => item.BackColor = Color.Blue));
                        listView1.BeginInvoke(new Action(() => item.ForeColor = Color.White));
                    }
                }

                Task.Delay(TimeSpan.FromSeconds(5)).Wait();
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int collectedData = random.Next(0, 101);
            string collectedEvent = "manual";

            ListViewItem item = new ListViewItem(collectedData.ToString());
            item.SubItems.Add(collectedEvent);

            listView1.Items.Add(item);
            listView1.EnsureVisible(listView1.Items.Count - 1);

            if (collectedData > 90)
            {
                item.BackColor = Color.Red; 
                item.ForeColor = Color.White;
            }
            else if (collectedData < 20)
            {
                item.BackColor = Color.Blue; 
                item.ForeColor = Color.White; 
            }
            else { }
        }
    }
}
