//Programmer: Mary Celeste Fischer
//Email: mfischer7@cnm.edu
//LogoOrderItem.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FischerP3
{
    class LogoOrderItem
    {
        //properties:
        private bool _hasLogo;
        public bool HasLogo
        {
            get { return _hasLogo; }
            set { _hasLogo = value; Calc(); }
        }

        private string _itemType;
        public string ItemType
        {
            get { return _itemType; }
            set { _itemType = value; Calc(); }
        }

        private int _numColors;
        public int NumColors
        {
            get { return _numColors; }
            set { _numColors = value; Calc(); }
        }
        private int _numItems;
        public int NumItems
        {
            get { return _numItems; }
            set { _numItems = value; Calc(); }
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; Calc(); }
        }

        public int ItemID { get; set; }
        public decimal Price { get; private set; } //read only

        //Constructors: 
        public LogoOrderItem(bool hasLogo, string itemType, int numColors, int numItems, string text, int itemID)
        {
            HasLogo = hasLogo;
            ItemType = itemType;
            NumColors = numColors;
            NumItems = numItems;
            Text = text;
            ItemID = itemID;

        }

        public LogoOrderItem(bool hasLogo, string text): this(hasLogo, "mug", 0, 0, text, -1)
        {
            
        }

        public LogoOrderItem(): this (false, "mug", 0, 0, "Your text here", -1)
        {

        }

        //Calc method
        private void Calc()
        {
            decimal textCost = 0.05M;
            decimal graphicCost = 0.10M;
            decimal colorCost = 0.03M * _numColors;
            decimal baseCost;
            if (_itemType == "Pen")
            {
                baseCost = 1.00M;
            }
            else if (_itemType == "Mug")
            {
                baseCost = 3.50M;
            }
            else
            {
                baseCost = 4.00M;
            }


            if (_hasLogo && Text != "") //has graphic logo and text
            {
                Price = (baseCost + textCost + graphicCost + colorCost) * _numItems;
            }
            else if (_hasLogo && Text == "") //has graphic logo only
            {
                Price = (baseCost + colorCost + graphicCost) * _numItems;
            }
            else //has text only
            {
                Price = (baseCost + textCost) * _numItems;
            }
           
            //Calc method based on the following:
            //base cost:
                //pen $1.00
                //mug $3.50
                //usb $4.00
            //add ons:
                //text only logo: add $0.05 for every item that has text (pen, mug, usb drive)
                //graphic logo: add $0.10 per item (pen, mug, or usb drive)
                //color logo: add $0.03 per color per item (pen, mug, or usb drive)

        }

        public string GetOrderSummary()
        {
            if (_hasLogo)
            {
               return "You have ordered: " + _numItems + " " + _itemType + "(s) with a " + _numColors +
                   " color logo and the following text: " + _text + "\nTotal: $" + Price;
            }
            else
            {
                return "You have ordered: " + _numItems + " " + _itemType + "(s) with no logo and the following text: " + _text +
                    "\nTotal: $" + Price;
            }
        }

    }
}
