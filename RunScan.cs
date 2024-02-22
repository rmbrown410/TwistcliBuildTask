namespace TwistcliBuildTask
{
    public class RunScan
    {
        public static void runScan(string token, string secretKey, string accessKeyId, string imageName)
        {
            string dir = System.IO.Directory.GetCurrentDirectory();
            string imageID = Commands.Bash($"docker images | grep -E '^'{imageName} | awk '{{print $3}}'");

            Commands.Bash($"sudo curl --progress -bar -L -k --header \"authorization: Bearer {token} \" https://us-west1.cloud.twistlock.com/us-3-159212111/api/v1/util/twistcli > {dir}/twistcli");
            Commands.Bash($"sudo chmod a+x {dir}/twistcli");
            Commands.Bash($"{dir}/twistcli images scan --ci --address https://us-west1.cloud.twistlock.com/us-3-159212111 --user {accessKeyId} --password {secretKey} --details {imageID}");
        }
    }
}
