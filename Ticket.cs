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
        public string[] LoadCode(string code) {

            string [] sResultCode = new string[2];
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                sCode = appSettings["codePB"];
                iConsecutive = Int32.Parse(code)+1;
                string sConsecutive = "" + iConsecutive;
                sResultCode[0] = listZero[sConsecutive.Length-1] + iConsecutive;
                sResultCode[1] = sCode ;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error",ex.Message);
            }
            return sResultCode;


        }
        public string[] LoadCode()
        {

            string[] sResultCode = new string[2];
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                sCode = appSettings["codePB"];
                sResultCode[0] = "" + "00000000";
                sResultCode[1] = sCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error", ex.Message);
            }
            return sResultCode;

        }
        public Boolean ValidateCode(string sDataCode)
        {

            Boolean bResultCode = false;
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                sCode = appSettings["codeValidation"];

                if (sCode == sDataCode) {
                    bResultCode = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error", ex.Message);
            }
            return bResultCode;


        }
        public string GetCode()
        {

            string sResultCode = "";
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                sCode = appSettings["codePB"];
                sResultCode = sCode;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error", ex.Message);
            }
            return sResultCode;


        }
        public bool UpdateCode(string sCodePB)
        {
            bool bValidate = false;
        
            try
            {
                var appSettings = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                appSettings.AppSettings.Settings["codePB"].Value=sCodePB;
                appSettings.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                bValidate = true;
                MessageBox.Show("Se realizo el cambio con éxito  del código #"+ sCodePB, "Ticket" );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error", ex.Message);
                bValidate = false;
            }
            return bValidate;
        }
        public bool CreateCodeConfigutarion(string sCodePB,string sCodeValidation)
        {
            bool bValidate = false;

            try
            {
                var appSettings = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                appSettings.AppSettings.Settings["codePB"].Value = sCodePB;
                appSettings.AppSettings.Settings["codeValidation"].Value = sCodeValidation;
                appSettings.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                bValidate = true;
                MessageBox.Show("Datos creados con éxito\n Código: "+sCodePB+"\n Contraseña: "+ sCodeValidation, "Ticket");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error", ex.Message);
                bValidate = false;
            }
            return bValidate;
            

        }
    }
}
