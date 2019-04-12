using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroNet.Entity
{
    public class User
    {
        int id;
        String name;
        String surname;
        public User()
        {
            id = 1;
            name = "Ivan";
            surname = "Ivanov";
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }
    }
}
