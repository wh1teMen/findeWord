using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw
{

    public partial class Form1 : Form
    {
        List<string> listSlov = new List<string>();
        List<Resultat> resultSlov = new List<Resultat>();
        static public AutoResetEvent _waitHandle = new AutoResetEvent(true);
        string mydocu = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
            size();
        }

        private void button_addSlovo_MouseClick(object sender, MouseEventArgs e)
        {
            listSlov.Add(textBox_slovo.Text);
            textBox_slovo.Clear();
            textBox_out.Clear();
            listSlov.ForEach(x=>textBox_out.Text += x+"\r\n");                       
        }    

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            listSlov.ForEach(x => Record("Slova.txt", x));
            for (int i = 1; i <= 4; i++)
            {                
                Thread tr = new Thread(() => { finde("VM"+i.ToString());});
                tr.Name = i.ToString()+" Поток";
                tr.Start();
                Record(mydocu + @"\output.txt", $"{(DateTime.Now.ToString("HH:mm:ss.ffff"))}\t{tr.Name} Запущен");
                Record(mydocu + @"\output.txt", $"{(DateTime.Now.ToString("HH:mm:ss.ffff"))}\t{tr.Name} Закончен");
                Thread.Sleep(100);
            }
            MessageBox.Show("Поиск завершен!");

        }
       
        private void finde(string fileName)
        {
            _waitHandle.WaitOne();
                foreach (var pattern in listSlov)
                {
                    StreamReader reader = new StreamReader(fileName + ".txt");
                    string text = reader.ReadToEnd();
                    List<string> list = new List<string>();
                    Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                    MatchCollection matches = regex.Matches(text);
                    foreach (var item in matches) { list.Add(item.ToString()); }
                    var result3 = list.GroupBy(x => x).Select(x => new { word = x.Key, count = x.Count() }).OrderByDescending(x => x.count).ToList();
                    result3.ForEach(item => resultSlov.Add(new Resultat(item.word, item.count)));
                }
                textBox_out.Clear();            
            RecordText(fileName);           
            _waitHandle?.Set();
        }

        private void RecordText(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(mydocu+@"\output.txt", true))
            {
                writer.WriteLine($"\n\nНайденные слова в {fileName}:");
                resultSlov.ForEach(item => writer.WriteLine(item.title + " - " + item.count + " слов"));
            }
            resultSlov.Clear();
        }     
        private void Record(string path,string text)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(text);
            }
        }

        private void size()
        {
            int x = this.Width = 280;
            int y = this.Height = 270;
            var CBSize = new Size(x, y);
            this.MinimumSize = this.MaximumSize = this.Size = CBSize;
        }

        
    }
}
