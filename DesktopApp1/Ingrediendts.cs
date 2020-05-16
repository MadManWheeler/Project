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
    public partial class Ingrediendts : UserControl
    {
        public Ingrediendts()
        {
            InitializeComponent();

            con.Open();
            refreshLB();
            con.Close();


        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DIEA2PE;Initial Catalog = Project; Integrated Security = True");
        static public List<string> listING;

        private void button1_Click(object sender, EventArgs e)
        {
            //fix this ugly code

            
            if (listBox1.SelectedItem == null) { MessageBox.Show("Please select an ingredient");}

            else
            {
                con.Open();
                listBox3.Items.Clear();
                using (SqlCommand cmd = new SqlCommand("UPDATE Ingredients SET got = '1' WHERE Type = " + "'" + listBox1.SelectedItem.ToString() + "';"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        //richTextBox1.Text = sdr["Ingredients"].ToString();
                        //linkLabel1.Text = sdr["Method"].ToString();

                    }

                }
                listBox1.Items.Clear();
                refreshLB();


                string Query = "SELECT Type FROM Ingredients WHERE FoodCategory =" + "'" + listBox2.SelectedItem.ToString() + "'AND got = 0;";
                DataTable dt = new DataTable();
                SqlDataAdapter SDA = new SqlDataAdapter(Query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                SDA.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    listBox1.Items.Add(dr["Type"].ToString());
                }
            }

            

            //string Query = "UPDATE Ingredients SET got = '1' WHERE Type = " + "'" + listBox1.SelectedItem.ToString() + "';";


            con.Close();


            // foreach (var item in listBox1.Items)
            // {
            //     listING.Add(item.ToString());
            // }


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

        private void refreshLB()
        {
            listBox3.Items.Clear();
            string Query2 = "SELECT Type FROM Ingredients WHERE got = '1';";
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(Query2, con);
            SDA.SelectCommand.ExecuteNonQuery();
            SDA.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                listBox3.Items.Add(dr["Type"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            
            using (SqlCommand cmd = new SqlCommand("UPDATE Ingredients SET got = '0' WHERE Type = " + "'" + listBox3.SelectedItem.ToString() + "';"))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    //richTextBox1.Text = sdr["Ingredients"].ToString();
                    //linkLabel1.Text = sdr["Method"].ToString();

                }

            }
            
            

            refreshLB();
            con.Close();

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            listBox1.Items.Clear();


            
            con.Open();
            string Query = "SELECT Type FROM Ingredients WHERE FoodCategory =" + "'" + listBox2.SelectedItem.ToString() + "'AND got = 0;";
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(Query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            SDA.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["Type"].ToString());
            }

            con.Close();
        }

        private void Ingrediendts_Load(object sender, EventArgs e)
        {

        }
    }
}
