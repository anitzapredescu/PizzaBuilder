using System;
using System.Web.UI.WebControls;
using PizzaBuilder.Enums;

namespace PizzaBuilder
{
    public partial class Default : System.Web.UI.Page
    {
        private Builder PizzaBuilder
        {
            get
            {
                return (Builder)Session["Builder"];
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Builder"] = new Builder();


                selectPizzaType.DataSource = Enum.GetValues(typeof(PizzaType));
                selectPizzaType.DataBind();

                selectDimension.DataSource = Enum.GetValues(typeof(Dimension));
                selectDimension.DataBind();

                selectDoughType.DataSource = Enum.GetValues(typeof(DoughType));
                selectDoughType.DataBind();

                selecttoppings.DataSource = Enum.GetValues(typeof(Topping));
                selecttoppings.DataBind();

                textArea.Text = PizzaBuilder.GetPizza().ToString();
            }
        }

        protected virtual void dimensionChanged(Object sender, EventArgs e)
        {
            var selectedIndex = (sender as DropDownList).SelectedIndex;

            PizzaBuilder.SetDimension((Dimension)selectedIndex);

            textArea.Text = PizzaBuilder.GetPizza().ToString();
        }

        protected virtual void doughChanged(Object sender, EventArgs e)
        {
            var selectedIndex = (sender as DropDownList).SelectedIndex;

            PizzaBuilder.SetDough((DoughType)selectedIndex);

            textArea.Text = PizzaBuilder.GetPizza().ToString();
        }

        protected virtual void typeChanged(Object sender, EventArgs e)
        {
            var selectedIndex = (sender as DropDownList).SelectedIndex;

            PizzaBuilder.SetPizzaType((PizzaType)selectedIndex);

            textArea.Text = PizzaBuilder.GetPizza().ToString();
        }

        protected virtual void toppingsChanged(Object sender, EventArgs e)
        {
            var items = (sender as CheckBoxList).Items;

            foreach (var item in items)
            {
                var listItem = item as ListItem;
                if (listItem.Selected)
                {
                    PizzaBuilder.AddDeleteTopping((Topping)Enum.Parse(typeof(Topping), listItem.Value, true));
                }
                else
                {
                    PizzaBuilder.AddDeleteTopping((Topping)Enum.Parse(typeof(Topping), listItem.Value, true), false);
                }
            }
            textArea.Text = PizzaBuilder.GetPizza().ToString();
        }
    }
}