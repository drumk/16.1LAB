using System.IO;
using System.Windows.Forms;

namespace _16._1
{
    public partial class Form1 : Form
    {
        string fname; //глобальная переменная
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fname = textBox1.Text;
            StreamWriter write_text; //Класс для записи в файл
            FileInfo file = new FileInfo(fname);
            write_text = file.CreateText(); /*дописываем информацию в файл, если файла не существует он создастся */
            write_text.WriteLine(richTextBox1.Text); /*Записываем в файл текст из текстового поля */
            write_text.Close(); // Закрываем файл
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fname = textBox1.Text;
            //Открываем файл для чтения
            StreamReader streamReader = new StreamReader(fname);
            string str = ""; /*Объявляем переменную, в которую будем записывать текст (строку) из файла */
            while (!streamReader.EndOfStream) /*Цикл длиться пока не будет достигнут конец файла */
            {
            str = str + streamReader.ReadLine(); /*В переменную str построчно записываем содержимое файла */
            }
            richTextBox1.Text = str;
            streamReader.Close(); // Закрываем файл
        }
    }
}