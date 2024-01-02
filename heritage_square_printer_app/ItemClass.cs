using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage_square_printer_app
{
    internal class ItemClass
    {

       public string Booth { get; set; }
        public string ItemNumber { get; set; }
        public string DescOne;
        public string DescTwo;
        public string DescThree;

        // if I add sql this will be usefull ... probably 
        public string Desc { get { return $"{DescOne} {DescTwo} {DescThree}"; } set { } }

        public string Amount { get; set; }

      
        public ItemClass(string booth,string itemNumber , string descOne, string descTwo, string descThree, string amount) { 
        
            this.Booth = booth;
            this.ItemNumber = itemNumber;
            this.DescOne = descOne;
            this.DescTwo = descTwo;
            this.DescThree = descThree;

            this.Amount = amount;
        
        }
    }
}
