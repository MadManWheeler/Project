using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class New : UserControl
    {
        //string done = Form1.passingTxt;

        public New()
        {
            InitializeComponent();
            
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < 9; i++)
            {
                richTextBox[i].Text = Form1.passingTxt[i];
                metroLabel1.Text = Form1.label1[i];
            }*/

            richTextBox1.Text = Form1.passingTxt[0];
            newLabel1.Text = Form1.label1[0];
            richTextBox2.Text = Form1.passingTxt[1];
            newLabel2.Text = Form1.label1[1];
            richTextBox3.Text = Form1.passingTxt[2];
            newLabel3.Text = Form1.label1[2];
            richTextBox4.Text = Form1.passingTxt[3];
            newLabel4.Text = Form1.label1[3];
            richTextBox5.Text = Form1.passingTxt[4];
            newLabel5.Text = Form1.label1[4];
            richTextBox6.Text = Form1.passingTxt[5];
            newLabel6.Text = Form1.label1[5];
            richTextBox7.Text = Form1.passingTxt[6];
            newLabel7.Text = Form1.label1[6];
            richTextBox8.Text = Form1.passingTxt[7];
            newLabel8.Text = Form1.label1[7];
            richTextBox9.Text = Form1.passingTxt[8];
            newLabel9.Text = Form1.label1[8];

            //string constring = "Data Source=DESKTOP-DIEA2PE;Initial Catalog = Project; Integrated Security = True";
            //string Query="insert into Project.Recipes (label) values('"+Form1.label1[0]+"') ;";
            //Connect conDataBase = new Connect(constring);



        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
