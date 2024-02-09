// Импорт пространства имен System, которое содержит базовые классы и структуры языка C#
using System;

// Объявление класса Bank
class Universitet
{
    // Приватные переменные для хранения информации о балансе, последнем внесении и последнем снятии
    private string student1 = "Иван";
    private string student2 = "Мария";
    private string student3 = "Пётр";
    private string student4 = "Валерия";
    private string student5 = "Фёдор";
    private string student4 = "Валерия";
    private string student5 = "Фёдор";

    // Метод для внесения денег на счет
    public void Plus(int name, int number)
    {
        // Проверка, что сумма для внесения больше нуля
        if  (name == 1)
        {
            student1 = student1 + $" {number}";
            Console.WriteLine($"1) {student1}");
            Console.WriteLine($"1) {student1.Remove('И')}");
        }
        else if (name == 2)
        {
            student2 = student2 + $" {number}";
            Console.WriteLine($"2) {student2}");
        }
        else if (name == 3)
        {
            student3 = student3 + $" {number}";
            Console.WriteLine($"3) {student3}");
        }
        else if (name == 4)
        {
            student4 = student4 + $" {number}";
            Console.WriteLine($"4) {student4}");
        }
        else if (name == 5)
        {
            student5 = student5 + $" {number}";
            Console.WriteLine($"5) {student5}");
        }
        else
        {
            Console.WriteLine("Студента с этим номером не существует");
        }


    }
    // Метод для снятия денег со счета
  //  public void Withdraw(double amount)
  //  {
        // Проверка, что сумма для снятия больше нуля и не превышает текущий баланс
   //     if (amount > 0 && amount <= balance)
  //      {
            // Уменьшение баланса на указанную сумму и обновление переменной последнего снятия
 //           balance -= amount;
  //          withdrawal = amount;
            // Вывод сообщения о снятии и текущем балансе
    //        Console.WriteLine($"Снято {amount} со счета. Текущий баланс: {balance}");
   //     }
   //     else
    //    {
            // Вывод сообщения об ошибке, если сумма для снятия меньше или равна нулю, или превышает текущий баланс
      //      Console.WriteLine("Недостаточно средств на счете или сумма для снятия некорректна.");
     //   }
  //  }
    // Метод для вывода информации о счете
    public void Info()
    {
        // Вывод текущего баланса, последнего внесения и последнего снятия
        Console.WriteLine("Текущие оценки:");
        Console.WriteLine($"1) {student1}");
        Console.WriteLine($"2) {student2}");
        Console.WriteLine($"3) {student3}");
        Console.WriteLine($"4) {student4}");
        Console.WriteLine($"5) {student5}");
    }
}
// Объявление класса Program
class Program
{
    // Точка входа в программу
    static void Main()
    {
        // Создание объекта класса Bank
        Universitet myAccount = new Universitet();
        myAccount.Info();
        string y;
        int name, number;
        Console.Write("Если хотите добавить оценку введите 'y', если хотите  убрать оценку введите 'n', если посмотреть информацию 'f' ");
        y = Console.ReadLine();
        // Вызов метода Deposit для внесения 1000 на счет
        Console.Write("Введите номер студента");
        if (y == "f")
        {
            myAccount.Info();
        }
        else if (int.TryParse(Console.ReadLine(), out name))
        {
            Console.Write("Введите оценку студента");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if(y == "y")
                {
                    myAccount.Plus(name, number);
                }
                else if(y == "n")
                {

                }
                else
                {
                    Console.Write("Ошибка при вводе");
                }
            }
            else
            {
                Console.Write("Ошибка при вводе. Введите целое число.");
            }
        }
        else
        {
            Console.Write("Ошибка при вводе. Введите целое число.");

            }
        Console.ReadLine();
    }
}



















//    else
//      {
//          Console.Write("Ошибка при вводе. ВВедите целое число.");
//       }
//       Console.Write("Введие какую сумму хотите снять");
//       if (int.TryParse(Console.ReadLine(), out b))
//       {
// Вызов метода Withdraw для снятия 500 со счета
//         myAccount.Withdraw(b);
//       }


// Вызов метода DisplayAccountInfo для вывода информации о счете
//      myAccount.DisplayAccountInfo();

// Ожидание ввода пользователя перед завершением программы
