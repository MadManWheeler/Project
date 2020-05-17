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
using ExtenstionMethods;


namespace DesktopApp1
{
    public partial class New : UserControl
    {
        //string done = Form1.passingTxt;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DIEA2PE;Initial Catalog = Project; Integrated Security = True");
        double[,] sortedOrder;

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

            AddDB(Convert.ToInt32(sortedOrder[19, 0]));

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
            AddDB(Convert.ToInt32(sortedOrder[11, 0]));
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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
                //string TBE = richTextBox1.Text;

                double check = 0;
                if (Form1.passingTxt[i] != null)
                {
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
                }
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
                        newLabel9.Text = Form1.label1[8];*/
        }



        private void button2_Click(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[18, 0]));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[17, 0]));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[16, 0]));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[15, 0]));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[14, 0]));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[13, 0]));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddDB(Convert.ToInt32(sortedOrder[12, 0]));
        }
    }
}

namespace ExtenstionMethods
{
    public static class MultiDimensionalArrayExtensions
    {
        /// <summary>
        ///   Orders the two dimensional array by the provided key in the key selector.
        /// </summary>
        /// <typeparam name="T">The type of the source two-dimensional array.</typeparam>
        /// <param name="source">The source two-dimensional array.</param>
        /// <param name="keySelector">The selector to retrieve the column to sort on.</param>
        /// <returns>A new two dimensional array sorted on the key.</returns>
        public static T[,] OrderBy<T>(this T[,] source, Func<T[], T> keySelector)
        {
            return source.ConvertToSingleDimension().OrderBy(keySelector).ConvertToMultiDimensional();
        }
        /// <summary>
        ///   Orders the two dimensional array by the provided key in the key selector in descending order.
        /// </summary>
        /// <typeparam name="T">The type of the source two-dimensional array.</typeparam>
        /// <param name="source">The source two-dimensional array.</param>
        /// <param name="keySelector">The selector to retrieve the column to sort on.</param>
        /// <returns>A new two dimensional array sorted on the key.</returns>
        public static T[,] OrderByDescending<T>(this T[,] source, Func<T[], T> keySelector)
        {
            return source.ConvertToSingleDimension().
                OrderByDescending(keySelector).ConvertToMultiDimensional();
        }
        /// <summary>
        ///   Converts a two dimensional array to single dimensional array.
        /// </summary>
        /// <typeparam name="T">The type of the two dimensional array.</typeparam>
        /// <param name="source">The source two dimensional array.</param>
        /// <returns>The repackaged two dimensional array as a single dimension based on rows.</returns>
        private static IEnumerable<T[]> ConvertToSingleDimension<T>(this T[,] source)
        {
            T[] arRow;

            for (int row = 0; row < source.GetLength(0); ++row)
            {
                arRow = new T[source.GetLength(1)];

                for (int col = 0; col < source.GetLength(1); ++col)
                    arRow[col] = source[row, col];

                yield return arRow;
            }
        }
        /// <summary>
        ///   Converts a collection of rows from a two dimensional array back into a two dimensional array.
        /// </summary>
        /// <typeparam name="T">The type of the two dimensional array.</typeparam>
        /// <param name="source">The source collection of rows to convert.</param>
        /// <returns>The two dimensional array.</returns>
        private static T[,] ConvertToMultiDimensional<T>(this IEnumerable<T[]> source)
        {
            T[,] twoDimensional;
            T[][] arrayOfArray;
            int numberofColumns;

            arrayOfArray = source.ToArray();
            numberofColumns = (arrayOfArray.Length > 0) ? arrayOfArray[0].Length : 0;
            twoDimensional = new T[arrayOfArray.Length, numberofColumns];

            for (int row = 0; row < arrayOfArray.GetLength(0); ++row)
                for (int col = 0; col < numberofColumns; ++col)
                    twoDimensional[row, col] = arrayOfArray[row][col];

            return twoDimensional;
        }
    }

}
