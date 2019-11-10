using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassDesign
{
    class Character
    {
        string name;
        int level;
        string occupation;
        int age;
        string parents;

        public Character(string name, int level, string occupation, int age, string parents)
        {
            this.Name = name;
            this.Level = level;
            this.Occupation = occupation;
            this.Age = age;
            this.Parents = parents;

        }

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public int Age { get => age; set => age = value; }
        public string Parents { get => parents; set => parents = value; }

        public override string ToString()
        {
            return Name + " is a Level " + Level +" "+ Occupation+ ", and is " + Age + " years old, and their parents "+Parents+".";
        }
    }
}

