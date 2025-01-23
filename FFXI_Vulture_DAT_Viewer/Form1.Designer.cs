namespace FFXI_Vulture_DAT_Viewer
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            preferencesToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            splitContainer1 = new SplitContainer();
            txtConsoleOutput = new TextBox();
            btn_go = new Button();
            pictureBox1 = new PictureBox();
            txt_filepath = new TextBox();
            btn_open = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2026, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, exportToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(203, 34);
            openToolStripMenuItem.Text = "Open DAT";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(203, 34);
            exportToolStripMenuItem.Text = "Export DAT";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(203, 34);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preferencesToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Size = new Size(204, 34);
            preferencesToolStripMenuItem.Text = "Preferences";
            preferencesToolStripMenuItem.Click += preferencesToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(78, 29);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Location = new Point(12, 42);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtConsoleOutput);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btn_go);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(txt_filepath);
            splitContainer1.Panel2.Controls.Add(btn_open);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(2002, 914);
            splitContainer1.SplitterDistance = 695;
            splitContainer1.TabIndex = 6;
            // 
            // txtConsoleOutput
            // 
            txtConsoleOutput.BackColor = Color.Black;
            txtConsoleOutput.Dock = DockStyle.Fill;
            txtConsoleOutput.ForeColor = Color.White;
            txtConsoleOutput.Location = new Point(0, 0);
            txtConsoleOutput.Multiline = true;
            txtConsoleOutput.Name = "txtConsoleOutput";
            txtConsoleOutput.ReadOnly = true;
            txtConsoleOutput.ScrollBars = ScrollBars.Both;
            txtConsoleOutput.Size = new Size(691, 910);
            txtConsoleOutput.TabIndex = 3;
            txtConsoleOutput.TextChanged += txtConsoleOutput_TextChanged;
            // 
            // btn_go
            // 
            btn_go.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_go.Location = new Point(1251, 6);
            btn_go.Name = "btn_go";
            btn_go.Size = new Size(45, 34);
            btn_go.TabIndex = 8;
            btn_go.Text = "Go";
            btn_go.UseVisualStyleBackColor = true;
            btn_go.Click += btn_go_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(3, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1293, 864);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txt_filepath
            // 
            txt_filepath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_filepath.Location = new Point(74, 6);
            txt_filepath.Name = "txt_filepath";
            txt_filepath.Size = new Size(1171, 31);
            txt_filepath.TabIndex = 6;
            txt_filepath.Text = "C:\\Program Files (x86)\\PlayOnline\\SquareEnix\\FINAL FANTASY XI\\";
            // 
            // btn_open
            // 
            btn_open.Location = new Point(3, 6);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(65, 34);
            btn_open.TabIndex = 5;
            btn_open.Text = "Open";
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_open_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2026, 968);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "FFXI Vulture DAT Viewer";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private SplitContainer splitContainer1;
        private TextBox txtConsoleOutput;
        private Button btn_go;
        private PictureBox pictureBox1;
        private TextBox txt_filepath;
        private Button btn_open;
    }
}
