using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz13
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }
    }

    // Клас Кафе
    public class Cafe : IEnumerable<Employee>
    {
        private List<Employee> employees;

        public Cafe()
        {
            employees = new List<Employee>();
        }

        // Додати працівника до кафе
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        // Реалізація ітератора
        public IEnumerator<Employee> GetEnumerator()
        {
            return employees.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    internal class cs3
    {
        public static void task_3()
        {
            Cafe cafe = new Cafe();

            // Додавання працівників до кафе
            cafe.AddEmployee(new Employee("Іван", "Офіціант"));
            cafe.AddEmployee(new Employee("Марія", "Кухар"));
            cafe.AddEmployee(new Employee("Петро", "Бариста"));

            // Використання foreach для Кафе
            foreach (Employee employee in cafe)
            {
                Console.WriteLine($"Працівник: {employee.Name}, Посада: {employee.Position}");
            }
        }
    }
}
