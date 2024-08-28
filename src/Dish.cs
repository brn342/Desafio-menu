namespace Ucu.Poo.Restaurant;
public class Dish
{
    private string name;
    public string Name
    {
        get 
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    private double price;
    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }

    private bool isVegetarian;
    public bool IsVegetarian
    {
        get
        {
            return isVegetarian;
        }
        set
        {
            isVegetarian = value;
        }
    }

    public Dish(string name, double price, bool isVegetarian)
    {
        Name = name;
        Price = price;
        IsVegetarian = isVegetarian;
    }
}