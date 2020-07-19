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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.topBar = new Guna.UI2.WinForms.Guna2Panel();
            this.minimum = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maximum = new Guna.UI2.WinForms.Guna2ControlBox();
            this.close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.menuBar = new Guna.UI2.WinForms.Guna2Panel();
            this.menuString = new Guna.UI2.WinForms.Guna2Panel();
            this.info = new Guna.UI2.WinForms.Guna2Button();
            this.home = new Guna.UI2.WinForms.Guna2Button();
            this.setting = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ThemaSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.title = new System.Windows.Forms.Label();
            this.subTitle = new System.Windows.Forms.Label();
            this.Program = new System.Windows.Forms.ListBox();
            this.timeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.topBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeChart)).BeginInit();
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
            this.menuBar.Size = new System.Drawing.Size(54, 420);
            this.menuBar.TabIndex = 0;
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
            // info
            // 
            this.info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("info.BackgroundImage")));
            this.info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.info.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.info.CheckedState.Parent = this.info;
            this.info.CustomImages.Parent = this.info;
            this.info.FillColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.HoverState.Parent = this.info;
            this.info.Location = new System.Drawing.Point(15, 181);
            this.info.Name = "info";
            this.info.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.info.ShadowDecoration.Parent = this.info;
            this.info.Size = new System.Drawing.Size(25, 25);
            this.info.TabIndex = 3;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // home
            // 
            this.home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home.BackgroundImage")));
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.home.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.home.CheckedState.Parent = this.home;
            this.home.CustomImages.Parent = this.home;
            this.home.FillColor = System.Drawing.Color.Transparent;
            this.home.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.HoverState.Parent = this.home;
            this.home.Location = new System.Drawing.Point(15, 108);
            this.home.Name = "home";
            this.home.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.home.ShadowDecoration.Parent = this.home;
            this.home.Size = new System.Drawing.Size(25, 25);
            this.home.TabIndex = 2;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // setting
            // 
            this.setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("setting.BackgroundImage")));
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.setting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.setting.CheckedState.Parent = this.setting;
            this.setting.CustomImages.Parent = this.setting;
            this.setting.FillColor = System.Drawing.Color.Transparent;
            this.setting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.setting.ForeColor = System.Drawing.Color.White;
            this.setting.HoverState.Parent = this.setting;
            this.setting.Location = new System.Drawing.Point(15, 257);
            this.setting.Name = "setting";
            this.setting.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.setting.ShadowDecoration.Parent = this.setting;
            this.setting.Size = new System.Drawing.Size(25, 25);
            this.setting.TabIndex = 1;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderRadius = 30;
            this.mainPanel.Controls.Add(this.timeChart);
            this.mainPanel.Controls.Add(this.Program);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.ThemaSwitch);
            this.mainPanel.CustomBorderThickness = new System.Windows.Forms.Padding(100);
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.mainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.mainPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.mainPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.mainPanel.Location = new System.Drawing.Point(81, 120);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.BorderRadius = 12;
            this.mainPanel.ShadowDecoration.Depth = 10;
            this.mainPanel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(100);
            this.mainPanel.Size = new System.Drawing.Size(691, 304);
            this.mainPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // ThemaSwitch
            // 
            this.ThemaSwitch.Animated = true;
            this.ThemaSwitch.AutoRoundedCorners = true;
            this.ThemaSwitch.Checked = true;
            this.ThemaSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ThemaSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ThemaSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ThemaSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ThemaSwitch.CheckedState.Parent = this.ThemaSwitch;
            this.ThemaSwitch.Location = new System.Drawing.Point(619, 18);
            this.ThemaSwitch.Name = "ThemaSwitch";
            this.ThemaSwitch.ShadowDecoration.Parent = this.ThemaSwitch;
            this.ThemaSwitch.Size = new System.Drawing.Size(55, 20);
            this.ThemaSwitch.TabIndex = 4;
            this.ThemaSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ThemaSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ThemaSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ThemaSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ThemaSwitch.UncheckedState.Parent = this.ThemaSwitch;
            this.ThemaSwitch.CheckedChanged += new System.EventHandler(this.ThemaSwitch_CheckedChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(73, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(91, 50);
            this.title.TabIndex = 2;
            this.title.Text = "Title";
            // 
            // subTitle
            // 
            this.subTitle.AutoSize = true;
            this.subTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitle.ForeColor = System.Drawing.Color.White;
            this.subTitle.Location = new System.Drawing.Point(77, 83);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(80, 25);
            this.subTitle.TabIndex = 3;
            this.subTitle.Text = "SubTitle";
            // 
            // Program
            // 
            this.Program.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.Program.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Program.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Program.ForeColor = System.Drawing.Color.White;
            this.Program.FormattingEnabled = true;
            this.Program.ItemHeight = 21;
            this.Program.Location = new System.Drawing.Point(7, 41);
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(667, 252);
            this.Program.TabIndex = 5;
            // 
            // timeChart
            // 
            this.timeChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.timeChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            chartArea1.Name = "ChartArea1";
            this.timeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.timeChart.Legends.Add(legend1);
            this.timeChart.Location = new System.Drawing.Point(441, 55);
            this.timeChart.Name = "timeChart";
            this.timeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.timeChart.Size = new System.Drawing.Size(247, 238);
            this.timeChart.TabIndex = 6;
            this.timeChart.Text = "chart1";
            // 
            // Mcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mcon";
            this.Text = "Mcon";
            this.Load += new System.EventHandler(this.Mcon_Load);
            this.topBar.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label subTitle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ThemaSwitch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel mainPanel;
        private System.Windows.Forms.ListBox Program;
        private System.Windows.Forms.DataVisualization.Charting.Chart timeChart;
    }
}

