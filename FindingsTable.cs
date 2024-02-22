using System;
using Newtonsoft.Json;
using ConsoleTables;
using System.Collections.Generic;

namespace TwistcliBuildTask
{
    public class FindingsTable
    {
        public static List<string> vulnTable(string token, string imageName)
        {
            string imageID = Commands.Bash("docker images --no-trunc --format \"{{.ID}}\" " + imageName);
            var jsonResp = ApiCalls.apiReq(token, imageID);
            int vulnCount = jsonResp[0].entityInfo.vulnerabilitiesCount;

            var vulnFindings = new List<string>();

            var vulnTable = new ConsoleTable("CVE", "Description", "Package", "Version", "Severity", "Status", "CVSS", "Link");

            for (int i = 0; i < vulnCount; i++)
            {
                var vuln = jsonResp[0].entityInfo.vulnerabilities[i].cve;
                var riskFactors = jsonResp[0].entityInfo.vulnerabilities[i].riskFactors;
                string rf = JsonConvert.SerializeObject(riskFactors, Formatting.Indented);
                string v = JsonConvert.SerializeObject(vuln, Formatting.Indented);
                string finding = v + "\n" + rf;
                vulnFindings.Add(finding);
                var cve = jsonResp[0].entityInfo.vulnerabilities[i].cve;
                var description = jsonResp[0].entityInfo.vulnerabilities[i].description;
                var package = jsonResp[0].entityInfo.vulnerabilities[i].packageName;
                var version = jsonResp[0].entityInfo.vulnerabilities[i].packageVersion;
                var severity = jsonResp[0].entityInfo.vulnerabilities[i].severity;
                var status = jsonResp[0].entityInfo.vulnerabilities[i].status;
                var cvss = jsonResp[0].entityInfo.vulnerabilities[i].cvss;
                var link = jsonResp[0].entityInfo.vulnerabilities[i].link;
                vulnTable.AddRow(cve, description, package, version, severity, status, cvss, link);
            }

            Console.WriteLine("Vulnerabilities");
            Console.WriteLine(vulnTable);
            Console.WriteLine("Number of Vulnerabilities Identified: " + vulnCount);

            return vulnFindings;
        }

        public static List<string> compTable(string token, string imageName)
        {
            string imageID = Commands.Bash("docker images --no-trunc --format \"{{.ID}}\" " + imageName);
            var jsonResp = ApiCalls.apiReq(token, imageID);
            int compCount = jsonResp[0].entityInfo.complianceIssuesCount;

            var compFindings = new List<string>();
            var compTable = new ConsoleTable("Severity", "Title", "Description");

            for (int i = 0; i < compCount; i++)
            {
                string compSev = jsonResp[0].entityInfo.complianceIssues[i].severity;
                string compTitle = jsonResp[0].entityInfo.complianceIssues[i].title;
                string compDesc = jsonResp[0].entityInfo.complianceIssues[i].description;

                string cs = JsonConvert.SerializeObject(compSev, Formatting.Indented);
                string ct = JsonConvert.SerializeObject(compTitle, Formatting.Indented);
                string compFinding = ct + "\n" + cs;
                compFindings.Add(compFinding);

                compTable.AddRow(compSev, compTitle, compDesc);
            }
            Console.WriteLine("Compliance Issues");
            Console.WriteLine(compTable);
            Console.WriteLine("Number of Compliance Issues Identified: " + compCount);

            return compFindings;
        }

    }
}
