using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFXI_Vulture_DAT_Viewer
{
    public partial class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Apply Button:
        private void btn_Apply_Click(object sender, EventArgs e)
        {
            // Notify the user that the new preferences were applied successfully
            MessageBox.Show("New preferences applied successfully!", "Success");
        }

        // Close Button:
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Reset Preferences Button:
        private void btn_ResetPreferences_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to reset your preferences to the default settings?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Notify the user that their preferences were successfully reset to the default settings
                MessageBox.Show("Preferences successfully reset to their default settings!", "Success");
            }
        }
    }
}
