using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;

using Amazon;
using Amazon.S3;
using Amazon.S3.Model;

namespace Clouder.Model
{
    class MainModel : ClouderClient
    {
        public int num = 0;

        public ClouderClient client = new ClouderClient();
    }

    internal class ClouderClient
    {
        public string ID { get; set; }
        private string UserGuid;
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        private AmazonS3Client client;

        public ClouderClient()
        {
            ID = "";
            UserGuid = "";
            name = "";
            email = "";
            password = "";

            SetUserGuid("");
        }

        private void SetUserGuid(string guid)
        {
            this.UserGuid = guid;
        }

        public string GetUserGuid()
        {
            return UserGuid;
        }

        public AmazonS3Client GetCloudClient()
        {
            return client;
        }
    }

    internal class Core : ClouderClient
    {
        public Dictionary<string, string> StandbyList;
        public Dictionary<string, string> UploadList;
        private FileSystemWatcher watcher;

        public Core()
        {
            watcher = new();
            StandbyList = new();
            UploadList = new();
            watcher.EnableRaisingEvents = true;
        }

        public string Test()
        {
            StandbyList.Clear();
            return "";
        }

        public async Task UploadAsync(KeyValuePair<string, string> target)
        {

        }

        public async Task<List<string>> GetObjectsAsync()
        {
            GetObjectRequest request = new()
            {

            };
            GetObjectResponse response = await GetCloudClient().GetObjectAsync(request);
            return new List<string>();
        }
    }
}
