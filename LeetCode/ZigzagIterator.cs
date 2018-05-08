using System.Collections.Generic;

namespace LeetCode
{
    /**
    * Your ZigzagIterator will be called like this:
    * ZigzagIterator i = new ZigzagIterator(v1, v2);
    * while (i.HasNext()) v[f()] = i.Next();
    */
    public class ZigzagIterator
    {
        IList<int> _v1,_v2;
        int _currentIndex;
        int _maxIndex;

        public ZigzagIterator(IList<int> v1, IList<int> v2)
        {
            _v1 = v1;
            _v2 = v2;
            _currentIndex = -1;
            _maxIndex = (v1.Count > v2.Count ? v1.Count : v2.Count)-1;
        }

        public bool HasNext()
        {
           return _currentIndex < _maxIndex;
        }

        //public int Next()
        //{
             
        //}
    }

    class Consume
    {
        //void Main()
        //{
        //    IList<int> v1 = new List<int> { };
        //    IList<int> v2 = new List<int> { };
        //    IList<int> v = new List<int> { };

        //    ZigzagIterator i = new ZigzagIterator(v1, v2);

        //     while (i.HasNext())
        //        v[f()] = i.Next();
        //}
    }

   

}
