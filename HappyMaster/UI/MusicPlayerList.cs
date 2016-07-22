using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HappyMaster.UI
{
    public partial class MusicPlayerList : DMSkin.Main
    {
        public string filenmaefromlist = String.Empty;

        public MusicPlayerList()
        {
            InitializeComponent();
            
        }
        string[] names;
        List<string> list;
        string[] lists = new string[100];
        public void MusicPlayerList_Load(object sender, EventArgs e)
        {
            
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                PlayList.Items.Add(Path.GetFileName(of.FileName));
                filenmaefromlist = of.FileName;
            }
            /*list = new List<string>();
            string[] oldFile;
            string[] newFile;
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = "c:\\";         
            of.RestoreDirectory = true;
            of.FilterIndex = 1;
            of.Multiselect = true;
            if (of.ShowDialog() == DialogResult.OK)
            {
                int k = 0;
                int same = 0;
                if (names == null)
                {
                    oldFile = new string[of.FileNames.Length];
                    foreach (var i in of.FileNames)
                    {
                        oldFile[k] = i;
                        k++;
                    }
                }
                else
                {
                    oldFile = new string[of.FileNames.Length + names.Length];
                    for (int y = 0; y < names.Length; y++)
                    {
                        oldFile[k] = names[y];
                        k++;
                    }
                    foreach (var i in of.FileNames)
                    {
                        oldFile[k] = i;
                        k++;

                    }
                }
                for (int i = 0; i < oldFile.Length; i++)
                {
                    for (int j = i + 1; j < oldFile.Length; j++)
                    {
                        if (oldFile[i] == oldFile[j])
                        {
                            same++;
                        }
                    }
                }
                for (int i = 0; i < oldFile.Length; i++)
                {
                    for (int j = i + 1; j < oldFile.Length; j++)
                    {
                        if (oldFile[i] == oldFile[j])
                        {
                            oldFile[i] = "null";
                        }
                    }
                }
                int w = 0;
                newFile = new string[oldFile.Length - same];
                for (int i = 0; i < oldFile.Length; i++)
                {
                    if (oldFile[i] != "null")
                    {
                        newFile[w] = oldFile[i];
                        w++;
                    }
                }

                names = newFile;
                for (int i = 0; i < names.Length; i++)
                {
                    list.Add(names[i]);
                }
                SaveMusicList();
            }
            setMusicList(1);
        }

        public void SaveMusicList()
        {
            if (File.Exists(".\\Music.txt") == true)
            {
                File.Delete(".\\Music.txt");
            }
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = "Music.txt";
            sf.RestoreDirectory = true;
            sf.FilterIndex = 1;
            FileStream fs = new FileStream(string.Format("{0}", sf.FileName), FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, list);
            fs.Close();*/
        }

        public void GetMusicList()
        {
            string[] musicFile;
            if (File.Exists(".\\Music.txt") == false)
            {
            }
            else
            {
                OpenFileDialog of = new OpenFileDialog();
                of.FileName = "Music.txt";
                of.RestoreDirectory = true;
                of.FilterIndex = 1;
                FileStream fs = new FileStream(string.Format("{0}", of.FileName), FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                this.list = ((List<string>)bf.Deserialize(fs));
                fs.Close();
                musicFile = new string[list.Count];
                for (int i = 0; i < list.Count; i++)
                {
                    musicFile[i] = list[i];
                }
                names = musicFile;
            }
        }

        private void setMusicList(int page)
        {
            if (names != null)
            {
                try { }
                catch (Exception)              { }
            }
        }

        private void DeletFile_Click(object sender, EventArgs e)
        {
            PlayList.Items.Remove(PlayList.SelectedItem);
        }

        private void PlayList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CloseList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlaySelect_Click(object sender, EventArgs e)
        {
            this.Close();

            AppViewer.filename = filenmaefromlist;
        }
    }
}
