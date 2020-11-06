using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament
{
    class Pistikos : IHuman
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            private protected set { _name = value; } // για να δωσω access σε inheritance θα βαλω private protected
        }
        public Pistikos()
        {

        }
        public Pistikos(string Name)
        {
            this.Name = Name;
        }
        //METHODS
        public string Move()
        {
            Random rand = new Random();
            char randomLetter = Convert.ToChar(rand.Next(65, 73));
            string randomNumber = Convert.ToString(rand.Next(1, 9));
            
            return (randomLetter + randomNumber);
        }
        //public void OpenTheDoor(string item, string house, string name)
        //{

        //    Console.WriteLine($"{Name} opened the {item}, got out of the {house}, closed the {item} and held {name} from her hand.");

        //}
    }
}
