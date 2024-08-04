namespace KonataIzumi
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pictureBox1 = new PictureBox();
            notifyIcon = new NotifyIcon(components);
            contextMenuStrip = new ContextMenuStrip(components);
            closeToolStripMenuItem = new ToolStripMenuItem();
            audioToolStripMenuItem = new ToolStripMenuItem();
            startStopMusic = new ToolStripMenuItem();
            alwaysOnTopToolStripMenuItem = new ToolStripMenuItem();
            alwaysOnTopToggle = new ToolStripMenuItem();
            sizeToolStripMenuItem = new ToolStripMenuItem();
            sizeIncrease = new ToolStripMenuItem();
            sizeDecrease = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += PictureBox_MouseDown;
            pictureBox1.MouseMove += PictureBox_MouseMove;
            pictureBox1.MouseUp += PictureBox_MouseUp;
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipText = "Konata Izumi";
            notifyIcon.BalloonTipTitle = "Minimized";
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Konata Izumi";
            notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { closeToolStripMenuItem, audioToolStripMenuItem, alwaysOnTopToolStripMenuItem, sizeToolStripMenuItem, infoToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(181, 136);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // audioToolStripMenuItem
            // 
            audioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startStopMusic });
            audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            audioToolStripMenuItem.Size = new Size(180, 22);
            audioToolStripMenuItem.Text = "Audio";
            // 
            // startStopMusic
            // 
            startStopMusic.Name = "startStopMusic";
            startStopMusic.Size = new Size(98, 22);
            startStopMusic.Text = "Start";
            startStopMusic.Click += startStopToolStripMenuItem_Click;
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            alwaysOnTopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alwaysOnTopToggle });
            alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            alwaysOnTopToolStripMenuItem.Size = new Size(180, 22);
            alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            // 
            // alwaysOnTopToggle
            // 
            alwaysOnTopToggle.Name = "alwaysOnTopToggle";
            alwaysOnTopToggle.Size = new Size(109, 22);
            alwaysOnTopToggle.Text = "Enable";
            alwaysOnTopToggle.Click += alwaysOnTopToggle_Click;
            // 
            // sizeToolStripMenuItem
            // 
            sizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sizeIncrease, sizeDecrease });
            sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            sizeToolStripMenuItem.Size = new Size(180, 22);
            sizeToolStripMenuItem.Text = "Size";
            // 
            // sizeIncrease
            // 
            sizeIncrease.Name = "sizeIncrease";
            sizeIncrease.ShortcutKeys = Keys.Control | Keys.Oemplus;
            sizeIncrease.ShowShortcutKeys = false;
            sizeIncrease.Size = new Size(114, 22);
            sizeIncrease.Text = "Increase";
            sizeIncrease.Click += sizeIncrease_Click;
            // 
            // sizeDecrease
            // 
            sizeDecrease.Name = "sizeDecrease";
            sizeDecrease.ShortcutKeys = Keys.Control | Keys.OemMinus;
            sizeDecrease.ShowShortcutKeys = false;
            sizeDecrease.Size = new Size(114, 22);
            sizeDecrease.Text = "Decrease";
            sizeDecrease.Click += sizeDecrease_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(180, 22);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 251);
            ControlBox = false;
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Konata Izumi";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem audioToolStripMenuItem;
        private ToolStripMenuItem startStopMusic;
        private ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private ToolStripMenuItem alwaysOnTopToggle;
        private ToolStripMenuItem sizeToolStripMenuItem;
        private ToolStripMenuItem sizeIncrease;
        private ToolStripMenuItem sizeDecrease;
        private ToolStripMenuItem infoToolStripMenuItem;
    }
}
