using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections;
using System.Data.SqlClient;


namespace DesktopApp1
{


    public partial class Form1 : Form
    {
        public static string[] passingTxt = new string[9];
        public static string[] label1 = new string[9];
        public static string[] METHOD = new string[9];
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DIEA2PE;Initial Catalog = Project; Integrated Security = True");

        public Form1()
        {
            InitializeComponent();
            favourites1.Hide();
            ingrediendts1.Hide();
            new1.Hide();
            reccomended1.Hide();


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }



        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void favourites1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            ingrediendts1.Hide();
            favourites1.Show();
            new1.Hide();
            reccomended1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingrediendts1.Hide();
            favourites1.Hide();
            new1.Hide();
            reccomended1.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ingrediendts1.Show();
            favourites1.Hide();
            new1.Hide();
            reccomended1.Hide();
        }

        private void reccomended1_Load(object sender, EventArgs e)
        {

        }


        //remove
        public class Person
        {
            public string q { get; set; }
            public System.Collections.ObjectModel.Collection<hit> hits { get; set; }

        }

        //remove
        public class hit
        {
            public string label { get; set; }
            public Array ingredientLines { get; set; }
        }

        private void deserialiseJSON(string strJSON)
        {
            try
            {
                var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);

                // Person jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
                string ignlist = null;



                //for (int i = 0; i < jPerson.hits[2].recipe.ingredientLines.Length; i++)
                int counter = 0;
                for (int Rnumber = 0; Rnumber < 9; Rnumber++)
                {
                    int i = 0;
                    bool x = true;

                    bool y = false;

                    while (x == true)
                    {
                        try
                        {
                            ignlist = ignlist + "\n" + jPerson.hits[Rnumber].recipe.ingredientLines[i];
                            label1[Rnumber] = jPerson.hits[Rnumber].recipe.label;
                            METHOD[Rnumber] = jPerson.hits[Rnumber].recipe.url;
                            i++;
                        }
                        catch
                        {
                            y = true;
                            while (counter < 9 && y == true)
                            {
                                passingTxt[counter] = ignlist;
                                ignlist = null;
                                y = false;
                                counter++;
                            }
                            x = false;
                        }

                    }
                }







            }

            catch (Exception ex)
            {
                //put in error throw 

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //string[] array = new string[];
            //List<Student> list = new List<Student>();
            //List<string> listING = new List;
            List<string> listING = new List<string>();
            con.Open();
            string Query2 = "SELECT Type FROM Ingredients WHERE got = '1';";
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(Query2, con);
            SDA.SelectCommand.ExecuteNonQuery();
            SDA.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {

                listING.Add((dr["Type"].ToString()));
                int i = 0;

                //array[i] = (dr["Type"].ToString());
                i++;
            }

            for (int i = 0; i < 9; i++)
            {

                Random rnd = new Random();
                Random rnd2 = new Random();
                int ingr = 0;
                int ingr2 = 0;
                bool ranCheck = false;
                while (ranCheck == false)
                {
                    ingr = rnd.Next(0, listING.Count);
                    ingr2 = rnd.Next(0, listING.Count);

                    if (ingr != ingr2)
                    {
                        ranCheck = true;
                    }

                }


                //int r = rnd.Next(Ingrediendts.listING.Count);


                //string apiGet = string.Format("https://api.edamam.com/search?q=" + array[ingr] + Ingrediendts.listING[r] + "&app_id=32d7bc80&app_key=3ce2b8743eff32886ac3d5aa53ba1bec");
                string apiGet = string.Format("https://api.edamam.com/search?q=" + listING[ingr] + "+" + listING[ingr2] + "&app_id=32d7bc80&app_key=3ce2b8743eff32886ac3d5aa53ba1bec"/*+randomnumber*/);
                WebRequest requestObjGet = WebRequest.Create(apiGet);
                requestObjGet.Method = "GET";
                HttpWebResponse responceObjGet = null;
                responceObjGet = (HttpWebResponse)requestObjGet.GetResponse();

                string strresulttest = null;
                using (Stream stream = responceObjGet.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    strresulttest = sr.ReadToEnd();
                    sr.Close();
                }

                deserialiseJSON(strresulttest);
                //use json to pick random recipe


            }






            ingrediendts1.Hide();
            favourites1.Hide();
            new1.Show();

            reccomended1.Hide();





        }

        private void ALGI ()
        {

            /* pick random meat/fish
             * 
             * sleect random most frequent cuisine (top weighted)
             * 
             * most used ingredients in that cusine cross check with your ingredients
             * 
             * pull 20+ recipes and check what you have most ingredients for 
             * 
             * order from most to least*/


            List<string> listING = new List<string>();
            con.Open();
            string Query2 = "SELECT Type FROM Ingredients WHERE got = '1';";
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(Query2, con);
            SDA.SelectCommand.ExecuteNonQuery();
            SDA.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {

                listING.Add((dr["Type"].ToString()));
                int i = 0;

                //array[i] = (dr["Type"].ToString());
                i++;
            }

            
            string curItem = Properties.Settings.Default.Cuisines;


            String[] spearator = { " ", " " };
            Int32 count = 20;
            string[] aExclude = new string[5];
            aExclude = curItem.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);

            Random rnd3 = new Random();
            Random rnd4 = new Random();
            int RanMeatFish = 0;
            int RanCuisines = 0;

            RanMeatFish = rnd3.Next(0, listING.Count);
            RanCuisines = rnd4.Next(0, aExclude.Length);

            con.Open();
            string Query = "SELECT Type FROM Ingredients WHERE FoodCategory = 'Meats' OR 'Fish/Seafood' AND" + "id = '" + RanMeatFish + "'AND got = '1';";
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(Query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            SDA.Fill(dt);

            
            


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Settings f2 = new Settings();
            f2.ShowDialog(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    
}
 