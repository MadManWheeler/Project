using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DesktopApp1
{
    public partial class favourites : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DIEA2PE;Initial Catalog = Project; Integrated Security = True");


        private Connect sqlCon = new Connect();
        private ArrayList list = new ArrayList();

        public favourites()
        {
            InitializeComponent();
            RefreshDB();



        }

        private void RefreshDB()
        {
            listBox1.Items.Clear();
            richTextBox1.Clear();
            con.Open();
            string Query = "SELECT * FROM recipes";
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(Query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            SDA.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["label"].ToString());
            }

            con.Close();
        }

        bool on = true; //add this in properly
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fillTextFields(int id)
        {
            list = sqlCon.getFavourite(id);

           // txtTitle
                
            
        }


        int addRTB = 1; // fix this bad code
        int addLB = 1; // fix this bad code
        int addCB = 1; // fix this bad code
        private void button1_Click(object sender, EventArgs e)
        {
           /* AddNewCB();
            AddNewLabel();
            AddNewRTextBox();
            //208, 124*/
            
            
        }
        public System.Windows.Forms.Label AddNewLabel()
        {
            System.Windows.Forms.Label LB = new System.Windows.Forms.Label();
            this.Controls.Add(LB);
            LB.Top = addLB + 8; //8
            LB.Left = 15; //15
            LB.Text = "Recipe" + this.addLB.ToString();
            addLB = addLB + 130;
            return LB;
            
        }
        public System.Windows.Forms.CheckBox AddNewCB()
        {
            System.Windows.Forms.CheckBox CB = new System.Windows.Forms.CheckBox();
            this.Controls.Add(CB);
            CB.Top = addCB + 4; //4
            CB.Left = 65; //65
            
            
            addCB = addCB + 130;
            return CB;
        }
        public System.Windows.Forms.RichTextBox AddNewRTextBox()
        {
            System.Windows.Forms.RichTextBox txt = new System.Windows.Forms.RichTextBox();
            this.Controls.Add(txt);
            txt.Top = addRTB + 30;//30
            txt.Left = 15;//15
            txt.Text = "textBox" + this.addRTB.ToString();
            addRTB = addRTB + 130;
            return txt;
        }
        
        


        
        private void favourites_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           /* if (on == true)
            {
                richTextBox1.Hide();
                on = false;
            }
            else
            {
                richTextBox1.Show();
                on = true;
            }*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            for (int i = 0; i < 9; i++)
            { 
                string Query = "insert into Recipes (label,Ingredients,Method) values('"+ Form1.label1[i] + "','" + Form1.passingTxt[i] + "','" + Form1.METHOD[i] + "') ;";
                //string Query = "insert into Recipes (label) values('" + Form1.label1[0] + "') ;";
                SqlDataAdapter SDA = new SqlDataAdapter(Query, con);
                SDA.SelectCommand.ExecuteNonQuery();
            }
            con.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* con.Open();
            
            listBox1.SelectedItem.ToString();
            string Query = "SELECT Ingredients FROM recipes WHERE Label ="+ listBox1.SelectedItem.ToString() ;
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(Query, con);
            SDA.SelectCommand.ExecuteNonQuery();

            richTextBox1.Text = 
            con.Close();

           
            SqlCommand Comm1 = new SqlCommand(Query, con);
            Conn.Open();
            richTextBox1.Text = Comm1.ExecuteScalar();
            Conn.Close();*/


            using (SqlCommand cmd = new SqlCommand("SELECT Ingredients,Method FROM recipes WHERE Label =" +"'" + listBox1.SelectedItem.ToString() + "';"))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    richTextBox1.Text = sdr["Ingredients"].ToString().ToLower();
                    linkLabel1.Text = sdr["Method"].ToString();
                    
                }
            
                con.Close();
            }


            con.Open();
            string Query = "SELECT Type FROM Ingredients;";
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(Query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            SDA.Fill(dt);

            int check = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (richTextBox1.Text.Contains((dr["Type"].ToString())))
                {
                    
                    check++;

                }
            }

            int numLines = richTextBox1.Text.Split('\n').Length - 1;
            MessageBox.Show(check.ToString()+"/"+numLines);
            con.Close();

            

        }





    



        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "DELETE FROM Recipes WHERE Label = " + "'" + listBox1.SelectedItem.ToString() + "';";
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(Query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            SDA.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["label"].ToString());
            }

            con.Close();
            RefreshDB();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo Info = new ProcessStartInfo(linkLabel1.Text);
            Process.Start(Info);
        }
    }
    
}
