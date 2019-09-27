using Mynventory.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mynventory.View
{
    public partial class Transakcije_forma : MetroFramework.Forms.MetroForm
    {   
        

        public Transakcije_forma()
        {
            InitializeComponent();
        }

        private void Transakcije_forma_Load(object sender, EventArgs e)
        {

            var RacuniIzBaze = DBpristup.DohvatiRacune();
            var StavkeRacuna = DBpristup.DohvatiStavke();

            g_racuni.Rows.Clear();
            gr_stavke.Rows.Clear();
            
            foreach (var novi in RacuniIzBaze)
            {
               
                g_racuni.DataSource = RacuniIzBaze;
            }
            
            foreach (var s in StavkeRacuna)
            {
               
                gr_stavke.DataSource = StavkeRacuna;
            }
            
    
        }

        private void g_racuni_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            

            

            
        }
    }
}
