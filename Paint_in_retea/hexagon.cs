using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Paint_in_retea
{
    class hexagon : figura
    {
        PointF[] pnth = new PointF[6];
        public hexagon(fPaint form) : base(form)
        {
        }

        public override void deseneaza()
        {
            if (form.HexOnOf)
            {
                size = new Size(pcNou.X - pcCurent.X, pcNou.Y - pcCurent.Y);
                rect = new Rectangle(pcCurent, size);

                pnth[0].X = rect.X + (rect.Width / 2);
                pnth[0].Y = rect.Y;

                pnth[1].X = rect.X + rect.Width;
                pnth[1].Y = rect.Y + (float)0.25*rect.Height;

                pnth[2].X = rect.X + rect.Width;
                pnth[2].Y = rect.Y + (float)0.75 * rect.Height;

                pnth[3].X = rect.X + (rect.Width / 2);
                pnth[3].Y = rect.Y + rect.Height;

                pnth[4].X = rect.X;
                pnth[4].Y = rect.Y + (float)0.75 * rect.Height;

                pnth[5].X = rect.X;
                pnth[5].Y = rect.Y + (float)0.25 * rect.Height;

                form.g.DrawPolygon(pen, pnth);
            }
        }
    }
}
