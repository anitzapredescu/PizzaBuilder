
using PizzaBuilder.Enums;

namespace PizzaBuilder
{
    public interface IBuilder
    {
        void AddDeleteTopping(Topping topping, bool add = true);
        void SetDimension(Dimension dimension);
        void SetDough(DoughType dough);
        void SetPizzaType(PizzaType type);
    }
}