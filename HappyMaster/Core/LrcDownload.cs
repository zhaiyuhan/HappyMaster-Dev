using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HappyMaster.Core
{
    public class LrcDownload
    {
        public delegate void EventArgs_LrcDownloadCompleted(string filename);
        public event EventArgs_LrcDownloadCompleted LrcDownloadCompleted;
        public void searchLrc(string keyword)
        {
            if (keyword == "")
            {
                return;
            }
            string path = Application.StartupPath + "\\lrc\\";
            if (System.IO.File.Exists(path + keyword + ".lrc"))
            {
                if (LrcDownloadCompleted != null)
                {
                    LrcDownloadCompleted(keyword);
                    return;
                }
            }
            Network net = new Network();
            net.HttpGetParams.Add("key", keyword);
            net.HttpGet("http://music.baidu.com/search/lrc");
            net.HttpGetCompleted += new Network.EventArgs_DownloadCompleted(net_HttpGetCompleted);
            net.SessionID = keyword;
        }

        void net_HttpGetCompleted(string result, string SessionID)
        {
            if (result != "")
            {
                string path = Application.StartupPath + "\\lrc\\";
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                //System.IO.File.WriteAllText(path + SessionID + ".lrc" ,result);
                //LrcDownloadCompleted(result,SessionID);
                Regex reg = new Regex("down-lrc-btn { 'href':'(.*?)'");
                MatchCollection mc = reg.Matches(result);
                string lrcURL = "http://music.baidu.com/" + mc[0].Groups[1].Value;

                Network net = new Network();
                net.HttpGet(lrcURL);
                net.HttpGetCompleted += new Network.EventArgs_DownloadCompleted(net_HttpGetCompleted2);
                net.SessionID = SessionID;
            }
        }

        void net_HttpGetCompleted2(string result, string SessionID)
        {
            string path = Application.StartupPath + "\\lrc\\";
            System.IO.File.WriteAllText(path + SessionID + ".lrc", result);
            LrcDownloadCompleted(SessionID);
        }
    }
}
