namespace Media_Player
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SingleCycle = new Bunifu.Framework.UI.BunifuImageButton();
            this.Random = new Bunifu.Framework.UI.BunifuImageButton();
            this.Sequence = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnstop = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.actionbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnprevious = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnnext = new Bunifu.Framework.UI.BunifuImageButton();
            this.play = new Bunifu.Framework.UI.BunifuImageButton();
            this.pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnbrowse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnnowplay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnminimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnmax = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.Model = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SingleCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Random)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sequence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnstop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Model)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(111)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.Model);
            this.panel1.Controls.Add(this.Sequence);
            this.panel1.Controls.Add(this.SingleCycle);
            this.panel1.Controls.Add(this.btnstop);
            this.panel1.Controls.Add(this.bunifuImageButton4);
            this.panel1.Controls.Add(this.actionbtn);
            this.panel1.Controls.Add(this.btnprevious);
            this.panel1.Controls.Add(this.btnnext);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuSlider1);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuProgressBar1);
            this.panel1.Controls.Add(this.play);
            this.panel1.Controls.Add(this.pause);
            this.panel1.Controls.Add(this.Random);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(323, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 203);
            this.panel1.TabIndex = 1;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(757, 149);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(43, 23);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "100";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click_1);
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.White;
            this.bunifuSlider1.BorderRadius = 10;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSlider1.Location = new System.Drawing.Point(566, 149);
            this.bunifuSlider1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(184, 38);
            this.bunifuSlider1.TabIndex = 2;
            this.bunifuSlider1.Value = 100;
            this.bunifuSlider1.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(6, 77);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(148, 28);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Song Name";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(739, 30);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(48, 23);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "0.00";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(48, 23);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "0.00";
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.White;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(0, 4);
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Red;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(795, 22);
            this.bunifuProgressBar1.TabIndex = 0;
            this.bunifuProgressBar1.Value = 0;
            this.bunifuProgressBar1.progressChanged += new System.EventHandler(this.bunifuProgressBar1_progressChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(323, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(799, 531);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(323, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(799, 531);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SingleCycle
            // 
            this.SingleCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleCycle.BackColor = System.Drawing.Color.Transparent;
            this.SingleCycle.Image = global::Media_Player.Properties.Resources.单曲循环;
            this.SingleCycle.ImageActive = null;
            this.SingleCycle.Location = new System.Drawing.Point(78, 132);
            this.SingleCycle.Name = "SingleCycle";
            this.SingleCycle.Size = new System.Drawing.Size(75, 47);
            this.SingleCycle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SingleCycle.TabIndex = 16;
            this.SingleCycle.TabStop = false;
            this.SingleCycle.Zoom = 10;
            // 
            // Random
            // 
            this.Random.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Random.BackColor = System.Drawing.Color.Transparent;
            this.Random.Image = global::Media_Player.Properties.Resources.随机播放__1_;
            this.Random.ImageActive = null;
            this.Random.Location = new System.Drawing.Point(78, 132);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(64, 53);
            this.Random.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Random.TabIndex = 15;
            this.Random.TabStop = false;
            this.Random.Zoom = 10;
            // 
            // Sequence
            // 
            this.Sequence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sequence.BackColor = System.Drawing.Color.Transparent;
            this.Sequence.Image = global::Media_Player.Properties.Resources.顺序循环_;
            this.Sequence.ImageActive = null;
            this.Sequence.Location = new System.Drawing.Point(85, 137);
            this.Sequence.Name = "Sequence";
            this.Sequence.Size = new System.Drawing.Size(57, 42);
            this.Sequence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sequence.TabIndex = 14;
            this.Sequence.TabStop = false;
            this.Sequence.Zoom = 10;
            this.Sequence.Click += new System.EventHandler(this.Sequence_Click);
            // 
            // btnstop
            // 
            this.btnstop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnstop.BackColor = System.Drawing.Color.Transparent;
            this.btnstop.Image = global::Media_Player.Properties.Resources.tx_正方形;
            this.btnstop.ImageActive = null;
            this.btnstop.Location = new System.Drawing.Point(404, 142);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(57, 45);
            this.btnstop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnstop.TabIndex = 11;
            this.btnstop.TabStop = false;
            this.btnstop.Zoom = 10;
            this.btnstop.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = global::Media_Player.Properties.Resources.音量;
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(502, 142);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(57, 49);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 10;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // actionbtn
            // 
            this.actionbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actionbtn.BackColor = System.Drawing.Color.Transparent;
            this.actionbtn.Image = global::Media_Player.Properties.Resources.暂停;
            this.actionbtn.ImageActive = null;
            this.actionbtn.Location = new System.Drawing.Point(241, 114);
            this.actionbtn.Name = "actionbtn";
            this.actionbtn.Size = new System.Drawing.Size(84, 77);
            this.actionbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.actionbtn.TabIndex = 9;
            this.actionbtn.TabStop = false;
            this.actionbtn.Zoom = 10;
            this.actionbtn.Click += new System.EventHandler(this.actionbtn_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprevious.BackColor = System.Drawing.Color.Transparent;
            this.btnprevious.Image = global::Media_Player.Properties.Resources.Arrow_Left_Look_Control_256;
            this.btnprevious.ImageActive = null;
            this.btnprevious.Location = new System.Drawing.Point(168, 124);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(67, 63);
            this.btnprevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnprevious.TabIndex = 8;
            this.btnprevious.TabStop = false;
            this.btnprevious.Zoom = 10;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnnext
            // 
            this.btnnext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnext.BackColor = System.Drawing.Color.Transparent;
            this.btnnext.Image = global::Media_Player.Properties.Resources.Arrow_Right_Look_Control_512;
            this.btnnext.ImageActive = null;
            this.btnnext.Location = new System.Drawing.Point(331, 124);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(67, 63);
            this.btnnext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnnext.TabIndex = 7;
            this.btnnext.TabStop = false;
            this.btnnext.Zoom = 10;
            this.btnnext.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // play
            // 
            this.play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Image = global::Media_Player.Properties.Resources.播放;
            this.play.ImageActive = null;
            this.play.Location = new System.Drawing.Point(197, 136);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(38, 36);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play.TabIndex = 13;
            this.play.TabStop = false;
            this.play.Zoom = 10;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.Image = global::Media_Player.Properties.Resources.暂停;
            this.pause.ImageActive = null;
            this.pause.Location = new System.Drawing.Point(338, 136);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(38, 36);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pause.TabIndex = 12;
            this.pause.TabStop = false;
            this.pause.Zoom = 10;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnbrowse);
            this.bunifuGradientPanel1.Controls.Add(this.btnnowplay);
            this.bunifuGradientPanel1.Controls.Add(this.btnsong);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnminimize);
            this.bunifuGradientPanel1.Controls.Add(this.btnmax);
            this.bunifuGradientPanel1.Controls.Add(this.btnclose);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(323, 734);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnbrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnbrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnbrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbrowse.BorderRadius = 0;
            this.btnbrowse.ButtonText = "Browse Songs";
            this.btnbrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbrowse.DisabledColor = System.Drawing.Color.Gray;
            this.btnbrowse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnbrowse.Iconimage = global::Media_Player.Properties.Resources.resizeApi__2_;
            this.btnbrowse.Iconimage_right = null;
            this.btnbrowse.Iconimage_right_Selected = null;
            this.btnbrowse.Iconimage_Selected = null;
            this.btnbrowse.IconMarginLeft = 0;
            this.btnbrowse.IconMarginRight = 0;
            this.btnbrowse.IconRightVisible = true;
            this.btnbrowse.IconRightZoom = 0D;
            this.btnbrowse.IconVisible = true;
            this.btnbrowse.IconZoom = 90D;
            this.btnbrowse.IsTab = true;
            this.btnbrowse.Location = new System.Drawing.Point(0, 656);
            this.btnbrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Normalcolor = System.Drawing.Color.Transparent;
            this.btnbrowse.OnHovercolor = System.Drawing.Color.Red;
            this.btnbrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnbrowse.selected = false;
            this.btnbrowse.Size = new System.Drawing.Size(323, 74);
            this.btnbrowse.TabIndex = 6;
            this.btnbrowse.Text = "Browse Songs";
            this.btnbrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbrowse.Textcolor = System.Drawing.Color.White;
            this.btnbrowse.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // btnnowplay
            // 
            this.btnnowplay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnnowplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnnowplay.BackColor = System.Drawing.Color.Transparent;
            this.btnnowplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnowplay.BorderRadius = 0;
            this.btnnowplay.ButtonText = "Now Playing";
            this.btnnowplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnowplay.DisabledColor = System.Drawing.Color.Gray;
            this.btnnowplay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnnowplay.Iconimage = global::Media_Player.Properties.Resources.resizeApi__1_;
            this.btnnowplay.Iconimage_right = null;
            this.btnnowplay.Iconimage_right_Selected = null;
            this.btnnowplay.Iconimage_Selected = null;
            this.btnnowplay.IconMarginLeft = 0;
            this.btnnowplay.IconMarginRight = 0;
            this.btnnowplay.IconRightVisible = true;
            this.btnnowplay.IconRightZoom = 0D;
            this.btnnowplay.IconVisible = true;
            this.btnnowplay.IconZoom = 90D;
            this.btnnowplay.IsTab = true;
            this.btnnowplay.Location = new System.Drawing.Point(0, 574);
            this.btnnowplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnnowplay.Name = "btnnowplay";
            this.btnnowplay.Normalcolor = System.Drawing.Color.Transparent;
            this.btnnowplay.OnHovercolor = System.Drawing.Color.Red;
            this.btnnowplay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnnowplay.selected = false;
            this.btnnowplay.Size = new System.Drawing.Size(323, 74);
            this.btnnowplay.TabIndex = 5;
            this.btnnowplay.Text = "Now Playing";
            this.btnnowplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnowplay.Textcolor = System.Drawing.Color.White;
            this.btnnowplay.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnowplay.Click += new System.EventHandler(this.btnnowplay_Click);
            // 
            // btnsong
            // 
            this.btnsong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnsong.BackColor = System.Drawing.Color.Transparent;
            this.btnsong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsong.BorderRadius = 0;
            this.btnsong.ButtonText = "Playlist";
            this.btnsong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsong.DisabledColor = System.Drawing.Color.Gray;
            this.btnsong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsong.Iconimage = global::Media_Player.Properties.Resources.resizeApi;
            this.btnsong.Iconimage_right = null;
            this.btnsong.Iconimage_right_Selected = null;
            this.btnsong.Iconimage_Selected = null;
            this.btnsong.IconMarginLeft = 0;
            this.btnsong.IconMarginRight = 0;
            this.btnsong.IconRightVisible = true;
            this.btnsong.IconRightZoom = 0D;
            this.btnsong.IconVisible = true;
            this.btnsong.IconZoom = 80D;
            this.btnsong.IsTab = true;
            this.btnsong.Location = new System.Drawing.Point(0, 492);
            this.btnsong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsong.Name = "btnsong";
            this.btnsong.Normalcolor = System.Drawing.Color.Transparent;
            this.btnsong.OnHovercolor = System.Drawing.Color.Red;
            this.btnsong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsong.selected = false;
            this.btnsong.Size = new System.Drawing.Size(323, 74);
            this.btnsong.TabIndex = 4;
            this.btnsong.Text = "Playlist";
            this.btnsong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsong.Textcolor = System.Drawing.Color.White;
            this.btnsong.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsong.Click += new System.EventHandler(this.btnsong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Media_Player.Properties.Resources.卡通头像;
            this.pictureBox1.Location = new System.Drawing.Point(65, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.Transparent;
            this.btnminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimize.Image = global::Media_Player.Properties.Resources.最小化;
            this.btnminimize.ImageActive = null;
            this.btnminimize.Location = new System.Drawing.Point(105, 3);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(47, 36);
            this.btnminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimize.TabIndex = 2;
            this.btnminimize.TabStop = false;
            this.btnminimize.Zoom = 10;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnmax
            // 
            this.btnmax.BackColor = System.Drawing.Color.Transparent;
            this.btnmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmax.Image = global::Media_Player.Properties.Resources.全屏最大化;
            this.btnmax.ImageActive = null;
            this.btnmax.Location = new System.Drawing.Point(52, 3);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(47, 36);
            this.btnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmax.TabIndex = 1;
            this.btnmax.TabStop = false;
            this.btnmax.Zoom = 10;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Image = global::Media_Player.Properties.Resources.关闭;
            this.btnclose.ImageActive = null;
            this.btnclose.Location = new System.Drawing.Point(3, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(43, 36);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 0;
            this.btnclose.TabStop = false;
            this.btnclose.Zoom = 10;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Model
            // 
            this.Model.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Model.BackColor = System.Drawing.Color.Transparent;
            this.Model.Image = global::Media_Player.Properties.Resources.顺序循环_;
            this.Model.ImageActive = null;
            this.Model.Location = new System.Drawing.Point(78, 132);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(84, 55);
            this.Model.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Model.TabIndex = 17;
            this.Model.TabStop = false;
            this.Model.Zoom = 10;
            this.Model.Click += new System.EventHandler(this.Model_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 734);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SingleCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Random)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sequence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnstop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Model)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnminimize;
        private Bunifu.Framework.UI.BunifuImageButton btnmax;
        private Bunifu.Framework.UI.BunifuImageButton btnclose;
        private Bunifu.Framework.UI.BunifuFlatButton btnbrowse;
        private Bunifu.Framework.UI.BunifuFlatButton btnnowplay;
        private Bunifu.Framework.UI.BunifuFlatButton btnsong;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton actionbtn;
        private Bunifu.Framework.UI.BunifuImageButton btnprevious;
        private Bunifu.Framework.UI.BunifuImageButton btnnext;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private Bunifu.Framework.UI.BunifuImageButton btnstop;
        private Bunifu.Framework.UI.BunifuImageButton play;
        private Bunifu.Framework.UI.BunifuImageButton pause;
        private System.Windows.Forms.ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuImageButton Sequence;
        private Bunifu.Framework.UI.BunifuImageButton Random;
        private Bunifu.Framework.UI.BunifuImageButton SingleCycle;
        private Bunifu.Framework.UI.BunifuImageButton Model;
    }
}

