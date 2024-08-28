using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private ArrayList assignedTables = new ArrayList();
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Waiter(string name)
        {
            this.name = name;
        }

        public void AssignTable(Table table)
        {
            if (!assignedTables.Contains(table))
            {
                assignedTables.Add(table);
            }
        }

        public void TakeOrder(Table table, Dish dish)
        {
            if (assignedTables.Contains(table))
            {
                table.AddToOrder(dish);
            }
        }
    }
}