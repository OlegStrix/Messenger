namespace DotChatWF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listMessages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldUsername = new System.Windows.Forms.TextBox();
            this.fieldMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.updateLoop = new System.Windows.Forms.Timer(this.components);
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.textIp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listMessages
            // 
            this.listMessages.BackColor = System.Drawing.Color.White;
            this.listMessages.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.listMessages.ForeColor = System.Drawing.Color.DimGray;
            this.listMessages.FormattingEnabled = true;
            this.listMessages.ItemHeight = 17;
            this.listMessages.Location = new System.Drawing.Point(9, 10);
            this.listMessages.Margin = new System.Windows.Forms.Padding(2);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(230, 276);
            this.listMessages.TabIndex = 0;
            this.listMessages.SelectedIndexChanged += new System.EventHandler(this.listMessages_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(11, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // fieldUsername
            // 
            this.fieldUsername.AutoCompleteCustomSource.AddRange(new string[] {
            "You are not logged in"});
            this.fieldUsername.BackColor = System.Drawing.Color.White;
            this.fieldUsername.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.fieldUsername.ForeColor = System.Drawing.Color.DimGray;
            this.fieldUsername.Location = new System.Drawing.Point(81, 304);
            this.fieldUsername.Margin = new System.Windows.Forms.Padding(2);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.ReadOnly = true;
            this.fieldUsername.Size = new System.Drawing.Size(267, 23);
            this.fieldUsername.TabIndex = 3;
            this.fieldUsername.Text = "You are not loggined in";
            this.fieldUsername.TextChanged += new System.EventHandler(this.fieldUsername_TextChanged);
            // 
            // fieldMessage
            // 
            this.fieldMessage.BackColor = System.Drawing.Color.Snow;
            this.fieldMessage.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.fieldMessage.ForeColor = System.Drawing.Color.DimGray;
            this.fieldMessage.Location = new System.Drawing.Point(81, 332);
            this.fieldMessage.Margin = new System.Windows.Forms.Padding(2);
            this.fieldMessage.Multiline = true;
            this.fieldMessage.Name = "fieldMessage";
            this.fieldMessage.Size = new System.Drawing.Size(267, 25);
            this.fieldMessage.TabIndex = 4;
            this.fieldMessage.TextChanged += new System.EventHandler(this.fieldMessage_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(498, 305);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(93, 88);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // updateLoop
            // 
            this.updateLoop.Enabled = true;
            this.updateLoop.Interval = 600;
            // 
            // btnAuth
            // 
            this.btnAuth.BackColor = System.Drawing.Color.Transparent;
            this.btnAuth.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnAuth.Location = new System.Drawing.Point(9, 370);
            this.btnAuth.Margin = new System.Windows.Forms.Padding(2);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(121, 26);
            this.btnAuth.TabIndex = 6;
            this.btnAuth.Text = "Authentification";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.Transparent;
            this.btnReg.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnReg.Location = new System.Drawing.Point(153, 370);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(106, 26);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Registartion";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.listBox1.ForeColor = System.Drawing.Color.DimGray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(335, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 276);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Transparent;
            this.Delete.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.Delete.Location = new System.Drawing.Point(358, 367);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(106, 26);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextPort
            // 
            this.TextPort.BackColor = System.Drawing.Color.Snow;
            this.TextPort.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.TextPort.ForeColor = System.Drawing.Color.DimGray;
            this.TextPort.Location = new System.Drawing.Point(358, 332);
            this.TextPort.Margin = new System.Windows.Forms.Padding(2);
            this.TextPort.Multiline = true;
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(121, 25);
            this.TextPort.TabIndex = 10;
            this.TextPort.Text = "Paste Port";
            this.TextPort.TextChanged += new System.EventHandler(this.TextPort_TextChanged);
            // 
            // textIp
            // 
            this.textIp.BackColor = System.Drawing.Color.White;
            this.textIp.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.textIp.ForeColor = System.Drawing.Color.DimGray;
            this.textIp.Location = new System.Drawing.Point(358, 302);
            this.textIp.Margin = new System.Windows.Forms.Padding(2);
            this.textIp.Name = "textIp";
            this.textIp.Size = new System.Drawing.Size(121, 23);
            this.textIp.TabIndex = 11;
            this.textIp.Text = "Paste IP\r\n";
            this.textIp.TextChanged += new System.EventHandler(this.textIp_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 407);
            this.Controls.Add(this.textIp);
            this.Controls.Add(this.TextPort);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.fieldMessage);
            this.Controls.Add(this.fieldUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewYear";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldUsername;
        private System.Windows.Forms.TextBox fieldMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer updateLoop;
    private System.Windows.Forms.Button btnAuth;
    private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox TextPort;
        private System.Windows.Forms.TextBox textIp;
    }
}

