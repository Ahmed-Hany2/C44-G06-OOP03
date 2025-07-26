using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    #region video 3 (inheritance)
    internal class Child : Parent
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
     
        public override int Product()
        {
            return X * Y * Z;
        }
    }
    #endregion
}
