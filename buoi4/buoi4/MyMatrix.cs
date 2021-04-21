using System;
using System.Collections;
using System.Text;

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

        void printSumOfRow()
        {
            for(int i = 0; i < m; i++)
            {
            int sum = 0;
                for(int j = 0; j < n; j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine("Tong hang thu {0}", i+" = "+sum);
            }

        }
        void printElementOutLine()
        {
            StringBuilder rs = new StringBuilder();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == m - 1 || j == n - 1)
                    {
                        rs.Append(matrix[i, j]+" ");
                    }
                    else
                    {
                        rs.Append("  ");
                    }
                }
                rs.Append("\n");
            }
            Console.WriteLine(rs);
        }

        int sumOfElementsOutLine()
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == m - 1 || j == n - 1)
                    {
                        sum += matrix[i, j];
                    }
                  
                }
              
            }
            return sum;
        }

        void printAllMinValueInColumns()
        {
           
            for (int i = 0; i < m; i++)
            {
                 int min = matrix[0, i];
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] <= min)
                    {
                        min = matrix[i, j];
                    }
                    Console.WriteLine(j== n-1 ? "Gia tri nho nhat o cot " + i + " la: " + min : "");
                }
            }
        }
        void printAllMaxValueInRows()
        {
           
            for (int i = 0; i < m; i++)
            {
                int max = matrix[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] >= max)
                    {
                        max = matrix[i, j];
                    }
                }
                Console.WriteLine("Gia tri lon nhat o dong " + i + " la: " + max);
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
            Console.WriteLine("\n======Tong cac so tren tung hang======");
            ma.printSumOfRow();
            Console.WriteLine("\n======Cac phan tu ngoai bien=======");
            ma.printElementOutLine();
            Console.WriteLine("\n======Tong cac phan tu ngoai bien=======");
            Console.WriteLine(ma.sumOfElementsOutLine());
            Console.WriteLine("\n======Gia tri nho nhat tren cot cua ma tran=======");
            ma.printAllMinValueInColumns();
            Console.WriteLine("\n======Gia tri lon nhat tren dong cua ma tran=======");
            ma.printAllMaxValueInRows();
        }



    }
}
