using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HappyMaster.Core
{
    class MusicList
    {
        string[] names;//Music Files FileName 
        List<string> list;
        int musicNum;
        public void SaveMusicList()
        {
            if(File.Exists(".\\MusicList.list")==true)
            {
                File.Delete(".\\MusicList.list");
            }
        }
    }
}
