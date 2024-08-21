// using System.Linq;

using System.Net.Security;

namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();
    public void AddDish(Dish dish)
    {
        this.dishes.Add(dish);
    }
    public void RemoveDish(Dish dish)
    {
        this.dishes.Remove(dish);
    }

    public Dish GetDishByName(string name)
    {
        Dish resultado = null;
        foreach (Dish dish in dishes)
        {
            if (dish.Name == name)
            {
                resultado = dish;
            }
        }

        return resultado;
    }
}   