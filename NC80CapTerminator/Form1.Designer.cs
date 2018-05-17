namespace NC80CapTerminator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tmrKiller = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMomi = new System.Windows.Forms.Label();
            this.chkMomi = new System.Windows.Forms.CheckBox();
            this.chkSvc = new System.Windows.Forms.CheckBox();
            this.chkRMS = new System.Windows.Forms.CheckBox();
            this.chkCap = new System.Windows.Forms.CheckBox();
            this.chkCli = new System.Windows.Forms.CheckBox();
            this.lblSvc = new System.Windows.Forms.Label();
            this.lblRM = new System.Windows.Forms.Label();
            this.lblCap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCli = new System.Windows.Forms.Label();
            this.tmrStatus = new System.Windows.Forms.Timer(this.components);
            this.icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Killer stopped.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrKiller
            // 
            this.tmrKiller.Tick += new System.EventHandler(this.tmrKiller_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Killer Service";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMomi);
            this.groupBox2.Controls.Add(this.chkMomi);
            this.groupBox2.Controls.Add(this.chkSvc);
            this.groupBox2.Controls.Add(this.chkRMS);
            this.groupBox2.Controls.Add(this.chkCap);
            this.groupBox2.Controls.Add(this.chkCli);
            this.groupBox2.Controls.Add(this.lblSvc);
            this.groupBox2.Controls.Add(this.lblRM);
            this.groupBox2.Controls.Add(this.lblCap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblCli);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 234);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current status";
            // 
            // lblMomi
            // 
            this.lblMomi.AutoSize = true;
            this.lblMomi.Location = new System.Drawing.Point(13, 211);
            this.lblMomi.Name = "lblMomi";
            this.lblMomi.Size = new System.Drawing.Size(51, 12);
            this.lblMomi.TabIndex = 13;
            this.lblMomi.Text = "Running";
            // 
            // chkMomi
            // 
            this.chkMomi.AutoSize = true;
            this.chkMomi.Checked = true;
            this.chkMomi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMomi.Location = new System.Drawing.Point(15, 188);
            this.chkMomi.Name = "chkMomi";
            this.chkMomi.Size = new System.Drawing.Size(127, 16);
            this.chkMomi.TabIndex = 12;
            this.chkMomi.Text = "Momi (no mother)";
            this.chkMomi.UseVisualStyleBackColor = true;
            // 
            // chkSvc
            // 
            this.chkSvc.AutoSize = true;
            this.chkSvc.Checked = true;
            this.chkSvc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSvc.Location = new System.Drawing.Point(15, 148);
            this.chkSvc.Name = "chkSvc";
            this.chkSvc.Size = new System.Drawing.Size(176, 16);
            this.chkSvc.TabIndex = 11;
            this.chkSvc.Text = "SvcNC80Cli(Host Process)";
            this.chkSvc.UseVisualStyleBackColor = true;
            // 
            // chkRMS
            // 
            this.chkRMS.AutoSize = true;
            this.chkRMS.Checked = true;
            this.chkRMS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRMS.Location = new System.Drawing.Point(15, 109);
            this.chkRMS.Name = "chkRMS";
            this.chkRMS.Size = new System.Drawing.Size(202, 16);
            this.chkRMS.TabIndex = 10;
            this.chkRMS.Text = "RM_Service(Remote Controller)";
            this.chkRMS.UseVisualStyleBackColor = true;
            // 
            // chkCap
            // 
            this.chkCap.AutoSize = true;
            this.chkCap.Checked = true;
            this.chkCap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCap.Location = new System.Drawing.Point(15, 67);
            this.chkCap.Name = "chkCap";
            this.chkCap.Size = new System.Drawing.Size(131, 16);
            this.chkCap.TabIndex = 9;
            this.chkCap.Text = "NC80Cap(Capture)";
            this.chkCap.UseVisualStyleBackColor = true;
            // 
            // chkCli
            // 
            this.chkCli.AutoSize = true;
            this.chkCli.Checked = true;
            this.chkCli.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCli.Location = new System.Drawing.Point(15, 23);
            this.chkCli.Name = "chkCli";
            this.chkCli.Size = new System.Drawing.Size(111, 16);
            this.chkCli.TabIndex = 8;
            this.chkCli.Text = "NC80Cli(Client)";
            this.chkCli.UseVisualStyleBackColor = true;
            // 
            // lblSvc
            // 
            this.lblSvc.AutoSize = true;
            this.lblSvc.Location = new System.Drawing.Point(13, 170);
            this.lblSvc.Name = "lblSvc";
            this.lblSvc.Size = new System.Drawing.Size(51, 12);
            this.lblSvc.TabIndex = 7;
            this.lblSvc.Text = "Running";
            // 
            // lblRM
            // 
            this.lblRM.AutoSize = true;
            this.lblRM.Location = new System.Drawing.Point(13, 131);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(51, 12);
            this.lblRM.TabIndex = 6;
            this.lblRM.Text = "Running";
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Location = new System.Drawing.Point(13, 90);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(51, 12);
            this.lblCap.TabIndex = 5;
            this.lblCap.Text = "Running";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 3;
            // 
            // lblCli
            // 
            this.lblCli.AutoSize = true;
            this.lblCli.Location = new System.Drawing.Point(13, 47);
            this.lblCli.Name = "lblCli";
            this.lblCli.Size = new System.Drawing.Size(51, 12);
            this.lblCli.TabIndex = 1;
            this.lblCli.Text = "Running";
            // 
            // tmrStatus
            // 
            this.tmrStatus.Enabled = true;
            this.tmrStatus.Interval = 500;
            this.tmrStatus.Tick += new System.EventHandler(this.tmrStatus_Tick);
            // 
            // icon
            // 
            this.icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.icon.BalloonTipText = "Minimized to system tray";
            this.icon.BalloonTipTitle = "NC80Cap Killer";
            this.icon.Icon = ((System.Drawing.Icon)(resources.GetObject("icon.Icon")));
            this.icon.Text = "NC80CapKiller";
            this.icon.Visible = true;
            this.icon.DoubleClick += new System.EventHandler(this.icon_DoubleClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 368);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "topMost";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Get VPN Client";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 398);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sunrin Game Utility";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrKiller;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSvc;
        private System.Windows.Forms.Label lblRM;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCli;
        private System.Windows.Forms.Timer tmrStatus;
        private System.Windows.Forms.NotifyIcon icon;
        private System.Windows.Forms.CheckBox chkSvc;
        private System.Windows.Forms.CheckBox chkRMS;
        private System.Windows.Forms.CheckBox chkCap;
        private System.Windows.Forms.CheckBox chkCli;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkMomi;
        private System.Windows.Forms.Label lblMomi;
        private System.Windows.Forms.Button button2;
    }
}

