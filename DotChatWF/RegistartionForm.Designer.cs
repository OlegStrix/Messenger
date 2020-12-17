namespace DotChatWF
{
  partial class RegistartionForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistartionForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBPass2 = new System.Windows.Forms.TextBox();
            this.TBPass1 = new System.Windows.Forms.TextBox();
            this.fieldUserName = new System.Windows.Forms.TextBox();
            this.btnReg2serv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Retype password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username:";
            // 
            // TBPass2
            // 
            this.TBPass2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.TBPass2.Location = new System.Drawing.Point(11, 116);
            this.TBPass2.Margin = new System.Windows.Forms.Padding(2);
            this.TBPass2.Name = "TBPass2";
            this.TBPass2.PasswordChar = '*';
            this.TBPass2.Size = new System.Drawing.Size(208, 23);
            this.TBPass2.TabIndex = 10;
            // 
            // TBPass1
            // 
            this.TBPass1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.TBPass1.Location = new System.Drawing.Point(11, 72);
            this.TBPass1.Margin = new System.Windows.Forms.Padding(2);
            this.TBPass1.Name = "TBPass1";
            this.TBPass1.PasswordChar = '*';
            this.TBPass1.Size = new System.Drawing.Size(208, 23);
            this.TBPass1.TabIndex = 9;
            // 
            // fieldUserName
            // 
            this.fieldUserName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.fieldUserName.Location = new System.Drawing.Point(11, 28);
            this.fieldUserName.Margin = new System.Windows.Forms.Padding(2);
            this.fieldUserName.Name = "fieldUserName";
            this.fieldUserName.Size = new System.Drawing.Size(169, 23);
            this.fieldUserName.TabIndex = 8;
            this.fieldUserName.TextChanged += new System.EventHandler(this.fieldUserName_TextChanged);
            // 
            // btnReg2serv
            // 
            this.btnReg2serv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReg2serv.BackgroundImage")));
            this.btnReg2serv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReg2serv.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnReg2serv.ForeColor = System.Drawing.Color.Black;
            this.btnReg2serv.Location = new System.Drawing.Point(8, 146);
            this.btnReg2serv.Margin = new System.Windows.Forms.Padding(2);
            this.btnReg2serv.Name = "btnReg2serv";
            this.btnReg2serv.Size = new System.Drawing.Size(333, 91);
            this.btnReg2serv.TabIndex = 7;
            this.btnReg2serv.Text = "Registartion";
            this.btnReg2serv.UseVisualStyleBackColor = true;
            this.btnReg2serv.Click += new System.EventHandler(this.btnReg2serv_Click);
            // 
            // RegistartionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 248);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBPass2);
            this.Controls.Add(this.TBPass1);
            this.Controls.Add(this.fieldUserName);
            this.Controls.Add(this.btnReg2serv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistartionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewYearReg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistartionForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistartionForm_FormClosed);
            this.Load += new System.EventHandler(this.RegistartionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TBPass2;
    private System.Windows.Forms.TextBox TBPass1;
    private System.Windows.Forms.TextBox fieldUserName;
    private System.Windows.Forms.Button btnReg2serv;
  }
}