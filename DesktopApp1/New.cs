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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DIEA2PE;Initial Catalog = Project; Integrated Security = True");
        public New()
        {
            InitializeComponent();

            if (Visible == true)
            {
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

            }



        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDB(int i)
        {

            con.Open();

            //for (int i = 0; i < 9; i++)
           
            try
            {
                MessageBox.Show(Form1.label1[i]);
                string Query = "insert into Recipes (label,Ingredients,Method) values('" + Form1.label1[i] + "','" + Form1.passingTxt[i] + "','" + Form1.METHOD[i] + "') ;";
                //string Query = "insert into Recipes (label) values('" + Form1.label1[0] + "') ;";
                SqlDataAdapter SDA = new SqlDataAdapter(Query, con);
                SDA.SelectCommand.ExecuteNonQuery();
            }
            catch
            {

                //if recipe already exsists message box NOOO

                MessageBox.Show(i.ToString());
            }
            
            con.Close();


        }

        

        private void button1_Click(object sender, EventArgs e)
        {


            /*for (int i = 0; i < 9; i++)
            {
                richTextBox[i].Text = Form1.passingTxt[i];
                metroLabel1.Text = Form1.label1[i];
            }*/

            //string constring = "Data Source=DESKTOP-DIEA2PE;Initial Catalog = Project; Integrated Security = True";
            //string Query="insert into Project.Recipes (label) values('"+Form1.label1[0]+"') ;";
            //Connect conDataBase = new Connect(constring);

            //favourites.RefreshDB();

            AddDB(0);

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

        private void New_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*for (int i = 0; i < 9; i++)
            {
                richTextBox[i].Text = Form1.passingTxt[i];
                metroLabel1.Text = Form1.label1[i];
            }*/
            /*
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

            con.Open();

            for (int i = 0; i < 9; i++)
            {
                try
                {

                    string Query = "insert into Recipes (label,Ingredients,Method) values('" + Form1.label1[i] + "','" + Form1.passingTxt[i] + "','" + Form1.METHOD[i] + "') ;";
                    //string Query = "insert into Recipes (label) values('" + Form1.label1[0] + "') ;";
                    SqlDataAdapter SDA = new SqlDataAdapter(Query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show(i.ToString());
                }
            }
            con.Close();
            //favourites.RefreshDB();

            */

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void New_Load_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddDB(8);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDB(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDB(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDB(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDB(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDB(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDB(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddDB(7);
        }
    }
}
