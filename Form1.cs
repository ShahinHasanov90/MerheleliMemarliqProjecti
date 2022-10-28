using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_Layers;
using DataAccessLayer;
using LogicLayer;

namespace Merheleli_Memarliq_Projecti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonal> perlist = LogicPersonal.LLPersonalliste();
            dataGridView1.DataSource = perlist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityPersonal ntr = new EntityPersonal();
            ntr.Ad = txtad.Text;
            ntr.Soyad = txtsyd.Text;
            ntr.Vezife = txtvzf.Text;
            ntr.Maas = short.Parse(txtmaas.Text);
            ntr.Seher = txtshr.Text;
            LogicPersonal.llPersonal(ntr);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntityPersonal ntre = new EntityPersonal();
            ntre.Id = Convert.ToInt32(txtid.Text);
            LogicPersonal.llpersil(ntre.Id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EntityPersonal ntr2 = new EntityPersonal();
            ntr2.Id= Convert.ToInt32(txtid.Text);
            ntr2.Ad = txtad.Text;
            ntr2.Soyad = txtsyd.Text;
            ntr2.Vezife = txtvzf.Text;
            ntr2.Seher = txtshr.Text;
            ntr2.Maas = short.Parse(txtmaas.Text);
            ntr2.Seher = txtshr.Text;
            LogicPersonal.llpersgunc(ntr2);
        }
    }
}
