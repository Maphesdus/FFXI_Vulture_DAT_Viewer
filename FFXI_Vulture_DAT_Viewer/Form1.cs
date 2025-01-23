using System.Diagnostics;
using System.Xml.Linq;
using FFXI;


namespace FFXI_Vulture_DAT_Viewer
{
    public partial class Form1 : Form
    {
        string defaultFilepath = "C:\\Program Files (x86)\\PlayOnline\\SquareEnix\\FINAL FANTASY XI\\";

        public Form1()
        {
            InitializeComponent();
        }

        // File -> Open DAT:
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }


        // File -> Export DAT:
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ef = new ExportForm();
            ef.Show();
        }


        // File -> Quit:
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to quit?", "Confirm Quit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Edit -> Preferences:
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pf = new PreferencesForm();
            pf.Show();
        }

        // About:
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }


        // PICTURE BOX:
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_filepath_TextChanged(object sender, EventArgs e)
        {

        }

        // Open Button:
        private void btn_open_Click(object sender, EventArgs e)
        {
            Open();
        }

        // Go Button:
        private void btn_go_Click(object sender, EventArgs e)
        {
            WriteToConsole("This is a test message.");
        }

        // Open File Function:
        private void Open()
        {
            try
            {
                // Show an Open File dialog for the user to select a file
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "DAT files (*.dat)|*.dat|All files (*.*)|*.*";
                    openFileDialog.Title = "Select a DAT File";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Get the selected file path
                        string selectedFilePath = openFileDialog.FileName;
                        txt_filepath.Text = selectedFilePath;

                        // Pass the file path to the DAT.Open function as an array
                        string[] args = { selectedFilePath };
                        //DAT.Open(args);

                        // Notify the user that the file was processed successfully
                        MessageBox.Show("File opened and processed successfully!", "Success");
                    }
                }
            }

            catch (Exception ex)
            {
                // Handle any errors gracefully
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        // Write to Console:
        private void WriteToConsole(string message)
        {
            if (txtConsoleOutput != null)
            {
                txtConsoleOutput.AppendText(message + Environment.NewLine);
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtConsoleOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
