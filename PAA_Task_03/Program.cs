using System;

namespace PAA_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWrongPasswords = 0;
            string secretLetter = "Тут ничего нет";
            string password = "8688632";
            string answerOfOwner;
            string request = "Введите пароль: ";
            while(3 != countOfWrongPasswords)
            {
                Console.Write(request);
                answerOfOwner = Console.ReadLine();
                if(answerOfOwner == password)
                {
                    Console.WriteLine(secretLetter);
                    break;
                }
                else
                {
                    countOfWrongPasswords++;
                    request = "Неверный пароль, попробуйте ещё раз: ";
                }
            }
        }
    }
}
