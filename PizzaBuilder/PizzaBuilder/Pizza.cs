using System.Collections.Generic;
using System.Linq;
using System.Text;
using PizzaBuilder.Enums;

namespace PizzaBuilder
{
    public class Pizza
    {
        public Pizza()
        {
            Toppings = new List<Topping>();
        }
        public PizzaType Type { get; set; }
        public DoughType Dough { get; set; }
        public Dimension Dimension { get; set; }
        public List<Topping> Toppings { get; set; }

        public override string ToString()
        {
            var details = new StringBuilder("Pizza:").AppendLine();
            if (Dimension != 0)
                details.AppendLine(string.Format("-dimensiune:{0}", Dimension));
            if (Dough != 0)
                details.AppendLine(string.Format("-blat:{0}", Dough));
            if (Type != 0)
                details.AppendLine(string.Format("-tip:{0}", Type));
            if (Toppings.Any())
            {
                details.AppendLine("-toppinguri");
                foreach (var topping in Toppings)
                {
                    details.AppendLine(string.Format("\t{0}",topping));

                }
            }
            return details.ToString();
        }
    }
}