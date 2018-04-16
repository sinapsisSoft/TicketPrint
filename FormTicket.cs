using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;
using System.Configuration;


namespace TicketPrint
{
    public partial class Check_in : Form
    {
        
        Ticket ticket;
        DataBase dataBase;
        FilesTicket filesTicket;
        string sDataSearch = "";
        private string sCodeGet;
        private string [] sCode =new string [2] ;
        string sDate = DateTime.Now.ToString("d/M/yyyy");
        public Check_in()
        {
            InitializeComponent();
        }
        private void LoadData(Boolean bValidate) {
            DataTable dataTable = null;

            if (bValidate)
            {
                dataTable = dataBase.TicketSelect(sCodeGet);
            }
            else {
                dataTable = dataBase.TicketSelect(sDataSearch, sCodeGet);
            }
            DataGridViewTicket.DataSource = dataTable;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            
            if (dataBase.TicketInsert(sCode, sDate))
            {
                MessageBox.Show("Se creó correctamente la factura # "+ sCode[1]+ sCode[0], "Ticket");
                FilesTicket(sCode);
                LoadData(true);
                LoadDataStrar(); ;
            }
            else {
                MessageBox.Show("Se presento un error al crear la factura #"+ sCode, "Ticket");
            }
        }

       

        private void FilesTicket(string[] sDataFile )
        {  
            filesTicket.CreateFile(sDataFile);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dataBase = new DataBase();
            ticket = new Ticket();
            filesTicket = new FilesTicket();
            sCodeGet=ticket.GetCode();
            if (sCodeGet.Equals(""))
            {
                LoadFormConfiguration();
                this.Dispose();
                
            }
            dataBase.ConnectionDB();
            LoadData(true);
            LoadDataStrar();
        }
       
        
        private void LoadDataStrar() {

            if (dataBase.TicketSelectCode(sCodeGet) == "")
            {
                sCode = ticket.LoadCode();    
            }
            else {
               sCode = ticket.LoadCode(dataBase.TicketSelectCode(sCodeGet)); 
            }
            TxtCode.Text = sCode[1]+ sCode[0];
        }
      
        private void dataGridViewTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string[] sDataPrint = new string[2];

                if (e.ColumnIndex == 0)
                {   
                    string sGetDataCell = DataGridViewTicket.CurrentRow.Cells["Código"].Value.ToString();
                    MessageBox.Show("Se reimprime la factura #" + sGetDataCell);
                    sDataPrint[0] = sGetDataCell.Replace(sCode[1], "");
                    sDataPrint[1] = sCode[1];
                    filesTicket.CreateFile(sDataPrint);  
                }
            }
            catch (Exception ex){
                MessageBox.Show("No tiene contenidos para reimprimir", "Ticket");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sSelectCombo = comboBoxSearch.Text;
            string sData = "";
            sDataSearch = "";
            if (sSelectCombo.Equals("") || sSelectCombo == "Seleccionar")
            {
                LoadData(true);
                TxtSearch.Text = "";
            }
            else {
                if (TxtSearch.Text.Equals(""))
                {
                    MessageBox.Show("Digite un dato para la búsqueda de " + sSelectCombo, "Ticket");
                }
                else
                {
                    if (sSelectCombo == "Código")
                    {
                        sData = "Code"; 

                    }
                    else if (sSelectCombo == "Fecha") {
                        sData = "Date";
                    }
                    sDataSearch = sData + " LIKE " +"'%"+ TxtSearch.Text+"%'";
                    
                    LoadData(false);
                }
            }
            
        }

        private void BtnTool_Click(object sender, EventArgs e)
        {
        
            this.IsMdiContainer = true;
            FormTool formTool = new FormTool();
            formTool.ShowDialog(this);
            //this.Close();
        }
        private void  LoadFormConfiguration() {

            this.IsMdiContainer = true;
            FormConfiguration formConfiguration = new FormConfiguration();
            formConfiguration.ShowDialog(this);
        }
    }
}
