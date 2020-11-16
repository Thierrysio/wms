using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wms.Modeles;

namespace wms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Entrepot E1 = new Entrepot(1);
            Entrepot E2 = new Entrepot(2);

            Secteur S1 = new Secteur(1);
            Secteur S2 = new Secteur(2);
            Secteur S3 = new Secteur(3);
            Secteur S4 = new Secteur(4);
            Secteur S5 = new Secteur(5);

            E1.AddSecteur(S1);
            E1.AddSecteur(S3);
            E2.AddSecteur(S2);
            E2.AddSecteur(S4);
            E2.AddSecteur(S5);

            foreach(Entrepot unentrepot in Entrepot.CollClasseEntrepot)
            {
                comboBox1.Items.Add(unentrepot.IdEntrepot);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entrepot param2 = null;
            string param = comboBox1.Text;

            foreach(Entrepot unEntrepot in Entrepot.CollClasseEntrepot)
            {
                if(unEntrepot.IdEntrepot.ToString() == param)
                {
                    param2 = unEntrepot;
                    break;
                }
            }

            remplirDGV1(param2);
        }
        private void remplirDGV1(Entrepot param)
        {
            DataTable d = new DataTable();
            d.Columns.Add("Id", typeof(int));

            dataGridView1.Refresh();

            foreach (Secteur unSecteur in param.GetAllSecteurs())
            {
                d.Rows.Add(unSecteur.IdSecteur);
            }
            dataGridView1.DataSource = d;
        }

        private void remplirDGVDernier(Secteur param)
        {
            DataTable d = new DataTable();
            d.Columns.Add("Id", typeof(int));

            dataGridView1.Refresh();

                d.Rows.Add(param.IdSecteur);
           
            dataGridView1.DataSource = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrepot param2 = null;
            string param = comboBox1.Text;

            foreach (Entrepot unEntrepot in Entrepot.CollClasseEntrepot)
            {
                if (unEntrepot.IdEntrepot.ToString() == param)
                {
                    param2 = unEntrepot;
                    break;
                }
            }

            this.remplirDGVDernier(param2.GetLeDernier());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entrepot param2 = null;
            string param = comboBox1.Text;

            foreach (Entrepot unEntrepot in Entrepot.CollClasseEntrepot)
            {
                if (unEntrepot.IdEntrepot.ToString() == param)
                {
                    param2 = unEntrepot;
                    break;
                }
            }

            this.remplirDGVSecteurLigne(param2.GetLesSecteursEnLigne());

        }
        private void remplirDGVSecteurLigne(string param)
        {
            DataTable d = new DataTable();
            d.Columns.Add("Id", typeof(string));

            dataGridView1.Refresh();

            d.Rows.Add(param);

            dataGridView1.DataSource = d;
        }
    }
}
