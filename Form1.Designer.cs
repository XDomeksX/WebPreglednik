namespace WebPreglednik
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.BTNbrowse = new System.Windows.Forms.Button();
            this.BTNhome = new System.Windows.Forms.Button();
            this.BTNback = new System.Windows.Forms.Button();
            this.BTNforward = new System.Windows.Forms.Button();
            this.TXTbrowse = new System.Windows.Forms.TextBox();
            this.TABcontrol = new System.Windows.Forms.TabControl();
            this.TABPage = new System.Windows.Forms.TabPage();
            this.WEBbrowser = new System.Windows.Forms.WebBrowser();
            this.BTNtab = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TABcontrol.SuspendLayout();
            this.TABPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNbrowse
            // 
            this.BTNbrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNbrowse.Location = new System.Drawing.Point(800, 13);
            this.BTNbrowse.Name = "BTNbrowse";
            this.BTNbrowse.Size = new System.Drawing.Size(75, 23);
            this.BTNbrowse.TabIndex = 0;
            this.BTNbrowse.Text = "Browse";
            this.BTNbrowse.UseVisualStyleBackColor = true;
            this.BTNbrowse.Click += new System.EventHandler(this.BTNbrowse_Click);
            // 
            // BTNhome
            // 
            this.BTNhome.Location = new System.Drawing.Point(13, 13);
            this.BTNhome.Name = "BTNhome";
            this.BTNhome.Size = new System.Drawing.Size(75, 23);
            this.BTNhome.TabIndex = 1;
            this.BTNhome.Text = "Home";
            this.BTNhome.UseVisualStyleBackColor = true;
            this.BTNhome.Click += new System.EventHandler(this.BTNhome_Click);
            // 
            // BTNback
            // 
            this.BTNback.Location = new System.Drawing.Point(94, 13);
            this.BTNback.Name = "BTNback";
            this.BTNback.Size = new System.Drawing.Size(75, 23);
            this.BTNback.TabIndex = 2;
            this.BTNback.Text = "Back";
            this.BTNback.UseVisualStyleBackColor = true;
            this.BTNback.Click += new System.EventHandler(this.BTNback_Click);
            // 
            // BTNforward
            // 
            this.BTNforward.Location = new System.Drawing.Point(175, 13);
            this.BTNforward.Name = "BTNforward";
            this.BTNforward.Size = new System.Drawing.Size(75, 23);
            this.BTNforward.TabIndex = 3;
            this.BTNforward.Text = "Forward";
            this.BTNforward.UseVisualStyleBackColor = true;
            this.BTNforward.Click += new System.EventHandler(this.BTNforward_Click);
            // 
            // TXTbrowse
            // 
            this.TXTbrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTbrowse.Location = new System.Drawing.Point(256, 15);
            this.TXTbrowse.Name = "TXTbrowse";
            this.TXTbrowse.Size = new System.Drawing.Size(538, 20);
            this.TXTbrowse.TabIndex = 4;
            // 
            // TABcontrol
            // 
            this.TABcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABcontrol.Controls.Add(this.TABPage);
            this.TABcontrol.Location = new System.Drawing.Point(13, 42);
            this.TABcontrol.Name = "TABcontrol";
            this.TABcontrol.SelectedIndex = 0;
            this.TABcontrol.Size = new System.Drawing.Size(934, 587);
            this.TABcontrol.TabIndex = 6;
            // 
            // TABPage
            // 
            this.TABPage.Controls.Add(this.WEBbrowser);
            this.TABPage.Location = new System.Drawing.Point(4, 22);
            this.TABPage.Name = "TABPage";
            this.TABPage.Padding = new System.Windows.Forms.Padding(3);
            this.TABPage.Size = new System.Drawing.Size(926, 561);
            this.TABPage.TabIndex = 0;
            this.TABPage.Text = "Tab1";
            this.TABPage.UseVisualStyleBackColor = true;
            // 
            // WEBbrowser
            // 
            this.WEBbrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WEBbrowser.Location = new System.Drawing.Point(3, 3);
            this.WEBbrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WEBbrowser.Name = "WEBbrowser";
            this.WEBbrowser.ScriptErrorsSuppressed = true;
            this.WEBbrowser.Size = new System.Drawing.Size(920, 555);
            this.WEBbrowser.TabIndex = 0;
            // 
            // BTNtab
            // 
            this.BTNtab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNtab.Location = new System.Drawing.Point(881, 13);
            this.BTNtab.Name = "BTNtab";
            this.BTNtab.Size = new System.Drawing.Size(75, 23);
            this.BTNtab.TabIndex = 7;
            this.BTNtab.Text = "New tab";
            this.BTNtab.UseVisualStyleBackColor = true;
            this.BTNtab.Click += new System.EventHandler(this.BTNtab_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 641);
            this.Controls.Add(this.BTNtab);
            this.Controls.Add(this.TABcontrol);
            this.Controls.Add(this.TXTbrowse);
            this.Controls.Add(this.BTNforward);
            this.Controls.Add(this.BTNback);
            this.Controls.Add(this.BTNhome);
            this.Controls.Add(this.BTNbrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TABcontrol.ResumeLayout(false);
            this.TABPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNbrowse;
        private System.Windows.Forms.Button BTNhome;
        private System.Windows.Forms.Button BTNback;
        private System.Windows.Forms.Button BTNforward;
        private System.Windows.Forms.TextBox TXTbrowse;
        private System.Windows.Forms.TabControl TABcontrol;
        private System.Windows.Forms.TabPage TABPage;
        private System.Windows.Forms.WebBrowser WEBbrowser;
        private System.Windows.Forms.Button BTNtab;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

