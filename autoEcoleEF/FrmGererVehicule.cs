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
    public partial class FrmGererVehicule : Form
    {
        public FrmGererVehicule()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void bindingNavigatorMovePreviousItem_CheckedChanged(object sender, EventArgs e)
        {

            if (txtModele.Text == "" || txtNum.Text == "" || txtCouleur.Text == "")
            {

                MessageBox.Show("Il faut remplir tous les champs du nouvel vehicule");
                bdgSourceVehicule.CancelEdit();
            }
        }
        private void bindingNavigatorMoveFirstItem_CheckedChanged(object sender, EventArgs e)
        {

            if (txtModele.Text == "" || txtNum.Text == "" || txtCouleur.Text == "")
            {

                MessageBox.Show("Il faut remplir tous les champs du nouvel vehicule");
                bdgSourceVehicule.CancelEdit();
            }
        }
        private void bindingNavigatorAddNewItem_CheckedChanged(object sender, EventArgs e)
        {

            if (txtModele.Text == "" || txtNum.Text == "" || txtCouleur.Text == "")
            {

                MessageBox.Show("Il faut remplir tous les champs du nouvel vehicule");
                bdgSourceVehicule.CancelEdit();
            }
        }
        private void validationVehicule(object sender, EventArgs e)
        {

        }

    }
}
