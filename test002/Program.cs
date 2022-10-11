// Задача 1
// Сделайте генератор паролей длиной введеной пользователем 
// Обязательно использовать : Числа , Символы, спец-символы.

Console.Clear(); // Очищает поле консоли

System.Console.WriteLine("Генератор пароля, введите длину пароля: "); // Обясняет действие

// Start
// Создание переменных для использования в генераторе пароля

int lenght = Convert.ToInt32(Console.ReadLine()); 

string [] password_symbols = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y","/", ".", ",", "<", ">", "*", "&","?", "!", "#"};

string password = "";

Random rnd = new Random();

// End

// Start. Create generatore password

if (lenght >= 0)
{    
    for (int count = 0; count < lenght; count = count + 1)
    {
        password = password + password_symbols[rnd.Next(0,67)];
    }
    System.Console.WriteLine(password);
}
else
{
    System.Console.WriteLine("Число должно быть положительным !");
}
// End