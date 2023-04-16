using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Generics_ElinSUT22
{
    public class Box : IEquatable<Box>
    {
        public int height { get; set; }
        public int length { get; set; }
        public int width { get; set; }

        public Box (int h, int l, int w)
        {
            this.height = h;
            this.length = l;
            this.width = w;
        }
        public bool Equals(Box other)
        {
            if(new BoxSameDimensions().Equals(this, other)||new BoxSameVolumes().Equals(this,other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
