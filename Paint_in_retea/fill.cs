using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint_in_retea
{
    class fill : figura
    {
        public fill(fPaint form) : base(form)
        {
        }

        public override void deseneaza()
        {
            if (form.apasat)
            {
                if (form.fillOnOf)
                {
                    form.g.DrawLine(pen, pcCurent, pcNou);
                    pcNou = pcCurent;
                }
            }
        }
    }
}
