using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPrint
{
    class Ticket
    {
        private string sCode;
        private int iConsecutive;
        private string[] listZero = {"0000000", "000000", "00000", "0000", "000", "00", "0" };


        public string LoadCode(string code) {

            string sResultCode = "";
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                sCode = appSettings["codePB"];
                iConsecutive = Int32.Parse(code)+1;

                sResultCode = sCode+listZero[code.Length-1]+ iConsecutive;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error",ex.Message);
            }
            return sResultCode;


        }
        public void UpdateCode(){

        
            try
            {
               /* var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                var appSettings = ConfigurationManager.AppSettings;
                sConsecutive = appSettings["consecutive"];
                int iConsecutive = Int32.Parse(sConsecutive) + 1;

                settings["consecutive"].Value =""+iConsecutive;
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

                MessageBox.Show("Se presento un error"+ iConsecutive);

    */


            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error", ex.Message);
            }
            
        }
    }
}
