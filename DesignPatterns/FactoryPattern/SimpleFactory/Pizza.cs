﻿
namespace DesignPatterns.FactoryPattern.SimpleFactory
{
    abstract class Pizza
    {

        public abstract void Prepare();

        public abstract void Bake();

        public abstract void Cut();

        public abstract void Box();
    }
}
