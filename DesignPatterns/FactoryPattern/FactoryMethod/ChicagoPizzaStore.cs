
namespace DesignPatterns.FactoryPattern.FactoryMethod
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoCheesePizza();
                case "pepperoni":
                    return new ChicagoPepperoniPizza();
                default:
                    return null;
            }
        }
    }
    
}
