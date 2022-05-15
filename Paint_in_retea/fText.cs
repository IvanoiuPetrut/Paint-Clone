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
    public partial class fText : Form
    {
        public deseneazaText text;
        public fText(fPaint f)
        {
            InitializeComponent();
            text = new deseneazaText(f, this);
        }
        private void btApplyDim_Click(object sender, EventArgs e)
        {
            text.getTextFormat(Convert.ToInt32(textDimWidth.Text), Convert.ToInt32(textDimHeight.Text), textInserare.Text);
            text.editareText(comboTextFont.Text, textFontSize.Text);
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
