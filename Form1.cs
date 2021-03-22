using System;
using System.Windows.Forms;

namespace Polibiya
{
    public partial class Form1 : Form
    {
        string input;
        int one;
        int two;

        public Form1()
        {
            InitializeComponent();
        }

        char[,] alphabet = new char[8, 9]
            {
                {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з'},
                {'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р'},
                {'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ'},
                {'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'А', 'Б', 'В'},
                {'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К'},
                {'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У'},
                {'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь'},
                {'Э', 'Ю', 'Я', ' ', '.', ':', '!', '?', ','},
            };


        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;   //чтение текста
            int countMessage = message.Length;  //подсчет длины строки (символы)
            char[] b = new char[countMessage];  //массив под разделенные символы
            for (int i = 0; i < countMessage; i++)  //заполнение массива символами
            {
                b[i] = message[i];
            }
            input = "";
            for (int a = 0; a < b.Length; a++)  //проверка по количеству введеных символов
            {
                for (int i = 0; i < alphabet.GetLength(0); i++)
                {
                    for (int j = 0; j < alphabet.GetLength(1); j++)
                    {
                        if (b[a] == alphabet[i, j])  //проверка соответствия символов
                        {
                            input += (i + 1) + "" + (j + 1) + " "; //вывод результата
                        }
                        else
                        {
                            checkBox1.Checked = true;
                        }
                    }
                }
                textBox2.Text = input.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message2 = textBox2.Text;
            int countCryptMessage = message2.Length - 1;  //подсчет длины зашифрованной строки
            textBox3.Clear();
            for (int a = 0; a < countCryptMessage; a++)
            {
                one = int.Parse(message2[a].ToString());  //получение чисел для поиска буквы в алфавите
                a++;
                two = int.Parse(message2[a].ToString());
                textBox3.Text += alphabet[one - 1, two - 1].ToString();  //"-" потому что массив начинается с 0, а данные у нас кодируются с 1
                a++;
            }

        }
    }
}
