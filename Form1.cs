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
        private string sCode = "";
        public Check_in()
        {
            InitializeComponent();
        }

        private void LoadData() {

            
            DataGridViewTicket.DataSource = dataBase.TicketSelect();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string sDate= DateTime.Now.ToString("M/d/yyyy");
            if (dataBase.TicketInsert(sCode, sDate))
            {
                MessageBox.Show("Se creó correctamente la factura # "+ sCode);
                LoadDataStrar();
                LoadData();
            }
            else {
                MessageBox.Show("Se presento un error al crear la factura #"+ sCode);
            }
            //ticket.UpdateCode();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            /*  try
              {
                  connection = new SQLiteConnection("Data source=Ticket.db");
                  connection.Open();
                  MessageBox.Show("Connection OK");
                  LoadData();
                  CreateFile();
              }
              catch (SQLiteException ex)
              {
                  MessageBox.Show(ex.Message, "Error");
              }*/
            dataBase = new DataBase();
            dataBase.ConnectionDB();
    
            LoadData();
            ticket = new Ticket();
            LoadDataStrar();

        }
        private void LoadDataStrar() {

            sCode = ticket.LoadCode(dataBase.TicketSelectCode());
            TxtCode.Text = sCode;
        }
        private void  CreateFile() {

            string sPath = String.Format("test.txt",AppDomain.CurrentDomain.BaseDirectory);
            MessageBox.Show(sPath);
            try
            {
                if (File.Exists(sPath))
                {
                    PrintTicket(sPath);
                }
                else {
                    using (StreamWriter sw = File.CreateText(sPath))
                    {
                        sw.WriteLine("Hello");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);  
            }

        }
        private void PrintTicket(string filePath) {

            try
            {
                   System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(filePath);
                    psi.Verb = "PRINT";

                    Process.Start(psi);
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) { 
                MessageBox.Show("OK"+ DataGridViewTicket.CurrentRow.Cells["Código"].Value.ToString());
            }
        }
    }
}
