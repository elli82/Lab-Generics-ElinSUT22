using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab_Generics_ElinSUT22
{
    class BoxCollection : ICollection<Box>
    {
        private List<Box> innerCol;

        public BoxCollection() { innerCol = new List<Box>(); }

        public Box this[int index]
        {
            get { return (Box)innerCol[index]; }
            set { innerCol[index] = value; }
        }

        public int Count
        {
            get { return innerCol.Count; }
        }

        public bool IsReadOnly { get { return false; } }

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                innerCol.Add(item);                
            }
            else
            {
                Console.WriteLine("A box with the dimensions {0}x{1}x{2} already exists," +
                    " or has the same volume as an another box."
                    ,item.height.ToString(), item.length.ToString(), item.width.ToString());
            }
        }

        public void Clear()
        {
            innerCol.Clear();
        }

        public bool Contains(Box item)
        {
            foreach(Box b in innerCol)
            {
                if (b.Equals(item))
                {                    
                    return true;                    
                }
            }
            return false;
        }
        public bool Contains(Box item, EqualityComparer<Box> comparer)
        {
            foreach(Box b in innerCol)
            {
                if(comparer.Equals(b, item))
                {
                    Console.WriteLine("A box with these dimensions already exists.");
                    return true;                    
                }
            }
            return false;
        }
        public bool CheckifContainsBox(Box item)
        {
            foreach (Box b in innerCol)
            {
                if (new BoxSameDimensions().Equals(b, item))
                {
                    Console.WriteLine("A box with these dimensions already exists.");
                    return true;
                }
                else if (new BoxSameVolumes().Equals(b, item))
                {
                    Console.WriteLine("A box with the same volume already exists.");
                    return true;
                }
            }
            return false;
        }


        public void CopyTo(Box[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The array can not be null");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The starting array index can not be negative");
            }
            if (Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The final array has fewer elements than the collection");
            }

            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool result = false;
            for (int i = 0; i < innerCol.Count; i++)
            {
               Box box= innerCol[i];
                if (new BoxSameDimensions().Equals(box, item ))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    Console.WriteLine("Box ({0}x{1}x{2}) was removed.", box.height, box.length, box.width);
                    break;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
