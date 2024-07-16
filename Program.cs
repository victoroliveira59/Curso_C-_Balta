﻿using System;
using System.Diagnostics.Contracts;
namespace MeuApp
{
    class Program

    {
        static void Main(string[] args) 
        {
            Product mouse = new Product(1, "Mouse Gamer", 350.00, EProductType.Product);
            var manutencaoEletrica = new Product(2,"Manutenção Predial",300.00, EProductType.Service);
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
        }
    }
    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }  
    }
    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}