using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TwistcliBuildTask
{
    public class Binary
    {
        public string name { get; set; }
        public string path { get; set; }
        public string md5 { get; set; }
        public int cveCount { get; set; }
        public int layerTime { get; set; }
        public string version { get; set; }
    }

    public class StartupBinary
    {
        public string name { get; set; }
        public string path { get; set; }
        public string md5 { get; set; }
        public int cveCount { get; set; }
        public int layerTime { get; set; }
    }

    public class Pkg
    {
        public string version { get; set; }
        public string name { get; set; }
        public int cveCount { get; set; }
        public string license { get; set; }
        public int layerTime { get; set; }
        public List<string> binaryPkgs { get; set; }
        public List<int?> binaryIdx { get; set; }
    }

    public class Package
    {
        public string pkgsType { get; set; }
        public List<Pkg> pkgs { get; set; }
    }

    public class Image
    {
        public DateTime created { get; set; }
    }

    public class History
    {
        public int created { get; set; }
        public string instruction { get; set; }
        public int sizeBytes { get; set; }
        public string id { get; set; }
        public List<string> tags { get; set; }
    }

    public class ComplianceIssue
    {
        public string text { get; set; }
        public int id { get; set; }
        public string severity { get; set; }
        public int cvss { get; set; }
        public string status { get; set; }
        public string cve { get; set; }
        public string cause { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public string vecStr { get; set; }
        public string exploit { get; set; }
        public object riskFactors { get; set; }
        public string link { get; set; }
        public string type { get; set; }
        public string packageName { get; set; }
        public string packageVersion { get; set; }
        public int layerTime { get; set; }
        public List<object> templates { get; set; }
        public bool twistlock { get; set; }
        public int published { get; set; }
        public DateTime discovered { get; set; }
    }

    public class AllCompliance
    {
    }

    public class AttackVectorNetwork
    {
    }

    public class RecentVulnerability
    {
    }

    public class AttackComplexityLow
    {
    }

    public class DoS
    {
    }

    public class MediumSeverity
    {
    }

    public class HighSeverity
    {
    }

    public class PackageInUse
    {
    }

    public class ExploitExists
    {
    }

    public class CriticalSeverity
    {
    }

    public class HasFix
    {
    }

    public class RemoteExecution
    {
    }

    public class RiskFactors
    {
        [JsonProperty("Attack vector: network")]
        public AttackVectorNetwork AttackVectorNetwork { get; set; }

        [JsonProperty("Recent vulnerability")]
        public RecentVulnerability RecentVulnerability { get; set; }

        [JsonProperty("Attack complexity: low")]
        public AttackComplexityLow AttackComplexityLow { get; set; }

        public DoS DoS { get; set; }
        [JsonProperty("Medium severity")]

        public MediumSeverity MediumSeverity { get; set; }

        [JsonProperty("High severity")]
        public HighSeverity HighSeverity { get; set; }

        [JsonProperty("Package in use")]
        public PackageInUse PackageInUse { get; set; }

        [JsonProperty("Exploit exists")]
        public ExploitExists ExploitExists { get; set; }

        [JsonProperty("Critical severity")]
        public CriticalSeverity CriticalSeverity { get; set; }

        [JsonProperty("Has fix")]
        public HasFix HasFix { get; set; }

        [JsonProperty("Remote execution")]
        public RemoteExecution RemoteExecution { get; set; }
    }

    public class Vulnerability
    {
        public string text { get; set; }
        public int id { get; set; }
        public string severity { get; set; }
        public double cvss { get; set; }
        public string status { get; set; }
        public string cve { get; set; }
        public string cause { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public string vecStr { get; set; }
        public string exploit { get; set; }
        public RiskFactors riskFactors { get; set; }
        public string link { get; set; }
        public string type { get; set; }
        public string packageName { get; set; }
        public string packageVersion { get; set; }
        public int layerTime { get; set; }
        public object templates { get; set; }
        public bool twistlock { get; set; }
        public int published { get; set; }
        public List<string> applicableRules { get; set; }
        public DateTime discovered { get; set; }
        public List<string> binaryPkgs { get; set; }
    }

    public class RepoTag
    {
        public string registry { get; set; }
        public string repo { get; set; }
        public string tag { get; set; }
    }

    public class Tag
    {
        public string registry { get; set; }
        public string repo { get; set; }
        public string tag { get; set; }
    }

    public class VulnerabilityDistribution
    {
        public int critical { get; set; }
        public int high { get; set; }
        public int medium { get; set; }
        public int low { get; set; }
        public int total { get; set; }
    }

    public class ComplianceDistribution
    {
        public int critical { get; set; }
        public int high { get; set; }
        public int medium { get; set; }
        public int low { get; set; }
        public int total { get; set; }
    }

    public class AttackComplexityLow2
    {
    }

    public class AttackVectorNetwork2
    {
    }

    public class CriticalSeverity2
    {
    }

    public class DoS2
    {
    }

    public class ExploitExists2
    {
    }

    public class HasFix2
    {
    }

    public class HighSeverity2
    {
    }

    public class MediumSeverity2
    {
    }

    public class PackageInUse2
    {
    }

    public class RecentVulnerability2
    {
    }

    public class RemoteExecution2
    {
    }

    public class RiskFactors2
    {
        [JsonProperty("Attack complexity: low")]
        public AttackComplexityLow2 AttackComplexityLow { get; set; }
        [JsonProperty("Attack vector: network")]
        public AttackVectorNetwork2 AttackVectorNetwork { get; set; }
        [JsonProperty("Critical severity")]
        public CriticalSeverity2 CriticalSeverity { get; set; }
        public DoS2 DoS { get; set; }
        [JsonProperty("Exploit exists")]
        public ExploitExists2 ExploitExists { get; set; }
        [JsonProperty("Has fix")]
        public HasFix2 HasFix { get; set; }
        [JsonProperty("High severity")]
        public HighSeverity2 HighSeverity { get; set; }
        [JsonProperty("Medium severity")]
        public MediumSeverity2 MediumSeverity { get; set; }
        [JsonProperty("Package in use")]
        public PackageInUse2 PackageInUse { get; set; }
        [JsonProperty("Recent vulnerability")]
        public RecentVulnerability2 RecentVulnerability { get; set; }
        [JsonProperty("Remote execution")]
        public RemoteExecution2 RemoteExecution { get; set; }
    }

    public class InstalledProducts
    {
        public string docker { get; set; }
        public bool hasPackageManager { get; set; }
    }

    public class Trust
    {
        public string status { get; set; }
        public string reason { get; set; }
    }

    public class Instance
    {
        public string image { get; set; }
        public string host { get; set; }
        public DateTime modified { get; set; }
        public string tag { get; set; }
        public string repo { get; set; }
        public string registry { get; set; }
    }

    public class EntityInfo
    {
        public string _id { get; set; }
        public string hostname { get; set; }
        public DateTime scanTime { get; set; }
        public List<Binary> binaries { get; set; }
        public List<string> Secrets { get; set; }
        public List<StartupBinary> startupBinaries { get; set; }
        public string osDistro { get; set; }
        public string osDistroRelease { get; set; }
        public string distro { get; set; }
        public List<Package> packages { get; set; }
        public List<object> files { get; set; }
        public bool packageManager { get; set; }
        public Image image { get; set; }
        public List<History> history { get; set; }
        public string id { get; set; }
        public List<ComplianceIssue> complianceIssues { get; set; }
        public AllCompliance allCompliance { get; set; }
        public List<Vulnerability> vulnerabilities { get; set; }
        public RepoTag repoTag { get; set; }
        public List<Tag> tags { get; set; }
        public List<string> repoDigests { get; set; }
        public DateTime creationTime { get; set; }
        public int vulnerabilitiesCount { get; set; }
        public int complianceIssuesCount { get; set; }
        public VulnerabilityDistribution vulnerabilityDistribution { get; set; }
        public ComplianceDistribution complianceDistribution { get; set; }
        public int vulnerabilityRiskScore { get; set; }
        public int complianceRiskScore { get; set; }
        public List<string> layers { get; set; }
        public string topLayer { get; set; }
        public RiskFactors2 riskFactors { get; set; }
        public List<string> labels { get; set; }
        public InstalledProducts installedProducts { get; set; }
        public string scanVersion { get; set; }
        public DateTime firstScanTime { get; set; }
        public Trust trust { get; set; }
        public List<Instance> instances { get; set; }
        public string err { get; set; }
        public List<string> collections { get; set; }
        public int scanID { get; set; }
    }

    public class RootObject
    {
        public EntityInfo entityInfo { get; set; }
        public string _id { get; set; }
        public DateTime time { get; set; }
        public bool pass { get; set; }
        public string version { get; set; }
    }
}
