using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HappyMaster.Core
{
    public class LrcLoad
    {
        public Dictionary<float, string> LrcList = new Dictionary<float, string>();
        public void LoadLrc(string url)
        {
            Encoding fileEncoding = System.Text.Encoding.GetEncoding("utf-8");
            byte[] fileBytes = File.ReadAllBytes(url);
            string file = fileEncoding.GetString(fileBytes);
            string[] line = file.Split('\n');
            ArrayList sameContentLine = new ArrayList();
            foreach (string row in line)
            {
                if (row == "" || row == null || row.Length <= 4)
                {
                    continue;
                }
                string[] tmp = row.Split(']');
                // string timeTag = tmp[0].Replace("[","");
                string content = tmp[tmp.Length - 1].Replace("\r", "").Replace("\r\n", "").Replace("\n", "");

                Regex reg = new Regex("[0-9]{2}:[0-9]{2}.[0-9]{2}");
                MatchCollection times = reg.Matches(row);

                for (int i = 0; i < times.Count; i++)
                {
                    string[] tmp2 = times[i].Value.Split(':');
                    float time = 0F;
                    time = Convert.ToSingle(tmp2[0]) * 60F;
                    time += Convert.ToSingle(tmp2[1]);
                    if (content == "")
                    {
                        sameContentLine.Add(time);
                        continue;
                    }
                    if (sameContentLine.Count > 0)
                    {
                        for (int j = 0; j < sameContentLine.Count; j++)
                        {
                            LrcList[(float)sameContentLine[j]] = content;
                        }
                        sameContentLine.Clear();
                    }
                    LrcList[time] = content;
                }

            }

            Dictionary<float, string> sortedLrcList = new Dictionary<float, string>();
            float[] tmpList = new float[LrcList.Count];
            int id = 0;
            foreach (float key in LrcList.Keys)
            {
                tmpList[id] = key;
                id++;
            }
            Array.Sort(tmpList);
            for (int i = 0; i < tmpList.Length; i++)
            {
                sortedLrcList[tmpList[i]] = LrcList[tmpList[i]];
            }
            this.LrcList = sortedLrcList;

        }
    }
}
