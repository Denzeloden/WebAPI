
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_button(object sender, EventArgs e)//generates password
        {

            Random random = new Random();
            //int randomn = random.Next(0, 1000);

            // output.Text = randomn.ToString();
            ////////////////////////////////
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var charscombination = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var charsnumbers = "0123456789";
            var stringChars = new char[8];
            var randomc = new Random();
            string option = "";
           // int ch = 1;
            if (output.Tag == "Numbers")//if selected choice is ch 1 or numbers
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = charsnumbers[random.Next(charsnumbers.Length)];
                }
            }
            else if (output.Tag == "Letters")//if selected choice is ch 2 or numbers
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
            }
            else if (output.Tag == "Combination")
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = charscombination[random.Next(charscombination.Length)];
                }
            }
            output.Text = new String(stringChars);
        }

        private void Form1_Load(object sender, EventArgs e)//Password format options
        {
            //Creates listView Items
            ListViewItem c1 = new ListViewItem("Numbers");

            ListViewItem c2 = new ListViewItem("Letters");

            ListViewItem c3 = new ListViewItem("Combination");

            //add listView Items to ListView
            listView_options.Items.Add(c1);
            listView_options.Items.Add(c2);
            listView_options.Items.Add(c3);
        }

        private void Select_button_Click(object sender, EventArgs e)
        {//Selecet pasword format options
            string option = "";
            string selectedoption = listView_options.SelectedItems[0].Text;//assigns the selected option to string selectoption
            switch (selectedoption)
            {
                case "Numbers":
                     //option = "1";
                    output.Tag = selectedoption;//add
                    break;
                case "Letters":
                     //option = "2";
                    output.Tag = selectedoption;//subtract
                    break;
                case "Combination":
                    //option = "3";
                    output.Tag = selectedoption;//divide
                    break;
                   
            }
           // string selectedoption = "1";
            //Options.Tag = selectedoption;
        }
    }
}
