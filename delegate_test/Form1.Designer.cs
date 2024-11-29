namespace delegate_test
{
    partial class btnAddPerson
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
            lblCount = new Label();
            lblAlert = new Label();
            button1 = new Button();
            btnRemovePerson = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(403, 130);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(59, 25);
            lblCount.TabIndex = 0;
            lblCount.Text = "label1";
            // 
            // lblAlert
            // 
            lblAlert.AutoSize = true;
            lblAlert.Location = new Point(403, 213);
            lblAlert.Name = "lblAlert";
            lblAlert.Size = new Size(59, 25);
            lblAlert.TabIndex = 1;
            lblAlert.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(233, 303);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "添加人员";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnRemovePerson
            // 
            btnRemovePerson.Location = new Point(412, 303);
            btnRemovePerson.Name = "btnRemovePerson";
            btnRemovePerson.Size = new Size(112, 34);
            btnRemovePerson.TabIndex = 3;
            btnRemovePerson.Text = "移除人员";
            btnRemovePerson.UseVisualStyleBackColor = true;
            btnRemovePerson.Click += btnRemovePerson_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 130);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 4;
            label1.Text = "当前人数：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 213);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 5;
            label2.Text = "警告信息：";
            // 
            // btnAddPerson
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemovePerson);
            Controls.Add(button1);
            Controls.Add(lblAlert);
            Controls.Add(lblCount);
            Name = "btnAddPerson";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCount;
        private Label lblAlert;
        private Button button1;
        private Button btnRemovePerson;
        private Label label1;
        private Label label2;
    }
}
