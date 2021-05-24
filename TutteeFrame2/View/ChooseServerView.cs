using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.Utils;

namespace TutteeFrame2.View
{
    public partial class ChooseServerView : Form
    {
        public bool updated = false;
        public ChooseServerView()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            txtServer.Text = ServerSettings.Instance.ServerName;
            txtPort.Text = ServerSettings.Instance.Port.ToString();
            txtAccount.Text = ServerSettings.Instance.UserID;
            txtPassword.Text = ServerSettings.Instance.Password;
            txtConnectionString.Text = AppSettings.Instance.LocalConnectionString;
            if (AppSettings.Instance.ConnectionType == DataAccess.ConnectionType.Server)
            {
                rbtnServer.Checked = true;

            }
            else
            {
                rbtnLocal.Checked = true;
            }

        }
        private void OnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnConnectionTypeChanged(object sender, EventArgs e)
        {
            if (rbtnLocal.Checked)
            {
                txtServer.Enabled = txtPort.Enabled = txtAccount.Enabled = txtPassword.Enabled = false;
                txtConnectionString.Enabled = true;
            }    
            else
            {
                txtServer.Enabled = txtPort.Enabled = txtAccount.Enabled = txtPassword.Enabled = true;
                txtConnectionString.Enabled = false;
            }    
        }

        private void DigitOnly(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtPort.Text, out int result))
                txtPort.RaiseError("Vui lòng chỉ nhập số!");
            else
                txtPort.RemoveError();
        }

        private void OnSubmit(object sender, EventArgs e)
        {
            if (rbtnLocal.Checked)
            {
                AppSettings.Instance.ConnectionType = DataAccess.ConnectionType.Local;
                AppSettings.Instance.LocalConnectionString = txtConnectionString.Text;
            }
            else
            {
                if (txtPort.hasError)
                {
                    txtPort.Focus();
                    return;
                }
                AppSettings.Instance.ConnectionType = DataAccess.ConnectionType.Server;
                ServerSettings.Instance.ServerName = txtServer.Text;
                ServerSettings.Instance.Port = Int32.Parse(txtPort.Text);
                ServerSettings.Instance.UserID = txtAccount.Text;
                ServerSettings.Instance.Password = txtPassword.Text;
            }
            updated = true;
            AppSettings.Instance.Save();
            ServerSettings.Instance.Save();
            this.Close();
        }

        private void OnServerClicked(object sender, EventArgs e)
        {
            rbtnServer.Checked = !rbtnServer.Checked;
        }

        private void OnLocalClicked(object sender, EventArgs e)
        {
            rbtnLocal.Checked = !rbtnLocal.Checked;
        }
    }
}
