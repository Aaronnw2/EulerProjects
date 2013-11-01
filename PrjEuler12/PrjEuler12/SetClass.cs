using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Set_Class
{
    public class set
    {
        private List<int> elements;
        private int cardinality;

        public set()
        {
            cardinality = 0;
            elements = new List<int>();
        }

        public set(List<int> inputList)
        {
            cardinality = inputList.Count;
            elements = new List<int>();
            foreach (int a in inputList)
            {
                elements.Add(a);
            }
            elements.Sort();
        }

        public set(int[] startArray)
        {
            elements = new List<int>();
            foreach (int a in startArray)
            {
                elements.Add(a);
            }
            elements.Sort();
            cardinality = elements.Count;
        }

        public override bool Equals(object o)
        {
            return false;
        }

        public void Add(int addNumber)
        {
            elements.Add(addNumber);
            elements.Sort();
            cardinality++;
        }

        public void Add(int[] inputArray)
        {
            foreach (int a in inputArray)
            {
                elements.Add(a);
                cardinality++;
            }
            elements.Sort();
        }

        public int Cardinality()
        {
            return cardinality;
        }

        public override string ToString()
        {
            string returnString = "{";
            if (this.cardinality == 0)
            {
                returnString = "{}";
            }
            else
            {
                foreach (int a in elements)
                {
                    returnString = returnString + string.Format("{0}, ", a);
                }
                returnString = returnString.Substring(0, returnString.Length - 2);
                returnString = returnString + "}";
            }
            return returnString;
        }

        public int[] ToArray()
        {
            return elements.ToArray();
        }

        public List<int> ToList()
        {
            return elements;
        }

        public List<set> PowerSet()
        {
            List<set> powerSet = new List<set>();
            for (int i = 0; i < (Convert.ToInt32(Math.Pow(2, this.cardinality))); i++)
            {
                set subset = new set();
                for (int j = 0; j < this.elements.Count; j++)
                {
                    if((i & ( 1 << j)) != 0)
                        subset.Add(this.elements[j]);
                }
                powerSet.Add(subset);
            }
            return powerSet;
        }

        public static set operator +(set set1, set set2)
        {
            foreach (int a in set2.elements)
            {
                set1.Add(a);
            }
            set1.elements.Sort();
            set1.cardinality = set1.cardinality + set2.cardinality;
            return set1;
        }

        public static set operator +(set inputSet, int addNuber)
        {
            inputSet.elements.Add(addNuber);
            inputSet.cardinality++;
            inputSet.elements.Sort();
            return inputSet;
        }

        public static bool operator ==(set input1, set input2)
        {
            int[] array1 = input1.elements.ToArray();
            int[] array2 = input2.elements.ToArray();
            if (input2.cardinality != input1.cardinality)
                return false;
            for (int i = 0; i < input1.cardinality; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }
            return true;
        }

        public static bool operator !=(set input1, set input2)
        {
            int[] array1 = input1.elements.ToArray();
            int[] array2 = input2.elements.ToArray();
            if (input2.cardinality != input1.cardinality)
                return true;
            for (int i = 0; i < input1.cardinality; i++)
            {
                if (array1[i] != array2[i])
                    return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}