using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint_in_retea
{
    public class deseneazaText : figura
    {
        
        public fText formText;
        public Font drawFont;
        public SolidBrush drawBrush = new SolidBrush(Color.Black);
        public int inaltime;
        public int latime;
        public string text;

        public deseneazaText(fPaint form, fText formText) : base(form)
        {
            this.formText = formText;
        }


        public void getTextFormat(int latime, int inaltime, string text)
        {
            this.inaltime = inaltime;
            this.latime = latime;
            this.text = text;
        }

        public void editareText(string fontText, string fontSize)
        {
            if (latime != 0 && inaltime != 0)
            {
                formText.textInserare.Width = Convert.ToInt32(latime);
                formText.textInserare.Height = Convert.ToInt32(inaltime);
            }
            drawFont = new Font(fontText, Convert.ToInt32(fontSize));
            formText.textInserare.Font = drawFont;
        }

       public void inserareText() 
        {
            if (form.inserareTextOnOf)
            {
                size = new Size(Convert.ToInt32(latime), Convert.ToInt32(inaltime));
                rect = new Rectangle(pcCurent, size);
                form.g.DrawString(text, drawFont, drawBrush, rect);
            }
        }

        public override void modificare_penColor(int r, int g, int b)
        {
            drawBrush.Color = Color.FromArgb(r, g, b);
        }

    }
}
