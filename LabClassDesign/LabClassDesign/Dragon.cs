using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassDesign
{
    class Dragon
    {
        String name;
        String elementType;
        int age;
        int powerLevel;

        public Dragon(string name, string elementType, int age, int powerLevel)
        {
            this.Name = name;
            this.ElementType = elementType;
            this.Age = age;
            this.PowerLevel = powerLevel;

        }

       

        public string Name { get => name; set => name = value; }
        public string ElementType { get => elementType; set => elementType = value; }
        public int Age { get => age; set => age = value; }
        public int PowerLevel { get => powerLevel; set => powerLevel = value; }

        public override string ToString()
        {
            return Name +" is a dragon of type "+ ElementType+ ", and is " +Age +" years old.";
        }
    }
}
