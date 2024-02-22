using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTables;

namespace TwistcliBuildTask
{
    public class Logic
    {
        public static int vulnLogic(List<string> vulnFindings, string vulnSeverity, string scanType)
        {
            int countVulnFindings = vulnFindings.Count;
            var exploitExists = new List<string>();
            var rce = new List<string>();
            var hasFix = new List<string>();
            var total = new List<string>();

            for (var i = 0; i < countVulnFindings; i++)
            {
                string[] lineInt = vulnFindings[i].Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                var temp = new List<string>();
                foreach (var j in lineInt)
                {
                    temp.Add(j);
                }

                var tempTwo = new List<string>();

                foreach (var s in temp)
                {
                    if (!string.IsNullOrEmpty(s))
                        tempTwo.Add(s);
                    if (s.Contains("null"))
                        tempTwo.Remove(s);
                    if (vulnSeverity == "critical")
                    {
                        foreach (var r in tempTwo)
                        {
                            if (r.Contains("Critical severity"))
                            {
                                foreach (var t in tempTwo)
                                {
                                    if (t.Contains("Exploit exists"))
                                    {
                                        exploitExists.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                    if (t.Contains("Has fix"))
                                    {
                                        hasFix.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                    if (t.Contains("Remote execution"))
                                    {
                                        rce.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                }
                            }
                        }
                    }
                    if (vulnSeverity == "high")
                    {
                        foreach (var r in tempTwo)
                        {
                            if (r.Contains("Critical severity"))
                            {
                                foreach (var t in tempTwo)
                                {
                                    if (t.Contains("Exploit exists"))
                                    {
                                        exploitExists.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                    if (t.Contains("Has fix"))
                                    {
                                        hasFix.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                    if (t.Contains("Remote execution"))
                                    {
                                        rce.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                }
                            }
                            if (r.Contains("High severity"))
                            {
                                foreach (var t in tempTwo)
                                {

                                    if (t.Contains("Exploit exists"))
                                    {
                                        exploitExists.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                    if (t.Contains("Has fix"))
                                    {
                                        hasFix.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                    if (t.Contains("Remote execution"))
                                    {

                                        rce.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                }
                            }
                        }
                    }
                    if (vulnSeverity == "medium")
                    {
                        foreach (var r in tempTwo)
                        {
                            if (r.Contains("Critical severity"))
                            {
                                foreach (var t in tempTwo)
                                {
                                    if (t.Contains("Exploit exists"))
                                    {
                                        exploitExists.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                    if (t.Contains("Has fix"))
                                    {
                                        hasFix.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                    if (t.Contains("Remote execution"))
                                    {
                                        rce.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                }
                            }
                            if (r.Contains("High severity"))
                            {
                                foreach (var t in tempTwo)
                                {
                                    if (t.Contains("Exploit exists"))
                                    {
                                        exploitExists.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                    if (t.Contains("Has fix"))
                                    {
                                        hasFix.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                    if (t.Contains("Remote execution"))
                                    {
                                        rce.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                }
                            }

                            if (r.Contains("Medium severity"))
                            {
                                foreach (var t in tempTwo)
                                {
                                    if (t.Contains("Exploit exists"))
                                    {
                                        exploitExists.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                    if (t.Contains("Has fix"))
                                    {
                                        hasFix.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                    if (t.Contains("Remote execution"))
                                    {
                                        rce.Add(tempTwo[0]);
                                        total.Add(tempTwo[0]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            int totalVulnCount = total.Count;
            string[] arr = new string[totalVulnCount];
            for (var i = 0; i < totalVulnCount; i++)
            {
                arr[i] = total[i];
            }
            string[] arrTwo = new string[totalVulnCount];
            IEnumerable<string> collectionWithDistinctElements = arr.Distinct().ToArray();
            if (scanType == "logic")
            {
                var tableTwo = new ConsoleTable("CVE", "Has Fix", "Has Exploit", "RCE");
                foreach (var j in collectionWithDistinctElements)
                {
                    var hasFixTable = new List<bool>();
                    var exploitExistsTable = new List<bool>();
                    var rceTable = new List<bool>();

                    var cveTable = j;
                    if (hasFix.Contains(j))
                    {
                        hasFixTable.Add(true);
                    }
                    else
                    {
                        hasFixTable.Add(false);
                    }
                    if (exploitExists.Contains(j))
                    {
                        exploitExistsTable.Add(true);
                    }
                    else
                    {
                        exploitExistsTable.Add(false);
                    }
                    if (rce.Contains(j))
                    {
                        rceTable.Add(true);
                    }
                    else
                    {
                        rceTable.Add(false);
                    }
                    tableTwo.AddRow(cveTable, hasFixTable[0], exploitExistsTable[0], rceTable[0]);
                }
                Console.WriteLine(tableTwo);
            }
            else
            {
                Console.WriteLine("Vulnerabilities that do not make threshold");
                var tableTwo = new ConsoleTable("CVE");
                var standardTotal = new List<string>();
                foreach (var i in collectionWithDistinctElements)
                {
                    var cveTable = i;
                    standardTotal.Add(cveTable);
                    tableTwo.AddRow(cveTable);
                }
                Console.WriteLine(tableTwo);
            }
            return totalVulnCount;
        }


        public static int compLogic(List<string> compFindings, string compSeverity, string scanType)
        {
            int countCompFindings = compFindings.Count;
            var total = new List<string>();

            Console.WriteLine(compFindings[0]);

            var tempTwo = new List<string>();
            for (var i = 0; i < countCompFindings; i++)
            {
                string[] lineInt = compFindings[i].Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                var temp = new List<string>();
                foreach (var j in lineInt)
                {
                    temp.Add(j);
                }
                Console.WriteLine(temp[0]);

                foreach (var s in temp)
                {
                    if (compSeverity == "critical")
                    {
                        if (s.Contains("critical"))
                            tempTwo.Add(s);
                    }
                    if (compSeverity == "high")
                    {
                        if (s.Contains("critical"))
                            tempTwo.Add(s);
                        if (s.Contains("high"))
                            tempTwo.Add(s);
                    }
                    if (compSeverity == "medium")
                    {
                        if (s.Contains("critical"))
                            tempTwo.Add(s);
                        if (s.Contains("high"))
                            tempTwo.Add(s);
                        if (s.Contains("medium"))
                            tempTwo.Add(s);
                    }
                }
            }
            int totalCompCount = tempTwo.Count;
            Console.WriteLine(totalCompCount);
            return totalCompCount;
        }
    }
}
