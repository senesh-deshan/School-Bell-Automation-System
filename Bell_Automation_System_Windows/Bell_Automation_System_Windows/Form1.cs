using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Windows.;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Media;
using WMPLib;


namespace Bell_Automation_System_Windows
{

    public partial class Main_Form : Form
    {

        StreamWriter stsw;
        StreamReader stsr;
        StreamWriter spsw;
        StreamReader spsr;
        StreamWriter smsw;
        StreamReader smsr;
        StreamReader dtsr;

        String songs_path;
        DateTime Current_Date_Time;
        String Current_Time;
        String Current_Day;
        String Str_Time;
        String Stp_Time;
        String[] Times = new String[20];
        String[] Commands = new String[20];
        int esckeyCount;
        int skeyCount;

        SoundPlayer Bell_Up = new SoundPlayer("Audio\\Bell_Up.wav");
        SoundPlayer Bell_Down = new SoundPlayer("Audio\\Bell_Down.wav");
        SoundPlayer Bell_Up_Down = new SoundPlayer("Audio\\Bell_Up_Down.wav");
        SoundPlayer Fitness = new SoundPlayer("Audio\\Fitness.wav");
        SoundPlayer Interval = new SoundPlayer("Audio\\Interval.wav");
        SoundPlayer News = new SoundPlayer("Audio\\News.wav");
        SoundPlayer Nat_Ant = new SoundPlayer("Audio\\Nat_Ant.wav");
        SoundPlayer Scl_EN = new SoundPlayer("Audio\\Scl_EN.wav");
        SoundPlayer Scl_SI = new SoundPlayer("Audio\\Scl_SI.wav");
        Boolean User_Stop;
        int Song_No;
       

        public Main_Form()
        {
            InitializeComponent();

            Current_Date_Time = (DateTime.Now);
            Current_Time = Current_Date_Time.ToString("HH:mm:ss");
            Current_Day = Current_Date_Time.ToString("ddd");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Current_Date_Time = (DateTime.Now);
            
            Current_Time = Current_Date_Time.ToString("HH:mm:ss");
            Current_Day = Current_Date_Time.ToString("ddd");
            Time_Label.Text = " | "+Current_Date_Time.ToString("yyyy/MM/dd ") + Current_Day + " | " + Current_Time ;

            for (int i = 0; i < Times.Length;i++)
            {
                if(Current_Time.Equals(Times[i]))
                {
                    Data_ListBox.SelectedIndex = i;
                    play_sound(Commands[i]);
                    
                }
                
            }
            try
            {
                if ((axWindowsMediaPlayer.playState.ToString() != "wmppsPlaying") && Current_Date_Time > DateTime.ParseExact(Str_Time, "HH:mm:ss", CultureInfo.InvariantCulture) && Current_Date_Time < DateTime.ParseExact(Stp_Time, "HH:mm:ss", CultureInfo.InvariantCulture) && User_Stop == false)
                {
                    play_sound("Day_Songs");
                }
                if ((axWindowsMediaPlayer.playState.ToString() == "wmppsPlaying"))
                {
                    User_Stop = false;
                }
            }
            catch (ArgumentNullException)
            {
              
            }
        }

        void play_sound(String aud){
 
            try{

            if (aud.Equals("Bell_Up"))
            {
                Bell_Up.Play();

            }
            else if (aud == "Bell_Down")
            {
                Bell_Down.Play();

            }
            else if (aud == "Bell_Up_Down")
            {
                Bell_Up_Down.Play();

            }
            else if (aud == "Interval")
            {
                Interval.Play();

            }
            else if (aud == "Fitness")
            {
                Fitness.Play();

            }
            else if (aud == "News")
            {
                if (File.Exists("Audio\\News.wav"))
                {
                    News.Play();
                }

            }
            else if (aud == "Nat_Ant")
            {
                Nat_Ant.Play();

            }
            else if (aud == "Scl_EN")
            {
                Scl_EN.Play();

            }
            else if (aud == "Scl_SI")
            {
                Scl_SI.Play();

            }
            else if (aud == "Nat_Ant_or_Scl_EN")
            {
                if (Current_Day == "Mon")
                {
                    Nat_Ant.Play();
                }
                else
                {
                    Scl_EN.Play();
                }
            }

            }catch(Exception){
                Status_Label.Text = "ERROR occurred while playing  "+aud;
            }

            if (aud == "Day_Songs")
            {
                String[] Songs_list = Directory.GetFiles(songs_path);
                if (Song_No < Songs_list.Length)
                {
                    Song_No++;
                    
                }
                else if (Song_No >= Songs_list.Length)
                {
                    Song_No = 1;

                }
                if (Songs_list.Length == 0)
                {
                    Status_Label.Text= ("No songs in the songs folder.");
                }
                else
                {
                    try
                    {
                        string lin = Songs_list[Song_No - 1];
                        String[] tw = lin.Split('.');
                        if (tw[tw.Length - 1] == "mp3" || tw[tw.Length - 1] == "wav" || tw[tw.Length - 1] == "mp4" || tw[tw.Length - 1] == "avi")
                        {
                            
                            axWindowsMediaPlayer.URL = Songs_list[Song_No - 1];
                            Songs_ListBox.SelectedIndex = Song_No - 1;
                            Status_Label.Text = "Playing " + Songs_list[Song_No - 1];
                        }
                        else
                        {
                            Status_Label.Text = "Unsupported file detected... " + tw[tw.Length - 1];
                        }
                    }
                    catch (Exception)
                    {
                        play_sound("Day_Songs");
                    }
                }

                if (Song_No >= (Songs_list.Length - 20))
                {
                    Warning_Label.Visible = true;
                }
                else
                {
                    Warning_Label.Visible = false;
                }


            stsr = new StreamReader("Data\\Status_File.rccs");
            string ln = stsr.ReadLine();
            if (ln != null)
            {
                String[] tw = ln.Split('/');
                stsr.Close();
                stsw = new StreamWriter("Data\\Status_File.rccs");
                stsw.WriteLine(Song_No + "/" + tw[1]);
                stsw.Close();
                label4.Text = Song_No.ToString() + "/" + tw[1];

                
            }
            }

        }

        

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            Bell_Up.Stop();
            Bell_Down.Stop();
            Bell_Up_Down.Stop();
            Interval.Stop();
            Fitness.Stop();
            Nat_Ant.Stop();
            Scl_EN.Stop();
            Scl_SI.Stop();

            if ((axWindowsMediaPlayer.playState.ToString() == "wmppsPlaying"))
            {
                axWindowsMediaPlayer.Ctlcontrols.stop();
                User_Stop = true;
            }
        }

        private void Bell_Up_Btn_Click(object sender, EventArgs e)
        {
            play_sound("Bell_Up");
           
        }

        private void Bell_Down_Btn_Click(object sender, EventArgs e)
        {
            play_sound("Bell_Down");
           
        }

        private void Bell_Up_Down_Btn_Click(object sender, EventArgs e)
        {
            play_sound("Bell_Up_Down");

        }

        private void News_Btn_Click(object sender, EventArgs e)
        {

            play_sound("News");   
        
        }

        private void Fitness_Btn_Click(object sender, EventArgs e)
        {
            play_sound("Fitness");

        }

        private void Interval_Btn_Click(object sender, EventArgs e)
        {
            play_sound("Interval");
  
        }

        private void Nat_Ant_Btn_Click(object sender, EventArgs e)
        {
            play_sound("Nat_Ant");
         
        }

        private void Scl_EN_btn_Click(object sender, EventArgs e)
        {
            play_sound("Scl_EN");
          
        }

        private void Scl_SI_btn_Click(object sender, EventArgs e)
        {
            play_sound("Scl_SI");
    
        }


       

        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
                if (keyData == Keys.Escape)
                {
                    esckeyCount++;
                    if (esckeyCount == 10)
                    {
                        Songs_Browser.ShowDialog();

                        spsw = new StreamWriter("Data\\Songs_Path_File.rccs");
                        spsw.WriteLine(Songs_Browser.SelectedPath);
                        spsw.Close();

                        esckeyCount = 0;
                        songs_path = Songs_Browser.SelectedPath;
                        Songs_ListBox.Items.Clear();
                        String[] Songs_list = Directory.GetFiles(songs_path);
                        if (Songs_list.Length != 0)
                        {
                            for (int j = 0; j < Songs_list.Length; j++)
                            {

                                String[] sg = Songs_list[j].Split('\\');
                                Songs_ListBox.Items.Add(sg[sg.Length - 1]);

                            }
                        }

                        if (Songs_list.Length == 0)
                        {
                            MessageBox.Show("No songs in the songs folder.");
                        }
                        if (Song_No >= (Songs_list.Length - 20))
                        {
                            Warning_Label.Visible = true;
                        }
                        else
                        {
                            Warning_Label.Visible = false;
                        }


                    }
                }
                if (keyData == Keys.S)
                {
                    skeyCount++;
                    if (skeyCount == 10)
                    {
                        if(!File.Exists("Data\\Songs_Time.rccs")){
                            File.Create("Data\\Songs_Time.rccs").Close();
                        }

                        Str_Time = Start_Time.Text;
                        Stp_Time = Stop_Time.Text;

                        smsw = new StreamWriter("Data\\Songs_Time.rccs");
                        smsw.WriteLine(Str_Time);
                        smsw.WriteLine(Stp_Time);
                        smsw.Close();

                        Status_Label.Text = "Songs times were set.";

                        skeyCount = 0;
                    }
                }
                

                return base.ProcessCmdKey(ref msg, keyData);    
        }

        private void RCCS_Load(object sender, EventArgs e)
        {

            Current_Date_Time = (DateTime.Now);

            if (!File.Exists("Data\\Status_File.rccs"))
            {

                try
                {
                    Directory.CreateDirectory("Data");
                    File.Create("Data\\Status_File.rccs").Close(); ;


                }
                catch (Exception)
                {
                    Status_Label.Text = "ERROR in creating status file.";
                }

            }

            if (!File.Exists("Data\\Songs_Path_File.rccs"))
            {

                try
                {

                    File.Create("Data\\Songs_Path_File.rccs").Close();


                }
                catch (Exception)
                {
                    Status_Label.Text = "ERROR in creating Songs Path File file.";
                }

            }





            if (!File.Exists("Data\\Data_File.rccs"))
            {

                try
                {
                    File.Create("Data\\Data_File.rccs").Close();

                }
                catch (Exception)
                {
                    Status_Label.Text = "ERROR in creating data file.";
                }

            }

            if (!Directory.Exists("Audio"))
            {


                try
                {
                    Directory.CreateDirectory("Audio");

                }
                catch (Exception)
                {
                    Status_Label.Text = "ERROR in creating audio directory.";
                }
            }

            spsr = new StreamReader("Data\\Songs_Path_File.rccs");

            songs_path = spsr.ReadLine();

            spsr.Close();

            if (!Directory.Exists(songs_path))
            {

                Songs_Browser.ShowDialog();

                try
                {

                    spsw = new StreamWriter("Data\\Songs_Path_File.rccs");
                    spsw.WriteLine(Songs_Browser.SelectedPath);
                    spsw.Close();
                    songs_path = Songs_Browser.SelectedPath;

                }
                catch (Exception)
                {
                    Status_Label.Text = "ERROR in creating songs directory.";
                }
            }




            stsr = new StreamReader("Data\\Status_File.rccs");
            string ln = stsr.ReadLine();
            if (ln == null)
            {
                stsr.Close();
                stsw = new StreamWriter("Data\\Status_File.rccs");
                stsw.WriteLine("0/" + Directory.GetFiles(songs_path).Length);
                stsw.Close();
                Song_No = 0;
            }
            else
            {
                String[] tw = ln.Split('/');
                Song_No = Convert.ToInt16(tw[0]);
                stsr.Close();
                stsw = new StreamWriter("Data\\Status_File.rccs");
                stsw.WriteLine(Song_No + "/" + Directory.GetFiles(songs_path).Length);
                stsw.Close();
            }
            Data_ListBox.Items.Clear();

            dtsr = new StreamReader("Data\\Data_File.rccs");
            string line = "";
            int i = 0;
            while ((line = dtsr.ReadLine()) != null)
            {
                Data_ListBox.Items.Add(line);

                String[] tm = line.Split('-');
                try
                {
                    Times[i] = tm[0].Trim();
                    Commands[i] = tm[1].Trim();

                }
                catch (IndexOutOfRangeException)
                {
                }

                i++;
            }
            Songs_ListBox.Items.Clear();
            String[] Songs_list = Directory.GetFiles(songs_path);
            if (Songs_list.Length != 0)
            {
                for (int j = 0; j < Songs_list.Length; j++)
                {

                    String[] sg = Songs_list[j].Split('\\');
                    Songs_ListBox.Items.Add(sg[sg.Length - 1]);
                
                }
            }

            timer1.Enabled = true;


            stsr = new StreamReader("Data\\Status_File.rccs");
            ln = stsr.ReadLine();
            stsr.Close();
            if(ln!=null){
            String[] tw = ln.Split('/');
            label4.Text = (Song_No).ToString() + "/" + tw[1];
            }
            if (File.Exists("Data\\Songs_Time.rccs"))
            {
                smsr = new StreamReader("Data\\Songs_Time.rccs");
                Str_Time  = smsr.ReadLine();
                Stp_Time = smsr.ReadLine();
                smsr.Close();
                Start_Time.Text = Str_Time;
                Stop_Time.Text = Stp_Time;
                
            }
            
            if (Songs_list.Length == 0)
            {
                MessageBox.Show("No songs in the songs folder.");
            }
            if (Song_No >= (Songs_list.Length - 5))
            {
                Warning_Label.Visible = true;
            }
            else
            {
                Warning_Label.Visible = false;
            }
            try
                {
                    

                    if ((axWindowsMediaPlayer.playState.ToString() == "wmppsStopped") && Current_Date_Time > DateTime.ParseExact(Str_Time, "HH:mm:ss", CultureInfo.InvariantCulture) && Current_Date_Time < DateTime.ParseExact(Stp_Time, "HH:mm:ss", CultureInfo.InvariantCulture))
                    {
                        play_sound("Day_Songs");
                    }
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Songs time not set.");
                }

        
        }


        private void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((axWindowsMediaPlayer.playState.ToString() != "wmppsPlaying"))
            {
                Status_Label.Text = "System Online";
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Song_No = 0;
            stsr = new StreamReader("Data\\Status_File.rccs");
            string ln = stsr.ReadLine();
            if (ln != null)
            {
                String[] tw = ln.Split('/');
                stsr.Close();
                stsw = new StreamWriter("Data\\Status_File.rccs");
                stsw.WriteLine(Song_No + "/" + tw[1]);
                stsw.Close();
                label4.Text = Song_No.ToString() + "/" + tw[1];


                
            }
        }




        
    }
}
