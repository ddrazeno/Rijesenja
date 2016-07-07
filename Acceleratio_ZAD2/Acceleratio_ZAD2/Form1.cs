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
            z.zadatak = txtZadatak.Text;
            z.stanje = "To Do";
            if (!String.IsNullOrWhiteSpace(z.zadatak))
            {
                zadToDo.Add(z);
            }
            txtZadatak.Clear();
            Osvjezi();         
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            if (ltbToDo.SelectedItem != null)
            {
                zad = ltbToDo.SelectedItem.ToString();
                foreach (Zadatak z in zadToDo.ToList<Zadatak>())
                {
                    if (z.zadatak == zad && cmbKategorije.SelectedItem!=null)
                    {
                        if (cmbKategorije.SelectedItem.ToString() == "In progress")
                        {
                            z.stanje = "In progress";
                            zadInProg.Add(z);
                            zadToDo.Remove(z);
                        }
                        else if (cmbKategorije.SelectedItem.ToString() == "Done")
                        {
                            z.stanje = "Done";
                            zadDone.Add(z);
                            zadToDo.Remove(z);
                        }
                    }
                }
            }
            if (ltbInProg.SelectedItem != null)
            {
                zad2 = ltbInProg.SelectedItem.ToString();
                foreach (Zadatak z in zadInProg.ToList<Zadatak>())
                {
                    if (z.zadatak == zad2 && cmbKategorije.SelectedItem != null)
                    {
                        if (cmbKategorije.SelectedItem.ToString() == "Done")
                        {
                            z.stanje = "Done";
                            zadDone.Add(z);
                            zadInProg.Remove(z);
                        }
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
            ltbToDo.Items.Clear();
            foreach (Zadatak z in zadToDo)
            {
                if (z.stanje == "To Do")
                {
                    ltbToDo.Items.Add(z.zadatak);
                }
            }
        }

        public void DohvatiInProg()
        {
            ltbInProg.Items.Clear();
            foreach (Zadatak z in zadInProg)
            {
                if (z.stanje == "In progress")
                {
                    ltbInProg.Items.Add(z.zadatak);
                }
            }
        }

        public void DohvatiDone()
        {
            ltbDone.Items.Clear();
            foreach (Zadatak z in zadDone)
            {
                if (z.stanje == "Done")
                {
                    ltbDone.Items.Add(z.zadatak);
                }
            }
        }
    }
}
