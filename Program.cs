using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Delegate_Demo
{
    class Program
    {
        public delegate void AddDel(int a, int b);
        public delegate int MultiplyDel(int x, int y);


        static void Main(string[] args)
        {
            string conString = @"Server=IISMAETSSTORE; Database=MaetsStore; User Id=tester; Password=admin123;";
            SqlConnection sql = new SqlConnection(conString);
            sql.Open();
            Console.WriteLine("works");
            sql.Close();

            Console.ReadLine();
        }








        //Person peter = new Person("Peter", true);
        //Person rene = new Person("René", false);
        //peter.NameChanged += NameWasChanged;
        //peter.DataSetChanged += Peter_DataSetChanged;
        //peter.firstName += Peter_firstName;
        //Math math = new Math();
        //math.peopleList.Add(peter);
        //math.peopleList.Add(rene);

        //AddDel ad = new AddDel(math.PlusNumbers);
        //MultiplyDel md = new MultiplyDel(math.MultiplyNumbers);
        //ad(40, 30);
        //Console.WriteLine(md(2, 4));

        //math.CheckPerson(PersonName);
        //math.CheckPerson(SayHello);
        private static void Peter_firstName(object sender, string oldValue, string newValue)
        {
            Console.WriteLine("old value " + oldValue);
            Console.WriteLine("new value " + newValue);
        }

        private static void Peter_DataSetChanged(object sender, Dataset e)
        {
            Console.WriteLine("dataset" +  e.FirstName);
            Console.WriteLine("dataset" +  e.LastName);
        }

        static void NameWasChanged(object o, EventArgs e)
        {
            Console.WriteLine("name was changed");
           
        }
        static void EndRobot()
        {
            //kill the robot
        }
        static void PersonName(string personName)
        {
            Console.WriteLine("This is: " + personName);
        }
        static void SayHello(string person)
        {
            Console.WriteLine(person + " says hello!");
        }

    }
}
