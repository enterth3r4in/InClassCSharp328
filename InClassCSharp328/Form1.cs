using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InClassCSharp328
{
    public partial class Form1 : Form
    {
        struct Address
        {
            public string addressLineOne;
            public string addressLineTwo;
            public string City;
            public string State;
            public string ZipCode;
        }

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
            string words = "";
            foreach(string str in addressArray)
            {
                words = words + " " + checkAbbreviations(str);
            }
            MessageBox.Show(addressNumbers);
            MessageBox.Show(words);
        }

        private string checkAbbreviations(string toCheck)
        {
            string rtrnWord = "";
            if (toCheck.ToLower().Contains("ave"))
            {
                rtrnWord = "Avenue";
            }
            else
            {
                rtrnWord = toCheck;
            }
            return rtrnWord;
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                string addressLine;
                int count;

                char[] delim = { ',' };

                inputFile = File.OpenText("addresses.csv");
                while(!inputFile.EndOfStream)
                {
                    addressLine = inputFile.ReadLine();
                    string[] tokens = addressLine.Split(delim);
                    foreach(string str in tokens)
                    {
                        MessageBox.Show(str);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the program.");
            Application.Exit();
        }

        private void btnStructure_Click(object sender, EventArgs e)
        {
            Address addressOne = new Address();
            addressOne.addressLineOne = tbSAddressLineOne.Text;
            addressOne.addressLineTwo = tbSAddressLineTwo.Text;
            addressOne.City = tbSCity.Text;
            addressOne.State = tbSCity.Text;
            addressOne.ZipCode = tbSZipCode.Text;

            tbAddressLineOne.Text = addressOne.addressLineOne;
            tbAddressLineTwo.Text = addressOne.addressLineTwo;
            tbCityInput.Text = addressOne.City;
            tbStateInput.Text = addressOne.State;
            tbZipCodeInput.Text = addressOne.ZipCode;
        }
    }
}
