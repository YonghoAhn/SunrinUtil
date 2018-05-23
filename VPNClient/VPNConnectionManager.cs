using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Net;
using Microsoft.VisualBasic.FileIO;
namespace VPNClient
{
    public class VPNConnectionManager
    {
        
        public void GetVPNServerList()
        {
            string Filename = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".csv";

            using (WebClient client = new WebClient())
            {
                client.DownloadFile("http://www.vpngate.net/api/iPhone",Filename);
            }

            using (TextFieldParser parser = new TextFieldParser(Filename))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while(!parser.EndOfData)
                {
                    VPNServer server = new VPNServer(parser.ReadFields());
                }
            }

        }

        private void GetFinnestVPNServer(List<VPNServer> servers)
        {

        }

        public void ConenctVPN(string ServerAdress)
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                PowerShellInstance.AddCommand($"Add-VpnConnection -Name \"{new Random().Next(0, 10000).ToString()}\" -ServerAddress \"{ServerAdress}\" -TunnelType \"L2tp\" -AuthenticationMethod MSChapv2 -EncryptyionLevel Optional -L2tpPsk \"vpn\" -Force -SplitTunneling");
            }

        }
    }
}
