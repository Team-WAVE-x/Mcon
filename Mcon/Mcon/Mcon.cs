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

            menuString.Location = new Point(0, 90);

            ChageMenu("Home", true);
            ChageMenu("Setting", false);
            ChageMenu("Info", false);
        }

        //홈 화면
        private void home_Click(object sender, EventArgs e)
        {
            menuString.Location = new Point(0, 90);

            ChageMenu("Home", true);
            ChageMenu("Setting", false);
            ChageMenu("Info", false);
        }

        //info 화면
        private void info_Click(object sender, EventArgs e)
        {
            menuString.Location = new Point(0, 170);

            ChageMenu("Home", false);
            ChageMenu("Setting", false);
            ChageMenu("Info", true);
        }

        //설정 화면
        private void setting_Click(object sender, EventArgs e)
        {
            menuString.Location = new Point(0, 245);

            ChageMenu("Home", false);
            ChageMenu("Setting", true);
            ChageMenu("Info", false);
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

                        title.Text = "Home";
                        subTitle.Text = "홈이당";

                        label1.Text = "오늘 프로그램"; 
                    }
                    break;

                case "Setting":
                    if (visible)
                    {
                        home.BackgroundImage = Image.FromFile("Image/home.png");
                        setting.BackgroundImage = Image.FromFile("Image/settingBlue.png");
                        info.BackgroundImage = Image.FromFile("Image/info.png");


                        title.Text = "Setting";
                        subTitle.Text = "설정이당";

                        label1.Text = "다크 모드";
                    }

                    ThemaSwitch.Visible = visible;
                    break;

                case "Info":
                    if (visible)
                    {
                        home.BackgroundImage = Image.FromFile("Image/home.png");
                        setting.BackgroundImage = Image.FromFile("Image/setting.png");
                        info.BackgroundImage = Image.FromFile("Image/infoBlue.png");

                        title.Text = "Info";
                        subTitle.Text = "설명이당";

                        label1.Text = "Mcon 은 청소년 개발팀 웨이브에서 만든 프로그램 사용량 측정기입니다.";
                    }
                    break;
            }
        }

        private void ChangeThema(bool dark)
        {
            if (dark)
            {
                
            }
        }

    }
}
