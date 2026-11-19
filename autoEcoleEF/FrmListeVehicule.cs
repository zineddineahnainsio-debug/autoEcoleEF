using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoEcoleEF
{
    public partial class FrmListeVehicule : Form
    {
        private autoecoleEntities mesDonneesEF;
        public FrmListeVehicule(autoecoleEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bdgVehicule.DataSource = mesDonneesEF.vehicules.ToList();
        }

        private void FrmListeVehicule_Load(object sender, EventArgs e)
        {

        }

        private void dgvVehicule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            this.bdgVehicule.EndEdit();
            this.mesDonneesEF.SaveChanges();
        }
    }
}
