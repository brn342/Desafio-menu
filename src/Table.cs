namespace Ucu.Poo.Restaurant;
using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private int number;
    public int Number
    {
        get { return number; } set { number = value; }
    }

    private bool isOccupied;
    public bool IsOccupied
    {
        get { return isOccupied;} set { isOccupied = value; }
    }
    private ArrayList order = new ArrayList();

    public Table(int number, bool isOccupied = false)
    {
        this.Number = number;
        this.IsOccupied = isOccupied;
    }

    public void Occupy()
    {
        IsOccupied = true;
    }

    public void Free()
    {
        IsOccupied = false;
        order.Clear();
    }

    public void AddToOrder(Dish dish)
    {
        order.Add(dish);
    }
    
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }
}