using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Paint_in_retea
{
    public class figura : pozitie
    {
        protected fPaint form;
        protected Size size;
        protected Rectangle rect;
        protected Pen pen = new Pen(Color.Black, 10);

        public figura(fPaint form)
        {
            this.form = form;
        }
        public void capRotund()
        {
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }

        public void capPatrat()
        {
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Square, System.Drawing.Drawing2D.LineCap.Square, System.Drawing.Drawing2D.DashCap.Flat);
        }

        public void modificare_penWidth(int a)
        {

            pen.Width = a;
        }

        public virtual void modificare_penColor(int r, int g, int b)
        {
            pen.Color = Color.FromArgb(r, g, b);
        }

        public void modificare_penColor(Color culoare)
        {
            pen.Color = culoare;
        }
        public virtual void deseneaza()
        {
            if (form.apasat)
                if (form.brushOnOf)
                {
                    form.g.DrawLine(pen, pcCurent, pcNou);
                    pcCurent = pcNou;
                }
        }

        public void deseneazaSimVer(int latime)
        {
            if(form.symVerOnOf)
            if (form.apasat)
                if (form.brushOnOf)
                {
                  pcCurent.X = latime - pcCurent.X;
                    form.g.DrawLine(pen, pcCurent, pcNou);
                    pcCurent = pcNou;
                }
        }

        public void deseneazaSimOrz(int inaltime)
        {
            if (form.symOrizOnOf)
                if (form.apasat)
                    if (form.brushOnOf)
                    {
                        pcNou.Y = inaltime - pcNou.Y;
                        form.g.DrawLine(pen, pcCurent, pcNou);
                        pcCurent = pcNou;
                    }
        }
    }
}
