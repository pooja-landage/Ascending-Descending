using System;

namespace Pratice16task
{
    public struct student
    {
        public string Name;
        public string Course;
        public int StudentId;
        public int RegistrationId;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("==================================================Student Detail=======================================================");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------- \n");
            {
                student st1;
                st1.Name = "Pooja";
                st1.Course = "Cse";
                st1.StudentId = 11;
                st1.RegistrationId = 12414;
                Console.WriteLine("Name : {0} , Course : {1} , StudentId : {2} , RegistrationId : {3} \n", st1.Name, st1.Course, st1.StudentId, st1.RegistrationId);
            }

            // Ascending Order

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            int[] arr = new int[10];
            int n, i, j, temp;

            Console.WriteLine("==================================================Ascending Order======================================================");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Enter the size of array {0}");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the {0} of array", +n);
            for(i = 0; i < n; i++)
            {
                Console.Write("Number - {0} = " , i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(i = 0; i < n; i++)
            {
                for(j = i+1; j < n; j++ )
                {
                    if (arr[j] < arr[i])
                        {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;


                        }
                }
            }

            Console.WriteLine("Elements of array in ascending order");
            for(i=0; i<n; i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }

            // Descending Order 

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("==================================================dscending Order=======================================================");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------- \n");

            int[] arr1 = new int[10];
            int l, p, q;

            Console.WriteLine("Enter the size of array {0}");
            l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the {0} of array", +l);
            for (p = 0; p < l; p++)
            {
                Console.Write("Number - {0} = ", p);
                arr[p] = Convert.ToInt32(Console.ReadLine());
            }

            for (p = 0; p < l; p++)
            {
                for (q = p + 1; q < l; q++)
                {
                    if (arr[p] < arr[q])
                    {
                        temp = arr[p];
                        arr[p] = arr[q];
                        arr[p] = temp;


                    }
                }
            }

            Console.WriteLine("Elements of array in dscending order");
            for (p = 0; p < l; p++)
            {
                Console.WriteLine("{0}", arr[p]);
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("=================================================Reverse the String ====================================================");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------- \n");

            int[] arr2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Reverse(arr2);
            Console.WriteLine(String.Join(',', arr2));

        }
    }
}
