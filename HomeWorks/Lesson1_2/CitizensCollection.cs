using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_2
{
    class CitizensCollection : IEnumerable
    {
        /*-------------fields--------------*/
        private Citizen[] _citizens;
        int _capacity, _count = 0, _pensionersIndex = -1, _pensionersCount = 0;
        /*------------Properties-----------*/
        public int PensionersCount => _pensionersCount;
        public int Capacity => _capacity;
        public int Count => _count;
        /*----------------Index--------------*/
        public string this[int index] => _citizens[index].FullName;
        /*------------Constructors-----------*/
        public CitizensCollection()
        {
            _citizens = new Citizen[4];
            _capacity = 4;
        }
        public CitizensCollection(int capacity)
        {

            _capacity = capacity;
            _citizens = new Citizen[_capacity];
        }
        /*----------------Methods-----------*/
        public int Add(Citizen citizen)
        {
            if (Contains(citizen) == true)
            {
                Console.WriteLine("There is already a citizen with the same passport");
                return _pensionersCount;
            }
            if (_count < _capacity - 1)
            {
                if (citizen is Pensioner == false)
                {
                    _citizens[_count] = citizen;
                }
                else
                {
                    Citizen[] temp = new Citizen[_capacity];
                    Array.Copy(_citizens, 0, temp, 0, _pensionersIndex + 1);
                    Array.Copy(_citizens, _pensionersIndex + 1, temp, _pensionersIndex + 2, _capacity - (_pensionersIndex + 2));
                    temp[_pensionersIndex + 1] = citizen;
                    _citizens = temp;
                    _pensionersIndex++;
                    _pensionersCount++;
                }
            }
            else
            {
                Citizen[] temp = new Citizen[_capacity * 2];
                if (citizen is Pensioner == false)
                {
                    Array.Copy(_citizens, temp, _count);
                    temp[_count] = citizen;
                    _citizens = temp;
                }
                else
                {
                    Array.Copy(_citizens, 0, temp, 0, _pensionersIndex + 1);
                    Array.Copy(_citizens, _pensionersIndex + 1, temp, _pensionersIndex + 2, _capacity - (_pensionersIndex + 2));
                    temp[_pensionersIndex + 1] = citizen;
                    _citizens = temp;
                    _pensionersIndex++;
                    _pensionersCount++;
                }
                _capacity *= 2;

            }
            _count++;
            return _pensionersCount;
        }
        public bool Contains(Citizen citizen)
        {
            foreach (var member in _citizens) if (citizen.Equals(member)) return true;
            return false;
        }
        public void Remove(Citizen citizen = null)
        {
            if (citizen != null) { citizen = _citizens[0]; }
            for (int i = 0; i < _count; i++)
            {
                if (citizen == _citizens[i])
                {
                    var temp = new Citizen[_capacity];
                    Array.Copy(_citizens, 0, temp, 0, i - 1);
                    Array.Copy(_citizens, i + 1, temp, i, _capacity - (i - 2));
                    _citizens = temp;
                    _count--;
                }
            }
        }
        /// <summary>
        /// Returns last item in collection
        /// </summary>
        /// <returns></returns>
        public Citizen ReturnLast() => _citizens[_count];
        /// <summary>
        /// Clears all collection
        /// </summary>
        public void Clear() => Array.Clear(_citizens, 0, _count);
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _citizens[i];
            }
        }
    }
}

