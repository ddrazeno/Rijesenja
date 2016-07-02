using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceleratio_ZAD1
{
    public partial class Form1 : Form
    {
        string putanja;
        string path;
        string path2 = @"C:\Users\DOMAGOJ\Desktop\Riješenja\Acceleratio_ZAD1\Acceleratio_ZAD1\log.txt";
        string tekst;
        string odabir;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            comboBox1.Items.Clear();
            tekst = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();
            putanja = fbd.SelectedPath;
            path = putanja + @"\log.txt";

            string[] files = Directory.GetFiles(putanja);
            string[] dirs = Directory.GetDirectories(putanja);

            foreach (char c in putanja)
            {
                if (Regex.IsMatch(c.ToString(), @"[""'\\]+") == true)
                {
                    textBox2.Text += Environment.NewLine + "   ";
                    tekst += Environment.NewLine + "   ";
                }
                else
                {
                    textBox2.Text += c;
                    tekst += c;
                }
                
            }
            textBox2.Text += Environment.NewLine;
            
            foreach (string item in files)
            {
                FileInfo f = new FileInfo(item);
                textBox2.Text += "   " + f.Name + Environment.NewLine;
                comboBox1.Items.Add(f.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path2))
            {
                File.Create(path2).Dispose();
                TextWriter tw = new StreamWriter(path2, true);
                tw.WriteLine(tekst + Environment.NewLine + odabir);
                tw.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            odabir += "   " + comboBox1.SelectedItem + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path2))
            {
                textBox2.Text = File.ReadAllText(path2);
            }
            
        }
    }
}
