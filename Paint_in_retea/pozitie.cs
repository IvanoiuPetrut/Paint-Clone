using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint_in_retea
{
    public class pozitie 
    {
        protected Point pcCurent;
        protected Point pcNou;
        
        public void getCurrent(Point pc)
        {
            pcCurent = pc;
        }

        public void getNou(Point pc)
        {
            pcNou = pc;
        }
    }
}
