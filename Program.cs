using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace _071120
{
    class Program
    {
        public static object DialogResult { get; private set; }

        static void Main(string[] args)
        {
            int menuItem = 0;

            do
            {
                Console.WriteLine("1.Загрузить текст:");
                Console.WriteLine("2.Сохранить как текст:");
                Console.WriteLine("3.Сохранить как HTML :");
                Console.WriteLine("4.Выход :");
                Console.WriteLine("Введите число с пунктом меню:");
                menuItem = int.Parse(Console.ReadLine());

                switch (menuItem)
                {
                    case 1:
                        LoadText();
                        break;
                    case 2:
                        SaveFile();
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("Выход из программы.");
                        break;

                }

            }
            while (menuItem != 4);
            Console.ReadKey();
        }
        public static void LoadText()
        {

            string text = String.Empty;

            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        StreamReader reader = new StreamReader(myStream, Encoding.Default);
                        text = reader.ReadToEnd();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }

            Console.WriteLine("Текст загруженный из файла\n " + text);
            Console.WriteLine();
        }
        public static void SaveFile()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if ((myStream = saveFileDialog1.OpenFile()) != null)
            {
                myStream.Close();
            }
        }
    }
}
