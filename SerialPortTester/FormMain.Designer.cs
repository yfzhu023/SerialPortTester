namespace SerialPortTester
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.RadioButton_Hex = new System.Windows.Forms.RadioButton();
            this.RadioButton_Char = new System.Windows.Forms.RadioButton();
            this.ComboBox_DataBits = new System.Windows.Forms.ComboBox();
            this.ComboBox_Parity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox_StopBits = new System.Windows.Forms.ComboBox();
            this.ComboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.ComboBox_PortName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_ClearReceive = new System.Windows.Forms.Button();
            this.TextBox_RecvData = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.Button_CleanData = new System.Windows.Forms.Button();
            this.TextBox_SendData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.button_Open);
            this.groupBox1.Controls.Add(this.RadioButton_Hex);
            this.groupBox1.Controls.Add(this.RadioButton_Char);
            this.groupBox1.Controls.Add(this.ComboBox_DataBits);
            this.groupBox1.Controls.Add(this.ComboBox_Parity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboBox_StopBits);
            this.groupBox1.Controls.Add(this.ComboBox_BaudRate);
            this.groupBox1.Controls.Add(this.ComboBox_PortName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lable1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(556, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(468, 63);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(80, 28);
            this.button_Close.TabIndex = 8;
            this.button_Close.Text = "关闭端口";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(468, 31);
            this.button_Open.Margin = new System.Windows.Forms.Padding(2);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(80, 28);
            this.button_Open.TabIndex = 7;
            this.button_Open.Text = "打开端口";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.Button_OpenCOM_Click);
            // 
            // RadioButton_Hex
            // 
            this.RadioButton_Hex.AutoSize = true;
            this.RadioButton_Hex.Location = new System.Drawing.Point(388, 65);
            this.RadioButton_Hex.Margin = new System.Windows.Forms.Padding(2);
            this.RadioButton_Hex.Name = "RadioButton_Hex";
            this.RadioButton_Hex.Size = new System.Drawing.Size(56, 24);
            this.RadioButton_Hex.TabIndex = 6;
            this.RadioButton_Hex.Text = "Hex";
            this.RadioButton_Hex.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Char
            // 
            this.RadioButton_Char.AutoSize = true;
            this.RadioButton_Char.Checked = true;
            this.RadioButton_Char.Location = new System.Drawing.Point(323, 65);
            this.RadioButton_Char.Margin = new System.Windows.Forms.Padding(2);
            this.RadioButton_Char.Name = "RadioButton_Char";
            this.RadioButton_Char.Size = new System.Drawing.Size(57, 24);
            this.RadioButton_Char.TabIndex = 5;
            this.RadioButton_Char.TabStop = true;
            this.RadioButton_Char.Text = "字符";
            this.RadioButton_Char.UseVisualStyleBackColor = true;
            // 
            // ComboBox_DataBits
            // 
            this.ComboBox_DataBits.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_DataBits.FormattingEnabled = true;
            this.ComboBox_DataBits.Location = new System.Drawing.Point(62, 63);
            this.ComboBox_DataBits.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_DataBits.Name = "ComboBox_DataBits";
            this.ComboBox_DataBits.Size = new System.Drawing.Size(76, 28);
            this.ComboBox_DataBits.TabIndex = 3;
            // 
            // ComboBox_Parity
            // 
            this.ComboBox_Parity.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_Parity.FormattingEnabled = true;
            this.ComboBox_Parity.Location = new System.Drawing.Point(218, 27);
            this.ComboBox_Parity.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_Parity.Name = "ComboBox_Parity";
            this.ComboBox_Parity.Size = new System.Drawing.Size(76, 28);
            this.ComboBox_Parity.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(161, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "校验位";
            // 
            // ComboBox_StopBits
            // 
            this.ComboBox_StopBits.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_StopBits.FormattingEnabled = true;
            this.ComboBox_StopBits.Location = new System.Drawing.Point(218, 63);
            this.ComboBox_StopBits.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_StopBits.Name = "ComboBox_StopBits";
            this.ComboBox_StopBits.Size = new System.Drawing.Size(76, 28);
            this.ComboBox_StopBits.TabIndex = 4;
            // 
            // ComboBox_BaudRate
            // 
            this.ComboBox_BaudRate.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_BaudRate.FormattingEnabled = true;
            this.ComboBox_BaudRate.Location = new System.Drawing.Point(381, 27);
            this.ComboBox_BaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_BaudRate.Name = "ComboBox_BaudRate";
            this.ComboBox_BaudRate.Size = new System.Drawing.Size(76, 28);
            this.ComboBox_BaudRate.TabIndex = 2;
            // 
            // ComboBox_PortName
            // 
            this.ComboBox_PortName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_PortName.FormattingEnabled = true;
            this.ComboBox_PortName.Location = new System.Drawing.Point(62, 27);
            this.ComboBox_PortName.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_PortName.Name = "ComboBox_PortName";
            this.ComboBox_PortName.Size = new System.Drawing.Size(76, 28);
            this.ComboBox_PortName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(161, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "停止位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(323, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable1.Location = new System.Drawing.Point(4, 31);
            this.lable1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(54, 20);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "串口号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_ClearReceive);
            this.groupBox2.Controls.Add(this.TextBox_RecvData);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(11, 244);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(556, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据接收";
            // 
            // button_ClearReceive
            // 
            this.button_ClearReceive.Location = new System.Drawing.Point(468, 170);
            this.button_ClearReceive.Margin = new System.Windows.Forms.Padding(2);
            this.button_ClearReceive.Name = "button_ClearReceive";
            this.button_ClearReceive.Size = new System.Drawing.Size(80, 28);
            this.button_ClearReceive.TabIndex = 1;
            this.button_ClearReceive.Text = "清除";
            this.button_ClearReceive.UseVisualStyleBackColor = true;
            this.button_ClearReceive.Click += new System.EventHandler(this.button_ClearReceive_Click);
            // 
            // TextBox_RecvData
            // 
            this.TextBox_RecvData.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_RecvData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_RecvData.Location = new System.Drawing.Point(10, 22);
            this.TextBox_RecvData.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_RecvData.Multiline = true;
            this.TextBox_RecvData.Name = "TextBox_RecvData";
            this.TextBox_RecvData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_RecvData.Size = new System.Drawing.Size(447, 176);
            this.TextBox_RecvData.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Button_Send);
            this.groupBox3.Controls.Add(this.Button_CleanData);
            this.groupBox3.Controls.Add(this.TextBox_SendData);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(11, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(556, 116);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据发送";
            // 
            // Button_Send
            // 
            this.Button_Send.Location = new System.Drawing.Point(468, 46);
            this.Button_Send.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(80, 28);
            this.Button_Send.TabIndex = 1;
            this.Button_Send.Text = "发送";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Button_CleanData
            // 
            this.Button_CleanData.Location = new System.Drawing.Point(468, 78);
            this.Button_CleanData.Margin = new System.Windows.Forms.Padding(2);
            this.Button_CleanData.Name = "Button_CleanData";
            this.Button_CleanData.Size = new System.Drawing.Size(80, 28);
            this.Button_CleanData.TabIndex = 2;
            this.Button_CleanData.Text = "清除";
            this.Button_CleanData.UseVisualStyleBackColor = true;
            this.Button_CleanData.Click += new System.EventHandler(this.Button_CleanData_Click);
            // 
            // TextBox_SendData
            // 
            this.TextBox_SendData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_SendData.Location = new System.Drawing.Point(10, 25);
            this.TextBox_SendData.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_SendData.Multiline = true;
            this.TextBox_SendData.Name = "TextBox_SendData";
            this.TextBox_SendData.Size = new System.Drawing.Size(447, 81);
            this.TextBox_SendData.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 462);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口测试程序";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBox_StopBits;
        private System.Windows.Forms.ComboBox ComboBox_BaudRate;
        private System.Windows.Forms.ComboBox ComboBox_PortName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.RadioButton RadioButton_Hex;
        private System.Windows.Forms.RadioButton RadioButton_Char;
        private System.Windows.Forms.ComboBox ComboBox_DataBits;
        private System.Windows.Forms.ComboBox ComboBox_Parity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_RecvData;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.Button Button_CleanData;
        private System.Windows.Forms.TextBox TextBox_SendData;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_ClearReceive;
    }
}

