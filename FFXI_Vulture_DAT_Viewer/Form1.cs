using System.Diagnostics;
using FFXI;

namespace FFXI_Vulture_DAT_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // OPEN DAT FILE:
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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

                        // Pass the file path to the DAT.Open function as an array
                        string[] args = { selectedFilePath };
                        DAT.Open(args);

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

            // -------------------


            /*try
            {
                // Open Windows Explorer
                Process.Start("explorer.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }*/
        }


        // EXPORT DAT FILE:
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        // QUIT PROGRAM:
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to quit?", "Confirm Quit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        // PICTURE BOX:
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
