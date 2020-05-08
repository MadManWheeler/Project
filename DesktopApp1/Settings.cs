using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;

namespace DesktopApp1
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            string curItem = Properties.Settings.Default.Cuisines;

            textBox2.Text = Properties.Settings.Default.Email;
            String[] spearator = { " ", " " };
            Int32 count = 20;
            string[] aExclude = new string[5];
            aExclude = curItem.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);


            foreach (string i in aExclude)
            {
                int counter = 0;

                //int index = listBox2.FindString(curItem.Trim()); 
                int index = listBox2.FindString(i);
                listBox2.SetSelected(index, true);
                counter++;


            }


            curItem = Properties.Settings.Default.Alergies;
            aExclude = curItem.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);

            foreach (string i in aExclude)
            {
                int counter = 0;
                
                int index = listBox1.FindString(i);
                
                listBox1.SetSelected(index, true);
                    
                counter++;


            }

            curItem = Properties.Settings.Default.Exclude;
            aExclude = curItem.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);

            foreach (string i in aExclude)
            {
                int counter = 0;

                listBox4.Items.Add(i);

                counter++;


            }

            curItem = Properties.Settings.Default.Diet;
            aExclude = curItem.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);

            foreach (string i in aExclude)
            {
                int counter = 0;

                int index = listBox3.FindString(i);

                listBox3.SetSelected(index, true);

                counter++;


            }


        }

        public void GetSettings()
        {
            StringCollection myCol = new StringCollection();
            String[] myArr = new String[] {};
            myCol.AddRange(myArr);
            //listBox4.Items.ToString() = Properties.Settings.Default.Exclude;
            int i = 0;
            foreach (var item in listBox4.Items)
            {
                myArr[i] = item.ToString();
                i++;
            }
            //myCol = Properties.Settings.Default.Exclude;

        }   
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {

            //use one loop for this?
            
            string strselecteditems = null;
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                strselecteditems = strselecteditems + " " + listBox2.SelectedItems[i].ToString();

                //Call the database function.
            }
            Properties.Settings.Default.Cuisines = strselecteditems;
            MessageBox.Show(strselecteditems.ToString());
            Properties.Settings.Default.Save();

            strselecteditems = null;
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                strselecteditems = strselecteditems + " " + listBox1.SelectedItems[i].ToString();

                //Call the database function.
            }
            Properties.Settings.Default.Alergies = strselecteditems;
            MessageBox.Show(strselecteditems.ToString());
            Properties.Settings.Default.Save();

            strselecteditems = null;
            for (int i = 0; i < listBox3.SelectedItems.Count; i++)
            {
                strselecteditems = strselecteditems + " " + listBox3.SelectedItems[i].ToString();

                //Call the database function.
            }
            Properties.Settings.Default.Diet = strselecteditems;
            MessageBox.Show(strselecteditems.ToString());
            Properties.Settings.Default.Save();


            
            //Properties.Settings.Default.Exclude = listBox4.Items.ToString();
            //MessageBox.Show(Properties.Settings.Default.Exclude);

           strselecteditems = null;
            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                strselecteditems = strselecteditems + " " + listBox4.Items[i].ToString();

                //Call the database function.
            }
            Properties.Settings.Default.Exclude = strselecteditems;
            MessageBox.Show(strselecteditems.ToString());
            Properties.Settings.Default.Save();

            
            Properties.Settings.Default.Email = textBox2.Text;
            
            Properties.Settings.Default.Save();


            //add try catch

            //add try catch here
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add(textBox1.Text);
            textBox1.Clear();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox4.Items.Remove(listBox4.SelectedItem);

            
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
