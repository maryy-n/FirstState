using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Создать метод, принимающий введенную пользователем
            //строку, и выводящий на экран статистику по этой строке.
            //Статистика должна включать общее кол - во символов,
            //кол - во пробелом, кол - во цифр, кол - во символов
            //пунктуации, кол-во букв.
            //Console.Write("Enter string -> ");
            //string str = Console.ReadLine();
            //Console.WriteLine("Characters number -> " + str.Length);
            //int count = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == ' ')
            //        count++;
            //}
            //Console.WriteLine("Spaces number -> " + count);
            //count = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] >= 48 && str[i] <= 57)
            //        count++;
            //}
            //Console.WriteLine("Digits number -> " + count);
            //count = 0;
            //string key = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = 0; j < key.Length; j++)
            //    {
            //        if (str[i] == key[j])
            //        {
            //            count++;
            //            continue;
            //        }
            //    }
            //}
            //Console.WriteLine("Punctuation characters number -> " + count);
            //count = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] >= 65 && str[i] <= 90 || str[i] >= 97 && str[i] <= 122)
            //        count++;
            //}
            //Console.WriteLine("Letters number -> " + count);

            //2.Пользователь вводит строку и символ. В строке найти все
            //вхождения этого символа и перевести его в верхний регистр,
            //а также удалить часть строки, начиная с последнего вхождения
            //этого символа и до конца.
            //Console.Write("Enter string -> ");
            //string str = Console.ReadLine();
            //Console.Write("Enter character -> ");
            //char ch = char.Parse(Console.ReadLine());
            //string _ch = ch.ToString();
            //StringBuilder sb = new StringBuilder(str);
            //sb.Replace(_ch, _ch.ToUpper());
            //str = sb.ToString();
            //Console.WriteLine("New_1 string -> " + str);
            //sb = new StringBuilder(str);
            //sb.Remove(str.LastIndexOf(_ch.ToUpper()), str.Length - str.LastIndexOf(_ch.ToUpper()));
            //str = sb.ToString();
            //Console.WriteLine("New_2 string -> " + str);

            //3. Удалить из строки повторяющиеся слова.
            //string str = "one one three two one two one two two three three one four one one four four three";
            //Console.Write("Old string -> " + str);
            //Console.WriteLine();
            //var strArr = str.Split();
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    for (int j = i + 1; j < strArr.Length; j++)
            //    {
            //        if (strArr[i] == strArr[j])
            //        {
            //            string[] tmp = new string[strArr.Length - 1];
            //            for (int k = 0; k < strArr.Length; k++)
            //            {
            //                if (k < j)
            //                    tmp[k] = strArr[k];
            //                else if (k == j)
            //                    continue;
            //                else if (k > j)
            //                    tmp[k - 1] = strArr[k];
            //            }
            //            strArr = tmp;
            //            --j;
            //        }
            //    }
            //}
            //str = string.Join(" ", strArr);
            //Console.Write("New string -> " + str);
            //Console.WriteLine();

            //4. Преобразовать все слова по правилу: удалить из слова все
            //последующие вхождения первого символа.
            //string str = "onooeoo ttwtott thttttrtetttet ffffoufffrfff ананас";
            //Console.Write("Old string -> " + str);
            //Console.WriteLine();
            //var strArr = str.Split();
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    StringBuilder sb = new StringBuilder(strArr[i]);
            //    for (int j = 0; j < sb.Length; j++)
            //    {
            //        if (sb[j] == sb[0] && j != 0)
            //        {
            //            sb.Remove(j, 1);
            //            --j;
            //        }
            //    }
            //    strArr[i] = sb.ToString();
            //}
            //str = string.Join(" ", strArr);
            //Console.Write("New string -> " + str);
            //Console.WriteLine();

            //5.Преобразовать все слова по правилу: удалить в слове только
            //последние вхождения каждого символа.
            //string str = "onnoee onnoee ttwwoo thtreeehr fourfour ttt000ryry ананас";
            //Console.Write("Old string -> " + str);
            //Console.WriteLine();
            //var strArr = str.Split();
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    StringBuilder sb = new StringBuilder(strArr[i]);
            //    string tmp = null;
            //    for (int j = 0; j < sb.Length; j++)
            //    {
            //        if (j == 0)
            //            tmp = string.Concat(tmp, sb[j]);
            //        if (j == 0 && j != sb.ToString().LastIndexOf(sb[j]) && tmp.Contains(sb[j]))
            //        {
            //            sb.Remove(sb.ToString().LastIndexOf(sb[j]), 1);
            //        }
            //        else if (j != sb.ToString().LastIndexOf(sb[j]) && !tmp.Contains(sb[j]))
            //        {
            //            tmp = string.Concat(tmp, sb[j]);
            //            sb.Remove(sb.ToString().LastIndexOf(sb[j]), 1);
            //        }
            //    }
            //    strArr[i] = sb.ToString();
            //}
            //str = string.Join(" ", strArr);
            //Console.Write("New string -> " + str);
            //Console.WriteLine();


        }
    }
}
