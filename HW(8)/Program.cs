using System;
using System.Collections.Generic;

class Program
{
    static ICommand[] commands = new ICommand[]
    {
        new AddProduct(),
        new RemoveProduct(),
        new SendOrder()
    };
    static void Main(string[] args)
    {
        while (true)
        {

            StartMenu(commands);
            if (InputHelper.Input("введите ваше действие: ", 1, commands.Length, out int inputvalue))
            {
                commands[inputvalue - 1].Run();
            }
        }
    }
    static void StartMenu(ICommand[] commands)
    {
        for (int i = 0; i < commands.Length; i++)
        {
            ICommand? item = commands[i];
            Console.WriteLine($"{i + 1}--{item}");
        }
    }
}
}
public class BasketManager
{
    List<Product> products = new List<Product>();
    public static readonly BasketManager basketManager;
    static BasketManager()
    {
        basketManager = new BasketManager();
    }
    private BasketManager()
    {

    }
    public void AddProduct(Product product)
    {
        Console.WriteLine("продукт добавлен");
    }
    public void RemoveProduct()
    {
        Console.WriteLine("продукт удален");
    }
    public void SendOrder()
    {
        Console.WriteLine("продукт заказан");
    }
}
public class AddProduct : ICommand
{
    public void Run()
    {
        Console.WriteLine("продукт добавлен");
    }
}
public class RemoveProduct : ICommand
{
    public void Run()
    {
        Console.WriteLine("продукт удален");
    }
}

public class SendOrder : ICommand
{
    public void Run()
    {
        Console.WriteLine("продукты заказаны");
    }
}






////Задача 1
////Система управления заказами в интернет-магазине: 
////Реализовать систему, которая позволяет пользователям добавлять товары в корзину, 
////удалять их и отправлять заказ. 
////Каждая операция (добавление, удаление, отправка заказа(Cw("Отправил"))) 
////должна быть инкапсулирована в отдельный объект команды.
////Корзина должна быть синглетоном.
////В заказе должно быть:
////Цена, имя товара и вес
////Добавить команду на вывод информации о заказе

//Реализовать интерактивное меню и выбор пунктов