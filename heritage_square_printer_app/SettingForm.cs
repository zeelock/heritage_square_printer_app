using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heritage_square_printer_app
{
    public partial class SettingForm : Form
    {

        settings lableSettings;

        int bX;
        int bY;
        int bSize;

        int inX;
        int inY;
        int inSize;

        int idX;
        int idY;
        int idSize;

        int iaX;
        int iaY;
        int iaSize;



        public SettingForm(settings lableSettings)
        {
            InitializeComponent();

            this.lableSettings = lableSettings;


            boothX.Text = this.lableSettings.boothX.ToString();
            boothY.Text = this.lableSettings.boothY.ToString();
            boothSize.Text = this.lableSettings.boothFountSize.ToString();

            itemNumberX.Text = this.lableSettings.itemNumberX.ToString();
            itemNumberY.Text = this.lableSettings.itemNumberY.ToString();
            itemNumberSize.Text = this.lableSettings.itemNumberFountSize.ToString();

            itemDescX.Text = this.lableSettings.itemDescX.ToString();
            itemDescY.Text = this.lableSettings.itemDescY.ToString();
            itemDescSize.Text = this.lableSettings.itemDescFountSize.ToString();

            itemAmountX.Text = this.lableSettings.priceX.ToString();
            itemAmountY.Text = this.lableSettings.priceY.ToString();
            itemAmountSize.Text = this.lableSettings.priceFountSize.ToString();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (int.TryParse(boothX.Text, out bX) 
                && int.TryParse(boothY.Text, out bY)
                && int.TryParse(boothSize.Text, out bSize)
                
                && int.TryParse(itemNumberX.Text, out inX)
                && int.TryParse(itemNumberY.Text, out inY)
                && int.TryParse(itemNumberSize.Text, out inSize) 
                
                && int.TryParse(itemDescX.Text, out idX) 
                && int.TryParse(itemDescY.Text, out idY) 
                && int.TryParse(itemDescSize.Text, out idSize)
                
                && int.TryParse(itemAmountX.Text, out iaX) 
                && int.TryParse(itemAmountY.Text, out iaY) 
                && int.TryParse(itemAmountSize.Text, out iaSize))

            {

                this.lableSettings.boothX = bX;
                this.lableSettings.boothY = bY;
                this.lableSettings.boothFountSize = bSize;


                this.lableSettings.itemNumberX = inX;
                this.lableSettings.itemNumberY = inY;
                this.lableSettings.itemNumberFountSize = inSize;

                this.lableSettings.itemDescX = idX;
                this.lableSettings.itemDescY = idY;
                this.lableSettings.itemDescFountSize = idSize;


                this.lableSettings.priceX = iaX;
                this.lableSettings.priceY = iaY;
                this.lableSettings.priceFountSize = iaSize;

                settings.AddUpdateAppSettings("boothX" , bX.ToString());
                settings.AddUpdateAppSettings("boothY", bY.ToString());
                settings.AddUpdateAppSettings("boothFountSize", bSize.ToString());

                settings.AddUpdateAppSettings("itemNumberX", inX.ToString());
                settings.AddUpdateAppSettings("itemNumberY", inY.ToString());
                settings.AddUpdateAppSettings("itemNumberFountSize", inSize.ToString());


                settings.AddUpdateAppSettings("itemDescX", idX.ToString());
                settings.AddUpdateAppSettings("itemDescY", idY.ToString());
                settings.AddUpdateAppSettings("itemDescFountSize", idSize.ToString());

                settings.AddUpdateAppSettings("priceX", iaX.ToString());
                settings.AddUpdateAppSettings("priceY", iaY.ToString());
                settings.AddUpdateAppSettings("priceFountSize", iaSize.ToString());




                Close();

            }
            else {

                MessageBox.Show("An error accored");
            }



        }
    }
}
