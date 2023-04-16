using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Generics_ElinSUT22
{
    class BoxEnumerator : IEnumerator<Box>
    {
        private BoxCollection _boxes;

        private Box _currBox;

        public BoxEnumerator(BoxCollection boxes)
        {
            _boxes = boxes;

            _currBox = default(Box);
        }
        int currIndex = -1;

        public Box Current  { get { return _currBox; } }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if(++currIndex >= _boxes.Count)
            {
                return false;
            }
            else
            {
                _currBox = _boxes[currIndex];
            }
            return true;
        }

        public void Reset()
        {
            currIndex = -1;
        }
    }
}
