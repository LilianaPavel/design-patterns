
namespace DesignPatterns.FactoryPattern.SimpleFactory
{
    class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new CheesePizza();
                case "pepperoni":
                    return new PepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
