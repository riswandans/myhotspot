using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void execute_cmd(string command)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + command;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdExe_Click(object sender, EventArgs e)
        {
            if (cmdExe.Text == "Start")
            {
                cmdExe.Text = "Stop";
                execute_cmd("netsh wlan set hostednetwork mode=allow ssid=" + ssid_name.Text + " key=" + password.Text);
                execute_cmd("netsh wlan start hostednetwork");
            } else
            {
                cmdExe.Text = "Start";
                execute_cmd("netsh wlan stop hostednetwork");
            }
        }
    }
}
