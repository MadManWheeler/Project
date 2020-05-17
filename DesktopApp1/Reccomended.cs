using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExtenstionMethods;


namespace DesktopApp1
{
    public partial class Reccomended : UserControl
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DIEA2PE;Initial Catalog = Project; Integrated Security = True");
        double[,] sortedOrder;

        public Reccomended()
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

        private void Reccomended_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[19, 0]));

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void newLabel9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void newLabel8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void newLabel7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void newLabel6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void newLabel5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void newLabel4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void newLabel3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void newLabel2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void newLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

            double[,] orderRecipes = { { 0, 0 }, { 1, 0.00 }, { 2, 0.00 }, { 3, 0.00 }, { 4, 0.00 }, { 5, 0.00 }, { 6, 0.00 }, { 7, 0.00 }, { 8, 0.00 }, { 9, 0.00 }, { 10, 0.00 }, { 11, 0.00 }, { 12, 0.00 }, { 13, 0.00 }, { 14, 0.00 }, { 15, 0.00 }, { 16, 0.00 }, { 17, 0.00 }, { 18, 0.00 }, { 19, 0.00 } };
            for (int i = 0; i < 20; i++)
            {


                con.Open();
                string Query = "SELECT Type FROM Ingredients WHERE got = '1';";
                DataTable dt = new DataTable();
                SqlDataAdapter SDA = new SqlDataAdapter(Query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                SDA.Fill(dt);
                string TBE = richTextBox1.Text;

                double check = 0;
                
                List<string> result = Form1.passingTxt[i].Split('\n').ToList();
                foreach (DataRow dr in dt.Rows)
                {

                    for (int counter = 0; result.Count != counter; counter++)
                    {

                        if (result[counter].Contains((dr["Type"].ToString())))
                        {
                            result[counter] = "";

                            check++;
                        }
                    }
                }

                double numLines = Form1.passingTxt[i].Split('\n').Length - 1;
                orderRecipes[i, 1] = check / numLines;
                // double f = (check/numLines);
                // MessageBox.Show(check.ToString() + "/" + numLines);
                con.Close();
            }
            sortedOrder = orderRecipes.OrderBy(x => x[1]);
            //Array.Sort(orderRecipes [0,0]);


            richTextBox1.Text = Form1.passingTxt[Convert.ToInt32(sortedOrder[19, 0])];
            newLabel1.Text = Form1.label1[Convert.ToInt32(sortedOrder[19, 0])];
            richTextBox2.Text = Form1.passingTxt[Convert.ToInt32(sortedOrder[18, 0])];
            newLabel2.Text = Form1.label1[Convert.ToInt32(sortedOrder[18, 0])];
            richTextBox3.Text = Form1.passingTxt[Convert.ToInt32(sortedOrder[17, 0])];
            newLabel3.Text = Form1.label1[Convert.ToInt32(sortedOrder[17, 0])];
            richTextBox4.Text = Form1.passingTxt[Convert.ToInt32(sortedOrder[16, 0])];
            newLabel4.Text = Form1.label1[Convert.ToInt32(sortedOrder[16, 0])];
            richTextBox5.Text = Form1.passingTxt[Convert.ToInt32(sortedOrder[15, 0])];
            newLabel5.Text = Form1.label1[Convert.ToInt32(sortedOrder[15, 0])];
            richTextBox6.Text = Form1.passingTxt[Convert.ToInt32(sortedOrder[14, 0])];
            newLabel6.Text = Form1.label1[Convert.ToInt32(sortedOrder[14, 0])];
            richTextBox7.Text = Form1.passingTxt[Convert.ToInt32(sortedOrder[13, 0])];
            newLabel7.Text = Form1.label1[Convert.ToInt32(sortedOrder[13, 0])];
            richTextBox8.Text = Form1.passingTxt[Convert.ToInt32(sortedOrder[12, 0])];
            newLabel8.Text = Form1.label1[Convert.ToInt32(sortedOrder[12, 0])];
            richTextBox9.Text = Form1.passingTxt[Convert.ToInt32(sortedOrder[11, 0])];
            newLabel9.Text = Form1.label1[Convert.ToInt32(sortedOrder[11, 0])];

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
            newLabel9.Text = Form1.label1[8]; */
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[18, 0]));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[17, 0]));
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[16, 0]));
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[15, 0]));
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[14, 0]));
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[13, 0]));
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[12, 0]));
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[11, 0]));
        }
    }
}
