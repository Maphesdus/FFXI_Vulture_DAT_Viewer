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
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
