namespace ChatDemoClient
{
    partial class ChatClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.TextBox();
            this.portText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "链接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP地址";
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(72, 27);
            this.ipText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(105, 21);
            this.ipText.TabIndex = 2;
            this.ipText.Text = "127.0.0.1";
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(247, 27);
            this.portText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(45, 21);
            this.portText.TabIndex = 4;
            this.portText.Text = "2468";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口号：";
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLog.Location = new System.Drawing.Point(8, 62);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(477, 361);
            this.txtLog.TabIndex = 5;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(8, 446);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(401, 21);
            this.txtMessage.TabIndex = 6;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(412, 441);
            this.btn_send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(81, 25);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "中断链接";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 475);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChatClient";
            this.Text = "Chat客户端v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button button3;
    }
}

