using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class Ingrediendts : UserControl
    {
        public Ingrediendts()
        {
            InitializeComponent();
            
             
            
        }

        static public List<string> listING;

        private void button1_Click(object sender, EventArgs e)
        {
            //fix this ugly code
            string getText1 = comboBox1.SelectedItem.ToString();
            string getText2 = comboBox2.SelectedItem.ToString();
            string getText3 = comboBox3.SelectedItem.ToString();
            string getText4 = comboBox4.SelectedItem.ToString();
            string getText5 = comboBox5.SelectedItem.ToString();

            listBox1.Items.Add(getText1);
            listBox1.Items.Add(getText2);
            listBox1.Items.Add(getText3);
            listBox1.Items.Add(getText4);
            listBox1.Items.Add(getText5);

            

            foreach (var item in listBox1.Items)
            {
                listING.Add(item.ToString());
            }

            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void metroScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           listBox1.SelectionMode = SelectionMode.MultiExtended;

            
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }
    }
}
