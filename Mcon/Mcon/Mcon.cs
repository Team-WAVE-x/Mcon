using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mcon
{
    public partial class Mcon : Form
    {
        public Mcon()
        {
            InitializeComponent();
        }

        private void Mcon_Load(object sender, EventArgs e)
        {
            Shadow.SetShadowForm(this);

            menuString.Location = new Point(0, 170);

            ChageMenu("Home", true);
            ChageMenu("Setting", false);
            ChageMenu("Info", false);
        }

        private void setting_Click(object sender, EventArgs e)
        {
            menuString.Location = new Point(0, 90);

            ChageMenu("Home", false);
            ChageMenu("Setting", true);
            ChageMenu("Info", false);
        }

        private void home_Click(object sender, EventArgs e)
        {
            menuString.Location = new Point(0, 170);

            ChageMenu("Home", true);
            ChageMenu("Setting", false);
            ChageMenu("Info", false);
        }

        private void info_Click(object sender, EventArgs e)
        {
            menuString.Location = new Point(0, 245);

            ChageMenu("Home", false);
            ChageMenu("Setting", false);
            ChageMenu("Info", true);
        }

        private void ChageMenu(string menu, bool visible)
        {
            switch (menu)
            {
                case "Home":
                    if (visible)
                    {
                        home.BackgroundImage = Image.FromFile("Image/homeBlue.png");
                        setting.BackgroundImage = Image.FromFile("Image/setting.png");
                        info.BackgroundImage = Image.FromFile("Image/info.png");
                    }
                    break;

                case "Setting":
                    if (visible)
                    {
                        home.BackgroundImage = Image.FromFile("Image/home.png");
                        setting.BackgroundImage = Image.FromFile("Image/settingBlue.png");
                        info.BackgroundImage = Image.FromFile("Image/info.png");
                    }
                    break;

                case "Info":
                    if (visible)
                    {
                        home.BackgroundImage = Image.FromFile("Image/home.png");
                        setting.BackgroundImage = Image.FromFile("Image/setting.png");
                        info.BackgroundImage = Image.FromFile("Image/infoBlue.png");
                    }
                    break;
            }
        }

    }
}
