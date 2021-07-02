using System;
using System.Text;

namespace Animals
{
    public abstract class Animal  //abstract class -> does not produce instance, not instantiatable, abstract calss can be inherited, abstract method must be implemented in direct
        //children classes, abstarct method does not have a body , is not implemented
    {
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine(this.ProduceSound());

            return sb.ToString().TrimEnd();
        }
    }    
}
