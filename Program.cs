using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CShapImprove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook(new Book("Sach giao khoa", "Nguyen Van Ut", 20, "01", 20));
            library.AddBook(new Book("Sach giao khoa 1", "Nguyen Van Ut", 40, "02", 40));
            library.AddBook(new Book("Sach giao khoa 2", "Nguyen Van Ut", 40, "03", 40));
            library.AddBook(new Book("Sach giao khoa 3", "Nguyen Van Ut", 40, "04", 40));
            library.RemoveBook("03");
            library.search("01");
            Console.WriteLine("List book member borrow!!!");
            library.memberBorrowBook();
            Console.WriteLine("List book affter member borrow!!!");
            library.printListBook();
            Console.ReadKey();
        }

        static int[] changArrayMinMax(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            int indexMin = 0,indexMax = 0;
            for(int i = 0;i< arr.Length; i++)
            {
                if(max < arr[i]) indexMax = i;
                else if(min > arr[i]) indexMin = i;
              
            }
            Swap(ref arr[indexMax], ref arr[indexMin]);
            return arr;
        }


      
        
            
        static int[] sortArray(int[] arr)
        {
            int j = arr.Length,i = 0;
            for(int x = j - 1; x >= 0; x--)
            {
                if (arr[x] % 2 ==0)
                {
                    for(int y = i;y< j;y++)
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

        static void Swap(ref int a,ref int b)
        {
            int temp = a; a = b; b = temp;  
        }

        static int[] swapArray(int[] arr)
        {
            for(int i = 1;i< arr.Length; i++)
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

        static List<int> interchangeSort(List<int> list,int n)
        {
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (list[i] < list[j]) SwapNew(list, i,j);
            return list;

        }

        static void SwapNew(List<int> list,int a,int b)
        {
            int temp = list[a];
            list[a] =list[b]; 
            list[b] = temp;    
        }

        static List<int> inputListArray(List<int> list,int n)
        {
            for(int i = 0; i < n; i++)
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

        static List<int> removeElement( List<int> list)
        {
            int max = list.Max();
            list = list.Where(q => q != max).ToList();
            return list;
        }

       
        static int[] removeItem(int[] arr,int index)
        {
            int[] arrNew = new int[arr.Length - 1];
            Array.Copy(arr, 0, arrNew, 0, index);
            Array.Copy(arr, index + 1, arrNew, index, arr.Length - index - 1);
            return arrNew;
        }

    }
}
