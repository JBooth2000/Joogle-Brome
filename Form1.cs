using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CefTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitBrowser();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
        }

        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("www.google.com");
            this.tabPage1.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
          

        }

        //This is the Create new Tab Button
        private void button4_Click(object sender, EventArgs e)
        {
            //crete new tab
            TabPage tp = new TabPage("Test");
            tabControl1.TabPages.Add(tp);

            TextBox tb = new TextBox();
            tb.Dock = DockStyle.Fill;
            tb.Multiline = true;

            tp.Controls.Add(tb);
            browser.Load("www.google.com");
            //InitBrowser();

        }

        private void Forward_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: ALPHA 1");

        }

        private void devleoperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer: John Booth (Health Informatics Apprentice)");
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Changes of yet...");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For Help with this browser please contact John at John.Booth3@nhs.net");
        }

        private void Navigate_Click(object sender, EventArgs e)
        {
            NavigateToPage();
        }


        private void NavigateToPage()
        {
            browser.Load(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                NavigateToPage();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser.Load("www.google.com");
        }
    }
}

