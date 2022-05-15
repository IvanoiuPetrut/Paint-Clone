using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint_in_retea
{
    class triunghi : figura
    {
        Point[] pnt = new Point[3];
        public triunghi(fPaint form) : base(form)
        {
        }

        public override void deseneaza()
        {
            if (form.triangleOnOf)
            {
                size = new Size(pcNou.X - pcCurent.X, pcNou.Y - pcCurent.Y);
                rect = new Rectangle(pcCurent, size);

                pnt[0].X = rect.X + (rect.Width / 2);
                pnt[0].Y = rect.Y;

                pnt[1].X = rect.X + rect.Width;
                pnt[1].Y = rect.Y + rect.Height;

                pnt[2].X = rect.X;
                pnt[2].Y = rect.Y + rect.Height;


                form.g.DrawPolygon(pen, pnt);
            }
        }
    }
}
