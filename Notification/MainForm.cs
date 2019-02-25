using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace Notification
{
       

    public partial class MainForm : Form
    {
        //bool close = false;
       // Task webShowList;
        string webShown = "";
        int idxWebListNow = 0;
        int idxNotCheckedNow = 0;
        System.Timers.Timer timer;
        Thread th;
        Object key = new Object();

        public MainForm()
        {
            InitializeComponent();
            timer1.Interval = 1000 * 60 *5; // 1 minutes
            timer1.Enabled = true;
            timer1.Start();
            CallUpdate();
            timer2.Interval = 500;
            timer2.Enabled = true;
            timer2.Start();
            if (WebContentChecker.value.Datas.Count > 0)
            {
                idxWebListNow = WebContentChecker.value.Datas.Count - 1;
                webList.Text = WebContentChecker.value.Datas[idxWebListNow].URL.ToString();
            }
            else
            {
                webList.Text = "None";
            }
            notChecked.Clear();
            notChecked.AddRange(WebContentChecker.value.NotCheckedDatas());
            notCheckedLastIdx = notChecked.Count - 1;
            idxNotCheckedNow = (idxNotCheckedNow > notCheckedLastIdx) ? notCheckedLastIdx : idxNotCheckedNow;
            idxNotCheckedNow = (idxNotCheckedNow < 0) ? 0 : idxNotCheckedNow;
            if (notChecked.Count > 0)
            {
                idxNotCheckedNow = notChecked.Count - 1;
                changedWebList.Text = notChecked[idxNotCheckedNow].URL;
            }
            else
            {
                changedWebList.Text = "None";
            }
        }
        

        private void inputLinkButton_Click(object sender, EventArgs e)
        {
            lock (key) // do this so thread finish it's process before inputing this
            {
                //add data
                WebContentChecker.value.AddData(new Data(urlInput.Text, urlIDInput.Text, urlClassInput.Text));
                idxWebListNow = WebContentChecker.value.Datas.Count-1;
                CallUpdate();

                //set all input in text bar removed
                urlInput.Text = "";
                urlIDInput.Text = "";
                urlClassInput.Text = "";
            }
        }

        public static bool isAppRunning = true;
     
        private void CallUpdate()
        {
            
            ProcessingIndicator.Text = "Processing";
            this.Refresh(); //Update display so it show new value
            if (th==null || !th.IsAlive)
            {
                th = new Thread(CheckWeb);
                th.Start();
            }
        }

        int webCheckerLastIdx = 0; //contain last idx of weblist. Did this since WebContentChecker.value.Datas.Count is too long to type
        int notCheckedLastIdx = 0;
        List<Data> notChecked = new List<Data>();

        bool displayIsChanged = false;
        string wl = "";
        string cwl = "";

        private void CheckWeb()
        {
            lock (key)
            {
                WebContentChecker.value.Update();
                RefreshDisplay();
            }
        }

        private void RefreshDisplay()
        {
            lock (key)
            {
                Debug.WriteLine("Processing");
                
                //since web list idx start from 0, last idx should be remove by 1.
                webCheckerLastIdx = WebContentChecker.value.Datas.Count - 1;
                //make sure index is not more than webCheckerLastIdx. If it's more, change value to last index
                //but if it's not, return its own value.
                idxWebListNow = (idxWebListNow > webCheckerLastIdx) ? webCheckerLastIdx : idxWebListNow;
                //make sure index is not less than 0. If it less, return it as 0, but if not, return its own value
                idxWebListNow = (idxWebListNow < 0) ? 0 : idxWebListNow;
                //You don't want to assign value if list is empty. Make sure list is not empty
                if (WebContentChecker.value.Datas.Count > 0)
                {
                    wl = WebContentChecker.value.Datas[idxWebListNow].URL.ToString();
                }
                else
                {
                    wl = "None";
                }
                notChecked.Clear();
                notChecked.AddRange(WebContentChecker.value.NotCheckedDatas());
                notCheckedLastIdx = notChecked.Count - 1;
                idxNotCheckedNow = (idxNotCheckedNow > notCheckedLastIdx) ? notCheckedLastIdx : idxNotCheckedNow;
                idxNotCheckedNow = (idxNotCheckedNow < 0) ? 0 : idxNotCheckedNow;
                if (notChecked.Count > 0)
                {
                    cwl = notChecked[idxNotCheckedNow].URL;
                }
                else
                {
                    cwl = "None";
                }
                Debug.WriteLine("Done Processing");

                displayIsChanged = true;
            }
        }

        private void prevLinkList_Click(object sender, EventArgs e)
        {
            if (idxNotCheckedNow - 1 >=0)
            {
                idxNotCheckedNow--;
                changedWebList.Text = notChecked[idxNotCheckedNow].URL;
            }     
        }

        private void nextLinkList_Click(object sender, EventArgs e)
        {
            if (idxNotCheckedNow + 1 < notChecked.Count)
            {
                idxNotCheckedNow++;
                changedWebList.Text = notChecked[idxNotCheckedNow].URL;
            }
        }

        private void SetAsSeen_Click(object sender, EventArgs e)
        {
            lock (key)
            {
                if (notChecked.Count > 0)
                    WebContentChecker.value.DataIsChecked(notChecked[idxNotCheckedNow]);

                RefreshDisplay();
                //CallChangeText();
            }
        }

        private void removeWebList_Click(object sender, EventArgs e)
        {
            lock (key)
            {
                Data data = WebContentChecker.value.Datas[idxWebListNow];
                WebContentChecker.value.RemoveData(data.URL, data.ID, data.Class);
                RefreshDisplay();
            }
        }

        private void prevUrlList_Click(object sender, EventArgs e)
        {
            if(idxWebListNow +1 < WebContentChecker.value.Datas.Count)
            {
                idxWebListNow++;
                webList.Text = WebContentChecker.value.Datas[idxWebListNow].URL;
            }            
        }

        private void nextUrlList_Click(object sender, EventArgs e)
        {
            if (idxWebListNow -1 >= 0)
            {
                idxWebListNow--;
                webList.Text = WebContentChecker.value.Datas[idxWebListNow].URL;
            }           
        }

        private void webList_Click(object sender, EventArgs e)
        {
            if (webList.Text != "None")
                System.Diagnostics.Process.Start(webList.Text);
        }

        private void changedWebList_Click(object sender, EventArgs e)
        {
            if (changedWebList.Text != "None") 
                System.Diagnostics.Process.Start(changedWebList.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("Run timer");
            CallUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible)
            {
                e.Cancel = true;
                Hide();
            }            
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {            
            if (displayIsChanged && !th.IsAlive )
            {
                webList.Text = wl; //now change the label of display to url in weblist at index assigned.
                changedWebList.Text = cwl;
                if (notChecked.Count > 0)
                {
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipText = "Click on message to see it";
                    notifyIcon1.BalloonTipTitle = "Some Website changed";
                    notifyIcon1.ShowBalloonTip(1000);
                }
                Debug.WriteLine("Done");
                ProcessingIndicator.Text = "Not processing";
                this.Refresh();
                displayIsChanged = false;
            }
        }
    }
}
