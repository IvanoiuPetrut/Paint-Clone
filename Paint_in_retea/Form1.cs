using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_in_retea
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        string ip;
        private fPaint newPaintPanel;

        private void btConnect_Click(object sender, EventArgs e)
        {
            ip = textIP.Text;
            if (ip != null)
            {
                newPaintPanel = new fPaint();
                newPaintPanel.Show();
            }
            Visible = false;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
