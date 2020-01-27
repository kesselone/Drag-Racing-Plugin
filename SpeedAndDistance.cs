using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using PluginContracts;
using DataConnection;
using Settings;


namespace SpeedAndDistance
{
    
    [Export(typeof(IDataIOProvider))]
    public class SpeedAndDistance: IDataIOProvider
    {
        private System.Windows.Forms.ToolStripMenuItem menuEntry = new ToolStripMenuItem();
        private OnePlugInDataConnection speed = new OnePlugInDataConnection();
        private OnePlugInDataConnection distance = new OnePlugInDataConnection();
        
        private List<OnePlugInDataConnection> data = new List<OnePlugInDataConnection>();
        private DynoDataConnection dynoDataConnection;
        public event ConfigChangeEventHandler OnConfigurationChange; // not needed for this module
        private SetDistancePerRev setDistancePerRev = new SetDistancePerRev();

        public string name
        {
            get
            {
                return "Drag Racing";
            }
        }

        public string pluginDescription
        {
            get
            {
                return "This plugin combines gauges and logging of speed and distance plugin and the USB Relay plugin functionallity. This way it adds drag racing capabilities including controlling a starting light";
            }
        }

        public string version
        {
            get
            {
                return "1.1";
            }
        }


        public void initDynoDataConnection(DynoDataConnection d)
        {
            dynoDataConnection = d;
            dynoDataConnection.OnDynoDataReceived += DynoDataReceivedEventHandler;
        }

        public SpeedAndDistance()
        {
            if (Properties.Settings.Default.upgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.upgradeRequired = false;
                Properties.Settings.Default.Save();
            }

            this.menuEntry.Name = "menuEntry";
            this.menuEntry.Text = "Drag Racing";
            this.menuEntry.Click += new System.EventHandler(this.menuItem_Click);

            speed.name = "Speed";
            if (Settings.Properties.Settings.Default.UnitSelection == "Metric")
                speed.unit = "kph";
            else
                speed.unit = "mph";
            speed.graphPane = 1;
            speed.isY2Axis = true;
            speed.showGaugeInRunWindow = true;
            speed.applyNoiseFiltering = true;
            data.Add(speed);

            distance.name = "Distance";
            if (Settings.Properties.Settings.Default.UnitSelection == "Metric")
                distance.unit = "m";
            else
                distance.unit = "ft";
            distance.graphPane = 1;
            distance.isY2Axis = true;
            distance.showGaugeInRunWindow = true; 
            distance.applyNoiseFiltering = true;
            data.Add(distance);

            // this is necessary for YourDyno to associate each plugin channel with the right plugin
            foreach (OnePlugInDataConnection plugin in data)
                plugin.pluginName = name;
            
            
            
        }

        public System.Windows.Forms.ToolStripMenuItem pluginMenuEntry
        {
            get
            {
                return menuEntry;
            }
        }

        public List<OnePlugInDataConnection> pluginDataConnections
        {
            get
            {
                return data;
            }
        }


        private void menuItem_Click(object sender, EventArgs e)
        {
            setDistancePerRev.ShowDialog();
        
        }

        public void DynoDataReceivedEventHandler(object sender, OnDataReceivedEventArgs e)
        {
            float rollerRPM;
            if (SensorAndBrakeConfig.NumberOfRPMSensors() == 2)
                rollerRPM = (float)(e.processedDynoSample.instantRoller1RPM + e.processedDynoSample.instantRoller2RPM) / 2;
            else
                rollerRPM = (float)e.processedDynoSample.instantRoller1RPM;

            if (Settings.Properties.Settings.Default.UnitSelection == "Metric")
            {
                speed.y = rollerRPM * Properties.Settings.Default.brakeCirc * 60 / 1000;

                if (!dynoDataConnection.isLogging)
                    distance.y = 0;
                else
                    distance.y += rollerRPM / 60 * Properties.Settings.Default.brakeCirc * (float)e.processedDynoSample.timeStamp;
            }
            else
            {
                speed.y = rollerRPM * Properties.Settings.Default.brakeCirc * 60 / 1000 * (float)0.621371;

                if (!dynoDataConnection.isLogging)
                    distance.y = 0;
                else
                    distance.y += rollerRPM / 60 * Properties.Settings.Default.brakeCirc * (float)e.processedDynoSample.timeStamp * (float) 3.28084;
            }
            
            /////////////Drag Racing:
            float distance_target = 0, speed_target = 0;
            
            
            switch (Properties.Settings.Default.race_mode)
            {
                case 0:
                    distance_target = 201.168F; //1/8th mile
                    speed_target = 1000;
                    break;
                case 1:
                    distance_target = 402.336F; //1/4th mile
                    speed_target = 1000;
                    break;
                case 2:
                    distance_target = 804.672F; //1/2 mile
                    speed_target = 1000;
                    break;
                case 3:
                    distance_target = 10000; //NA
                    speed_target = 100; //0-100kmh
                    break;
                case 4:
                    distance_target = 10000; //NA
                    speed_target = 200; //0-100kmh
                    break;
            }
            
            
            switch (Properties.Settings.Default.race_state) //not yet handled...
            {
                case 0:
                //come to stop
                    break;
                case 1:
                if (rollerRPM > 0)
                    {
                        Properties.Settings.Default.race_state = 3; //false start 
                    }
                    break;
                case 2:
                    if (distance.y > distance_target || speed.y > speed_target)
                    {
                        Properties.Settings.Default.race_state = 4; //finished
                    }
                    break;

            }
           



        }
    }
}
