using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint_in_retea
{
    class eraser : figura
    {
        public eraser(fPaint form) : base(form)
        {
        }
            
        public override void deseneaza()
        {
            if(form.apasat)
                if(form.eraserOnOf)
                {
                   // pen.Color = culoare_fundal;
                    form.g.DrawLine(pen, pcCurent, pcNou);
                    pcCurent = pcNou;
                }
        }
    }
}
