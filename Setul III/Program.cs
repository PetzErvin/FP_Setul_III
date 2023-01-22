using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Setul2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar de la 1 la 32 pentru a alege una din probleme:");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        P1();
                        break;
                    case 2:
                        P2();
                        break;
                    case 3:
                        P3();
                        break;
                    case 4:
                        P4();
                        break;
                    case 5:
                        P5();
                        break;
                    case 6:
                        P6();
                        break;
                    case 7:
                        P7();
                        break;
                    case 8:
                        P8();
                        break;
                    case 9:
                        P9();
                        break;
                    case 10:
                        P10();
                        break;
                    case 11:
                        P11();
                        break;
                    case 12:
                        P12();
                        break;
                    case 13:
                        P13();
                        break;
                    case 14:
                        P14();
                        break;
                    case 15:
                        P15();
                        break;
                    case 16:
                        P16();
                        break;
                    case 17:
                        P17();
                        break;
                    case 18:
                        P18();
                        break;
                    case 19:
                        P19();
                        break;
                    case 20:
                        P20();
                        break;
                    case 21:
                        P21();
                        break;
                    case 22:
                        P22();
                        break;
                    case 23:
                        P23();
                        break;
                    case 24:
                        P24();
                        break;
                    case 25:
                        P25();
                        break;
                    case 26:
                        P26();
                        break;
                    case 27:
                        P27();
                        break;
                    case 28:
                        P28();
                        break;
                    case 29:
                        P29();
                        break;
                    case 30:
                        P30();
                        break;
                    case 31:
                        P31();
                        break;
                  
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). 
        /// </summary>
        private static void P31()
        {
            int FindMajorityElement(int[] v)
            {
                int majorityElement = v[0];
                int count = 1;
                for (int i = 1; i < v.Length; i++)
                {
                    if (v[i] == majorityElement)
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                    if (count == 0)
                    {
                        majorityElement = v[i];
                        count = 1;
                    }
                }
                return majorityElement;
            }

            ///Pentru a determina elementul majoritate al unui vector, apelati functia `FindMajorityElement` cu vectorul:

            int[] v = { 2, 2, 1, 2, 2, 3, 2 };
            int majorityElement = FindMajorityElement(v);
            if (majorityElement != -1)
            {
                Console.WriteLine("Elementul majoritate este " + majorityElement);
            }
            else
            {
                Console.WriteLine("Nu exista element majoritate");
            }
        }
        /// <summary>
        /// Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 
        /// </summary>
        private static void P30()
        {
            void SortByWeight(int[] E, int[] W)
            {
                var zipped = E.Select((e, i) => new { e, w = W[i] }).ToList();
                zipped.Sort((a, b) => a.e == b.e ? b.w - a.w : a.e - b.e);
                for (int i = 0; i < E.Length; i++)
                {
                    E[i] = zipped[i].e;
                    W[i] = zipped[i].w;
                }
            }
            ///În acest cod, cele două array-uri E și W sunt mai întâi "impachetate" împreună folosind metoda Select pentru a crea o listă de obiecte anonime care conțin elementele din E și elementele corespondente din W. Apoi, această listă este sortată folosind metoda Sort, care compara elementele din E și le sortează în ordine crescătoare. Pentru elementele din E care sunt egale, compara greutatea lor corespunzatoare din W și le sortează în ordine descrescătoare. În final, valorile sortate sunt dezlegate înapoi în array-urile E și W.
        }
        /// <summary>
        /// MergeSort. Sortati un vector folosind metoda MergeSort.
        /// </summary>
        private static void P29()
        {
            void MergeSort(int[] v, int left, int right)
            {
                if (left >= right)
                {
                    return;
                }
                int mid = (left + right) / 2;
                MergeSort(v, left, mid);
                MergeSort(v, mid + 1, right);
                Merge(v, left, mid, right);
            }

            void Merge(int[] v, int left, int mid, int right)
            {
                int[] temp = new int[right - left + 1];
                int i = left;
                int j = mid + 1;
                int k = 0;
                while (i <= mid && j <= right)
                {
                    if (v[i] < v[j])
                    {
                        temp[k++] = v[i++];
                    }
                    else
                    {
                        temp[k++] = v[j++];
                    }
                }
                while (i <= mid)
                {
                    temp[k++] = v[i++];
                }
                while (j <= right)
                {
                    temp[k++] = v[j++];
                }
                Array.Copy(temp, 0, v, left, temp.Length);
            }
        }
        /// <summary>
        /// Quicksort. Sortati un vector folosind metoda QuickSort. 
        /// </summary>
        private static void P28()
        {
            void QuickSort(int[] v, int left, int right)
            {
                if (left >= right)
                {
                    return;
                }
                int pivot = v[(left + right) / 2];
                int index = Partition(v, left, right, pivot);
                QuickSort(v, left, index - 1);
                QuickSort(v, index, right);
            }

            int Partition(int[] v, int left, int right, int pivot)
            {
                while (left <= right)
                {
                    while (v[left] < pivot)
                    {
                        left++;
                    }
                    while (v[right] > pivot)
                    {
                        right--;
                    }
                    if (left <= right)
                    {
                        Swap(v, left, right);
                        left++;
                        right--;
                    }
                }
                return left;
            }

            void Swap(int[] v, int i, int j)
            {
                int temp = v[i];
                v[i] = v[j];
                v[j] = temp;
            }
        }
        /// <summary>
        /// Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. 
        /// </summary>
        private static void P27()
        {
            int FindValueAtIndex(int[] v, int index)
            {
                Array.Sort(v);
                return v[index];
            }
        }
        /// <summary>
        /// Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 
        /// </summary>
        private static void P26()
        {
            int[] Add(int[] a, int[] b)
            {
                int n = Math.Max(a.Length, b.Length);
                int[] result = new int[n + 1];
                int carry = 0;
                for (int i = 0; i < n; i++)
                {
                    int x = i < a.Length ? a[i] : 0;
                    int y = i < b.Length ? b[i] : 0;
                    result[i] = (x + y + carry) % 10;
                    carry = (x + y + carry) / 10;
                }
                result[n] = carry;
                return result;
            }

            int[] Subtract(int[] a, int[] b)
            {
                int n = Math.Max(a.Length, b.Length);
                int[] result = new int[n];
                int borrow = 0;
                for (int i = 0; i < n; i++)
                {
                    int x = i < a.Length ? a[i] : 0;
                    int y = i < b.Length ? b[i] : 0;
                    result[i] = (x - y - borrow + 10) % 10;
                    borrow = (x - y - borrow) < 0 ? 1 : 0;
                }
                return result;
            }

            int[] Multiply(int[] a, int[] b)
            {
                int n = a.Length + b.Length;
                int[] result = new int[n];
                for (int i = 0; i < a.Length; i++)
                {
                    int carry = 0;
                    for (int j = 0; j < b.Length; j++)
                    {
                        result[i + j] += a[i] * b[j] + carry;
                        carry = result[i + j] / 10;
                        result[i + j] %= 10;
                    }
                    result[i + b.Length] = carry;
                }
                return result;
            }

        }
        /// <summary>
        /// (Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. 
        /// </summary>
        private static void P25()
        {
            int[] Merge(int[] v1, int[] v2)
            {
                int[] result = new int[v1.Length + v2.Length];
                int i = 0;
                int j = 0;
                int k = 0;
                while (i < v1.Length && j < v2.Length)
                {
                    if (v1[i] < v2[j])
                    {
                        result[k] = v1[i];
                        i++;
                    }
                    else
                    {
                        result[k] = v2[j];
                        j++;
                    }
                    k++;
                }
                while (i < v1.Length)
                {
                    result[k] = v1[i];
                    i++;
                    k++;
                }
                while (j < v2.Length)
                {
                    result[k] = v2[j];
                    j++;
                    k++;
                }
                return result;
            }
        }
        /// <summary>
        /// Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
        /// </summary>
        private static void P24()
        {
            void SortByWeight(int[] E, int[] W)
            {
                var zipped = Enumerable.Range(0, E.Length).Where(i => E[i] == 1).Select(i => new { i, w = W[i] }).ToList();
                zipped.Sort((a, b) => a.w == b.w ? a.i - b.i : b.w - a.w);
                for (int i = 0; i < E.Length; i++)
                {
                    E[i] = zipped.Select(x => x.i).Contains(i) ? 1 : 0;
                    W[i] = zipped.Select(x => x.w).FirstOrDefault();
                }
            }
            ///In aceasta versiune a codului, funcția folosește metoda Enumerable.Range pentru a crea o secvență de numere intregi de la 0 la lungimea lui E. Apoi, filtrează această secvență pentru a include numai indexurile unde E[i] este egal cu 1 folosind metoda Where. Apoi, creează o listă de obiecte anonime care conțin indexurile și elementele corespondente din W. Această listă este apoi sortată folosind metoda Sort, care compara elementele din W și le sortează în ordine descrescătoare. Pentru elementele din W care sunt egale, compara indexurile lor corespunzatoare din E și le sortează în ordine crescătoare. În final, valorile sortate sunt dezlegate înapoi în array-urile E și W.

        }
        /// <summary>
        /// Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. 
        /// </summary>
        private static void P23()
        {
            int[] Intersection(int[] v1, int[] v2)
            {
                Array.Sort(v1);
                Array.Sort(v2);
                List<int> result = new List<int>();
                int i = 0, j = 0;
                while (i < v1.Length && j < v2.Length)
                {
                    if (v1[i] < v2[j])
                    {
                        i++;
                    }
                    else if (v1[i] > v2[j])
                    {
                        j++;
                    }
                    else
                    {
                        result.Add(v1[i]);
                        i++;
                        j++;
                    }
                }
                return result.ToArray();
            }

            int[] Union(int[] v1, int[] v2)
            {
                Array.Sort(v1);
                Array.Sort(v2);
                List<int> result = new List<int>();
                int i = 0, j = 0;
                while (i < v1.Length && j < v2.Length)
                {
                    if (v1[i] < v2[j])
                    {
                        result.Add(v1[i]);
                        i++;
                    }
                    else if (v1[i] > v2[j])
                    {
                        result.Add(v2[j]);
                        j++;
                    }
                    else
                    {
                        result.Add(v1[i]);
                        i++;
                        j++;
                    }
                }
                while (i < v1.Length)
                {
                    result.Add(v1[i]);
                    i++;
                }
                while (j < v2.Length)
                {
                    result.Add(v2[j]);
                    j++;
                }
                return result.ToArray();
            }

            int[] Difference(int[] v1, int[] v2)
            {
                Array.Sort(v1);
                Array.Sort(v2);
                List<int> result = new List<int>();
                int i = 0, j = 0;
                while (i < v1.Length && j < v2.Length)
                {
                    if (v1[i] < v2[j])
                    {
                        result.Add(v1[i]);
                        i++;
                    }
                    else if (v1[i] > v2[j])
                    {
                        j++;
                    }
                    else
                    {
                        i++;
                        j++;
                    }
                }
                while (i < v1.Length)
                {
                    result.Add(v1[i]);
                    i++;
                }
                return result.ToArray();
            }

        }
        /// <summary>
        /// Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. 
        /// </summary>
        private static void P22()
        {
            int[] Intersection(int[] v1, int[] v2)
            {
                List<int> result = new List<int>();
                foreach (int i in v1)
                {
                    if (v2.Contains(i))
                    {
                        result.Add(i);
                    }
                }
                return result.ToArray();
            }

            int[] Union(int[] v1, int[] v2)
            {
                HashSet<int> set = new HashSet<int>(v1);
                foreach (int i in v2)
                {
                    set.Add(i);
                }
                return set.ToArray();
            }

            int[] Difference(int[] v1, int[] v2)
            {
                List<int> result = new List<int>(v1);
                foreach (int i in v2)
                {
                    result.Remove(i);
                }
                return result.ToArray();
            }
        }
        /// <summary>
        /// Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). 
        /// </summary>
        private static void P21()
        {
            int CompareVectors(int[] v1, int[] v2)
            {
                int length = Math.Min(v1.Length, v2.Length);
                for (int i = 0; i < length; i++)
                {
                    if (v1[i] < v2[i])
                    {
                        return -1;
                    }
                    if (v1[i] > v2[i])
                    {
                        return 1;
                    }
                }
                if (v1.Length < v2.Length)
                {
                    return -1;
                }
                if (v1.Length > v2.Length)
                {
                    return 1;
                }
                return 0;
            }
        }
        /// <summary>
        /// Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. 
        /// </summary>
        private static void P20()
        {
            int CountOverlaps(char[] s1, char[] s2)
            {
                int count = 0;
                for (int i = 0; i < s2.Length; i++)
                {
                    bool found = true;
                    for (int j = 0; j < s1.Length; j++)
                    {
                        int k = (i + j) % s1.Length;
                        if (s1[j] != s2[k])
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        /// <summary>
        /// Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 
        /// </summary>
        private static void P19()
        {
            int CountOccurrences(int[] s, int[] p)
            {
                int count = 0;
                for (int i = 0; i <= s.Length - p.Length; i++)
                {
                    bool found = true;
                    for (int j = 0; j < p.Length; j++)
                    {
                        if (s[i + j] != p[j])
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        /// <summary>
        /// Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. 
        /// </summary>
        private static void P18()
        {
            double EvaluatePolynomial(double[] coefficients, double x)
            {
                double result = 0;
                for (int i = coefficients.Length - 1; i >= 0; i--)
                {
                    result = result * x + coefficients[i];
                }
                return result;
            }
        }
        /// <summary>
        /// Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.
        /// </summary>
        private static void P17()
        {
            string ConvertToBase(int n, int b)
            {
                string result = "";
                while (n > 0)
                {
                    int r = n % b;
                    char c;
                    if (r >= 10)
                    {
                        c = (char)('A' + (r - 10));
                    }
                    else
                    {
                        c = (char)('0' + r);
                    }
                    result = c + result;
                    n /= b;
                }
                return result;
            }
        }
        /// <summary>
        /// Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
        /// </summary>
        private static void P16()
        {
            int FindGCD(int[] arr)
            {
                int result = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    result = GCD(result, arr[i]);
                }
                return result;
            }

            int GCD(int a, int b)
            {
                if (a == 0)
                {
                    return b;
                }
                if (b == 0)
                {
                    return a;
                }
                if (a == b)
                {
                    return a;
                }
                if (a > b)
                {
                    return GCD(a - b, b);
                }
                return GCD(a, b - a);
            }
        }
        /// <summary>
        /// Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.
        /// </summary>
        private static void P15()
        {
            int RemoveDuplicates(int[] arr)
            {
                int i = 0;
                int j = 1;
                while (j < arr.Length)
                {
                    if (arr[i] == arr[j])
                    {
                        j++;
                    }
                    else
                    {
                        i++;
                        arr[i] = arr[j];
                        j++;
                    }
                }
                return i + 1;
            }
        }
        /// <summary>
        /// Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). 
        /// </summary>
        private static void P14()
        {
            void MoveZerosToEnd(int[] arr)
            {
                int i = 0;
                int j = arr.Length - 1;
                while (i < j)
                {
                    if (arr[i] == 0)
                    {
                        while (arr[j] == 0 && i < j)
                        {
                            j--;
                        }
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    i++;
                }
            }
        }
        /// <summary>
        /// Sortare prin insertie. Implementati algoritmul de sortare
        /// </summary>
        private static void P13()
        {
            void InsertionSort(int[] arr)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    int key = arr[i];
                    int j = i - 1;
                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                    arr[j + 1] = key;
                }
            }
        }
        /// <summary>
        /// Sortare selectie. Implementati algoritmul de sortare.
        /// </summary>
        private static void P12()
        {
            void SelectionSort(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[minIndex])
                        {
                            minIndex = j;
                        }
                    }
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }
        /// <summary>
        /// Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).
        /// </summary>
        private static void P11()
        {
            void SieveOfEratosthenes(int n)
            {
                // Cream un vector de boolean-uri cu dimensiunea n + 1
                // Initializam toti vectorii cu true
                bool[] prime = new bool[n + 1];
                for (int i = 0; i <= n; i++)
                {
                    prime[i] = true;
                }

                // Setam prime[0] si prime[1] la false, deoarece 0 si 1 nu sunt numere prime
                prime[0] = false;
                prime[1] = false;

                // Aplicam ciurul lui Eratosthenes
                for (int p = 2; p * p <= n; p++)
                {
                    // Daca p este un numar prim, marcam toate numerele
                    // multiple cu p ca fiind non-prime
                    if (prime[p] == true)
                    {
                        for (int i = p * p; i <= n; i += p)
                        {
                            prime[i] = false;
                        }
                    }
                }

                // Afisam toate numerele prime mai mici sau egale cu n
                for (int i = 0; i <= n; i++)
                {
                    if (prime[i] == true)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
        /// <summary>
        /// Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1.
        /// </summary>
        private static void P10()
        {
            int BinarySearch(int[] arr, int k)
            {
                int left = 0;
                int right = arr.Length - 1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (arr[mid] == k)
                    {
                        return mid;
                    }
                    else if (arr[mid] < k)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                return -1;
            }
        }
        /// <summary>
        /// Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.
        /// </summary>
        private static void P9()
        {
            void RotateLeft(int[] arr, int k)
            {
                for (int i = 0; i < k; i++)
                {
                    int temp = arr[0];
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[arr.Length - 1] = temp;
                }
            }
        }
        /// <summary>
        /// Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.
        /// </summary>
        private static void P8()
        {
            void RotateLeft(int[] arr)
            {
                int temp = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[(i + 1) % arr.Length];
                }
                arr[arr.Length - 1] = temp;
            }
        }
        /// <summary>
        /// Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
        /// </summary>
        private static void P7()
        {
            Console.WriteLine("Introduceți numărul de elemente din vector:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceți elementul {0}:", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Inversează ordinea elementelor.
            for (int i = 0; i < n / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[n - i - 1];
                numbers[n - i - 1] = temp;
            }

            // Afișează vectorul rezultat.
            Console.WriteLine("Vectorul rezultat este:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        /// <summary>
        /// Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.
        /// </summary>
        private static void P6()
        {
            Console.WriteLine("Introduceți numărul de elemente din vector:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceți elementul {0}:", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceți poziția elementului pe care doriți să-l ștergeți:");
            int k = int.Parse(Console.ReadLine());

            // Mută toate elementele de pe poziția k și mai la dreapta spre stânga.
            for (int i = k; i < n - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }

            // Afișează vectorul rezultat.
            Console.WriteLine("Vectorul rezultat este:");
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        /// <summary>
        ///  Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.
        /// </summary>
        private static void P5()
        {
            Console.WriteLine("Introduceți numărul de elemente din vector:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceți elementul {0}:", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceți valoarea pe care doriți să o inserați:");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceți poziția pe care doriți să o inserați:");
            int k = int.Parse(Console.ReadLine());

            // Mută toate elementele de pe poziția k în sus cu o poziție.
            for (int i = n; i > k; i--)
            {
                numbers[i] = numbers[i - 1];
            }

            // Inserează elementul pe poziția k.
            numbers[k] = e;

            // Afișează vectorul rezultat.
            Console.WriteLine("Vectorul rezultat este:");
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        /// <summary>
        /// Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.
        /// </summary>
        private static void P4()
        {
            Console.WriteLine("Introduceți numărul de elemente din vector:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceți elementul {0}:", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int min = numbers[0];
            int max = numbers[0];
            int minCount = 0;
            int maxCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minCount = 1;
                }
                else if (numbers[i] == min)
                {
                    minCount++;
                }

                if (numbers[i] > max)
                {
                    max = numbers[i];
                    maxCount = 1;
                }
                else if (numbers[i] == max)
                {
                    maxCount++;
                }
            }

            Console.WriteLine("Cea mai mică valoare este {0} și apare de {1} ori.", min, minCount);
            Console.WriteLine("Cea mai mare valoare este {0} și apare de {1} ori.", max, maxCount);
        }
        /// <summary>
        /// Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii. 
        /// </summary>
        private static void P3()
        {
            Console.WriteLine("Introduceți numărul de elemente din vector:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceți elementul {0}:", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int minIndex = 0;
            int maxIndex = 0;

            // Compară fiecare element cu cel mai mic element cunoscut până în prezent
            // și îl actualizează dacă este necesar.
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] < numbers[minIndex])
                {
                    minIndex = i;
                }
            }

            // Compară fiecare element cu cel mai mare element cunoscut până în prezent
            // și îl actualizează dacă este necesar.
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine("Cel mai mic element este {0} și se află la poziția {1}.", numbers[minIndex], minIndex);
            Console.WriteLine("Cel mai mare element este {0} și se află la poziția {1}.", numbers[maxIndex], maxIndex);
        }
        /// <summary>
        /// Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 
        /// </summary>
        private static void P2()
        {
            Console.WriteLine("Introduceți numărul de elemente din vector:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceți elementul {0}:", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceți valoarea pe care doriți să o căutați:");
            int k = int.Parse(Console.ReadLine());

            int index = -1;
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] == k)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine("Valoarea {0} a fost găsită la poziția {1}.", k, index);
        }
        /// <summary>
        /// Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
        /// </summary>
        private static void P1()
        {
            Console.WriteLine("Introduceți numărul de elemente din vector:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceți elementul {0}:", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("Suma elementelor din vector este {0}.", sum);
        }
    }



}