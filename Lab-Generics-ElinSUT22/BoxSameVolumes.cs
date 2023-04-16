using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab_Generics_ElinSUT22
{
    class BoxSameVolumes : EqualityComparer<Box>
    {
        public override bool Equals([AllowNull] Box x, [AllowNull] Box y)
        {
            if(x.height*x.length*x.width == y.height*y.length*y.width)
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
            Console.WriteLine("hashcode: {0}", hcode.GetHashCode());
            return hcode.GetHashCode();
        }
    }
}
