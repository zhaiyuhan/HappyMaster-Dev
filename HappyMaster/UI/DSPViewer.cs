using System;
using System.Drawing;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.Misc;
using Un4seen.Bass.AddOn.Fx;
using System.IO;
using Un4seen.Bass.AddOn.Tags;

namespace HappyMaster.UI
{
    public partial class DSPViewer : CCWin.Skin_DevExpress
    {
        private int _stream = 0;
        private string _fileName = String.Empty;
        private int _tickCounter = 0;
        private DSP_PeakLevelMeter _plm1;
        private DSP_PeakLevelMeter _plm2;
        private Visuals _visModified = new Visuals();
        private bool _fullSpectrum = true;
        private SYNCPROC _sync = null;
        private int _syncer = 0;
        private DSP_Mono _mono;
        private DSP_Gain _gain;
        private DSP_StereoEnhancer _stereoEnh;
        private DSP_IIRDelay _delay;
        private DSP_SoftSaturation _softSat;
        private DSP_StreamCopy _streamCopy;
        private BASS_BFX_DAMP _damp = new BASS_BFX_DAMP();
        private BASS_DX8_COMPRESSOR _comp = new BASS_DX8_COMPRESSOR();
        private int _dampPrio = 3;
        private int _compPrio = 2;
        private int _deviceLatencyMS = 0; // device latency in milliseconds
        private int _deviceLatencyBytes = 0; // device latency in bytes
        private int _updateInterval = 50; // 50ms
        private Un4seen.Bass.BASSTimer _updateTimer = null;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public DSPViewer()
        {
            InitializeComponent();
        }

        private void DSPViewer_Load(object sender, EventArgs e)
        {
            if (Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_LATENCY, this.Handle))
            {
                BassNet.Registration("zhaiyuhanx@hotmail.com", "2X3931422312422");
                _info = Bass.BASS_GetInfo();
                _deviceLatencyMS = _info.latency;
            }
            else
                DMSkin.MetroMessageBox.Show(this, "Bass_Init error!");

            BassFx.BASS_FX_GetVersion();

            // init some FX
            _comp.Preset_Soft();
            _damp.Preset_Medium();

            // create a secure timer
            _updateTimer = new Un4seen.Bass.BASSTimer(_updateInterval);
            _updateTimer.Tick += new EventHandler(timerUpdate_Tick);

            _sync = new SYNCPROC(SetPosition);

            _visModified.MaxFFT = BASSData.BASS_DATA_FFT1024;
            _visModified.MaxFrequencySpectrum = Utils.FFTFrequency2Index(16000, 1024, 44100);

            comboBoxStreamCopy.Items.AddRange(Bass.BASS_GetDeviceInfos());
            comboBoxStreamCopy.SelectedIndex = -1;
        }

        private void DSPViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bass.BASS_Stop();
            Bass.BASS_Free();
            _updateTimer.Tick -= new EventHandler(timerUpdate_Tick);         
            
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            this.openFileDialog.FileName = _fileName;
            if (DialogResult.OK == this.openFileDialog.ShowDialog(this))
            {
                if (File.Exists(this.openFileDialog.FileName))
                {
                    _fileName = this.openFileDialog.FileName;
                    
                }
                else
                    _fileName = String.Empty;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            _updateTimer.Stop();
            Bass.BASS_StreamFree(_stream);
            if (_fileName != String.Empty)
            {
                // create the stream
                _stream = Bass.BASS_StreamCreateFile(_fileName, 0, 0, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_SPEAKER_FRONT);
                if (_stream != 0)
                {
                    // latency from milliseconds to bytes
                    _deviceLatencyBytes = (int)Bass.BASS_ChannelSeconds2Bytes(_stream, _deviceLatencyMS / 1000f);

                    if (_plm1 != null)
                        _plm1.Notification -= new EventHandler(_plm1_Notification);
                    // set up a ready-made DSP (here the PeakLevelMeter)
                    _plm1 = new DSP_PeakLevelMeter(_stream, 2000);
                    _plm1.CalcRMS = true;
                    _plm1.Notification += new EventHandler(_plm1_Notification);
                    checkBoxLevel1Bypass_CheckedChanged(this, EventArgs.Empty);

                    checkBoxMono.Checked = false;
                    _mono = new DSP_Mono();

                    comboBoxStreamCopy.SelectedIndex = -1;
                    checkBoxStreamCopy.Checked = true;

                    _gain = new DSP_Gain(_stream, 0);
                    buttonSetGain_Click(this, EventArgs.Empty);
                    trackBarGain_ValueChanged(this, EventArgs.Empty);

                    _stereoEnh = new DSP_StereoEnhancer(_stream, 0);
                    checkBoxStereoEnhancer_CheckedChanged(this, EventArgs.Empty);
                    trackBarStereoEnhancerWetDry_ValueChanged(this, EventArgs.Empty);
                    trackBarStereoEnhancerWide_ValueChanged(this, EventArgs.Empty);

                    _delay = new DSP_IIRDelay(_stream, 0, 2f);
                    checkBoxIIRDelay_CheckedChanged(this, EventArgs.Empty);
                    trackBarIIRDelay_ValueChanged(this, EventArgs.Empty);
                    trackBarIIRDelayWetDry_ValueChanged(this, EventArgs.Empty);
                    trackBarIIRDelayFeedback_ValueChanged(this, EventArgs.Empty);

                    _softSat = new DSP_SoftSaturation(_stream, 0);
                    checkBoxSoftSat_CheckedChanged(this, EventArgs.Empty);
                    trackBarSoftSat_ValueChanged(this, EventArgs.Empty);
                    trackBarSoftSatDepth_ValueChanged(this, EventArgs.Empty);

                    checkBoxDAmp_CheckedChanged(this, EventArgs.Empty);

                    checkBoxCompressor_CheckedChanged(this, EventArgs.Empty);
                    trackBarCompressor_ValueChanged(this, EventArgs.Empty);

                    checkBoxGainDither_CheckedChanged(this, EventArgs.Empty);

                    if (_plm2 != null)
                        _plm2.Notification -= new EventHandler(_plm2_Notification);
                    _plm2 = new DSP_PeakLevelMeter(_stream, -2000);
                    _plm2.CalcRMS = true;
                    _plm2.Notification += new EventHandler(_plm2_Notification);
                    checkBoxLevel2Bypass_CheckedChanged(this, EventArgs.Empty);
                }

                if (_stream != 0 && Bass.BASS_ChannelPlay(_stream, false))
                {
                    // render wave form (this is done in a background thread, so that we already play the channel in parallel)
                    if (this._zoomed)
                        this.buttonZoom.PerformClick();
                    GetWaveForm();

                    Console.WriteLine("Playing");

                    _updateTimer.Start();

                    this.buttonStop.Enabled = true;
                    this.buttonPlay.Enabled = false;
                    BASS_CHANNELINFO info = new BASS_CHANNELINFO();
                    Bass.BASS_ChannelGetInfo(_stream, info);
                    TAG_INFO tagInfo = new TAG_INFO(_fileName);
                    Title.Text = tagInfo.title;
                    Artist.Text = tagInfo.artist;
                    Album.Text = tagInfo.album;
                }
                else
                {
                    Console.WriteLine("Error = {0}", Bass.BASS_ErrorGetCode());
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopStream();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                Bass.BASS_ChannelPause(_stream);
            }
            else
            {
                Bass.BASS_ChannelPlay(_stream, false);
            }
        }
        private void StopStream()
        {
            _updateTimer.Stop();
            // kills rendering, if still in progress, e.g. if a large file was selected
            if (WF != null && WF.IsRenderingInProgress)
                WF.RenderStop();
            DrawWavePosition(-1, -1);

            Bass.BASS_StreamFree(_stream);
            _stream = 0;
            this.labelTime.Text = "Stopped";
            this.buttonStop.Enabled = false;
            this.buttonPlay.Enabled = true;
        }

        private void timerUpdate_Tick(object sender, System.EventArgs e)
        {
            // here we gather info about the stream, when it is playing...
            if (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_STOPPED)
            {
                // the stream is NOT playing anymore...
                //StopStream();
                return;
            }

            // from here on, the stream is for sure playing...
            _tickCounter++;
            long pos = Bass.BASS_ChannelGetPosition(_stream); // position in bytes
            long len = Bass.BASS_ChannelGetLength(_stream); // length in bytes

            if (_tickCounter == 20)
            {
                _tickCounter = 0;
                // reset the peak level every 1000ms (since timer is 50ms)
                if (_plm1 != null)
                    _plm1.ResetPeakHold();
                if (_plm2 != null)
                    _plm2.ResetPeakHold();
            }
            if (_tickCounter % 5 == 0)
            {
                // display the position every 250ms (since timer is 50ms)
                double totaltime = Bass.BASS_ChannelBytes2Seconds(_stream, len); // the total time length
                double elapsedtime = Bass.BASS_ChannelBytes2Seconds(_stream, pos); // the elapsed time length
                double remainingtime = totaltime - elapsedtime;
                this.labelTime.Text = String.Format("Elapsed: {0:#0.00} - Total: {1:#0.00} - Remain: {2:#0.00}", Utils.FixTimespan(elapsedtime, "MMSS"), Utils.FixTimespan(totaltime, "MMSS"), Utils.FixTimespan(remainingtime, "MMSS"));              
            }

            // update the wave position
            DrawWavePosition(pos, len);
            
        }

        private void pictureBoxSpectrum_Click(object sender, System.EventArgs e)
        {
            _fullSpectrum = !_fullSpectrum;
        }

        #region Wave Form 

        // zoom helper varibales
        private bool _zoomed = false;
        private int _zoomStart = -1;
        private long _zoomStartBytes = -1;
        private int _zoomEnd = -1;
        private float _zoomDistance = 5.0f; // zoom = 5sec.

        private Un4seen.Bass.Misc.WaveForm WF = null;
        private void GetWaveForm()
        {
            // render a wave form2
            WF = new WaveForm(this._fileName, new WAVEFORMPROC(MyWaveFormCallback), this);
            WF.FrameResolution = 0.005f; // 5ms are very nice
            WF.CallbackFrequency = 4000; // every 20 seconds rendered (4000*5ms=20sec)
            WF.ColorBackground = SystemColors.Control;
            WF.ColorLeft = Color.Gainsboro;
            WF.ColorLeftEnvelope = Color.Gray;
            WF.ColorRight = Color.LightGray;
            WF.ColorRightEnvelope = Color.DimGray;
            WF.ColorMarker = Color.DarkBlue;
            WF.DrawWaveForm = WaveForm.WAVEFORMDRAWTYPE.Stereo;
            WF.DrawMarker = WaveForm.MARKERDRAWTYPE.Line | WaveForm.MARKERDRAWTYPE.Name | WaveForm.MARKERDRAWTYPE.NamePositionAlternate;
            WF.RenderStart(true, BASSFlag.BASS_DEFAULT);
            WF.SyncPlayback(_stream);
        }

        private void MyWaveFormCallback(int framesDone, int framesTotal, TimeSpan elapsedTime, bool finished)
        {
            // will be called during rendering...
            DrawWave();
            if (finished)
            {
                Console.WriteLine("Finished rendering in {0}sec.", elapsedTime);
                Console.WriteLine("FramesRendered={0} of {1}", WF.FramesRendered, WF.FramesToRender);
                // eg.g use this to save the rendered wave form...
                //WF.WaveFormSaveToFile( Path.ChangeExtension(_fileName, ".wf") );
            }
        }

        private void pictureBox1_Resize(object sender, System.EventArgs e)
        {
            DrawWave();
        }

        private void DrawWave()
        {
            if (WF != null)
                this.pictureBox1.BackgroundImage = WF.CreateBitmap(this.pictureBox1.Width, this.pictureBox1.Height, _zoomStart, _zoomEnd, true);
            else
                this.pictureBox1.BackgroundImage = null;
        }

        private void DrawWavePosition(long pos, long len)
        {
            // Note: we might take the latency of the device into account here!
            // so we show the position as heard, not played.
            // That's why we called Bass.Bass_Init with the BASS_DEVICE_LATENCY flag
            // and then used the BASS_INFO structure to get the latency of the device

            if (len == 0 || pos < 0)
            {
                this.pictureBox1.Image = null;
                return;
            }

            Bitmap bitmap = null;
            Graphics g = null;
            Pen p = null;
            double bpp = 0;

            try
            {
                if (_zoomed)
                {
                    // total length doesn't have to be _zoomDistance sec. here
                    len = WF.Frame2Bytes(_zoomEnd) - _zoomStartBytes;

                    int scrollOffset = 1;
                    // if we scroll out the window...(scrollOffset*20ms before the zoom window ends)
                    if (pos > (_zoomStartBytes + len - scrollOffset * WF.Wave.bpf))
                    {
                        // we 'scroll' our zoom with a little offset
                        _zoomStart = WF.Position2Frames(pos - scrollOffset * WF.Wave.bpf);
                        _zoomStartBytes = WF.Frame2Bytes(_zoomStart);
                        _zoomEnd = _zoomStart + WF.Position2Frames(_zoomDistance) - 1;
                        if (_zoomEnd >= WF.Wave.data.Length)
                        {
                            // beyond the end, so we zoom from end - _zoomDistance.
                            _zoomEnd = WF.Wave.data.Length - 1;
                            _zoomStart = _zoomEnd - WF.Position2Frames(_zoomDistance) + 1;
                            if (_zoomStart < 0)
                                _zoomStart = 0;
                            _zoomStartBytes = WF.Frame2Bytes(_zoomStart);
                            // total length doesn't have to be _zoomDistance sec. here
                            len = WF.Frame2Bytes(_zoomEnd) - _zoomStartBytes;
                        }
                        // get the new wave image for the new zoom window
                        DrawWave();
                    }
                    // zoomed: starts with _zoomStartBytes and is _zoomDistance long
                    pos -= _zoomStartBytes; // offset of the zoomed window

                    bpp = len / (double)this.pictureBox1.Width;  // bytes per pixel
                }
                else
                {
                    // not zoomed: width = length of stream
                    bpp = len / (double)this.pictureBox1.Width;  // bytes per pixel
                }

                // we take the device latency into account
                // Not really needed, but if you have a real slow device, you might need the next line
                // so the BASS_ChannelGetPosition might return a position ahead of what we hear
                pos -= _deviceLatencyBytes;

                p = new Pen(Color.Red);
                bitmap = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
                g = Graphics.FromImage(bitmap);
                g.Clear(Color.White);
                int x = (int)Math.Round(pos / bpp);  // position (x) where to draw the line
                g.DrawLine(p, x, 0, x, this.pictureBox1.Height - 1);
                bitmap.MakeTransparent(Color.White);
            }
            catch
            {
                bitmap = null;
            }
            finally
            {
                // clean up graphics resources
                if (p != null)
                    p.Dispose();
                if (g != null)
                    g.Dispose();
            }

            this.pictureBox1.Image = bitmap;
        }

        private void buttonZoom_Click(object sender, System.EventArgs e)
        {
            if (WF == null)
                return;

            // WF is not null, so the stream must be playing...
            if (_zoomed)
            {
                // unzoom...(display the whole wave form)
                _zoomStart = -1;
                _zoomStartBytes = -1;
                _zoomEnd = -1;
                _zoomDistance = 5.0f; // zoom = 5sec.
            }
            else
            {
                // zoom...(display only a partial wave form)
                long pos = Bass.BASS_ChannelGetPosition(this._stream);
                // calculate the window to display
                _zoomStart = WF.Position2Frames(pos);
                _zoomStartBytes = WF.Frame2Bytes(_zoomStart);
                _zoomEnd = _zoomStart + WF.Position2Frames(_zoomDistance) - 1;
                if (_zoomEnd >= WF.Wave.data.Length)
                {
                    // beyond the end, so we zoom from end - _zoomDistance.
                    _zoomEnd = WF.Wave.data.Length - 1;
                    _zoomStart = _zoomEnd - WF.Position2Frames(_zoomDistance) + 1;
                    _zoomStartBytes = WF.Frame2Bytes(_zoomStart);
                }
            }
            _zoomed = !_zoomed;
            // and display this new wave form
            DrawWave();
        }

        private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (WF == null)
                return;

            if (e.Button == MouseButtons.Left)
            {
                long pos = WF.GetBytePositionFromX(e.X, this.pictureBox1.Width, _zoomStart, _zoomEnd);
                // set Start marker
                WF.AddMarker("START", pos);
                Bass.BASS_ChannelSetPosition(_stream, pos);
                if (WF.Wave.marker.ContainsKey("END"))
                {
                    long endpos = WF.Wave.marker["END"];
                    if (endpos < pos)
                    {
                        WF.RemoveMarker("END");
                    }
                }
                DrawWave();
            }
            else if (e.Button == MouseButtons.Right)
            {
                long pos = WF.GetBytePositionFromX(e.X, this.pictureBox1.Width, _zoomStart, _zoomEnd);
                // set End marker
                WF.AddMarker("END", pos);
                Bass.BASS_ChannelRemoveSync(_stream, _syncer);
                _syncer = Bass.BASS_ChannelSetSync(_stream, BASSSync.BASS_SYNC_POS, pos, _sync, IntPtr.Zero);
                if (WF.Wave.marker.ContainsKey("START"))
                {
                    long startpos = WF.Wave.marker["START"];
                    if (startpos > pos)
                    {
                        WF.RemoveMarker("START");
                    }
                }
                DrawWave();
            }
        }

        private void SetPosition(int handle, int channel, int data, IntPtr user)
        {
            if (WF.Wave.marker.ContainsKey("START"))
            {
                long startpos = WF.Wave.marker["START"];
                Bass.BASS_ChannelSetPosition(_stream, (long)startpos);
                if (_zoomed)
                {
                    _zoomStart = WF.Position2Frames((long)startpos) - 1;
                    _zoomStartBytes = WF.Frame2Bytes(_zoomStart);
                    if (WF.Wave.marker.ContainsKey("END"))
                    {
                        long endpos = WF.Wave.marker["END"];
                        _zoomEnd = WF.Position2Frames((long)endpos) + 10;
                        _zoomDistance = WF.Frame2Bytes(_zoomEnd) - WF.Frame2Bytes(_zoomStart);
                    }
                    DrawWave();
                }
            }
            else
                Bass.BASS_ChannelSetPosition(_stream, 0);

        }

        #endregion

        #region PeakLevelMeter

        private void _plm1_Notification(object sender, EventArgs e)
        {
            try
            {
                // sender will be the DSP_PeakLevelMeter instance
                // you could also access it via: DSP_PeakLevelMeter plm = (DSP_PeakLevelMeter)sender;
                this.progressBarPeak1Left.Value = _plm1.LevelL;
                this.progressBarPeak1Right.Value = _plm1.LevelR;
                this.labelLevel1.Text = String.Format("RMS: {0:#00.0} dB    AVG: {1:#00.0} dB    Peak: {2:#00.0} dB", _plm1.RMS_dBV, _plm1.AVG_dBV, Math.Max(_plm1.PeakHoldLevelL_dBV, _plm1.PeakHoldLevelR_dBV));
            }
            catch { }
        }

        private void _plm2_Notification(object sender, EventArgs e)
        {
            try
            {
                // sender will be the DSP_PeakLevelMeter instance
                // you could also access it via: DSP_PeakLevelMeter plm = (DSP_PeakLevelMeter)sender;
                this.progressBarPeak2Left.Value = _plm2.LevelL;
                this.progressBarPeak2Right.Value = _plm2.LevelR;
                this.labelLevel2.Text = String.Format("RMS: {0:#00.0} dB    AVG: {1:#00.0} dB    Peak: {2:#00.0} dB", _plm2.RMS_dBV, _plm2.AVG_dBV, Math.Max(_plm2.PeakHoldLevelL_dBV, _plm2.PeakHoldLevelR_dBV));
                // display the effect
                int effect = Math.Max(_plm2.LevelL, _plm2.LevelR) - Math.Max(_plm1.LevelL, _plm1.LevelR);
                this.trackBarEffect.Value = effect;
            }
            catch { }
        }

        private void checkBoxLevel1Bypass_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_plm1 != null)
                _plm1.SetBypass(!checkBoxLevel1Bypass.Checked);
        }

        private void checkBoxLevel2Bypass_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_plm2 != null)
                _plm2.SetBypass(!checkBoxLevel2Bypass.Checked);
        }

        #endregion PeakLevelMeter

        #region DSP_Gain

        private void buttonSetGain_Click(object sender, System.EventArgs e)
        {
            if (_gain != null)
            {
                try
                {
                    double gainDB = double.Parse(this.textBoxGainDBValue.Text);
                    if (gainDB == 0.0)
                        _gain.SetBypass(true);
                    else
                    {
                        _gain.SetBypass(false);
                        _gain.Gain_dBV = gainDB;
                    }
                    trackBarGain.Value = (int)(gainDB * 1000d);
                }
                catch { }
            }
        }

        private void trackBarGain_ValueChanged(object sender, System.EventArgs e)
        {
            if (_gain != null)
                this.textBoxGainDBValue.Text = Convert.ToString(trackBarGain.Value / 1000d);
            buttonSetGain_Click(this, EventArgs.Empty);
        }

        private void checkBoxGainDither_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_gain != null)
            {
                _gain.UseDithering = checkBoxGainDither.Checked;
            }
            if (_stereoEnh != null)
            {
                _stereoEnh.UseDithering = checkBoxGainDither.Checked;
            }
        }

        #endregion DSP_Gain

        #region DynAmp

        private int _dampFX = 0;
        private void checkBoxDAmp_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_stream == 0)
                return;

            if (checkBoxDAmp.Checked)
            {
                _dampFX = Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_BFX_DAMP, _dampPrio);
                Bass.BASS_FXSetParameters(_dampFX, _damp);

            }
            else
            {
                Bass.BASS_ChannelRemoveFX(_stream, _dampFX);
                _dampFX = 0;
            }
        }

        #endregion DynAmp

        #region Compressor

        private int _compFX = 0;
        private void checkBoxCompressor_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_stream == 0)
                return;

            if (checkBoxCompressor.Checked)
            {
                _compFX = Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_DX8_COMPRESSOR, _compPrio);
                Bass.BASS_FXSetParameters(_compFX, _comp);

            }
            else
            {
                Bass.BASS_ChannelRemoveFX(_stream, _compFX);
                _compFX = 0;
            }
        }

        private void trackBarCompressor_ValueChanged(object sender, System.EventArgs e)
        {
            if (_stream == 0)
                return;

            _comp.fThreshold = (float)Utils.DBToLevel(trackBarCompressor.Value / 10d, 1.0);
            Bass.BASS_FXSetParameters(_compFX, _comp);

            labelCompThreshold.Text = String.Format("Threshold: {0:#0.0} dB", trackBarCompressor.Value / 10d);
        }

        #endregion Compressor

        #region StereoEnhancer

        private void checkBoxStereoEnhancer_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void trackBarStereoEnhancerWide_ValueChanged(object sender, System.EventArgs e)
        {
            if (_stereoEnh != null)
                _stereoEnh.WideCoeff = trackBarStereoEnhancerWide.Value / 100d;
            labelStereoEnhancer.Text = String.Format("Wide: {0:#0.00}, {1:#0.00}", trackBarStereoEnhancerWide.Value / 100d, trackBarStereoEnhancerWetDry.Value / 100d);
        }

        private void trackBarStereoEnhancerWetDry_ValueChanged(object sender, System.EventArgs e)
        {

        }

        #endregion StereoEnhancer

        #region Mono

        private void checkBoxMono_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_stream == 0)
                return;

            if (_mono.IsAssigned)
            {
                _mono.Stop();
            }
            else
            {
                _mono.ChannelHandle = _stream;
                _mono.DSPPriority = 0;
                _mono.UseDithering = true;
                _mono.Invert = checkBoxMonoInvert.Checked;
                _mono.Start();
            }
        }

        private void checkBoxMonoInvert_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_mono != null)
                _mono.Invert = checkBoxMonoInvert.Checked;
        }

        #endregion Mono

        #region IIR Delay

        private void checkBoxIIRDelay_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_delay != null)
                _delay.SetBypass(!checkBoxIIRDelay.Checked);
        }

        private void trackBarIIRDelay_ValueChanged(object sender, System.EventArgs e)
        {

        }

        private void trackBarIIRDelayWetDry_ValueChanged(object sender, System.EventArgs e)
        {
            if (_delay != null)
                _delay.WetDry = trackBarIIRDelayWet.Value / 100d;
        }

        private void trackBarIIRDelayFeedback_ValueChanged(object sender, System.EventArgs e)
        {
            if (_delay != null)
                _delay.Feedback = trackBarIIRDelayFeedback.Value / 100d;
        }

        #endregion IIR Delay

        #region Soft Saturation

        private void checkBoxSoftSat_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void trackBarSoftSat_ValueChanged(object sender, System.EventArgs e)
        {
            if (_softSat != null)
                _softSat.Factor = trackBarSoftSat.Value / 100d;
        }

        private void trackBarSoftSatDepth_ValueChanged(object sender, System.EventArgs e)
        {
            if (_softSat != null)
                _softSat.Depth = trackBarSoftSatDepth.Value / 100d;
        }

        #endregion Soft Saturation

        #region Stream Copy

        private BASS_INFO _info = Bass.BASS_GetInfo();
        private void comboBoxStreamCopy_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (_streamCopy != null)
            {
                _streamCopy.Stop();
                _streamCopy = null;
                return;
            }

            int dev = comboBoxStreamCopy.SelectedIndex;
            if (_stream != 0)
            {
                if (!Bass.BASS_Init(dev, 44100, BASSInit.BASS_DEVICE_LATENCY, this.Handle))
                    Bass.BASS_SetDevice(dev); // already?!
                _info = Bass.BASS_GetInfo();

                // add the stream copy option
                _streamCopy = new DSP_StreamCopy();
                _streamCopy.OutputLatency = _info.latency;
                _streamCopy.ChannelHandle = _stream;
                _streamCopy.DSPPriority = checkBoxStreamCopy.Checked ? -4000 : 4000;
                _streamCopy.StreamCopyDevice = dev;
                //_streamCopy.StreamCopyFlags = BASSFlag.BASS_SPEAKER_REAR;
                _streamCopy.Start();
            }
        }

        private void checkBoxStreamCopy_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_streamCopy != null)
            {
                _streamCopy.DSPPriority = checkBoxStreamCopy.Checked ? -4000 : 4000;
            }
        }

        #endregion Stream Copy
    }
}
