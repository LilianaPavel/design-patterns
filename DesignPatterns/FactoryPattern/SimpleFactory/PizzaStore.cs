
namespace DesignPatterns.FactoryPattern.SimpleFactory
{
    class PizzaStore
    {
        SimplePizzaFactory factory;
        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = factory.CreatePizza(type);
            if (pizza != null)
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
            }
            return pizza;
        }
    }
}
