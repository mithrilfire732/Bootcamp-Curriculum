using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Curriculum
{
    class Topic
    {
        public static int NextId { get; set; } = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Difficulty { get; set; } 

        public void Print()
        {
            Console.WriteLine($" ID: {Id}, Name: {Name}, Category: {Category}, Difficulty: {Difficulty}");
        }

        public Topic(string Name, string Category, int Difficulty) 
        {
            this.Id = NextId++;
            this.Name = Name;
            this.Category = Category;
            this.Difficulty = Difficulty;
        }
    }
}
