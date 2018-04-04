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
    public partial class FormTool : Form
    {
        Ticket ticket;
        DataBase dataBase;
        string[] sGetCode = new string[2];
        private string sCodeGet;
        string sDate = DateTime.Now.ToString("d/M/yyyy");
        Check_in check_In = null;
        public FormTool()
        {
            InitializeComponent();
        }
        private void BtnValidate_Click(object sender, EventArgs e)
        {
            string sCode = TxtCodeUser.Text;
            if (sCode == "" || sCode.Length == 0)
            {
                MessageBox.Show("Digite un código", "Ticket");
            }
            else {
      
                if (ticket.ValidateCode(sCode))
                {
                    HideSelection(true);
                }
                else {
                    MessageBox.Show("Código ingresado no es correcto", "Ticket");
                    TxtCodeUser.Text = "";
                }
            }
        }
        private void HideSelection(Boolean bValidate) {
            TxtSequence.Enabled = bValidate;
            TxtCodePB.Enabled = bValidate;
            BtnUpdate.Enabled =bValidate;
        }
        private void LoadStarData() {
            ticket = new Ticket();
            dataBase = new DataBase();
            sCodeGet = ticket.GetCode();
             
        

            if (dataBase.ConnectionDB()) {

                string sCode = dataBase.TicketSelectCode(sCodeGet);
                if (sCode.Equals(""))
                {
                    sGetCode = ticket.LoadCode();
                }
                else {
                    sGetCode = ticket.LoadCode(dataBase.TicketSelectCode(sCodeGet));
                }
                TxtCodePB.Text = sGetCode[1];
                TxtSequence.Text = sGetCode[0];
               
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string sSequence = TxtSequence.Text;
            string sCodePB = TxtCodePB.Text;
        
            if ((sCodePB.Equals("") || sCodePB.Length == 0)|| (sSequence.Equals("") || sSequence.Length == 0))
            {
                MessageBox.Show("Verifique los datos ingresados", "Ticket");
            }
            else {
                int n;
                bool isNumeric = int.TryParse(sSequence, out n);
                bool bValidateInsert = false;
                if (!isNumeric)
                {
                    MessageBox.Show("El valor ingresado en la secuencia no es numérico ", "Ticket");
                }
                else if ((sSequence.Length < 8) || (sSequence.Length > 8))
                {
                    MessageBox.Show("La longitud del numero debe ser de 8 caracteres","Ticket");
                }
                else {
                    
                    if (sCodePB.Length <= 3 || sCodePB.Length >= 6)
                    {
                        MessageBox.Show("El codigo debe contener minimo 4 caracteres y maximo 5", "Ticket");
                    }
                    else
                    {
                        bValidateInsert = true;
                    }
                }
                if (bValidateInsert)
                {
                    HideSelection(false);
                    if (ticket.UpdateCode(sCodePB))
                    {
                        MessageBox.Show("Cambios realizados con éxito, es necesario reiniciar el sistema ","Ticket");
                        this.Close();
                        sGetCode[0] = sSequence;
                        sGetCode[1] = sCodePB;
                        InsertData(sGetCode, sDate);
                    }
                    else {
                        MessageBox.Show("Se presento un inconveniente en la acción ");
                    }
                    

                }
            }
        }

        private void FormTool_Load(object sender, EventArgs e)
        {
            LoadStarData();
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
        private void TxtSequence_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void InsertData(string [] sCode, string sGetdate) {
            if (dataBase.TicketInsert(sCode, sGetdate))
            {

                MessageBox.Show("Modificación realizada con éxito ", "Ticket");
            }
        }

    }
}
