using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceleratio_ZAD2
{
    public partial class Form1 : Form
    {
        string zad, zad2;
        List<Zadatak> zadToDo;
        List<Zadatak> zadInProg;
        List<Zadatak> zadDone;
        Zadatak z;
        public Form1()
        {
            InitializeComponent();
            zadToDo = new List<Zadatak>();
            zadInProg = new List<Zadatak>();
            zadDone = new List<Zadatak>();
            
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            z = new Zadatak();
            z.zadatak = textBox1.Text;
            z.stanje = "To Do";
            zadToDo.Add(z);
            textBox1.Clear();
            Osvjezi();         
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                zad = listBox1.SelectedItem.ToString();
                foreach (Zadatak z in zadToDo.ToList<Zadatak>())
                {
                    if (z.zadatak == zad)
                    {
                        if (comboBox1.SelectedItem.ToString() == "In progress")
                        {
                            z.stanje = "In progress";
                            zadInProg.Add(z);
                            zadToDo.Remove(z);
                        }
                        else if (comboBox1.SelectedItem.ToString() == "Done")
                        {
                            z.stanje = "Done";
                            zadDone.Add(z);
                            zadToDo.Remove(z);
                        }
                    }
                }
            }
            if (listBox2.SelectedItem != null)
            {
                zad2 = listBox2.SelectedItem.ToString();
                foreach (Zadatak z in zadInProg.ToList<Zadatak>())
                {
                    if (comboBox1.SelectedItem.ToString() == "Done")
                    {
                        z.stanje = "Done";
                        zadDone.Add(z);
                        zadInProg.Remove(z);
                    }
                }
            }
            
            Osvjezi();
        }

        public void Osvjezi()
        {
            DohvatiToDo();
            DohvatiInProg();
            DohvatiDone();
        }

        public void DohvatiToDo()
        {
            listBox1.Items.Clear();
            foreach (Zadatak z in zadToDo)
            {
                if (z.stanje == "To Do")
                {
                    listBox1.Items.Add(z.zadatak);
                }
            }
        }

        public void DohvatiInProg()
        {
            listBox2.Items.Clear();
            foreach (Zadatak z in zadInProg)
            {
                if (z.stanje == "In progress")
                {
                    listBox2.Items.Add(z.zadatak);
                }
            }
        }

        public void DohvatiDone()
        {
            listBox3.Items.Clear();
            foreach (Zadatak z in zadDone)
            {
                if (z.stanje == "Done")
                {
                    listBox3.Items.Add(z.zadatak);
                }
            }
        }
    }
}
