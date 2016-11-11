using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Un4seen.Bass;

namespace HappyMaster_Dev.Core
{
    class HandleBASSError
    {
        public string HandleBASSErrorMethod(BASSError _BassError)
        {
            switch (_BassError)
            {
                case BASSError.BASS_ERROR_ACM_CANCEL:
                    return "";
                case BASSError.BASS_ERROR_ALREADY:
                    return "";
                case BASSError.BASS_ERROR_BUFLOST:
                    return "";
                case BASSError.BASS_ERROR_BUSY:
                    return "";
                case BASSError.BASS_ERROR_CAST_DENIED:
                    return "";
                case BASSError.BASS_ERROR_CDTRACK:
                    return "";
                case BASSError.BASS_ERROR_CODEC:
                    return "";
                case BASSError.BASS_ERROR_CREATE:
                    //Couldn't create the file
                    return "无法创建文件";
                case BASSError.BASS_ERROR_DECODE:
                    return "";
                case BASSError.BASS_ERROR_DEVICE:
                    return "";
                case BASSError.BASS_ERROR_DRIVER:
                    return "";
                case BASSError.BASS_ERROR_DX:
                    return "";
                case BASSError.BASS_ERROR_EMPTY:
                    return "";
                case BASSError.BASS_ERROR_ENDED:
                    return "";
                case BASSError.BASS_ERROR_FILEFORM:
                    return "";
                case BASSError.BASS_ERROR_FILEOPEN:
                    return "";
                case BASSError.BASS_ERROR_FORMAT:
                    return "";
                case BASSError.BASS_ERROR_FREQ:
                    return "";
                case BASSError.BASS_ERROR_HANDLE:
                    return "";
                case BASSError.BASS_ERROR_ILLPARAM:
                    return "";
                case BASSError.BASS_ERROR_ILLTYPE:
                    return "";
                case BASSError.BASS_ERROR_INIT:
                    return "";
                case BASSError.BASS_ERROR_MEM:
                    return "";
                case BASSError.BASS_ERROR_MP4_NOSTREAM:
                    return "";
                case BASSError.BASS_ERROR_NO3D:
                    return "";
                case BASSError.BASS_ERROR_NOCD:
                    return "";
                case BASSError.BASS_ERROR_NOCHAN:
                    return "";
                case BASSError.BASS_ERROR_NOEAX:
                    return "";
                case BASSError.BASS_ERROR_NOFX:
                    return "";
                case BASSError.BASS_ERROR_NOHW:
                    return "";
                case BASSError.BASS_ERROR_NONET:
                    return "";
                case BASSError.BASS_ERROR_NOPAUSE:
                    return "";
                case BASSError.BASS_ERROR_NOPLAY:
                    return "";
                case BASSError.BASS_ERROR_NOTAUDIO:
                    return "";
                case BASSError.BASS_ERROR_NOTAVAIL:
                    return "";
                case BASSError.BASS_ERROR_NOTFILE:
                    return "";
                case BASSError.BASS_ERROR_PLAYING:
                    return "";
                case BASSError.BASS_ERROR_POSITION:
                    return "";
                case BASSError.BASS_ERROR_SPEAKER:
                    return "";
                case BASSError.BASS_ERROR_START:
                    return "";
                case BASSError.BASS_ERROR_TIMEOUT:
                    return "";
                case BASSError.BASS_ERROR_UNKNOWN:
                    return "";
                case BASSError.BASS_ERROR_VERSION:
                    return "";
                case BASSError.BASS_ERROR_WASAPI:
                    return "";
                case BASSError.BASS_ERROR_WMA_CODEC:
                    return "";
                case BASSError.BASS_ERROR_WMA_DENIED:
                    return "";
                case BASSError.BASS_ERROR_WMA_INDIVIDUAL:
                    return "";
                case BASSError.BASS_ERROR_WMA_LICENSE:
                    return "";
                case BASSError.BASS_ERROR_WMA_WM9:
                    return "";
                case BASSError.BASS_OK:
                    return "";
                case BASSError.BASS_VST_ERROR_NOINPUTS:
                    return "";
                case BASSError.BASS_VST_ERROR_NOOUTPUTS:
                    return "";
                case BASSError.BASS_VST_ERROR_NOREALTIME:
                    return "";
            }

            return "fuck";
        }
    }
}
