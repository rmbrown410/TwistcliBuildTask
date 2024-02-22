# TwistcliBuildTask
 
Simple .NET Console Application to be used in build pipelines to scan containers utilizing Prisma Clouds Twistcli utility.

Process:

Downloads twistcli utility.

Modifies the permissions to allow it to execute. 

Executes it.

Queries the API to verify vulnerabilities and exceptions to vulnerabilities.

Identifies whether the scan passed or failed.

Issues 0 or non-zero exit-code depending if it passed or failed. 

If it fails with a non-zero exit code (1), the build task fails in order to break the build. 

Results are printed out in a pretty table. 
