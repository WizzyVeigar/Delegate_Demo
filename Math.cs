using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Demo
{
    delegate void PersonDel(string str);

    class Math
    {
        public List<Person> peopleList = new List<Person>();

        public void PlusNumbers(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public int MultiplyNumbers(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        private void AAA()
        {
           
        }
        public void CheckPerson(PersonDel processPerson)
        {
            foreach (Person person in peopleList)
            {
                if (person.IsRobot)
                {
                    person.Name += " Robot";
                }
                processPerson(person.Name);
            }
        }

    }
}
