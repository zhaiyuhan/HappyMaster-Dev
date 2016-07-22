using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.Web.UI;
using System.Text;

namespace HappyMaster.Core
{
    public class Network
    {
        public Dictionary<string, string> HttpGetParams = new Dictionary<string, string>();
        public Dictionary<string, string> HttpPostParams = new Dictionary<string, string>();
        public Encoding DefaultEncoding = Encoding.GetEncoding("utf-8");
        public delegate void EventArgs_DownloadCompleted(string result, string SessionID);
        public event EventArgs_DownloadCompleted HttpGetCompleted;
        public event EventArgs_DownloadCompleted HttpPostCompleted;
        public delegate void EventArgs_HttpError(string error);
        public event EventArgs_HttpError DownloadError;
        private string _Uri = "";
        private string _SessionID = "";

        /// <summary>
        /// Download URI use http get
        /// 使用HTTP GET的方式下载数据
        /// </summary>
        /// <param name="DownloadURI"></param>
        public Network(string DownloadURI)
        {
            this.HttpGet(DownloadURI);
            this.CreateSession();  // create a session id for every download,because we must distinguish downloads，because this is multithreaded downloading .
                                   // 为每次下载分配一个会话ID，这样可以区分每次下载的数据，因为下载的时候是多线程异步的
        }
        public Network()
        {
            //construct overloaded
            //重载函数
            this.CreateSession();
        }
        private void CreateSession()
        {
            this.SessionID = new Random().Next(100000, 999999).ToString();
        }
        public void HttpGet(string DownloadURI)
        {
            this.Uri = DownloadURI;
            Thread td = new Thread(new ThreadStart(DownloadBegin));
            td.Start();
        }
        public void HttpPost(string DownloadURI)
        {
            this.Uri = DownloadURI;
            Thread td = new Thread(new ThreadStart(PostDownloadBegin));
            td.Start();
        }
        /// <summary>
        /// Uri string you want to download
        /// 你想要下载的URI
        /// </summary>
        public string Uri
        {
            get
            {
                return _Uri;
            }
            set
            {
                _Uri = value;
            }
        }
        public string SessionID
        {
            get
            {
                return _SessionID;
            }
            set
            {
                _SessionID = value;
            }
        }
        /// <summary>
        /// Http Get
        /// </summary>
        private void DownloadBegin()
        {
            try
            {
                WebClient Wc = new WebClient();
                string download_uri = this.Uri + "?";
                foreach (string p in this.HttpGetParams.Keys)
                {
                    download_uri += p + "=" + System.Web.HttpUtility.UrlEncode(this.HttpGetParams[p]) + "&";
                }
                byte[] data = Wc.DownloadData(download_uri);
                HttpGetCompleted(DefaultEncoding.GetString(data), this.SessionID);
            }
            catch (Exception)
            {
                //DownloadError(ex.Message);
            }
        }
        /// <summary>
        /// Begin use Http Post to download data
        /// 开始用http post 下载数据
        /// </summary>
        private void PostDownloadBegin()
        {
            try
            {
                string post_string = "";
                foreach (string p in this.HttpPostParams.Keys)
                {
                    post_string += this.HttpPostParams[p];
                }
                byte[] post_byte = this.DefaultEncoding.GetBytes(post_string);
                WebClient wc = new WebClient();
                wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                byte[] responseData = wc.UploadData(this.Uri, "POST", post_byte);
                string result = DefaultEncoding.GetString(responseData);
                HttpPostCompleted(result, this.SessionID);
            }
            catch (Exception ex)
            {
                DownloadError(ex.Message);
            }
        }
    }
}
