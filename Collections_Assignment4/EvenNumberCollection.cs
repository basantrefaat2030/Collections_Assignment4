using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Assignment4
{
    //yield
    internal class EvenNumberCollection : IEnumerable<int>
    {
        List<int> _evenNumCollection;

        public EvenNumberCollection(List<int> evenNumCollection)
        {
            _evenNumCollection = evenNumCollection;
        }

        public IEnumerator<int> GetEnumerator() 
        {
            if (_evenNumCollection.Count != 0)
            {
                foreach (var even in _evenNumCollection)
                {
                    if (even % 2 == 0)
                    {
                        yield return even;
                    }


                }

            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    //custom Ienumerator<int>
    internal class EvenNumberCustomCollection : IEnumerable<int>
    {

        List<int> _evenNumCollection;

        public EvenNumberCustomCollection(List<int> evenNumCollection)
        {
            _evenNumCollection = evenNumCollection;
        }
        public IEnumerator<int> GetEnumerator()
        {
            return new EvenIterator(_evenNumCollection);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

         class EvenIterator : IEnumerator<int>
        {
            List<int> _evenNumCollection;
            int index = -1;
            public EvenIterator(List<int> evenNumCollection)
            {
                this._evenNumCollection = evenNumCollection;
            }
            public int Current => _evenNumCollection[index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                //throw new NotImplementedException();
            }

            public bool MoveNext()
            {

                while (++index < _evenNumCollection.Count())
                {
                    if (_evenNumCollection[index] % 2 == 0)
                    {
                        return true;
                    }
                }
                return false;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
