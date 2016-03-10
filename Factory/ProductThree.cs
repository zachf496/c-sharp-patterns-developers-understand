﻿using System;

namespace Factory
{
    //a generic model that implements IProduct
    public class ProductThree : IProduct
    {
        public void MyMethod()
        {
            Console.WriteLine("Invoking method from product 3!");
        }
    }
}
