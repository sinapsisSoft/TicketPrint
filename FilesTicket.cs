using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPrint
{
    class FilesTicket
    {
        string sPath;
        public void CreateFile(string[] sCode)
        {
            sPath = String.Format("ticket.txt", AppDomain.CurrentDomain.BaseDirectory);
            
            try
            {
               
                    using (StreamWriter sw = File.CreateText(sPath))
                    {
                        sw.Flush();
                        sw.WriteLine("<xpml><page quantity='0' pitch='25.0 mm'></xpml>'Seagull:2.1:DP");
                        sw.WriteLine("INPUT OFF");
                        sw.WriteLine("VERBOFF");
                        sw.WriteLine("INPUT ON");
                        sw.WriteLine("SYSVAR(48) = 0");
                        sw.WriteLine("ERROR 15,\"FONT NOT FOUND\" ");
                        sw.WriteLine("ERROR 18,\"DISK FULL\" ");
                        sw.WriteLine("ERROR 26,\"PARAMETER TOO LARGE\" ");
                        sw.WriteLine("ERROR 27,\"PARAMETER TOO SMALL\" ");
                        sw.WriteLine("ERROR 37,\"CUTTER DEVICE NOT FOUND\" ");
                        sw.WriteLine("ERROR 1003,\"FIELD OUT OF LABEL\" ");
                        sw.WriteLine("SYSVAR(35)=0");
                        sw.WriteLine("OPEN \"tmp:setup.sys \"FOR OUTPUT AS #1 ");
                        sw.WriteLine("PRINT#1,\"Printing,Media,Print Area,Media Margin (X),0\" ");
                        sw.WriteLine("PRINT#1,\"Printing,Media,Print Area,Media Width,795\" ");
                        sw.WriteLine("PRINT#1,\"Printing,Media,Print Area,Media Length,201\" ");
                        sw.WriteLine("PRINT#1,\"Printing,Media,Clip Default,On\" ");
                        sw.WriteLine("CLOSE #1");
                        sw.WriteLine("SETUP \"tmp:setup.sys\" ");
                        sw.WriteLine("KILL \"tmp:setup.sys\" ");
                        sw.WriteLine("<xpml></page></xpml><xpml><page quantity='1' pitch='25.0 mm'></xpml>CLL");
                        sw.WriteLine("OPTIMIZE \"BATCH\" ON");
                        sw.WriteLine("PP192,160:AN7");
                        sw.WriteLine("BARSET \"CODE128B\",2,1,3,102");
                        sw.WriteLine("PB \""+ sCode[1]+sCode[0]+"\" ");
                        sw.WriteLine("PP273,60:NASC 8");
                        sw.WriteLine("FT \"Andale Mono\",12,0,99");
                        sw.WriteLine("PT \""+sCode[1]+sCode[0]+"\" ");
                        sw.WriteLine("LAYOUT RUN \"\" ");
                        sw.WriteLine("PF");
                        sw.WriteLine("PRINT KEY OFF");
                        sw.WriteLine("<xpml></page></xpml><xpml><end/></xpml>");
                    }

                PrintTicket(sPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void PrintTicket(string filePath)
        {
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
    }
}
