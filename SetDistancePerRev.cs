// https://www.ebay.com/itm/1-2-4-8-Ch-5V-10V-USB-Relay-Programmable-Computer-Control-Relay-For-Smart-Home/192208103778?hash=item2cc07ee962:m:mlg_RwObhC-7ozedu3cOnAQ:rk:1:pf:0


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.IO;
using USB;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;
using PluginContracts;
using DataConnection;


namespace SpeedAndDistance
{
    public partial class SetDistancePerRev : Form
    {
        string dlldir; //Remembers the location of the installed driver
        private int counter;
        Stopwatch stopwatch = new Stopwatch();
        HotKey HK = new HotKey();
        StatusOverlay statusOverlay = new StatusOverlay
        {
            Size = new System.Drawing.Size(398, 38),
            
        };


        //Loads the driver from embeded resource
        static public class NativeMethods
        {
            [DllImport("kernel32.dll")]
            public static extern IntPtr LoadLibrary(string dllToLoad);
        }

        //Loads the driver from embeded resource
        public static class CommonUtils
        {
            public static string LoadUnmanagedLibraryFromResource(Assembly assembly,
                string libraryResourceName,
                string libraryName)
            {
                string tempDllPath = string.Empty;
                using (Stream s = assembly.GetManifestResourceStream(libraryResourceName))
                {
                    byte[] data = new BinaryReader(s).ReadBytes((int)s.Length);

                    string assemblyPath = Path.GetDirectoryName(assembly.Location);
                    tempDllPath = Path.Combine(assemblyPath, libraryName);

                    File.WriteAllBytes(tempDllPath, data);

                }

                NativeMethods.LoadLibrary(libraryName);
                return tempDllPath;
            }
        }

        //Is called when "YourDyno" Closes
        private void OnApplicationExit(object sender, EventArgs e)
        {
            try
            {
                RelayManager.CloseAllChannels(); //Closes all relay channels
            }
            catch
            {
                MessageBox.Show("Failed to close relays.");
            }

            try
            {
                //Removes the driver (Needs to be done though CMD since not every one runs "YourDyno" as admin.
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C del " + dlldir;
                process.StartInfo = startInfo;
                process.Start();
            }
            catch
            {
                MessageBox.Show("Failed to clean up USB Relay Driver.");
            }
        }


        public SetDistancePerRev()
        {
            //defines the internal USB Relay driver resource
            string resourceName = "SpeedAndDistance.USB_RELAY_DEVICE.dll";
            string libraryName = "USB_RELAY_DEVICE.dll";

            // create and load library from the resource
            string tempDllPath = CommonUtils.LoadUnmanagedLibraryFromResource(Assembly.GetExecutingAssembly(),
                resourceName,
                libraryName);
            dlldir = tempDllPath;
            // invoke native library function

            //Makes a new event for when "YourDyno" closes.
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            ////////////////////////////////////
            ///Hotkeys
            ///
            ////////////////////////////////////
            //Hilfsform erschaffen um die Hotkeys zu behandeln. nicht sichtbar
            Form HKHandlerForm = new Form() { Visible = false };

            HK.OwnerForm = HKHandlerForm;

            HK.HotKeyPressed += new HotKey.HotKeyPressedEventHandler(HK_HotKeyPressed);

            HK.AddHotKey(Keys.F1, HotKey.MODKEY.MOD_CONTROL, "Relay1Key");
            HK.AddHotKey(Keys.F2, HotKey.MODKEY.MOD_CONTROL, "Relay2Key");
            HK.AddHotKey(Keys.F3, HotKey.MODKEY.MOD_CONTROL, "Relay3Key");
            HK.AddHotKey(Keys.F4, HotKey.MODKEY.MOD_CONTROL, "Relay4Key");
            HK.AddHotKey(Keys.F5, HotKey.MODKEY.MOD_CONTROL, "Relay5Key");
            HK.AddHotKey(Keys.F6, HotKey.MODKEY.MOD_NONE, "Relay6Key");
            HK.AddHotKey(Keys.F7, HotKey.MODKEY.MOD_NONE, "Relay7Key");
            HK.AddHotKey(Keys.F8, HotKey.MODKEY.MOD_NONE, "Relay8Key");

            //////////////////////////////
            ///Relay Status
            ///
            Rectangle screensize=Screen.PrimaryScreen.WorkingArea;
            int xpos = screensize.Width-400;
            int ypos = 25;
            statusOverlay.Location = new System.Drawing.Point(xpos, ypos);

            InitializeComponent();


            
            

            statusOverlay.Show();


            R6.Text = Properties.Settings.Default.R_6Name;
            R7.Text = Properties.Settings.Default.R_7Name;
            R8.Text = Properties.Settings.Default.R_8Name;

            //Starts the driver
            RelayManager.Init();
            startButton.Enabled = true;
            R1.Enabled = false; R1.BackColor = SystemColors.Control;
            R2.Enabled = false; R2.BackColor = SystemColors.Control;
            R3.Enabled = false; R3.BackColor = SystemColors.Control;
            R4.Enabled = false; R4.BackColor = SystemColors.Control;
            R5.Enabled = false; R5.BackColor = SystemColors.Control;
            R6.Enabled = true;
            R7.Enabled = true;
            R8.Enabled = true;

            //Checks to see if there is a connected USB Relay board.
            if (RelayManager.DevicesCount() == 0)
            {
                //MessageBox.Show("USBRelay (No Connected Devices)");

            }
            else
            {
                //Opens first USB Relay board found
                RelayManager.OpenDevice(0);

                //Reads serial number
                RSerial.Text = "USB Relay Serial: " + (RelayManager.RelaySerial().ToString());

                //Reads info on how many channels and enables the correct number of buttons.
                switch (RelayManager.ChannelsCount())
                {
                    case 1:
                        R1.Enabled = true;
                        //Checks state of relay and sets colour accordingly.
                        if (RelayManager.ChannelOpened(1).ToString() == "False") R1.BackColor = SystemColors.Control; else R1.BackColor = Color.ForestGreen;

                        break;
                    case 2:
                        R1.Enabled = true;
                        R2.Enabled = true;
                        if (RelayManager.ChannelOpened(1).ToString() == "False") R1.BackColor = SystemColors.Control; else R1.BackColor = Color.ForestGreen;
                        if (RelayManager.ChannelOpened(2).ToString() == "False") R2.BackColor = SystemColors.Control; else R2.BackColor = Color.ForestGreen;

                        break;
                    case 4:
                        R1.Enabled = true;
                        R2.Enabled = true;
                        R3.Enabled = true;
                        R4.Enabled = true;
                        if (RelayManager.ChannelOpened(1).ToString() == "False") R1.BackColor = SystemColors.Control; else R1.BackColor = Color.ForestGreen;
                        if (RelayManager.ChannelOpened(2).ToString() == "False") R2.BackColor = SystemColors.Control; else R2.BackColor = Color.ForestGreen;
                        if (RelayManager.ChannelOpened(3).ToString() == "False") R3.BackColor = SystemColors.Control; else R3.BackColor = Color.ForestGreen;
                        if (RelayManager.ChannelOpened(4).ToString() == "False") R4.BackColor = SystemColors.Control; else R4.BackColor = Color.ForestGreen;
                        break;
                    case 8:
                        R1.Enabled = true;
                        R2.Enabled = true;
                        R3.Enabled = true;
                        R4.Enabled = true;
                        R5.Enabled = true;
                        R6.Enabled = true;
                        R7.Enabled = true;
                        R8.Enabled = true;
                        if (RelayManager.ChannelOpened(1).ToString() == "False") R1.BackColor = SystemColors.Control; else R1.BackColor = Color.ForestGreen;
                        if (RelayManager.ChannelOpened(2).ToString() == "False") R2.BackColor = SystemColors.Control; else R2.BackColor = Color.ForestGreen;
                        if (RelayManager.ChannelOpened(3).ToString() == "False") R3.BackColor = SystemColors.Control; else R3.BackColor = Color.ForestGreen;
                        if (RelayManager.ChannelOpened(4).ToString() == "False") R4.BackColor = SystemColors.Control; else R4.BackColor = Color.ForestGreen;
                        if (RelayManager.ChannelOpened(5).ToString() == "False") R5.BackColor = SystemColors.Control; else R5.BackColor = Color.ForestGreen;
                        if (RelayManager.ChannelOpened(6).ToString() == "False") R6.BackColor = SystemColors.Control; else R6.BackColor = Color.ForestGreen;
                        if (RelayManager.ChannelOpened(7).ToString() == "False") R7.BackColor = SystemColors.Control; else R7.BackColor = Color.ForestGreen;
                        if (RelayManager.ChannelOpened(8).ToString() == "False") R8.BackColor = SystemColors.Control; else R8.BackColor = Color.ForestGreen;
                        break;
                    default:
                        MessageBox.Show("Something went wrong with detecting number of relays.");
                        break;
                }
            }

            //Fill Text Boxes and other control elements with Settings
            textBoxBrakeCirc.Value = (decimal)Properties.Settings.Default.brakeCirc;
            textBoxCdA.Text = Properties.Settings.Default.CdA.ToString();
            textBoxStageTime.Text = Properties.Settings.Default.preStageTime_ms.ToString();
            textBoxWeight.Text = Properties.Settings.Default.VehicleWeight.ToString();
            if (Properties.Settings.Default.start_mode) radioButtonModeStd.Checked = true; else radioButtonModeNHRA.Checked = true;
            switch (Properties.Settings.Default.race_mode)
            {
                case 0:
                    radioButtonRaceMode1.Checked = true;
                    break;
                case 1:
                    radioButtonRaceMode2.Checked = true;
                    break;
                case 2:
                    radioButtonRaceMode3.Checked = true;
                    break;
                case 3:
                    radioButtonRaceMode4.Checked = true;
                    break;
                case 4:
                    radioButtonRaceMode5.Checked = true;
                    break;
            }


        }

        private void HK_HotKeyPressed(string ID)
        {
            if (ID == "Relay6Key") toggleRelay(6);
            if (ID == "Relay7Key") toggleRelay(7);
            if (ID == "Relay8Key") toggleRelay(8);
            //DEBUG
            //MessageBox.Show(ID);
        }

        private void SetDistancePerRev_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEverything();
        }

        private void SetDistancePerRev_Load(object sender, EventArgs e)
        {

        }
        private void SaveEverything() //This Function is used to save all properties. Should be called when closing form or starting a pull etc.
        {
            if (radioButtonRaceMode1.Checked) Properties.Settings.Default.race_mode = 0;
            if (radioButtonRaceMode2.Checked) Properties.Settings.Default.race_mode = 1;
            if (radioButtonRaceMode3.Checked) Properties.Settings.Default.race_mode = 2;
            if (radioButtonRaceMode4.Checked) Properties.Settings.Default.race_mode = 3;
            if (radioButtonRaceMode5.Checked) Properties.Settings.Default.race_mode = 4;
            statusOverlay.button1.Text = Properties.Settings.Default.R_6Name+" (F6)";
            statusOverlay.button2.Text = Properties.Settings.Default.R_7Name+" (F7)";
            statusOverlay.button3.Text = Properties.Settings.Default.R_8Name+" (F8)";
            Properties.Settings.Default.brakeCirc = (float)textBoxBrakeCirc.Value;
            Properties.Settings.Default.start_mode = radioButtonModeStd.Checked;
            int.TryParse(textBoxStageTime.Text, out int j);
            Properties.Settings.Default.preStageTime_ms = j;
            int.TryParse(textBoxWeight.Text, out int i);
            Properties.Settings.Default.VehicleWeight = i;
            float.TryParse(textBoxCdA.Text, out float k);
            Properties.Settings.Default.CdA = k;

            Properties.Settings.Default.Save();
        }

        private void R1_Click(object sender, EventArgs e)
        {
            toggleRelay(1);
        }
        private void R2_Click(object sender, EventArgs e)
        {
            toggleRelay(2);
        }

        private void R3_Click(object sender, EventArgs e)
        {
            toggleRelay(3);
        }

        private void R4_Click(object sender, EventArgs e)
        {
            toggleRelay(4);
        }

        private void R5_Click(object sender, EventArgs e)
        {
            toggleRelay(5);
        }

        private void R6_Click(object sender, EventArgs e)
        {
            toggleRelay(6);
        }

        private void R7_Click(object sender, EventArgs e)
        {
            toggleRelay(7);
        }
        
        private void R8_Click(object sender, EventArgs e)
        {
            toggleRelay(8);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SaveEverything();
            Properties.Settings.Default.race_state = 0;
            //Race State:
            //0 - before start
            //1 - starting
            //2 - green, Go!
            //3 - false start
            //4 - Finished

            counter = 0;
            RelayManager.Open(0, 1);
            R1.BackColor = Color.Blue;
            RelayManager.Close(0, 2);
            R2.BackColor = SystemColors.Control;
            RelayManager.Close(0, 3);
            R3.BackColor = SystemColors.Control;
            RelayManager.Close(0, 4);
            R4.BackColor = SystemColors.Control;
            RelayManager.Close(0, 5);
            R5.BackColor = SystemColors.Control;
            RelayManager.Close(0, 6);
            R6.BackColor = SystemColors.Control;
            RelayManager.Close(0, 7);
            R7.BackColor = SystemColors.Control;
            buttonCancelRace.Visible = false;

            timer2000.Interval = Properties.Settings.Default.preStageTime_ms;
            if (Properties.Settings.Default.start_mode) { timer500.Interval = 500; } else { timer500.Interval = 400; }
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            
            stopwatch.Stop();
            stopwatch.Reset();

            timer2000.Start();
        }

        private void timer2000_Tick(object sender, EventArgs e)
        {
                    RelayManager.Open(0, 2);
                    R2.BackColor = Color.Orange;
                    timer2000.Stop();
                    timer500.Start();
            Properties.Settings.Default.race_state = 1;
        }

        private void timer500_Tick(object sender, EventArgs e)
        {
            counter++;
            switch (counter)
            {
                case 1:
                    if (Properties.Settings.Default.start_mode)
                    {
                        RelayManager.Close(0, 2);
                        R2.BackColor = SystemColors.Control;
                    }
                    RelayManager.Open(0, 3);
                    R3.BackColor = Color.Orange;
                    break;
                case 2:
                    if (Properties.Settings.Default.start_mode)
                    {
                        RelayManager.Close(0, 3);
                        R3.BackColor = SystemColors.Control;
                    }
                    RelayManager.Open(0, 4);
                    R4.BackColor = Color.Orange;
                    break;
                case 3:
                    RelayManager.Close(0, 2);
                    RelayManager.Close(0, 3);
                    RelayManager.Close(0, 4);
                    RelayManager.Open(0, 5);
                    R2.BackColor = SystemColors.Control;
                    R3.BackColor = SystemColors.Control;
                    R4.BackColor = SystemColors.Control;
                    R5.BackColor = Color.ForestGreen;
                    timer500.Stop();
                    buttonCancelRace.Visible = true;
                    stopwatch.Restart();
                    Properties.Settings.Default.race_state = 2;
                    break;
            }
        }

        private void timerRedraw_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}.{1:000}",
            ts.Seconds, ts.Milliseconds);
            labelRacetime.Text = elapsedTime;
            
            //brakeforce = (1 / 2) * roh_Air / 10000 * CdA * (RollerCirc / 60000 * dynoRollerRPM) ^ 2; //F_brake = 1/2*roh_air*CdA*v^2
        }

        private void labelRacetime_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelRace_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            stopwatch.Stop();
            startButton.Enabled = true;
            RelayManager.Close(0, 1);
            R1.BackColor = SystemColors.Control;
            RelayManager.Close(0, 2);
            R2.BackColor = SystemColors.Control;
            RelayManager.Close(0, 3);
            R3.BackColor = SystemColors.Control;
            RelayManager.Close(0, 4);
            R4.BackColor = SystemColors.Control;
            RelayManager.Close(0, 5);
            R5.BackColor = SystemColors.Control;

            buttonCancelRace.Visible = false;

        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fom_rename fom_Rename = new fom_rename();
            fom_Rename.ShowDialog(this);

            R6.Text = Properties.Settings.Default.R_6Name;
            R7.Text = Properties.Settings.Default.R_7Name;
            R8.Text = Properties.Settings.Default.R_8Name;
        }

        private void toggleRelay(int RelayNo)
        {
            //StatusOverlay statusOverlay = new StatusOverlay();
            switch (RelayNo)
            {
                case 1:
                    if (R1.BackColor == SystemColors.Control)
                    {
                        //Enables that relay when button pressed.
                        RelayManager.Open(0, 1);
                        R1.BackColor = Color.ForestGreen;
                        
                    }
                    else
                    {
                        //Disables that relay when button pressed.
                        RelayManager.Close(0, 1);
                        R1.BackColor = SystemColors.Control;
                    }
                    break;
                case 2:
                    if (R2.BackColor == SystemColors.Control)
                    {
                        //Enables that relay when button pressed.
                        RelayManager.Open(0, 2);
                        R2.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        //Disables that relay when button pressed.
                        RelayManager.Close(0, 2);
                        R2.BackColor = SystemColors.Control;
                    }
                    break;
                case 3:
                    if (R3.BackColor == SystemColors.Control)
                    {
                        //Enables that relay when button pressed.
                        RelayManager.Open(0, 3);
                        R3.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        //Disables that relay when button pressed.
                        RelayManager.Close(0, 3);
                        R3.BackColor = SystemColors.Control;
                    }
                    break;
                case 4:
                    if (R4.BackColor == SystemColors.Control)
                    {
                        //Enables that relay when button pressed.
                        RelayManager.Open(0, 4);
                        R4.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        //Disables that relay when button pressed.
                        RelayManager.Close(0, 4);
                        R4.BackColor = SystemColors.Control;
                    }
                    break;
                case 5:
                    if (R5.BackColor == SystemColors.Control)
                    {
                        //Enables that relay when button pressed.
                        RelayManager.Open(0, 5);
                        R5.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        //Disables that relay when button pressed.
                        RelayManager.Close(0, 5);
                        R5.BackColor = SystemColors.Control;
                    }
                    break;
                case 6:
                    if (R6.BackColor == SystemColors.Control)
                    {
                        //Enables that relay when button pressed.
                        RelayManager.Open(0, 6);
                        R6.BackColor = Color.ForestGreen;
                        statusOverlay.button1.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        //Disables that relay when button pressed.
                        RelayManager.Close(0, 6);
                        R6.BackColor = SystemColors.Control;
                        statusOverlay.button1.BackColor = SystemColors.Control;
                    }
                    break;
                case 7:
                    if (R7.BackColor == SystemColors.Control)
                    {
                        //Enables that relay when button pressed.
                        RelayManager.Open(0, 7);
                        R7.BackColor = Color.ForestGreen;
                        statusOverlay.button2.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        //Disables that relay when button pressed.
                        RelayManager.Close(0, 7);
                        R7.BackColor = SystemColors.Control;
                        statusOverlay.button2.BackColor = SystemColors.Control;
                    }
                    break;
                case 8:
                    if (R8.BackColor == SystemColors.Control)
                    {
                        //Enables that relay when button pressed.
                        RelayManager.Open(0, 8);
                        R8.BackColor = Color.ForestGreen;
                        statusOverlay.button3.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        //Disables that relay when button pressed.
                        RelayManager.Close(0, 8);
                        R8.BackColor = SystemColors.Control;
                        statusOverlay.button3.BackColor = SystemColors.Control;
                    }
                    break;

            }

        }

    }
}


/// <summary>
/// Mit dieser Klasse kann man sehr leicht eine globale Hotkey funktionalität in seinem Programm einbinden.
/// Man muss nur dieser Klasse nur eine Form zuweisen die gesubclassed werden soll.
/// Dann muss man nur noch ein paar eigene HotKey-Kombinationen registrieren (z.B. Strg+Alt+X) und diese
/// mit dem Event abfragen bzw. abfangen. Dazu muss man eine eigene HotKeyID angeben um einen bestimmte HotKey
/// Kombination später zu identifizieren wenn diese gedrückt wird. Wenn man z.B. eine Kombination registriert
/// und ihr z.B. die HotKeyID "TEST1" zugewiesen wird dann kann man später im Event nach dieser ID "TEST1" fragen
/// und dann eine Funktion aufrufen die für diesen HotKey bestimmt wurde.
/// </summary>
/// <remarks>Copyright © 2006 Tim Hartwig</remarks>
public class HotKey : IMessageFilter
{
    [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    private static extern int RegisterHotKey(IntPtr Hwnd, int ID, int Modifiers, int Key);

    [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    private static extern int UnregisterHotKey(IntPtr Hwnd, int ID);

    [DllImport("kernel32", EntryPoint = "GlobalAddAtomA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    private static extern short GlobalAddAtom(string IDString);

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    private static extern short GlobalDeleteAtom(short Atom);


    public class HotKeyObject
    {
        private Keys mHotKey;
        private MODKEY mModifier;
        private string mHotKeyID;
        private short mAtomID;

        public Keys HotKey
        {
            get { return mHotKey; }
            set { mHotKey = value; }
        }

        public MODKEY Modifier
        {
            get { return mModifier; }
            set { mModifier = value; }
        }

        public string HotKeyID
        {
            get { return mHotKeyID; }
            set { mHotKeyID = value; }
        }

        public short AtomID
        {
            get { return mAtomID; }
            set { mAtomID = value; }
        }

        public HotKeyObject(Keys NewHotKey, MODKEY NewModifier, string NewHotKeyID)
        {
            mHotKey = NewHotKey;
            mModifier = NewModifier;
            mHotKeyID = NewHotKeyID;
        }
    }

      public Form OwnerForm
       {
           get { return mForm; }
           set { mForm = value; }
       }
      
    private Form mForm;
    private const int WM_HOTKEY = 786;
    private System.Collections.Generic.Dictionary<short, HotKeyObject> mHotKeyList = new System.Collections.Generic.Dictionary<short, HotKeyObject>();
    private System.Collections.Generic.Dictionary<string, short> mHotKeyIDList = new System.Collections.Generic.Dictionary<string, short>();

    /// <summary>
    /// Diesem Event wird immer die zugewiesene HotKeyID übergeben wenn eine HotKey Kombination gedrückt wurde.
    /// </summary>
    public event HotKeyPressedEventHandler HotKeyPressed;
    public delegate void HotKeyPressedEventHandler(string HotKeyID);

    public enum MODKEY : int
    {
        MOD_NONE = 0,
        MOD_ALT = 1,
        MOD_CONTROL = 2,
        MOD_SHIFT = 4,
        MOD_WIN = 8
    }

    public HotKey()
    {
        Application.AddMessageFilter(this);
    }

    /// <summary>
    /// Diese Funktion fügt einen Hotkey hinzu und registriert ihn auch sofort
    /// </summary>
    /// <param name="KeyCode">Den KeyCode für die Taste</param>
    /// <param name="Modifiers">Die Zusatztasten wie z.B. Strg oder Alt, diese können auch mit OR kombiniert werden</param>
    /// <param name="HotKeyID">Die ID die der Hotkey bekommen soll um diesen zu identifizieren</param>
    public void AddHotKey(Keys KeyCode, MODKEY Modifiers, string HotKeyID)
    {
        if (mHotKeyIDList.ContainsKey(HotKeyID) == true) return; // TODO: might not be correct. Was : Exit Sub

        short ID = GlobalAddAtom(HotKeyID);
        mHotKeyIDList.Add(HotKeyID, ID);
        mHotKeyList.Add(ID, new HotKeyObject(KeyCode, Modifiers, HotKeyID));
        RegisterHotKey(mForm.Handle, (int)ID, (int)mHotKeyList[ID].Modifier, (int)mHotKeyList[ID].HotKey);
    }

    /// <summary>
    /// Diese Funktion entfernt einen Hotkey und deregistriert ihn auch sofort
    /// </summary>
    /// <param name="HotKeyID">Gibt die HotkeyID an welche entfernt werden soll</param>
    public void RemoveHotKey(string HotKeyID)
    {
        if (mHotKeyIDList.ContainsKey(HotKeyID) == false) return; // TODO: might not be correct. Was : Exit Sub

        short ID = mHotKeyIDList[HotKeyID];
        mHotKeyIDList.Remove(HotKeyID);
        mHotKeyList.Remove(ID);
        UnregisterHotKey(mForm.Handle, (int)ID);
        GlobalDeleteAtom(ID);
    }

    /// <summary>
    /// Diese Routine entfernt und Deregistriert alle Hotkeys
    /// </summary>
    public void RemoveAllHotKeys()
    {
        List<string> IDList = new List<string>();
        foreach (KeyValuePair<string, short> KVP in mHotKeyIDList)
        {
            IDList.Add(KVP.Key);
        }

        for (int i = 0; i <= IDList.Count - 1; i++)
        {
            RemoveHotKey(IDList[i]);
        }
    }

    public bool PreFilterMessage(ref Message m)
    {
        if (m.Msg == WM_HOTKEY)
        {
            if (HotKeyPressed != null)
            {
                HotKeyPressed(mHotKeyList[(short)m.WParam].HotKeyID);
            }
        }
        return false;
    }
}