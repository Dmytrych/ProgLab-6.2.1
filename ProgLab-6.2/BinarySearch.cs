using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_6._2
{
    public static class BinarySearcher<T> where T : IComparable
    {
        public static int SharrSearch(T[] array, T key)
        {
            int koef = (int)Math.Log(array.Length, 2),
                currentIndex = (int)Math.Pow(2, koef) - 1,
                delta = 0,
                counter = 1;
            if (array[currentIndex].CompareTo(key) > 0)
            {
                while (array[currentIndex].CompareTo(key) != 0)
                {
                    currentIndex = array[currentIndex].CompareTo(key) > 0 ? currentIndex - delta : currentIndex + delta;
                    delta = (int)Math.Pow(2, koef - counter);
                    if (delta <= 0 && counter != 1)
                        break;
                    counter++;
                }
                if (array[currentIndex].CompareTo(key) == 0)
                    return currentIndex;
                else
                    return -1;
            }
            else
            {
                koef = (int)Math.Log(array.Length - Math.Pow(2, koef) + 1, 2);
                currentIndex = (int)(array.Length - Math.Pow(2, koef) + 1);
                while (array[currentIndex].CompareTo(key) != 0)
                {
                    currentIndex = array[currentIndex].CompareTo(key) > 0 ? currentIndex - delta : currentIndex + delta;
                    delta = (int)Math.Pow(2, koef - counter);
                    counter++;
                    if (delta <= 0)
                        break;
                }
                if (array[currentIndex].CompareTo(key) == 0)
                    return currentIndex;
                else
                    return -1;
            }
        }
    }
}

