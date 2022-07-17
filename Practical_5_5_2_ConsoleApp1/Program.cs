using System;

namespace Practical_5_5_2_ConsoleApp1
{
    internal class Program
    {
        static string[] SplitText() // описываем метод разделения на слова
        {
            Console.Write(" Введите предложение : \n");
            string text = Console.ReadLine(); // ввод предложения
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//делим предложение на слова
            return words;//для использования предложения в другом методе возвращаем значение
        }
        static void ReverseWords(string[] words)//описываем метод переворота предложения
        {
            string ReverseText = ""; //объявляем новую строку для перевёрнутого текста
            for (int i = words.Length - 1; i >= 0; i--) //цикл от длины массива до нуля(с конца предложения до начала)
            {
                ReverseText += words[i] + " ";//складываем слова в строку
            }
            Console.WriteLine(ReverseText);//вывод новой строки
        }
        static void Main(string[] args)//главный метод
        {
            ReverseWords(SplitText());//вызываем методы так,чтобы Split подставлялся в Reverse 
        }
    }
}
