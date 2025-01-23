namespace FFXI_Vulture_DAT_Viewer
{
    partial class PreferencesForm
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
            lbl_DefaultFilepath = new Label();
            lbl_WinSize = new Label();
            txt_filepath = new TextBox();
            lbl_CurrentFilepath = new Label();
            txt_DefaultFilepath = new TextBox();
            comboBox1 = new ComboBox();
            btn_Apply = new Button();
            btn_Close = new Button();
            btn_ResetPreferences = new Button();
            comboBox2 = new ComboBox();
            lbl_Width = new Label();
            lbl_Height = new Label();
            SuspendLayout();
            // 
            // lbl_DefaultFilepath
            // 
            lbl_DefaultFilepath.AutoSize = true;
            lbl_DefaultFilepath.Location = new Point(12, 15);
            lbl_DefaultFilepath.Name = "lbl_DefaultFilepath";
            lbl_DefaultFilepath.Size = new Size(140, 25);
            lbl_DefaultFilepath.TabIndex = 0;
            lbl_DefaultFilepath.Text = "Default Filepath:";
            // 
            // lbl_WinSize
            // 
            lbl_WinSize.AutoSize = true;
            lbl_WinSize.Location = new Point(34, 127);
            lbl_WinSize.Name = "lbl_WinSize";
            lbl_WinSize.Size = new Size(118, 25);
            lbl_WinSize.TabIndex = 1;
            lbl_WinSize.Text = "Window Size:";
            // 
            // txt_filepath
            // 
            txt_filepath.Location = new Point(159, 50);
            txt_filepath.Name = "txt_filepath";
            txt_filepath.Size = new Size(630, 31);
            txt_filepath.TabIndex = 2;
            txt_filepath.Text = "C:\\Program Files (x86)\\PlayOnline\\SquareEnix\\FINAL FANTASY XI\\";
            // 
            // lbl_CurrentFilepath
            // 
            lbl_CurrentFilepath.AutoSize = true;
            lbl_CurrentFilepath.Location = new Point(12, 53);
            lbl_CurrentFilepath.Name = "lbl_CurrentFilepath";
            lbl_CurrentFilepath.Size = new Size(141, 25);
            lbl_CurrentFilepath.TabIndex = 3;
            lbl_CurrentFilepath.Text = "Current Filepath:";
            // 
            // txt_DefaultFilepath
            // 
            txt_DefaultFilepath.Location = new Point(159, 12);
            txt_DefaultFilepath.Name = "txt_DefaultFilepath";
            txt_DefaultFilepath.ReadOnly = true;
            txt_DefaultFilepath.Size = new Size(630, 31);
            txt_DefaultFilepath.TabIndex = 4;
            txt_DefaultFilepath.Text = "C:\\Program Files (x86)\\PlayOnline\\SquareEnix\\FINAL FANTASY XI\\";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "512", "768", "1024", "2048" });
            comboBox1.Location = new Point(159, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btn_Apply
            // 
            btn_Apply.Location = new Point(558, 404);
            btn_Apply.Name = "btn_Apply";
            btn_Apply.Size = new Size(112, 34);
            btn_Apply.TabIndex = 6;
            btn_Apply.Text = "Apply";
            btn_Apply.UseVisualStyleBackColor = true;
            btn_Apply.Click += btn_Apply_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(676, 404);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(112, 34);
            btn_Close.TabIndex = 7;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_ResetPreferences
            // 
            btn_ResetPreferences.Location = new Point(12, 404);
            btn_ResetPreferences.Name = "btn_ResetPreferences";
            btn_ResetPreferences.Size = new Size(241, 34);
            btn_ResetPreferences.TabIndex = 8;
            btn_ResetPreferences.Text = "Reset Preferences to Default";
            btn_ResetPreferences.UseVisualStyleBackColor = true;
            btn_ResetPreferences.Click += btn_ResetPreferences_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "512", "768", "1024", "2048" });
            comboBox2.Location = new Point(347, 124);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 9;
            // 
            // lbl_Width
            // 
            lbl_Width.AutoSize = true;
            lbl_Width.Location = new Point(159, 96);
            lbl_Width.Name = "lbl_Width";
            lbl_Width.Size = new Size(64, 25);
            lbl_Width.TabIndex = 10;
            lbl_Width.Text = "Width:";
            // 
            // lbl_Height
            // 
            lbl_Height.AutoSize = true;
            lbl_Height.Location = new Point(347, 96);
            lbl_Height.Name = "lbl_Height";
            lbl_Height.Size = new Size(69, 25);
            lbl_Height.TabIndex = 11;
            lbl_Height.Text = "Height:";
            // 
            // PreferencesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Height);
            Controls.Add(lbl_Width);
            Controls.Add(comboBox2);
            Controls.Add(btn_ResetPreferences);
            Controls.Add(btn_Close);
            Controls.Add(btn_Apply);
            Controls.Add(comboBox1);
            Controls.Add(txt_DefaultFilepath);
            Controls.Add(lbl_CurrentFilepath);
            Controls.Add(txt_filepath);
            Controls.Add(lbl_WinSize);
            Controls.Add(lbl_DefaultFilepath);
            Name = "PreferencesForm";
            Text = "Preferences";
            Load += PreferencesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_DefaultFilepath;
        private Label lbl_WinSize;
        private TextBox txt_filepath;
        private Label lbl_CurrentFilepath;
        private TextBox txt_DefaultFilepath;
        private ComboBox comboBox1;
        private Button btn_Apply;
        private Button btn_Close;
        private Button btn_ResetPreferences;
        private ComboBox comboBox2;
        private Label lbl_Width;
        private Label lbl_Height;
    }
}