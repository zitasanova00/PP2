﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\TipTop-PC\Desktop\programming principles\C#\PP2\Week2"); //инфо папки
            PrintInfo(dir, 0); //функция которая выводит все папки и файлы который содержит уик2 в лестничном порядке
        }

        static void PrintInfo(FileSystemInfo fsi, int k)
        {
            string s = new string(' ', k);   //стринг состаящий из к пробела
            Console.WriteLine(s + fsi.Name);

            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos();
                for (int i = 0; i < arr.Length; ++i)
                {
                    PrintInfo(arr[i], k + 3);  //это метод вызывает сам себя с другими параметрами
                }
            }
        }
    }
}
