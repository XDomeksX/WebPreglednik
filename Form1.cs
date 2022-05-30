using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPreglednik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNbrowse_Click(object sender, EventArgs e)
        {
            WebBrowser web = TABcontrol.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
                web.Navigate(TXTbrowse.Text);
        }

        private void WEBbrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            TXTbrowse.Text = WEBbrowser.Url.ToString();
        }

        private void BTNhome_Click(object sender, EventArgs e)
        {
            WebBrowser web = TABcontrol.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                WEBbrowser.Navigate("https://www.google.com");
            }
        }

        private void BTNback_Click(object sender, EventArgs e)
        {
            WebBrowser web = TABcontrol.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                    web.GoBack();
            }
        }

        private void BTNforward_Click(object sender, EventArgs e)
        {
            WebBrowser web = TABcontrol.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                    web.GoForward();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WEBbrowser.Navigate("https://www.google.com");
            WEBbrowser.DocumentCompleted += WEBbrowser_DocumentCompleted;
        }

        private void WEBbrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            TABcontrol.SelectedTab.Text = WEBbrowser.DocumentTitle;
        }

        WebBrowser webTab = null;
        private void BTNtab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New tab";
            TABcontrol.Controls.Add(tab);
            TABcontrol.SelectTab(TABcontrol.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("https://www.google.com");
            TXTbrowse.Text = "https://www.google.com";
            webTab.DocumentCompleted += WebTab_DocumentCompleted;
        }

        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            TABcontrol.SelectedTab.Text = webTab.DocumentTitle;
        }

        private void TXTbrowse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                WebBrowser web = TABcontrol.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate(TXTbrowse.Text);
            }
            }
        }
    }
}
