using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.IO;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;

namespace HappyPlayer.Extra
{
    [SuppressUnmanagedCodeSecurity]
    internal class ID3V2
    {
        private Stream stream;//a
        private byte byte1;
        private byte byte2;
        private byte byte3;
        private int num;
        private string frame;
        private short gShort;
        private object ob;
        private int index;
        private byte[] data;
        private byte byte4 = 3;//k
        private byte byte5 = 0;

        public ID3V2(IntPtr A_0)
        {
            if (Utils.IntPtrAsStringAnsi(A_0, 3) == "ID3")
            {
                this.index += 3;
                this.byte1 = Marshal.ReadByte(A_0, this.index);
                this.index++;
                this.byte2 = Marshal.ReadByte(A_0, this.index);
                this.index++;
                this.byte3 = Marshal.ReadByte(A_0, this.index);
                this.index++;
                int num = this.c(A_0, this.index);
                this.index += 4;
                bool flag = (this.byte3 & 0x40) > 0;
                int num2 = 0;
                if (flag)
                {
                    num2 = this.c(A_0, this.index);
                }
                this.data = new byte[num + 10];
                Marshal.Copy(A_0, this.data, 0, num + 10);
                this.stream = new MemoryStream(this.data);
                this.stream.Position = 10 + num2;
                int num3 = num + 10;
                this.num = num3 - 10;
            }
            else
            {
                this.byte1 = this.byte4;
                this.byte2 = this.byte5;
                this.stream = null;
            }
            this.frame = null;
            this.ob = null;
        }

        private int a()
        {
            return 0;
        }

        private byte[] a(byte[] A_0)
        {
            List<byte> list = new List<byte>(A_0);
            for (int i = list.Count - 2; i >= 0; i--)
            {
                if ((list[i] == 0xff) && (list[i + 1] == 0))
                {
                    list.RemoveAt(i + 1);
                }
            }
            return list.ToArray();
        }

        private Encoding a(byte A_0)
        {
            switch (A_0)
            {
                case 0:
                    return Encoding.Default;
                case 1:
                    return Encoding.Unicode;
                case 2:
                    return Encoding.BigEndianUnicode;
                case 3:
                    return Encoding.UTF8;
            }
            return Encoding.Default;
        }

        private string a(IntPtr A_0)
        {
            byte[] buffer = new byte[3];
            this.stream.Read(buffer, 0, 3);
            return Encoding.ASCII.GetString(buffer, 0, 3);
        }

        private object a(int A_0, short A_1)
        {
            byte[] buffer = new byte[A_0];
            this.stream.Read(buffer, 0, A_0);
            int index = 0;
            if ((A_1 & 1) != 0)
            {
                this.a(buffer[0], buffer[1], buffer[2], buffer[3]);
                index = 4;
            }
            if (((this.byte3 & 0x80) != 0) || ((A_1 & 2) != 0))
            {
                buffer = this.a(buffer);
                A_0 = buffer.Length;
            }
            if (((this.frame == "COM") || (this.frame == "COMM")) || (((this.frame == "USER") || (this.frame == "ULT")) || (this.frame == "USLT")))
            {
                Encoding unicode = this.a(buffer[index]);
                index += 4;
                if ((buffer[index - 4] == 1) && (A_0 > 6))
                {
                    if ((buffer[index] != 0xfe) || (buffer[index + 1] != 0xff))
                    {
                        if ((buffer[index] != 0xff) || (buffer[index + 1] != 0xfe))
                        {
                            return string.Empty;
                        }
                        unicode = Encoding.Unicode;
                        index += 2;
                    }
                    else
                    {
                        unicode = Encoding.BigEndianUnicode;
                        index += 2;
                    }
                }
                string str = unicode.GetString(buffer, index, A_0 - index).TrimEnd(new char[1]);
                string[] strArray = str.Split(new char[1]);
                if ((strArray != null) && (strArray.Length > 1))
                {
                    if ((strArray[0].Trim().Length > 0) && (strArray[1].Trim().Length > 0))
                    {
                        str = "(" + strArray[0].Trim() + "):" + strArray[1].Trim();
                    }
                    else
                    {
                        str = strArray[1].Trim();
                    }
                }
                return str.Trim();
            }
            if (((this.frame == "WXXX") || (this.frame == "WXX")) || ((this.frame == "TXXX") || (this.frame == "TXX")))
            {
                Encoding bigEndianUnicode = this.a(buffer[index]);
                index++;
                if ((buffer[index - 1] == 1) && (A_0 > 6))
                {
                    if ((buffer[index] != 0xfe) || (buffer[index + 1] != 0xff))
                    {
                        if ((buffer[index] != 0xff) || (buffer[index + 1] != 0xfe))
                        {
                            return string.Empty;
                        }
                        bigEndianUnicode = Encoding.Unicode;
                        index += 2;
                    }
                    else
                    {
                        bigEndianUnicode = Encoding.BigEndianUnicode;
                        index += 2;
                    }
                }
                string str2 = bigEndianUnicode.GetString(buffer, index, A_0 - index).TrimEnd(new char[1]);
                string[] strArray2 = str2.Split(new char[1]);
                if ((strArray2 != null) && (strArray2.Length > 1))
                {
                    if (strArray2[0].Trim().Length > 0)
                    {
                        str2 = strArray2[0].Trim() + ":" + strArray2[1].Trim();
                    }
                    else
                    {
                        str2 = strArray2[1].Trim();
                    }
                }
                return str2.Trim();
            }
            if (this.frame[0] == 'T')
            {
                Encoding encoding3 = this.a(buffer[index]);
                index++;
                if ((buffer[index - 1] == 1) && (A_0 > 3))
                {
                    if ((buffer[index] != 0xfe) || (buffer[index + 1] != 0xff))
                    {
                        if ((buffer[index] != 0xff) || (buffer[index + 1] != 0xfe))
                        {
                            return string.Empty;
                        }
                        encoding3 = Encoding.Unicode;
                        index += 2;
                    }
                    else
                    {
                        encoding3 = Encoding.BigEndianUnicode;
                        index += 2;
                    }
                }
                return encoding3.GetString(buffer, index, A_0 - index).TrimEnd(new char[1]).Trim();
            }
            if (this.frame[0] == 'W')
            {
                string str4 = Encoding.Default.GetString(buffer, index, A_0).TrimEnd(new char[1]).TrimEnd(new char[1]);
                string[] strArray3 = str4.Split(new char[1]);
                if ((strArray3 != null) && (strArray3.Length > 1))
                {
                    str4 = strArray3[0].Trim();
                }
                return str4.Trim();
            }
            if (((this.frame == "UFI") || (this.frame == "LNK")) || ((this.frame == "UFID") || (this.frame == "LINK")))
            {
                string str5 = Encoding.Default.GetString(buffer, index, A_0).TrimEnd(new char[1]);
                string[] strArray4 = str5.Split(new char[1]);
                if ((strArray4 != null) && (strArray4.Length > 1))
                {
                    if (strArray4[0].Trim().Length > 0)
                    {
                        str5 = strArray4[0].Trim() + ":" + strArray4[1].Trim();
                    }
                    else
                    {
                        str5 = strArray4[1].Trim();
                    }
                }
                return str5.Trim();
            }
            if (!(this.frame == "POP") && !(this.frame == "POPM"))
            {
                return buffer;
            }
            for (int i = 0; i < A_0; i++)
            {
                if ((buffer[i + index] == 0) && (i < (A_0 - 1)))
                {
                    return buffer[(i + index) + 1];
                }
            }
            return 0;
        }

        private string a(byte[] A_0, ref int A_1)
        {
            StringBuilder builder = new StringBuilder();
            try
            {
                char ch;
                while ((ch = (char)A_0[A_1]) != '\0')
                {
                    builder.Append(ch);
                    A_1++;
                }
            }
            catch
            {
            }
            return builder.ToString();
        }

        private int a(IntPtr A_0, int A_1)
        {
            byte[] buffer = new byte[] { Marshal.ReadByte(A_0, A_1), Marshal.ReadByte(A_0, A_1 + 1), Marshal.ReadByte(A_0, A_1 + 2) };
            return (((buffer[0] << 0x10) | (buffer[1] << 8)) | buffer[2]);
        }

        private string a(byte[] A_0, ref int A_1, Encoding A_2)
        {
            string str = string.Empty;
            try
            {
                if (A_0[0] == 1)
                {
                    if ((A_0[A_1] != 0xfe) || (A_0[A_1 + 1] != 0xff))
                    {
                        if ((A_0[A_1] != 0xff) || (A_0[A_1 + 1] != 0xfe))
                        {
                            return str;
                        }
                        A_2 = Encoding.Unicode;
                    }
                    else
                    {
                        A_2 = Encoding.BigEndianUnicode;
                    }
                }
                int num = 1;
                if ((A_0[0] == 1) || (A_0[0] == 2))
                {
                    num = 2;
                }
                int index = A_1;
                while (true)
                {
                    while (num == 1)
                    {
                        if (A_0[index] == 0)
                        {
                            break;
                        }
                        index++;
                    }
                    if (num == 2)
                    {
                        if ((A_0[index] == 0) && (A_0[index + 1] == 0))
                        {
                            index++;
                            break;
                        }
                        index++;
                    }
                }
                str = A_2.GetString(A_0, A_1, index - A_1);
                A_1 = index;
                if (num == 2)
                {
                    A_1++;
                }
            }
            catch
            {
            }
            return str;
        }

        public TagPicture a(byte[] A_0, short A_1, int A_2, bool A_3)
        {
            if (A_0 == null)
            {
                return null;
            }
            TagPicture picture = null;
            byte[] destinationArray = null;
            try
            {
                string str;
                TagPicture.PICTURE_TYPE unknown;
                int index = 0;
                if ((A_1 & 1) != 0)
                {
                    this.a(A_0[0], A_0[1], A_0[2], A_0[3]);
                    index = 4;
                }
                Encoding encoding = this.a(A_0[index]);
                index++;
                if (A_3)
                {
                    str = "Unknown";
                    if (((A_0[index] == 0x4a) && (A_0[index + 1] == 80)) && (A_0[index + 2] == 0x47))
                    {
                        str = "image/jpeg";
                    }
                    else if (((A_0[index] == 0x47) && (A_0[index + 1] == 0x49)) && (A_0[index + 2] == 70))
                    {
                        str = "image/gif";
                    }
                    else if (((A_0[index] == 0x42) && (A_0[index + 1] == 80)) && (A_0[index + 2] == 0x4d))
                    {
                        str = "image/bmp";
                    }
                    else if (((A_0[index] == 80) && (A_0[index + 1] == 0x4e)) && (A_0[index + 2] == 0x47))
                    {
                        str = "image/png";
                    }
                    index += 3;
                }
                else
                {
                    str = this.a(A_0, ref index);
                    index++;
                }
                byte num2 = A_0[index];
                try
                {
                    unknown = (TagPicture.PICTURE_TYPE)num2;
                }
                catch
                {
                    unknown = TagPicture.PICTURE_TYPE.Unknown;
                }
                index++;
                string description = this.a(A_0, ref index, encoding);
                index++;
                int length = A_0.Length - index;
                if (length <= 0)
                {
                    return picture;
                }
                destinationArray = new byte[length];
                Array.Copy(A_0, index, destinationArray, 0, length);
                if ((A_1 & 2) != 0)
                {
                    List<byte> list = new List<byte>(length);
                    for (int i = 0; i < length; i++)
                    {
                        list.Add(destinationArray[i]);
                        if (((i < (length - 1)) && (destinationArray[i] == 0xff)) && (destinationArray[i + 1] == 0))
                        {
                            i++;
                        }
                    }
                    destinationArray = list.ToArray();
                }
                picture = new TagPicture(A_2, str, unknown, description, destinationArray);
            }
            catch
            {
            }
            return picture;
        }

        private int a(byte A_0, byte A_1, byte A_2, byte A_3)
        {
            if ((((A_0 & 0x80) != 0) || ((A_1 & 0x80) != 0)) || (((A_2 & 0x80) != 0) || ((A_3 & 0x80) != 0)))
            {
                throw new FormatException("Found invalid syncsafe integer");
            }
            return ((((A_0 << 0x15) | (A_1 << 14)) | (A_2 << 7)) | A_3);
        }

        private int b()
        {
            byte[] buffer = new byte[3];
            this.stream.Read(buffer, 0, 3);
            return (((buffer[0] << 0x10) | (buffer[1] << 8)) | buffer[2]);
        }

        private int b(IntPtr A_0, int A_1)
        {
            byte[] buffer = new byte[] { Marshal.ReadByte(A_0, A_1), Marshal.ReadByte(A_0, A_1 + 1), Marshal.ReadByte(A_0, A_1 + 2), Marshal.ReadByte(A_0, A_1 + 3) };
            return ((((buffer[0] << 0x18) | (buffer[1] << 0x10)) | (buffer[2] << 8)) | buffer[3]);
        }

        private int c()
        {
            byte[] buffer = new byte[4];
            this.stream.Read(buffer, 0, 4);
            return ((((buffer[0] << 0x18) | (buffer[1] << 0x10)) | (buffer[2] << 8)) | buffer[3]);
        }

        private int c(IntPtr A_0, int A_1)
        {
            byte[] buffer = new byte[] { Marshal.ReadByte(A_0, A_1), Marshal.ReadByte(A_0, A_1 + 1), Marshal.ReadByte(A_0, A_1 + 2), Marshal.ReadByte(A_0, A_1 + 3) };
            if ((((buffer[0] & 0x80) != 0) || ((buffer[1] & 0x80) != 0)) || (((buffer[2] & 0x80) != 0) || ((buffer[3] & 0x80) != 0)))
            {
                throw new FormatException("Found invalid syncsafe integer");
            }
            return ((((buffer[0] << 0x15) | (buffer[1] << 14)) | (buffer[2] << 7)) | buffer[3]);
        }

        private int d()
        {
            byte[] buffer = new byte[4];
            this.stream.Read(buffer, 0, 4);
            return this.a(buffer[0], buffer[1], buffer[2], buffer[3]);
        }

        private short e()
        {
            int num = this.stream.ReadByte();
            int num2 = this.stream.ReadByte();
            return (short)((num << 8) | num2);
        }

        private int f()
        {
            if (this.byte1 == 4)
            {
                return this.d();
            }
            if (this.byte1 == 3)
            {
                return this.c();
            }
            if (this.byte1 != 2)
            {
                throw new NotSupportedException("Unsupported ID3v2 version detected. Don't know how to deal with this version.");
            }
            return this.b();
        }

        private string g()
        {
            int count = 4;
            if (this.byte1 == 2)
            {
                count = 3;
            }
            byte[] buffer = new byte[count];
            this.stream.Read(buffer, 0, count);
            return Encoding.ASCII.GetString(buffer, 0, count).TrimEnd(new char[1]);
        }

        public byte h()
        {
            return this.byte1;
        }

        public short i()
        {
            return this.gShort;
        }

        public object j()
        {
            return this.ob;
        }

        public bool k()
        {
            this.frame = null;
            this.ob = null;
            if (this.stream == null)
            {
                return false;
            }
            if (this.stream.Position > this.num)
            {
                return false;
            }
            this.frame = this.g();
            int num = this.f();
            if (num > 0x1000000)
            {
                return false;
            }
            this.gShort = 0;
            if (this.byte1 > 2)
            {
                this.gShort = this.e();
            }
            if (num == 0)
            {
                this.ob = string.Empty;
            }
            else
            {
                this.ob = this.a(num, this.gShort);
            }
            return true;
        }

        public void Dispose()
        {
            if (this.stream != null)
            {
                this.stream.Close();
                this.stream.Dispose();
                this.stream = null;
            }
        }

        public string m()
        {
            return this.frame;
        }

        public byte n()
        {
            return this.byte2;
        }
    }

}
