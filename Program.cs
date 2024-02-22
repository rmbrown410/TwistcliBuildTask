using System;
using System.Collections.Generic;

namespace TwistcliBuildTask
{
    class Program
    {
        static void Main(string[] args)
        {

            string accessKeyId = args[0];
            string secretKey = args[1];
            string imageName = args[2];
            string vulnSeverity = args[3];
            string compSeverity = args[4];
            string scanType = args[5];

            string token = ApiCalls.getToken(accessKeyId, secretKey);
            RunScan.runScan(token, secretKey, accessKeyId, imageName);

            List<string> vulnFindings = FindingsTable.vulnTable(token, imageName);
            List<string> compFindings = FindingsTable.compTable(token, imageName);

            if (scanType == "logic")
            {
                int totalVulnCount = Logic.vulnLogic(vulnFindings, vulnSeverity, scanType);
                int compCount = Logic.compLogic(compFindings, compSeverity, scanType);
                ExitStrategy.ExitLogic(totalVulnCount, compCount);
            }
            else
            {
                int totalVulnCount = Logic.vulnLogic(vulnFindings, vulnSeverity, scanType);
                int compCount = Logic.compLogic(compFindings, compSeverity, scanType);
                ExitStrategy.ExitLogic(totalVulnCount, compCount);
            }
        }
    }
}
