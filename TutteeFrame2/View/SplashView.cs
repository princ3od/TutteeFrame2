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
    public partial class SplashView : Form
    {
        public SplashView()
        {
            InitializeComponent();
        }
        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            System.IO.Stream stream = Properties.Resources.intro;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(stream);
            player.Play();
            await Task.Run(() =>
            {
                AppSettings.Instance.Get();
                ServerSettings.Instance.Get();
            });
            await Task.Delay(2500);
            this.Close();
        }
    }
}
