﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person() 
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age)
            :this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
            :this()
        {
            this.Name = name;
            this.Age = age;
        }

    }
}
