using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz13
{
    public class MarineCreature
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }

        public MarineCreature(string name, string species, int age)
        {
            Name = name;
            Species = species;
            Age = age;
        }
    }

    // Клас Океанаріум
    public class Oceanarium : IEnumerable<MarineCreature>
    {
        private List<MarineCreature> creatures;

        public Oceanarium()
        {
            creatures = new List<MarineCreature>();
        }

        // Додати морську істоту до Океанаріуму
        public void AddCreature(MarineCreature creature)
        {
            creatures.Add(creature);
        }

        // Реалізація ітератора
        public IEnumerator<MarineCreature> GetEnumerator()
        {
            return creatures.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    internal class cs1
    {
        public static void task_1()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Oceanarium oceanarium = new Oceanarium();

            // Додавання морських істот до Океанаріуму
            oceanarium.AddCreature(new MarineCreature("Дельфін", "Delphinus", 10));
            oceanarium.AddCreature(new MarineCreature("Акула", "Carcharodon carcharias", 15));
            oceanarium.AddCreature(new MarineCreature("Кит", "Balaenoptera musculus", 50));

            // Використання foreach для Океанаріуму
            foreach (MarineCreature creature in oceanarium)
            {
                Console.WriteLine($"Назва: {creature.Name}, Вид: {creature.Species}, Вік: {creature.Age} років");
            }
            Console.WriteLine();
        }
    }
}
