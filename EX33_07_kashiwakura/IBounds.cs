using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX33
{
    interface IBounds
    {
        public void GetBounds(out float width, out float height);  //囲う長方形の幅と高さ
    }
}
