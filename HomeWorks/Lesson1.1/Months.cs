using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson1_1_Months
{
      class Months:IEnumerable,IEnumerator
    {
        private static string[] _months = { "January", "February", "March"    , "April"  ,    "May"  , "June"     ,
                                    "July"   , "August"  , "September","October" , "November", "December"  };
        private static int[] Keys = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
        int _count = -1;
        public object Current => _months[_count] + "_" + Keys[_count];

        public static IEnumerable<string> GetMonthsbyDays(int days)
        {
            for (int i = 0; i < Keys.Length; i++)
                if (days == Keys[i])
                    yield return _months[i];
        }
        public static string GetMonthByNumber(int numberOfMonth)
        {

                    return _months[numberOfMonth-1] + "_" + Keys[numberOfMonth-1];
        }

        public bool MoveNext()
        {
            if (_count == _months.Length-1)
            {
                Reset();
                return false;
            }
            _count++;
            return true;
        }

        public void Reset()
        {
            _count = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}
