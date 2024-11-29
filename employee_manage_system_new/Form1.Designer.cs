using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace employee_manage_system_new
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("");
            button1 = new Button();
            comboBoxJob = new ComboBox();
            id = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxLevel = new ComboBox();
            textBoxID = new TextBox();
            textBoxGender = new TextBox();
            textBoxSalary = new TextBox();
            textBoxName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxNa = new TextBox();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            listView1 = new ListView();
            colid = new ColumnHeader();
            colname = new ColumnHeader();
            colgen = new ColumnHeader();
            coljob = new ColumnHeader();
            collev = new ColumnHeader();
            colruzhi = new ColumnHeader();
            colbirth = new ColumnHeader();
            colna = new ColumnHeader();
            colsal = new ColumnHeader();
            button2 = new Button();
            button3 = new Button();
            textBoxIdS = new TextBox();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(972, 34);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "确认增加";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxJob
            // 
            comboBoxJob.FormattingEnabled = true;
            comboBoxJob.Items.AddRange(new object[] { "发工程师", "装配技术员", "项目工程师", "采购员", "财务", "人事" });
            comboBoxJob.Location = new Point(172, 203);
            comboBoxJob.Name = "comboBoxJob";
            comboBoxJob.Size = new Size(182, 33);
            comboBoxJob.TabIndex = 2;
            comboBoxJob.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(64, 30);
            id.Name = "id";
            id.Size = new Size(88, 25);
            id.TabIndex = 3;
            id.Text = "员工工号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 88);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 4;
            label2.Text = "姓名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 147);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 5;
            label3.Text = "性别";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 206);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 6;
            label4.Text = "岗位";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 206);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 7;
            label5.Text = "级别";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 275);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 8;
            label6.Text = "入职时间";
            // 
            // comboBoxLevel
            // 
            comboBoxLevel.FormattingEnabled = true;
            comboBoxLevel.Items.AddRange(new object[] { "初级", "中级", "高级", "经理" });
            comboBoxLevel.Location = new Point(541, 198);
            comboBoxLevel.Name = "comboBoxLevel";
            comboBoxLevel.Size = new Size(182, 33);
            comboBoxLevel.TabIndex = 9;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(189, 30);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(150, 31);
            textBoxID.TabIndex = 10;
            // 
            // textBoxGender
            // 
            textBoxGender.Location = new Point(189, 141);
            textBoxGender.Name = "textBoxGender";
            textBoxGender.Size = new Size(150, 31);
            textBoxGender.TabIndex = 11;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(558, 82);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(150, 31);
            textBoxSalary.TabIndex = 12;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(189, 88);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 31);
            textBoxName.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(172, 269);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 14;
            // 
            // textBoxNa
            // 
            textBoxNa.Location = new Point(558, 30);
            textBoxNa.Name = "textBoxNa";
            textBoxNa.Size = new Size(150, 31);
            textBoxNa.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(433, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 15;
            label1.Text = "籍贯";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(172, 329);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 329);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 17;
            label7.Text = "出生时间";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(433, 88);
            label8.Name = "label8";
            label8.Size = new Size(50, 25);
            label8.TabIndex = 19;
            label8.Text = "薪资";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BackColor = SystemColors.HighlightText;
            listView1.Columns.AddRange(new ColumnHeader[] { colid, colname, colgen, coljob, collev, colruzhi, colbirth, colna, colsal });
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(64, 399);
            listView1.Name = "listView1";
            listView1.Size = new Size(1498, 449);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // colid
            // 
            colid.Text = "员工工号";
            colid.Width = 150;
            // 
            // colname
            // 
            colname.Text = "姓名";
            colname.Width = 100;
            // 
            // colgen
            // 
            colgen.Text = "性别";
            // 
            // coljob
            // 
            coljob.Text = "岗位";
            coljob.Width = 150;
            // 
            // collev
            // 
            collev.Text = "级别";
            collev.Width = 150;
            // 
            // colruzhi
            // 
            colruzhi.Text = "入职时间";
            colruzhi.Width = 250;
            // 
            // colbirth
            // 
            colbirth.Text = "出生时间";
            colbirth.Width = 250;
            // 
            // colna
            // 
            colna.Text = "籍贯";
            colna.Width = 80;
            // 
            // colsal
            // 
            colsal.Text = "薪资";
            colsal.Width = 300;
            // 
            // button2
            // 
            button2.Location = new Point(972, 287);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 21;
            button2.Text = "薪资排序";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(972, 224);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 22;
            button3.Text = "按工号查";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBoxIdS
            // 
            textBoxIdS.Location = new Point(1130, 227);
            textBoxIdS.Name = "textBoxIdS";
            textBoxIdS.Size = new Size(150, 31);
            textBoxIdS.TabIndex = 23;
            // 
            // button4
            // 
            button4.Location = new Point(972, 99);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 24;
            button4.Text = "确认删除";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(972, 164);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 25;
            button5.Text = "保存修改";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 884);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBoxIdS);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(label8);
            Controls.Add(dateTimePicker2);
            Controls.Add(label7);
            Controls.Add(textBoxNa);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSalary);
            Controls.Add(textBoxGender);
            Controls.Add(textBoxID);
            Controls.Add(comboBoxLevel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(id);
            Controls.Add(comboBoxJob);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBoxJob;
        private Label id;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxLevel;
        private TextBox textBoxID;
        private TextBox textBoxGender;
        private TextBox textBoxSalary;
        private TextBox textBoxName;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxNa;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Label label8;
        private ListView listView1;
        private Button button2;
        private ColumnHeader colid;
        private ColumnHeader colname;
        private ColumnHeader colgen;
        private ColumnHeader coljob;
        private ColumnHeader collev;
        private ColumnHeader colruzhi;
        private ColumnHeader colbirth;
        private ColumnHeader colna;
        private ColumnHeader colsal;
        private Button button3;
        private TextBox textBoxIdS;
        private Button button4;
        private Button button5;
    }
}
