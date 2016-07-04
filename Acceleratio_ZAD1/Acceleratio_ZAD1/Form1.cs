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
    public partial class Zadatak1 : Form
    {
        Datoteka datoteka = new Datoteka();
        string path2 = NabaviPunoImePutanje("log.txt");
        
        public Zadatak1()
        {
            InitializeComponent();
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            txtPrikaz.Clear();
            cmbFiles.Items.Clear();
            datoteka.tekst = "";
            datoteka.razmak = "   ";
            FolderBrowserDialog browser = new FolderBrowserDialog();
            DialogResult result = browser.ShowDialog();
            datoteka.putanja = browser.SelectedPath;
            datoteka.path = datoteka.putanja + @"\log.txt";

            try
            {
                datoteka.datoteke = Directory.GetFiles(datoteka.putanja);
            }
            catch (Exception)
            {
                
            }

            try
            {
                datoteka.direktoriji = Directory.GetDirectories(datoteka.putanja);
            }
            catch (Exception)
            {
                
            }

            foreach (char c in datoteka.putanja)
            {
                if (Regex.IsMatch(c.ToString(), @"[""'\\]+") == true)
                {
                    datoteka.razmak += "   ";
                    txtPrikaz.Text += Environment.NewLine + datoteka.razmak;
                    datoteka.tekst += Environment.NewLine + "   " + datoteka.razmak;
                }
                else
                {
                    txtPrikaz.Text += c;
                    datoteka.tekst += c;
                }
                
            }

            txtPrikaz.Text += Environment.NewLine;

            try
            {
                foreach (string item in datoteka.datoteke)
                {
                    FileInfo f = new FileInfo(item);
                    txtPrikaz.Text += datoteka.razmak + f.Name + Environment.NewLine;
                    cmbFiles.Items.Add(f.Name);
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path2))
            {
                File.Create(path2).Dispose();
                TextWriter tw = new StreamWriter(path2, true);
                tw.WriteLine(datoteka.tekst + Environment.NewLine + datoteka.odabir);
                tw.Close();
            }
            else
            {
                TextWriter tw = new StreamWriter(path2, false);
                tw.WriteLine(datoteka.tekst + Environment.NewLine + datoteka.odabir);
                tw.Close();
            }
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(cmbFiles.Text))
            {
                MessageBox.Show("Morate odabrati datoteku!");
            }
            else
            {
                datoteka.odabir += datoteka.razmak + "   " + cmbFiles.SelectedItem + Environment.NewLine;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path2))
            {
                txtPrikaz.Text = File.ReadAllText(path2);
            }
        }

        public static string NabaviPunoImePutanje(string FileName)
        {
            string file = "";

            FileInfo f = new FileInfo(FileName);

            if (FileName.StartsWith(".\\"))
            {
                file = Application.StartupPath + FileName.Substring(1);
            } 
            else if (!FileName.Contains("\\"))
            {
                file = Application.StartupPath + "\\" + FileName;
            }
            else
            {
                file = f.FullName;
            }
            return file;
        }
    }
}
