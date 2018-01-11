using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Prototype
{
    class DrawingTools
    {
        public static SizeF Max(SizeF a, SizeF b)
        {
            return new SizeF(Math.Max(a.Width, b.Width), Math.Max(a.Height, b.Height));
        }
    }
}
