using System.Linq;
using System.Text;
using PizzaBuilder.Enums;

namespace PizzaBuilder
{
    public class Builder : IBuilder
    {
        private readonly Pizza pizza;

        public Builder()
        {
            pizza = new Pizza();
        }

        public Pizza GetPizza()
        {
            return pizza;
        }

        public void AddDeleteTopping(Topping topping, bool add = true)
        {
            if (add)
            {
                if (!pizza.Toppings.Contains(topping))
                    pizza.Toppings.Add(topping);
            }
            else
            {
                if (pizza.Toppings.Contains(topping))
                    pizza.Toppings.Remove(topping);
            }
        }

        public void RemoveTopping(Topping topping)
        {
            pizza.Toppings.Remove(topping);
        }

        public void SetDimension(Dimension dimension)
        {
            pizza.Dimension = dimension;
        }

        public void SetDough(DoughType dough)
        {
            pizza.Dough = dough;
        }

        public void SetPizzaType(PizzaType type)
        {
            pizza.Type = type;
        }
    }
}