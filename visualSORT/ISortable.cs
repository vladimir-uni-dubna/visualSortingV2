using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualSORT
{
    internal interface ISortable : IComparable
    {
        Color GetColor(ISortable min, ISortable max);
    }
}
