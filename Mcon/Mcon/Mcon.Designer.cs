namespace Mcon
{
    partial class Mcon
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mcon));
            this.topBar = new Guna.UI2.WinForms.Guna2Panel();
            this.minimum = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maximum = new Guna.UI2.WinForms.Guna2ControlBox();
            this.close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.menuBar = new Guna.UI2.WinForms.Guna2Panel();
            this.setting = new Guna.UI2.WinForms.Guna2Button();
            this.home = new Guna.UI2.WinForms.Guna2Button();
            this.info = new Guna.UI2.WinForms.Guna2Button();
            this.menuString = new Guna.UI2.WinForms.Guna2Panel();
            this.topBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.topBar.Controls.Add(this.minimum);
            this.topBar.Controls.Add(this.maximum);
            this.topBar.Controls.Add(this.close);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.ShadowDecoration.Parent = this.topBar;
            this.topBar.Size = new System.Drawing.Size(800, 30);
            this.topBar.TabIndex = 0;
            // 
            // minimum
            // 
            this.minimum.BackColor = System.Drawing.Color.Transparent;
            this.minimum.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimum.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimum.FillColor = System.Drawing.Color.Transparent;
            this.minimum.HoverState.Parent = this.minimum;
            this.minimum.IconColor = System.Drawing.Color.White;
            this.minimum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimum.Location = new System.Drawing.Point(665, 0);
            this.minimum.Name = "minimum";
            this.minimum.ShadowDecoration.Parent = this.minimum;
            this.minimum.Size = new System.Drawing.Size(45, 30);
            this.minimum.TabIndex = 3;
            // 
            // maximum
            // 
            this.maximum.BackColor = System.Drawing.Color.Transparent;
            this.maximum.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maximum.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximum.FillColor = System.Drawing.Color.Transparent;
            this.maximum.HoverState.Parent = this.maximum;
            this.maximum.IconColor = System.Drawing.Color.White;
            this.maximum.Location = new System.Drawing.Point(710, 0);
            this.maximum.Name = "maximum";
            this.maximum.ShadowDecoration.Parent = this.maximum;
            this.maximum.Size = new System.Drawing.Size(45, 30);
            this.maximum.TabIndex = 2;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FillColor = System.Drawing.Color.Transparent;
            this.close.HoverState.Parent = this.close;
            this.close.IconColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(755, 0);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(45, 30);
            this.close.TabIndex = 1;
            // 
            // Drag
            // 
            this.Drag.TargetControl = this.topBar;
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.menuBar.Controls.Add(this.menuString);
            this.menuBar.Controls.Add(this.info);
            this.menuBar.Controls.Add(this.home);
            this.menuBar.Controls.Add(this.setting);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuBar.Location = new System.Drawing.Point(0, 30);
            this.menuBar.Name = "menuBar";
            this.menuBar.ShadowDecoration.Parent = this.menuBar;
            this.menuBar.Size = new System.Drawing.Size(84, 420);
            this.menuBar.TabIndex = 0;
            // 
            // setting
            // 
            this.setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("setting.BackgroundImage")));
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.setting.BorderColor = System.Drawing.Color.Transparent;
            this.setting.CheckedState.Parent = this.setting;
            this.setting.CustomImages.Parent = this.setting;
            this.setting.FillColor = System.Drawing.Color.Transparent;
            this.setting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.setting.ForeColor = System.Drawing.Color.White;
            this.setting.HoverState.Parent = this.setting;
            this.setting.Location = new System.Drawing.Point(25, 101);
            this.setting.Name = "setting";
            this.setting.PressedColor = System.Drawing.Color.Transparent;
            this.setting.ShadowDecoration.Parent = this.setting;
            this.setting.Size = new System.Drawing.Size(30, 30);
            this.setting.TabIndex = 1;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // home
            // 
            this.home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home.BackgroundImage")));
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.home.CheckedState.Parent = this.home;
            this.home.CustomImages.Parent = this.home;
            this.home.FillColor = System.Drawing.Color.Transparent;
            this.home.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.HoverState.Parent = this.home;
            this.home.Location = new System.Drawing.Point(25, 178);
            this.home.Name = "home";
            this.home.ShadowDecoration.Parent = this.home;
            this.home.Size = new System.Drawing.Size(30, 30);
            this.home.TabIndex = 2;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // info
            // 
            this.info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("info.BackgroundImage")));
            this.info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.info.CheckedState.Parent = this.info;
            this.info.CustomImages.Parent = this.info;
            this.info.FillColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.HoverState.Parent = this.info;
            this.info.Location = new System.Drawing.Point(25, 254);
            this.info.Name = "info";
            this.info.ShadowDecoration.Parent = this.info;
            this.info.Size = new System.Drawing.Size(30, 30);
            this.info.TabIndex = 3;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // menuString
            // 
            this.menuString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(215)))));
            this.menuString.Location = new System.Drawing.Point(0, 90);
            this.menuString.Name = "menuString";
            this.menuString.ShadowDecoration.Parent = this.menuString;
            this.menuString.Size = new System.Drawing.Size(5, 54);
            this.menuString.TabIndex = 4;
            // 
            // Mcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mcon";
            this.Text = "Mcon";
            this.Load += new System.EventHandler(this.Mcon_Load);
            this.topBar.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel topBar;
        private Guna.UI2.WinForms.Guna2ShadowForm Shadow;
        private Guna.UI2.WinForms.Guna2DragControl Drag;
        private Guna.UI2.WinForms.Guna2Panel menuBar;
        private Guna.UI2.WinForms.Guna2ControlBox close;
        private Guna.UI2.WinForms.Guna2ControlBox minimum;
        private Guna.UI2.WinForms.Guna2ControlBox maximum;
        private Guna.UI2.WinForms.Guna2Button setting;
        private Guna.UI2.WinForms.Guna2Button info;
        private Guna.UI2.WinForms.Guna2Button home;
        private Guna.UI2.WinForms.Guna2Panel menuString;
    }
}

