using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Demo
{
    class Person
    {
        public delegate void DataValueChanged(object sender, string oldValue, string newValue);

        public event DataValueChanged firstName;

        public event EventHandler<Dataset> DataSetChanged;


        public event EventHandler NameChanged;
        private string name;

        public string Name
        {
            get { return name; }
            set
            {

                if (firstName != null)
                    firstName(this, Name, value);


                name = value;
                if (NameChanged != null)
                    NameChanged(this, new EventArgs());

                Dataset a = new Dataset();
                a.FirstName = "patrick";
                a.LastName = "G";

                if (DataSetChanged != null)
                    DataSetChanged(this, a);
                
            }
        }

        private bool isRobot;

        public bool IsRobot
        {
            get { return isRobot; }
            set { isRobot = value; }
        }

        public Person(string name, bool isRobot)
        {
            Name = name;
            IsRobot = isRobot;
        }
    }

    class Dataset
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
