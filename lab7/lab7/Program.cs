using System;
using System.Collections.Generic;

namespace lab7
{
    class Set
    {
        private char[] set;
        private List<char> list = new List<char>();
        private int size;

        public Set(int size)
        {
            this.size = size;
            char[] tmp = new char[size];
            set = tmp;
        }

        public void setSet()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter element index {i}");
                char tmp = char.Parse(Console.ReadLine());
                list.Add(tmp);
                if (check_correct(tmp))
                {
                    set[i] = tmp;
                }
                else
                {
                    i--;
                    Console.WriteLine("A set can't contain duplicate elements. Continue input");
                    continue;
                }
            }
        }

        public void prinSet()
        {
            for (int i = 0; i < set.Length; i++)
            {
                Console.WriteLine(set[i]);
            }
        }

        public bool check_correct(char ch)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == ch)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Set operator -(Set A, Set B)
        {
            List<char> el = new List<char>();
            int tmp = 0; // size C
            for (int i = 0; i < A.size; i++)
            {
                for (int j = 0; j < B.size; j++)
                {
                    if (A.set[i] == B.set[j])
                    {
                        tmp++;
                        el.Add(A.set[i]);
                    }
                }
            }

            Set C = new Set(A.size - tmp);

            int tmp_list = 0;
            int qw = 0;

            for (int i = 0; i < A.size; i++)
            {
                if (el.Count>0 && A.set[i] == el[tmp_list])
                {
                    if (tmp_list < el.Count - 1) tmp_list++;
                    continue;
                }

                else
                {
                    if (qw <= tmp)
                    {
                        C.set[qw] = A.set[i];
                        qw++;
                        continue;
                    }
                }
            }


            return C;

        }

        public static Set operator +(Set A, Set B)
        {

            List<char> el = new List<char>();
            int sizeC = 0; // size C
            for (int i = 0; i < A.size; i++)
            {
                for (int j = 0; j < B.size; j++)
                {
                    if (A.set[i] == B.set[j])
                    {
                        sizeC++;
                        el.Add(A.set[i]);
                    }
                }
            }


            Set C = new Set(A.size + B.size - sizeC);

            for (int i = 0; i < A.size; i++)
            {
                C.set[i] = A.set[i];
            }

            int index = 0;
            int indexC = A.size;
            for(int i = 0; i< B.size; i++)
            {
                if(el.Count > 0 && B.set[i] == el[index] )
                {
                    if(index<el.Count-1)
                    index++;
                    continue;
                }
                else
                {
                    C.set[indexC] = B.set[i];
                    indexC++;
                }
            }

            return C;

        }

        public static Set operator*(Set A, Set B)
        {
            int sizeC = 0; // size C
            for (int i = 0; i < A.size; i++)
            {
                for (int j = 0; j < B.size; j++)
                {
                    if (A.set[i] == B.set[j])
                    {
                        sizeC++;
                    }
                }
            }

            Set C = new Set(sizeC);
            int index = 0;
            for (int i = 0; i < A.size; i++)
            {
                for (int j = 0; j < B.size; j++)
                {
                    if (A.set[i] == B.set[j])
                    {
                        C.set[index] = A.set[i];
                        index++;
                    }
                }
            }

            return C;

        }

        public static bool operator>(Set A, Set B)
        {
            if (A.set.Length > B.set.Length) return true;
            else return false;
        }

        public static bool operator<(Set A, Set B)
        {
            if (A.set.Length < B.set.Length) return true;
            else return false;
        }

        public static bool operator == (Set A, Set B)
        {
            if(A.set.Length == B.set.Length)
            {
                for(int i = 0; i< A.set.Length; i++)
                {
                    if(A.set[i]!=B.set[i])
                    {
                        return false;
                    }
                }
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool operator !=(Set A, Set B)
        {
            if (A.set.Length != B.set.Length)
            {
                return true;
            }

            else
            {
                for (int i = 0; i < A.set.Length; i++)
                {
                    if (A.set[i] != B.set[i])
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of set A");
            Set A = new Set(int.Parse(Console.ReadLine()));
            A.setSet();
            Console.WriteLine("Enter size of set B");
            Set B = new Set(int.Parse(Console.ReadLine()));
            B.setSet();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("A - B");
            (A - B).prinSet();
            Console.WriteLine("A + B");
            (A + B).prinSet();
            Console.WriteLine("A * B");
            (A * B).prinSet();
            Console.WriteLine($"A > B {A > B}");
            Console.WriteLine($"A < B {A < B}");
            Console.WriteLine($"A == B {A == B}");
            Console.WriteLine($"A > B {A != B}");

        }
    }
}
