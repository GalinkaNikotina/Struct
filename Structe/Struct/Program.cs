using System;

namespace Struct
{

    // Создадим структуру вне класса Program
    struct student
    {
        public string name;    // поле - имя
        public byte age;       // поле - возраст
        public student(string Name, byte Age)  // конструктор
        {
            this.name = Name;
            age = Age;   // указатель this можно не добавлять
        }
        public void WriteUserInfo()   // метод для вывода
        {
            Console.WriteLine("Имя: {0}, возраст: {1}", name, age);
        }
    }        // конец объявления структуры

    class Program
    {
        static void Main()
        {
            student stud1;    // Без конструктора
            stud1.name = "Петр";
            stud1.age = 18;
            Console.Write("студент1: ");
            stud1.WriteUserInfo();
            student stud2 = new student("Елена", 17);  // с конструктором
            Console.Write("студент2: ");
            stud2.WriteUserInfo();
            // Отличие структур от классов – в передаче по значению
            stud1 = stud2;   // пересылка
            stud2.name = "Наталья";  // изменение полей структуры
            stud2.age = 19;
            Console.Write("\nстудент1: ");
            stud1.WriteUserInfo();
            Console.Write("студент2: ");
            stud2.WriteUserInfo();
            Console.ReadKey();
        }
    }
}
    

