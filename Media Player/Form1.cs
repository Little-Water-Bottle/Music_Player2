using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Windows.Forms;

namespace Media_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] paths, files;
        static int Startindex = -1;
        static int countBefor = 0;
        ArrayList FileName = new ArrayList();
        ArrayList FilePath = new ArrayList();
        //static string[] FilePath = new string[100];    //最多可以存储100首歌曲
        Boolean playnext = false;

        bool _playing = false;

        public bool isplaying
        {
            get
            {
                return _playing;
            }
            set
            {
                _playing = value;
                if (_playing)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause(); actionbtn.Image = play.Image;
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play(); actionbtn.Image = pause.Image;
                }
            }
        }

        int _model = 0; //歌曲播放模式
        bool flag = true;    //防止多次进入标志
        public int whatModel
        {
            get
            {
                
                return _model;
            }
            set
            {
                switch(_model)
                {
                    case 0: Model.Image = Sequence.Image; break;
                    case 1: Model.Image = Random.Image; break; 
                    case 2: Model.Image = SingleCycle.Image; break;
                    default: break;
                }
            }
        }


        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Startindex = 0;
            playnext = false;
            StopPlayer();

        }

        public void StopPlayer()
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        public void playfile(int playlistindex)
        {
            if(listBox1.Items.Count <=0)
            {
                return;
            }
            if(playlistindex < 0)
            {
                return;
            }
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.URL =FilePath[playlistindex].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.next();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            if (listBox1.Text == "")
            {
                listBox1.Text = FileName[playlistindex].ToString(); //由于第一次添加歌曲时 listBox1.Text为空，所以手动给其赋值
            }
            bunifuCustomLabel3.Text = listBox1.Text;
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Startindex = listBox1.SelectedIndex;
            playfile(Startindex);
            //bunifuCustomLabel3.Text = listBox1.Text;
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            //Startindex = 0;
            playnext = false;
            OpenFileDialog opnFileDlg = new OpenFileDialog();
            opnFileDlg.Multiselect = true;
            opnFileDlg.Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv)|*.mp3;*.wav;*.pm4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg|all files|*.*";
            
            if (opnFileDlg.ShowDialog()==DialogResult.OK)
            {
                //string[] temp = new string[10];
                //temp = opnFileDlg.SafeFileNames;
                foreach (string s in opnFileDlg.SafeFileNames)
                {
                   //string[] ss = new string(s);
                    FileName.Add(s.ToString());
                }
                foreach (string s in opnFileDlg.FileNames)
                {
                    FilePath.Add(s.ToString());
                }
                //FileName.Add(opnFileDlg.SafeFileNames);
                //FilePath.Add(opnFileDlg.FileNames);
                
                for (int i = 0; i <= FileName.Count-countBefor-1; i++)
                {
                    listBox1.Items.Add(FileName[i+ countBefor]);
                    Startindex +=1; //最后一首歌的下标
                    
                }
                countBefor = FileName.Count;
                listBox1.SelectedIndex = FileName.Count-1;    //移动指针到最后一行位置
                //Startindex = 0;
                playfile(Startindex);
                
            }
        }

        private void btnsong_Click(object sender, EventArgs e)
        {
            listBox1.BringToFront();
        }

        private void btnnowplay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.BringToFront();
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = bunifuSlider1.Value;
            bunifuCustomLabel4.Text = bunifuSlider1.Value.ToString();
        }

        private void play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        public EventHandler onActon = null;
        private void actionbtn_Click(object sender, EventArgs e)
        {
            isplaying = !isplaying;
            if(onActon != null)
            {
                onActon.Invoke(this, e);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (Startindex == listBox1.Items.Count - 1)
            {
                Startindex = listBox1.Items.Count - 1;
            }
            else if(Startindex < listBox1.Items.Count)
            {
                Startindex = Startindex + 1;
                listBox1.SelectedIndex += 1;    //移动指针到指定位置
            }
            
            playfile(Startindex);
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if(Startindex >0)
            {
                Startindex = Startindex - 1;
                listBox1.SelectedIndex -= 1;    //移动指针到指定位置
            }
            
            playfile(Startindex);
        }
          
        private void axWindowsMediaPlayer1_Enter(object sender,EventArgs e)
        {

        }
        //Timer timer1 = new Timer();
        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            bunifuCustomLabel2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
            if(axWindowsMediaPlayer1.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                bunifuProgressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
            if(bunifuProgressBar1.MaximumValue- bunifuProgressBar1.Value<=1 /*&& flag == true*/)
            {
                //flag = false;
                switch (_model)
                {
                    case 0:
                        Startindex = (Startindex + 1)% FileName.Count;
                        listBox1.SelectedIndex = Startindex;
                        break;   //顺序播放
                    case 1:
                        Random ran = new Random();
                        Startindex = ran.Next(FileName.Count-1); 
                        listBox1.SelectedIndex = Startindex;
                        break; //随机播放
                    case 2:  break;
                }
                playfile(Startindex);
                Thread.Sleep(200);
                // timer1.Interval = 10;

                //flag = true;
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                bunifuProgressBar1.MaximumValue = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                bunifuProgressBar1.Value = 0;
            }
        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            StopPlayer();
        }

        private void Sequence_Click(object sender, EventArgs e)
        {

        }

        private void Model_Click(object sender, EventArgs e)
        {
            _model = (_model + 1) % 3;
            whatModel = _model;
            if (onActon != null)
            {
                onActon.Invoke(this, e);
            }

        }

        private void bunifuCustomLabel4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
