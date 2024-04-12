using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace CShapImprove
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }


    public class myLinkList{
        private Node head;
        public myLinkList()
        {
            head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
                return;
            }
            Node current = head;
            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void Remove(int data)
        {
            if(head == null)
            {
                return;
            }

            if(head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while(current.Next != null)
            {
                if(current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }

        }

        public void Insert(int data,int position)
        {
            Node newNode = new Node(data);
            if(position == 0)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }
            Node current = head;
            for(int i = 0;i< position - 1 && current != null; i++) {
                current = current.Next;
            
            }
            if(current == null)
            {
                return;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void Display()
        {
            Node current = head;
            while(current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.WriteLine();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            myLinkList list = new myLinkList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            Console.WriteLine("Danh sách ban đầu:");
            list.Display();
            list.Remove(2);
            Console.WriteLine("Danh sách sau khi xóa phần tử 3:");
            list.Display();
            list.Insert(10, 2);
            Console.WriteLine("Danh sách sau khi chèn phần tử 10 vào vị trí 2:");
            list.Display();
            Console.ReadKey();
        }


        static int[] insertionSort(int[] arr)
        {
            //1 ,3,2,4
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int ai = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > ai)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = ai;
            }
            return arr;
        }

        static int[] bubbleSort(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                bool isSorted = true;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        isSorted = false;
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                if (isSorted) break;
            }
            return arr;
        }

        static int[] selectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex]) minIndex = j;
                }
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
            return arr;
        }
        static List<List<int>> getSubArray(int[] arr)
        {
            List<List<int>> subArrays = new List<List<int>>();
            int n = arr.Length;
            int max = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (i > 0 && arr[i] > max) max = arr[i];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    bool isDecrease = true;
                    bool isDuong = true;
                    List<int> subArray = new List<int>();
                    for (int x = i; x <= j; x++)
                    {
                        if (x > 0 && arr[x] > arr[x - 1]) isDecrease = false;
                        if (arr[x] < 0) isDuong = false;
                        subArray.Add(arr[x]);
                    }
                    if (subArray.Count() > 1 && isDecrease == true)
                        subArrays.Add(subArray);

                }
            }

            return subArrays;
        }


        static void ListSubArrays(int[] arr)
        {
            int n = arr.Length;
            for (int start = 0; start < n; start++)
                for (int end = start; end < n; end++)
                {
                    Console.Write("[");
                    for (int i = start; i <= end; i++)
                        Console.Write(arr[i] + ",");
                    Console.WriteLine("]");
                }
        }
        static int[] changArrayMinMax(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            int indexMin = 0, indexMax = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i]) indexMax = i;
                else if (min > arr[i]) indexMin = i;

            }
            Swap(ref arr[indexMax], ref arr[indexMin]);
            return arr;
        }
        static int[] sortArray(int[] arr)
        {
            int j = arr.Length, i = 0;
            for (int x = j - 1; x >= 0; x--)
            {
                if (arr[x] % 2 == 0)
                {
                    for (int y = i; y < j; y++)
                    {
                        if (arr[y] % 2 == 0)
                        {
                            i++; Swap(ref arr[x], ref arr[y]);
                            break;
                        }
                        i++;
                    }

                }
                j--;
            }
            return arr;

        }
        static int inputLengthArray()
        {
            int n = 0;
            do
            {
                Console.Write("Nhap so luong phan tu cua mang:");
                n = int.Parse(Console.ReadLine());
                if (n < 0) Console.WriteLine("So luong phan tu phai lon hon 0!!!");
            } while (n < 0);
            return n;
        }
        static int inputValue()
        {
            int x = 0;
            do
            {
                Console.Write("Nhap gia tri:");
                x = int.Parse(Console.ReadLine());
                if (x < 0) Console.WriteLine("gia tri phai lon hon 0!!!");
            } while (x < 0);
            return x;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a; a = b; b = temp;
        }

        static int[] swapArray(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] == 1)
                {
                    Swap(ref arr[0], ref arr[i]);
                    return arr;
                }

            return arr;
        }

        static int[] inputArray(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu tai vi tri {i}:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        static void displayArray(int[] arr, int n)
        {
            Console.WriteLine("Mang da nhap la:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Mang tai vi tri {i}: {arr[i]}");
            }
        }

        static List<int> interchangeSort(List<int> list, int n)
        {
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (list[i] < list[j]) SwapNew(list, i, j);
            return list;

        }

        static void SwapNew(List<int> list, int a, int b)
        {
            int temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

        static List<int> inputListArray(List<int> list, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu tai vi tri {i}:");
                list.Add(int.Parse(Console.ReadLine()));
            }

            return list;
        }


        static void displayListArray(List<int> list, int n)
        {
            Console.WriteLine("---Mang sau khi sap xep---");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Gia tri phan tu tai vi tri {i}:{list[i]}");
            }
        }

        static List<int> removeElement(List<int> list)
        {
            int max = list.Max();
            list = list.Where(q => q != max).ToList();
            return list;
        }


        static int[] removeItem(int[] arr, int index)
        {
            int[] arrNew = new int[arr.Length - 1];
            Array.Copy(arr, 0, arrNew, 0, index);
            Array.Copy(arr, index + 1, arrNew, index, arr.Length - index - 1);
            return arrNew;
        }

    }
}
