using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame2.DataAccess;
using Newtonsoft.Json;
using System.IO;

namespace TutteeFrame2.Utils
{
    class ServerSettings
    {
        private ServerSettings() { }

        static readonly ServerSettings instance = new ServerSettings();
        public static ServerSettings Instance => instance;

        const string FILE_NAME = "server.json";
        public string ServerName { get; set; }
        public int Port { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public void Set(ServerSettings serverSettings)
        {
            this.ServerName = serverSettings.ServerName;
            this.Port = serverSettings.Port;
            this.UserID = serverSettings.UserID;
            this.Password = serverSettings.Password;
        }

        public void Create()
        {
            this.ServerName = "PRINC3-LAPTOP";
            this.Port = 49172;
            this.UserID = "princ3od";
            this.Password = "";
            Save();
        }
        public void Get()
        {
            if (File.Exists(FILE_NAME))
            {
                string data = File.ReadAllText(FILE_NAME);
                Set(JsonConvert.DeserializeObject<ServerSettings>(data));
            }
            else
                Create();
        }
        public void Save()
        {
            string data = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(FILE_NAME, data);
        }
    }
    class AppSettings
    {

        private AppSettings() { }

        static readonly AppSettings instance = new AppSettings();
        public static AppSettings Instance => instance;

        const string FILE_NAME = "settings.json";
        public string LastID { get; set; }
        public string LastPassword { get; set; }
        public bool RememberMe { get; set; }
        public ConnectionType ConnectionType { get; set; }
        public string ServerConnectionString { get; set; }
        public string LocalConnectionString { get; set; }
        public void Set(AppSettings appSettings)
        {
            this.LastID = appSettings.LastID;
            this.LastPassword = appSettings.LastPassword;
            this.RememberMe = appSettings.RememberMe;
            this.ConnectionType = appSettings.ConnectionType;
            this.ServerConnectionString = appSettings.ServerConnectionString;
            this.LocalConnectionString = appSettings.LocalConnectionString;
        }

        public void Create()
        {
            LastID = "";
            LastPassword = "";
            RememberMe = false;
            ConnectionType = ConnectionType.Local;
            ServerConnectionString = "Server = {0},{1};Initial Catalog = TutteeFrame;User ID = {2};Password = {3};Integrated Security = False;Connect Timeout = 20; MultipleActiveResultSets = True; ";
            LocalConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TutteeFrame;Integrated Security=True";
            Save();
        }
        public void Get()
        {
            if (File.Exists(FILE_NAME))
            {
                string data = File.ReadAllText(FILE_NAME);
                Set(JsonConvert.DeserializeObject<AppSettings>(data));
            }
            else
                Create();
        }
        public void Save()
        {
            string data = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(FILE_NAME, data);
        }
    }
}
