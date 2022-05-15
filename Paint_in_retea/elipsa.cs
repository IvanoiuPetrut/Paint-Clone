using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint_in_retea
{
    class elipsa : figura
    {
        public elipsa(fPaint form) : base(form)
        {
        }

        public override void deseneaza()
        {
            if (form.eclipseOnOf)
            {
                size = new Size(pcNou.X - pcCurent.X, pcNou.Y - pcCurent.Y);
                rect = new Rectangle(pcCurent, size);
                form.g.DrawEllipse(pen, rect);
            }
        }
    }
}
