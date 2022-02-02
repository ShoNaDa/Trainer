using System;
using System.IO;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trainer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainerPage : ContentPage
    {
        //создание строки - пути к файлу
        readonly string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "words.txt");

        //string
        string line;

        //mass
        string[] wordsEN = new string[10];
        string[] wordsRU = new string[10];
        
        //list
        List<string> RndWordsRU = new List<string>();

        //int
        int i = 0;

        public TrainerPage()
        {
            InitializeComponent();

            if (File.Exists(fileName))
            {
                //заполнили массивы слов
                CreateMassENRU();

                //Выводим на экран 10 англ. слов
                ListViewEN.ItemsSource = wordsEN;
                
                //Рандомим порядок русс. слов
                while (RndWordsRU.Count != 10)
                {
                    var rnd = new Random();
                    string rndString = wordsRU[rnd.Next(0, 10)];

                    if (!RndWordsRU.Contains(rndString))
                    {
                        RndWordsRU.Add(rndString);
                    }
                }

                //Выводим на экран 10 русс. слов
                ListViewEN.ItemsSource = RndWordsRU;
            }
        }

        private void CreateMassENRU()
        {
            //Создаем путь
            StreamReader sr = new StreamReader(fileName);

            //Открываем первую строку файла
            line = sr.ReadLine();

            //Немного рандома
            Random rnd = new Random();

            //Рандом по первой строке
            if (rnd.Next(0, 2) != 0 && i == 0)
            {
                wordsEN[0] = line.Split(' ')[0];
                wordsRU[0] = line.Split(' ')[1];
                i++;
            }

            //Рандом по остальным строкам файла
            while (line != null && i < 10)
            {
                if (rnd.Next(0, 2) != 0)
                {
                    wordsEN[i] = line.Split(' ')[0];
                    wordsRU[i] = line.Split(' ')[1];
                    i++;
                }
            }

            //Если строки кончились, но массивы еще не заполнены, то вызываем функцию снова
            if (i == 9)
            {
                return;
            }
            else
            {
                CreateMassENRU();
            }
        }
    }
}