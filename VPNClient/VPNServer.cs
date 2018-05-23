using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPNClient
{
    class VPNServer
    {
        public VPNServer(string[] @params)
        {
            Hostname = @params[0];
            IP = @params[1];
            Score = @params[2];
            Ping = @params[3];
            Speed = @params[4];
            CountryLong = @params[5];
            CountryShort = @params[6];
            NumVpnSessions = @params[7];
            Uptime = @params[8];
            TotalUsers = @params[9];
            TotalTraffic = @params[10];
        }

        public VPNServer(string hostname, string iP, string score, string ping, string speed, string countryLong, string countryShort, string numVpnSessions, string uptime, string totalUsers, string totalTraffic)
        {
            Hostname = hostname;
            IP = iP;
            Score = score;
            Ping = ping;
            Speed = speed;
            CountryLong = countryLong;
            CountryShort = countryShort;
            NumVpnSessions = numVpnSessions;
            Uptime = uptime;
            TotalUsers = totalUsers;
            TotalTraffic = totalTraffic;
        }

        string Hostname { get; set; }
        string IP { get; set; }
        string Score { get; set; }
        string Ping { get; set; }
        string Speed { get; set; }
        string CountryLong { get; set; }
        string CountryShort { get; set; }
        string NumVpnSessions { get; set; }
        string Uptime { get; set; }
        string TotalUsers { get; set; }
        string TotalTraffic { get; set; }
    }
}
