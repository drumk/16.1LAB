using System.IO;
using System.Windows.Forms;

namespace _16._1
{
    public partial class Form1 : Form
    {
        string fname; //���������� ����������
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fname = textBox1.Text;
            StreamWriter write_text; //����� ��� ������ � ����
            FileInfo file = new FileInfo(fname);
            write_text = file.CreateText(); /*���������� ���������� � ����, ���� ����� �� ���������� �� ��������� */
            write_text.WriteLine(richTextBox1.Text); /*���������� � ���� ����� �� ���������� ���� */
            write_text.Close(); // ��������� ����
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fname = textBox1.Text;
            //��������� ���� ��� ������
            StreamReader streamReader = new StreamReader(fname);
            string str = ""; /*��������� ����������, � ������� ����� ���������� ����� (������) �� ����� */
            while (!streamReader.EndOfStream) /*���� ������� ���� �� ����� ��������� ����� ����� */
            {
            str = str + streamReader.ReadLine(); /*� ���������� str ��������� ���������� ���������� ����� */
            }
            richTextBox1.Text = str;
            streamReader.Close(); // ��������� ����
        }
    }
}