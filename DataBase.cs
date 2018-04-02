using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrint
{
    class DataBase
    {
        SQLiteConnection connection;
        private int iResult = 0;
        private DataTable table;

        public Boolean  TicketInsert(string sCode,string sDate) {
           string command= "INSERT INTO BillingTicket values(NULL,'" + sCode + "','"+ sDate + "')";
           SQLiteCommand insert = new SQLiteCommand(command,connection);
           iResult = insert.ExecuteNonQuery();
           if (iResult > 0)
           {
              return true;

           }
           else {
                return false;
            }
        }
        public DataTable TicketSelect()
        {
            string command = "SELECT Code AS 'Código', Date AS 'Fecha'  FROM BillingTicket";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command, connection);
            DataTable table = new DataTable("Ticket");
            adapter.Fill(table);
            return  table;
        }
        public string TicketSelectCode()
        {
            string command = "SELECT MAX(ROWID) AS 'ID' FROM BillingTicket";
            SQLiteCommand adapter = new SQLiteCommand(command, connection);
            SQLiteDataReader reader = adapter.ExecuteReader();
            string sResult = "";
            while (reader.Read())
            {
                sResult = ""+reader["ID"];
            }
               
            
            return sResult;
        }
        public Boolean ConnectionDB() {
              try
              {
                  connection = new SQLiteConnection("Data source=Ticket.db");
                  connection.Open();
                  return true;

              }
              catch (SQLiteException ex)
              {
                 return false;
            }
        }

    }
}
