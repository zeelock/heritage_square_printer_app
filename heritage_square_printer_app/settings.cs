using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace heritage_square_printer_app
{
    public class settings
    {

        public int boothX = 0;
       public int boothY = 0;
        public int boothFountSize = 6;

        public int itemNumberX = 0;
        public int itemNumberY = 0;
        public int itemNumberFountSize = 6;

        public int itemDescX = 0;
        public int itemDescY = 0;
        public int itemDescFountSize = 6;

        public int priceX = 0;
        public int priceY = 0;
        public int priceFountSize = 6;

     
      
        public settings() {

            boothX = (ReadSetting("boothX"));
            boothY = (ReadSetting("boothY"));
            boothFountSize = (ReadSetting("boothFountSize"));

            itemNumberX = (ReadSetting("itemNumberX"));
            itemNumberY = (ReadSetting("itemNumberY"));
            itemNumberFountSize = (ReadSetting("itemNumberFountSize"));

            itemDescX = (ReadSetting("itemDescX"));
            itemDescY =(ReadSetting("itemDescY"));
            itemDescFountSize =(ReadSetting("itemDescFountSize"));

            priceX = (ReadSetting("priceX"));
            priceY = (ReadSetting("priceY"));
            priceFountSize = (ReadSetting("priceFountSize"));

        }

        // updates the app config file 
            public static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Error writing app settings");
            }
        }

        // reads from the app config file
        public static int ReadSetting(string key)
        {
            string results = "";
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                results = appSettings[key] ?? "";

            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Error reading app settings");
            }
           
            return int.Parse(results);
        }




    }
}
