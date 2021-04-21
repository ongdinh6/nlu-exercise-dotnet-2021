using System;
using System.Collections;

namespace buoi4
{
    class MyMatrix
    {
        int m { set; get; }
        int n {set;get; }
        int[,] matrix { set; get; }


        public MyMatrix(int m, int n)
        {
            this.m = m;
            this.n = n;
            this.matrix = new int[m,n];
        }

        void generateMatrix()
        
        {
            int[,] arr = new int[m, n];
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                  arr[i,j] = new Random().Next(10);
                }
            }
            this.matrix = arr;
        }

        void printMatrix()
        {

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        bool isPrimaryNumber(int no)
        {
            for(int i = 1; i < no; i++)
            {
                if(no%i == 0 && i != 1)
                    return false;
            }
            return true;
        }

        //cau1
        ArrayList getArrPrimary()
        {
            
            ArrayList myarr = new ArrayList();

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (isPrimaryNumber(matrix[i,j]))
                    {
                        myarr.Add(matrix[i, j]);
                    }
                }
            }
          
            return myarr;
        }

        void printArrInt(ArrayList arr)
        {
            for(int i =0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + (i!=arr.Count-1?", ":""));
            }
        }

        public static void Main(string[] args)
        {
            MyMatrix ma = new MyMatrix(3, 3);
            Console.WriteLine("Ma tran: ");
            ma.generateMatrix();
            ma.printMatrix();
            Console.WriteLine("Danh sach cac so nguyen to: ");
            ArrayList arrPrimaryNumber =  ma.getArrPrimary();
            ma.printArrInt(arrPrimaryNumber);
        }



    }
}
