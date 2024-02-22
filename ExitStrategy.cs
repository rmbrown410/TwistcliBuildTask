using System;

namespace TwistcliBuildTask
{
    public class ExitStrategy
    {
        public static void ExitLogic(int totalVulnCount, int compCount)
        {
            if (totalVulnCount > 0)
            {
                int a = 1;
                if (compCount > 0)
                {
                    int b = 2;
                    int exitSum = a + b;
                    Console.WriteLine("Build Task Failed - Due to Compliance and Vulnerabilities Identified in Scan Results - Exit Code: " + exitSum);
                    Environment.Exit(exitSum);
                }
                Console.WriteLine("Build Task Failed - Due to Vulnerabilities Identified in Scan Results - Exit Code: " + a);
                Environment.Exit(a);
            }
            else
            {
                int code = 0;
                Console.WriteLine("Build Task Succeeded - Exit Code: " + code);
            }
        }
    }
}
