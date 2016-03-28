using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassCSharp328
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStandardize_Click(object sender, EventArgs e)
        {
            string addressLine = "";
            string addressNumbers = "";

            addressLine = tbAddressLineOne.Text;

            for(int i = 0; i < addressLine.Length; i++)
            {
                if (Char.IsDigit(addressLine, i))
                {
                    addressNumbers = addressNumbers + addressLine[i];
                }
            }

            string[] addressArray = addressLine.Split();
            foreach(string str in addressArray)
            {

            }
        }

        private string checkAbbreviations(string toCheck)
        {
            string rtrnWord = "";
            if(toCheck == "")
            {
                rtrnWord = "Avenue";
            }
            else
            {
                rtrnWord = toCheck;
            }
            return rtrnWord;
        }
    }
}
