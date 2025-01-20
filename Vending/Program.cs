﻿
int balance = 0;
int[] coinsQuantity = { 0, 0, 0, 0 }; //1, 2, 5, 10
int[] coinsValues = { 1, 2, 5, 10 };
PaymentType payment = PaymentType.Card;
string[] names = { "Шоколадка", "Газировка" };
int[] prices = { 70, 60 };
int[] availableQuantity = { 5, 2 };
string command = "";
while (true)
{
    Console.Clear();
    Console.WriteLine($"Баланс {balance}");
    Console.WriteLine("Введите команду:");
    command = Console.ReadLine();
    if (command == "AddMoney")
    {
        switch (payment)
        {
            case PaymentType.Coins:
                for (int i = 0; i <
                coinsValues.Length; i++)
                {
                    Console.WriteLine($"Сколько монет номиналом {coinsValues[i]} вы хотите внести ? ");
                    int count = 0;
                    while
                    (!int.TryParse(Console.ReadLine(),
                    out
                    count))
                    {
                        Console.WriteLine("Вы ввели не число!");
                    }
                    coinsQuantity[i] += count;
                    balance += count *
                    coinsValues[i];
                }
                break;
            case PaymentType.Card:
                Console.WriteLine("Сколько снять с вашей карты ? ");
                int balanceDelta = 0;
                while
                (!int.TryParse(Console.ReadLine(),
                out balanceDelta))
                {
                    Console.WriteLine("Вы ввели не число!");
                }
                balance += balanceDelta;
                Console.WriteLine("Баланс успешно пополнен");
                break;
            default:
                break;
        }

    }
    else if (command == "GetChange")
    {
    }
    else if (command.StartsWith("BuyGood"))
    {
    }
    else
    {
        Console.WriteLine("Команда не определена");
    }
    Console.ReadLine();
}
enum PaymentType
{
    Coins,
    Card
}