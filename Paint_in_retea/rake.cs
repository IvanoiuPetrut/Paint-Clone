using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint_in_retea
{
    class rake : figura
    {
        Point pcCurentL2;
        Point pcNouL2;
        Point pcCurentL3;
        Point pcNouL3;
        public rake(fPaint form) : base(form)
        {
        }

        public override void deseneaza()
        {
            if(form.rakeOnOf)
                if(form.apasat)
                {
                    pcCurentL2.X = pcCurent.X + 20;
                    pcCurentL2.Y = pcCurent.Y;

                    pcCurentL3.X = pcCurent.X - 20;
                    pcCurentL3.Y = pcCurent.Y;

                    pcNouL2.X = pcNou.X +20;
                    pcNouL2.Y = pcNou.Y;

                    pcNouL3.X = pcNou.X - 20;
                    pcNouL3.Y = pcNou.Y;

                    form.g.DrawLine(pen, pcCurentL2, pcNouL2);
                    form.g.DrawLine(pen, pcCurentL3, pcNouL3);
                    form.g.DrawLine(pen, pcCurent, pcNou);

                    pcCurent = pcNou;
                }
        }
    }
}
