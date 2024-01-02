using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace heritage_square_printer_app
{
    public partial class MainForm : Form
    {
        // thought having a way to print off more that one would be usefull its not really
        BindingList<ItemClass> ItemClasses= new BindingList<ItemClass>();
      
        SettingForm settingsForm;
        settings LableSettings;

        public MainForm()
        {
            InitializeComponent();
  
            // sets the dataViewer to see what will be printed
            ItemDataView.DataSource = ItemClasses;
         
            LableSettings = new settings();
       
        }
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            // formats the item amount and creates a new class for that item 

            if (decimal.TryParse(itemAmountTextBox.Text, out decimal itemAmountDecimal)) {

                string price;

                if (EachcheckBox.Checked)
                {

                    price = $"{itemAmountDecimal:c} ea";
                 
                }
                else {
                    price = $"{itemAmountDecimal:c}";
                }
                
                ItemClasses.Add(new ItemClass(boothTextBox.Text, itemNumbertextBox.Text, ItemDescOneTextBox.Text,ItemDescTwoTextBox.Text, ItemDescThreeTextBox.Text, price));
           
            
            }
       
        
        
        }

        int printDocForLoop;

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // will send a print no preview will just take up time 

     // TODO Find a way to set a printer instead of the defalt printer 

            for (printDocForLoop = 0; printDocForLoop < ItemClasses.Count; printDocForLoop++) {
                //printPreviewDialog1.Document = printDocument1;
                //  printPreviewDialog1.ShowDialog();
                printDocument1.Print();

            }
        
        }


        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
                   // creats the document that will be printed    
                e.Graphics.DrawString($"  {ItemClasses[printDocForLoop].Booth}", new Font("Microsoft Sans Serif", LableSettings.boothFountSize, FontStyle.Bold), Brushes.Black, new Point(LableSettings.boothX, LableSettings.boothY));

                e.Graphics.DrawString($"{ItemClasses[printDocForLoop].ItemNumber} ", new Font("Microsoft Sans Serif", LableSettings.itemNumberFountSize, FontStyle.Bold), Brushes.Black, new Point(LableSettings.itemNumberX, LableSettings.itemNumberY));

                e.Graphics.DrawString($"{ItemClasses[printDocForLoop].DescOne}\n{ItemClasses[printDocForLoop].DescTwo}\n{ItemClasses[printDocForLoop].DescThree}", new Font("Microsoft Sans Serif", LableSettings.itemDescFountSize, FontStyle.Bold), Brushes.Black, new Point(LableSettings.itemDescX, LableSettings.itemDescY));

                e.Graphics.DrawString($" {ItemClasses[printDocForLoop].Amount}", new Font("Microsoft Sans Serif", LableSettings.priceFountSize, FontStyle.Bold), Brushes.Black, new Point(LableSettings.priceX, LableSettings.priceY));
            
        }

        private void SettingsButtons_Click(object sender, EventArgs e)
        {
            // opens the settings form
            settingsForm = new SettingForm(LableSettings);
            settingsForm.ShowDialog();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // this is so that if you want to print one at a time it does not keep reprinting the old ones. 
            ItemClasses.Clear();
        }
    }
}
