using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab_Generics_ElinSUT22
{
    class BoxSameDimensions : EqualityComparer<Box>
    {        

        public override bool Equals([AllowNull] Box x, [AllowNull] Box y)
        {
            if (x.height==y.height && x.length==y.length && x.width == y.width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Box obj)
        {
            var hcode = obj.height ^ obj.length ^ obj.width;
            return hcode.GetHashCode();
        }
    }
}
