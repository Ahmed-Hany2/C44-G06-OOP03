using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    #region video 1 (Indexer)
    internal struct PhoneBook
    {
        private string[] names;
        private long[] numbers;
        private int _size;
        public PhoneBook(int size)
        {
            names = new string[size];
            numbers = new long[size];
            _size = size;
        }

        public int size
        {
            get { return _size; }
        }

        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                }
                return -1; 
            }
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                        return;
                    }
                }
            }
        }
        public void AddPerson(int position, string name, long number)
        {
            if (position >= 0 || position < names.Length)
            {
                names[position] = name;
                numbers[position] = number;
            }
        }

        public long GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return numbers[i];
                }
            }
            return -1;
        }

        public void UpdateNumber(string name, long newNumber)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    numbers[i] = newNumber;
                    return;
                }
            }
        }
        #endregion
    }
}