using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NC80CapTerminator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmrKiller.Enabled)
                tmrKiller.Stop();
            if (tmrStatus.Enabled)
                tmrStatus.Stop();
        }

        private void tmrStatus_Tick(object sender, EventArgs e)
        {
            var cli = Process.GetProcessesByName("NC80Cli");
            var cap = Process.GetProcessesByName("NC80Cap");
            var rms = Process.GetProcessesByName("RM_Service");
            var svc = Process.GetProcessesByName("SvcNC80Cli");
            var momi1 = Process.GetProcessesByName("todvvukkd");
            var momi2 = Process.GetProcessesByName("pelegiikc");
            var momi3 = Process.GetProcessesByName("qnaxknbgc");
            if (cli.Length >0)
                lblCli.Text = "Running";
            else
                lblCli.Text = "Stopped";

            if (cap.Length > 0)
                lblCap.Text = "Running";
            else
                lblCap.Text = "Stopped";

            if (rms.Length > 0)
                lblRM.Text = "Running";
            else
                lblRM.Text = "Stopped";

            if (svc.Length > 0)
                lblSvc.Text = "Running";
            else
                lblSvc.Text = "Stopped";


            if (momi1.Length > 0 || momi2.Length > 0 || momi3.Length > 0)
                lblMomi.Text = "Running";
            else
                lblMomi.Text = "Stopped";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                icon.Visible = true;
                icon.ShowBalloonTip(500);
                this.Hide();
                //this.ShowInTaskbar = false;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                icon.Visible = false;
            }
        }

        private void icon_DoubleClick(object sender, EventArgs e)
        {    
            this.Show();

            this.WindowState = FormWindowState.Normal;
           //this.ShowInTaskbar = true;
            icon.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tmrKiller.Enabled)
            {
                tmrKiller.Stop();
                button1.Text = "Start";
            }
            else
            {
                tmrKiller.Start();
                button1.Text = "Stop";
            }
        }

        private void tmrKiller_Tick(object sender, EventArgs e)
        {
            var process = new List<string>();
            if (chkCli.Checked)
                process.Add("NC80Cli");
            if (chkCap.Checked)
                process.Add("NC80Cap");
            if (chkRMS.Checked)
                process.Add("RM_Service");
            if (chkSvc.Checked)
                process.Add("SvcNC80Cli");
            if (chkMomi.Checked)
            {
                process.Add("todvvukkd");
                process.Add("pelegiikc");
                process.Add("qnaxknbgc");
            }
            Kill_Process(process.ToArray());
        }

        private void Kill_Process(string[] ProcessNames)
        {
            foreach(string processName in ProcessNames)
            {
                var process = Process.GetProcessesByName(processName);
                if(process.Length > 0)
                {
                    process[0].Kill();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.TopMost = true;
            else
                this.TopMost = false;
        }

        private void tmrTopmost_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.vpngate.net/en/download.aspx");
        }
    }
}
