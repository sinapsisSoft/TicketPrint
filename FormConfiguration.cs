using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicketPrint
{
    public partial class FormConfiguration : Form
    {
        private Ticket ticket=null;
        public FormConfiguration()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string sCodePB=TxtCodePB.Text;
            string sCodeUser=TxtCodeUser.Text;
            if ((sCodePB.Equals("") || sCodePB.Length == 0) || (sCodeUser.Equals("") || sCodeUser.Length == 0))
            {
                MessageBox.Show("Verifique los datos ingresados ", "Ticket");
            }
            else {
                if (sCodePB.Length<=3  || sCodePB.Length>=6)
                {
                    MessageBox.Show("El codigo debe contener minimo 4 caracteres y maximo 5", "Ticket");
                }
                else {
                    if (sCodeUser.Length <= 5 || sCodeUser.Length >= 16)
                    {
                        MessageBox.Show("La contraseña debe contener minimo 6 caracteres y maximo 15", "Ticket");
                    }
                    else
                    {
                        DialogResult dialogResult= MessageBox.Show("¿Esta seguro de realizar esta acción?\n\nDatos administrador\nContraseña: "+ sCodeUser+ "\nCódigo: "+ sCodePB, "Ticket", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (dialogResult.Equals(DialogResult.OK))
                        {
                            CleanText();
                            if (ticket.CreateCodeConfigutarion(sCodePB, sCodeUser))
                            {
                                this.Dispose();
                            }
                        }
                        else {
                            CleanText();
                        }
                    }
                }
            }
        }
        private void TxtCodePB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void CleanText() {
            TxtCodePB.Text = "";
            TxtCodeUser.Text = "";
        }

        private void FormConfiguration_Load(object sender, EventArgs e)
        {
             ticket = new Ticket();
        }
    }
}
