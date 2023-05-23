using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nexus_V1
{
    public partial class Form1 : Form
    {

        WeAreDevs_API.ExploitAPI wrdapi = new WeAreDevs_API.ExploitAPI();
        public Form1()
        {
            InitializeComponent();
        }
        Point lastPoint;

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;
        [DllImport("user32.dll")]

        private static extern int ShowWindow(int hwnd, int nCndShow);

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process[] roblox = Process.GetProcesses();

            foreach (Process openedroblox in roblox)

            {

                bool flag = openedroblox.ProcessName == "RobloxPlayerBeta";

                if (flag)

                {

                    openedroblox.Kill();

                }

            }
        }

        private void button1_Click(object sender, EventArgs e, RichTextBox richTextBox)
        {
            wrdapi.SendLuaScript(richTextBox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\Damian\\Desktop\\Nexus V1\\Nexus V1\\bin\\Debug\\bin\\NexusAPI.exe");
            wrdapi.LaunchExploit();
            for (int i = 1; i <= 10; i++)
            {
                int hWnd;
                Process[] processrunning = Process.GetProcesses();
                foreach (Process pr in processrunning)
                {
                    if (pr.ProcessName == "finj")
                    {
                        hWnd = pr.MainWindowHandle.ToInt32();
                        ShowWindow(hWnd, SW_HIDE);
                    }
                }
                int hWndd;
                Process[] processrunningg = Process.GetProcesses();
                foreach (Process prd in processrunningg)
                {
                    if (prd.MainWindowTitle == "WRD-API")
                    {
                        hWndd = prd.MainWindowHandle.ToInt32();
                        ShowWindow(hWndd, SW_HIDE);
                    }

                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fastColoredTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }

    }
