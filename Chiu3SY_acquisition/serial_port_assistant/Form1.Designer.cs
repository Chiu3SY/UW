namespace serial_port_assistant
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxDataFrame;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.CheckBox checkBoxHexDisplay;
        private System.Windows.Forms.CheckBox checkBoxHexSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonClearData;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonClearSend;
        private System.Windows.Forms.Button buttonSaveData;

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
            textBoxDataFrame = new TextBox();
            comboBoxPort = new ComboBox();
            comboBoxStopBits = new ComboBox();
            comboBoxDataBits = new ComboBox();
            comboBoxBaudRate = new ComboBox();
            comboBoxParity = new ComboBox();
            buttonOpenPort = new Button();
            checkBoxHexDisplay = new CheckBox();
            checkBoxHexSend = new CheckBox();
            textBoxSend = new TextBox();
            buttonClearData = new Button();
            buttonSend = new Button();
            buttonClearSend = new Button();
            buttonSaveData = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxDataFrame
            // 
            textBoxDataFrame.Location = new Point(12, 12);
            textBoxDataFrame.Multiline = true;
            textBoxDataFrame.Name = "textBoxDataFrame";
            textBoxDataFrame.Size = new Size(500, 248);
            textBoxDataFrame.TabIndex = 0;
            // 
            // comboBoxPort
            // 
            comboBoxPort.FormattingEnabled = true;
            comboBoxPort.Location = new Point(729, 12);
            comboBoxPort.Name = "comboBoxPort";
            comboBoxPort.Size = new Size(200, 33);
            comboBoxPort.TabIndex = 1;
            // 
            // comboBoxStopBits
            // 
            comboBoxStopBits.FormattingEnabled = true;
            comboBoxStopBits.Items.AddRange(new object[] { "1", "1.5", "2" });
            comboBoxStopBits.Location = new Point(729, 52);
            comboBoxStopBits.Name = "comboBoxStopBits";
            comboBoxStopBits.Size = new Size(200, 33);
            comboBoxStopBits.TabIndex = 2;
            // 
            // comboBoxDataBits
            // 
            comboBoxDataBits.FormattingEnabled = true;
            comboBoxDataBits.Items.AddRange(new object[] { "5", "6", "7", "8" });
            comboBoxDataBits.Location = new Point(729, 92);
            comboBoxDataBits.Name = "comboBoxDataBits";
            comboBoxDataBits.Size = new Size(200, 33);
            comboBoxDataBits.TabIndex = 3;
            // 
            // comboBoxBaudRate
            // 
            comboBoxBaudRate.FormattingEnabled = true;
            comboBoxBaudRate.Items.AddRange(new object[] { "9600", "19200", "38400", "115200" });
            comboBoxBaudRate.Location = new Point(729, 132);
            comboBoxBaudRate.Name = "comboBoxBaudRate";
            comboBoxBaudRate.Size = new Size(200, 33);
            comboBoxBaudRate.TabIndex = 4;
            // 
            // comboBoxParity
            // 
            comboBoxParity.FormattingEnabled = true;
            comboBoxParity.Items.AddRange(new object[] { "无", "奇校验", "偶校验" });
            comboBoxParity.Location = new Point(729, 172);
            comboBoxParity.Name = "comboBoxParity";
            comboBoxParity.Size = new Size(200, 33);
            comboBoxParity.TabIndex = 5;
            // 
            // buttonOpenPort
            // 
            buttonOpenPort.Location = new Point(622, 220);
            buttonOpenPort.Name = "buttonOpenPort";
            buttonOpenPort.Size = new Size(200, 40);
            buttonOpenPort.TabIndex = 6;
            buttonOpenPort.Text = "打开串口";
            buttonOpenPort.UseVisualStyleBackColor = true;
            buttonOpenPort.Click += buttonOpenPort_Click;
            // 
            // checkBoxHexDisplay
            // 
            checkBoxHexDisplay.AutoSize = true;
            checkBoxHexDisplay.Location = new Point(554, 290);
            checkBoxHexDisplay.Name = "checkBoxHexDisplay";
            checkBoxHexDisplay.Size = new Size(134, 29);
            checkBoxHexDisplay.TabIndex = 7;
            checkBoxHexDisplay.Text = "16进制显示";
            checkBoxHexDisplay.UseVisualStyleBackColor = true;
            // 
            // checkBoxHexSend
            // 
            checkBoxHexSend.AutoSize = true;
            checkBoxHexSend.Location = new Point(554, 320);
            checkBoxHexSend.Name = "checkBoxHexSend";
            checkBoxHexSend.Size = new Size(134, 29);
            checkBoxHexSend.TabIndex = 8;
            checkBoxHexSend.Text = "16进制发送";
            checkBoxHexSend.UseVisualStyleBackColor = true;
            // 
            // textBoxSend
            // 
            textBoxSend.Location = new Point(12, 283);
            textBoxSend.Multiline = true;
            textBoxSend.Name = "textBoxSend";
            textBoxSend.Size = new Size(500, 190);
            textBoxSend.TabIndex = 9;
            // 
            // buttonClearData
            // 
            buttonClearData.Location = new Point(729, 283);
            buttonClearData.Name = "buttonClearData";
            buttonClearData.Size = new Size(200, 40);
            buttonClearData.TabIndex = 10;
            buttonClearData.Text = "清除数据";
            buttonClearData.UseVisualStyleBackColor = true;
            buttonClearData.Click += buttonClearData_Click;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(729, 333);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(200, 40);
            buttonSend.TabIndex = 11;
            buttonSend.Text = "发送信息";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonClearSend
            // 
            buttonClearSend.Location = new Point(729, 383);
            buttonClearSend.Name = "buttonClearSend";
            buttonClearSend.Size = new Size(200, 40);
            buttonClearSend.TabIndex = 12;
            buttonClearSend.Text = "清除信息";
            buttonClearSend.UseVisualStyleBackColor = true;
            // 
            // buttonSaveData
            // 
            buttonSaveData.Location = new Point(729, 433);
            buttonSaveData.Name = "buttonSaveData";
            buttonSaveData.Size = new Size(200, 40);
            buttonSaveData.TabIndex = 13;
            buttonSaveData.Text = "保存数据";
            buttonSaveData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(534, 12);
            label1.Name = "label1";
            label1.Size = new Size(173, 38);
            label1.TabIndex = 14;
            label1.Text = "串口";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(534, 52);
            label2.Name = "label2";
            label2.Size = new Size(173, 38);
            label2.TabIndex = 15;
            label2.Text = "停止位";
            // 
            // label3
            // 
            label3.Location = new Point(534, 92);
            label3.Name = "label3";
            label3.Size = new Size(88, 38);
            label3.TabIndex = 16;
            label3.Text = "数据位";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Location = new Point(534, 132);
            label4.Name = "label4";
            label4.Size = new Size(88, 38);
            label4.TabIndex = 17;
            label4.Text = "波特率";
            // 
            // label5
            // 
            label5.Location = new Point(534, 170);
            label5.Name = "label5";
            label5.Size = new Size(88, 38);
            label5.TabIndex = 18;
            label5.Text = "奇偶校验";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 500);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSaveData);
            Controls.Add(buttonClearSend);
            Controls.Add(buttonSend);
            Controls.Add(buttonClearData);
            Controls.Add(textBoxSend);
            Controls.Add(checkBoxHexSend);
            Controls.Add(checkBoxHexDisplay);
            Controls.Add(buttonOpenPort);
            Controls.Add(comboBoxParity);
            Controls.Add(comboBoxBaudRate);
            Controls.Add(comboBoxDataBits);
            Controls.Add(comboBoxStopBits);
            Controls.Add(comboBoxPort);
            Controls.Add(textBoxDataFrame);
            Name = "Form1";
            Text = "串口调试助手";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
