namespace FFXI_Vulture_DAT_Viewer
{
    partial class ExportForm
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
            btn_ExtractHEXdump = new Button();
            btn_Close = new Button();
            txt_ExportFilepath = new TextBox();
            lbl_ExportFilepath = new Label();
            SuspendLayout();
            // 
            // btn_ExtractHEXdump
            // 
            btn_ExtractHEXdump.Location = new Point(12, 219);
            btn_ExtractHEXdump.Name = "btn_ExtractHEXdump";
            btn_ExtractHEXdump.Size = new Size(165, 34);
            btn_ExtractHEXdump.TabIndex = 0;
            btn_ExtractHEXdump.Text = "Extract HEX Dump";
            btn_ExtractHEXdump.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(676, 404);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(112, 34);
            btn_Close.TabIndex = 1;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // txt_ExportFilepath
            // 
            txt_ExportFilepath.Location = new Point(152, 12);
            txt_ExportFilepath.Name = "txt_ExportFilepath";
            txt_ExportFilepath.Size = new Size(636, 31);
            txt_ExportFilepath.TabIndex = 2;
            // 
            // lbl_ExportFilepath
            // 
            lbl_ExportFilepath.AutoSize = true;
            lbl_ExportFilepath.Location = new Point(12, 15);
            lbl_ExportFilepath.Name = "lbl_ExportFilepath";
            lbl_ExportFilepath.Size = new Size(134, 25);
            lbl_ExportFilepath.TabIndex = 3;
            lbl_ExportFilepath.Text = "Export Filepath:";
            // 
            // ExportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_ExportFilepath);
            Controls.Add(txt_ExportFilepath);
            Controls.Add(btn_Close);
            Controls.Add(btn_ExtractHEXdump);
            Name = "ExportForm";
            Text = "Export";
            Load += ExportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ExtractHEXdump;
        private Button btn_Close;
        private TextBox txt_ExportFilepath;
        private Label lbl_ExportFilepath;
    }
}