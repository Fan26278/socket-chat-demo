namespace ChatDemo
{
    partial class ChatServerForm
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(435, 18);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(134, 45);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(93, 28);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(166, 28);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "127.0.0.1";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(25, 31);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(71, 18);
            this.lbIP.TabIndex = 2;
            this.lbIP.Text = "IP地址:";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(294, 31);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(62, 18);
            this.lbPort.TabIndex = 4;
            this.lbPort.Text = "Port：";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(362, 28);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(67, 28);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "2468";
            // 
            // txtLog
            // 
            this.txtLog.ContextMenuStrip = this.contextMenuStrip1;
            this.txtLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLog.Location = new System.Drawing.Point(28, 77);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(671, 480);
            this.txtLog.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearTextBoxToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // ClearTextBoxToolStripMenuItem
            // 
            this.ClearTextBoxToolStripMenuItem.Name = "ClearTextBoxToolStripMenuItem";
            this.ClearTextBoxToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ClearTextBoxToolStripMenuItem.Text = "清屏";
            this.ClearTextBoxToolStripMenuItem.Click += new System.EventHandler(this.ClearTextBoxToolStripMenuItem_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(28, 585);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(482, 28);
            this.txtMessage.TabIndex = 6;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(516, 580);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(183, 35);
            this.btnSendMessage.TabIndex = 7;
            this.btnSendMessage.Text = "发送";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(575, 18);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 45);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "中断监听";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ChatServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(712, 629);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChatServerForm";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ClearTextBoxToolStripMenuItem;
        private System.Windows.Forms.Button btnStop;
    }
}

