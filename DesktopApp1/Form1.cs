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
using System.Net.Mail;


namespace DesktopApp1
{


    public partial class Form1 : Form
    {
        public static string[] passingTxt = new string[20];
        public static string[] label1 = new string[20];
        public static string[] METHOD = new string[20];
        public static string[] ingr = { "", "" };
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DIEA2PE;Initial Catalog = Project; Integrated Security = True");

        public Form1()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Email == null || Properties.Settings.Default.Email == "")
            {MessageBox.Show("Go to Settings to add your email, set any dietary requirements and select your favorite cuisine\n\nUse the ingredients page to add items to your kitchen and the New or Recommend page to find new recipes.\n\nOnce added new recipes can be found on the Favories page!", "How to use Resipe Recommend!"); }
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
            algorithmIngredients();
        /*

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

            
            for (int i = 0; i < 20; i++)
            {

            }   


                //int r = rnd.Next(Ingrediendts.listING.Count);

                
                //string apiGet = string.Format("https://api.edamam.com/search?q=" + array[ingr] + Ingrediendts.listING[r] + "&app_id=32d7bc80&app_key=3ce2b8743eff32886ac3d5aa53ba1bec");
                
                string apiGet = string.Format("https://api.edamam.com/search?q=" + ingr[0] + "+" + ingr[1] + "&app_id=32d7bc80&app_key=3ce2b8743eff32886ac3d5aa53ba1bec"/*+randomnumber);
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

            */
                //order from most ingredients to least the print
                

            



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

        

        private void deserialiseJSON(string strJSON)
        {
            try
            {
                var jRecipe = JsonConvert.DeserializeObject<dynamic>(strJSON);

                // Person jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
                string ignlist = null;



                //for (int i = 0; i < jPerson.hits[2].recipe.ingredientLines.Length; i++)
                int counter = 0;
                for (int Rnumber = 0; Rnumber < 20; Rnumber++)
                {
                    int i = 0;
                    bool x = true;

                    bool y = false;

                    while (x == true)
                    {
                        try
                        {
                            //buffer set of list to order on % of ingredients
                           

                            ignlist = ignlist + "\n" + jRecipe.hits[Rnumber].recipe.ingredientLines[i];
                            label1[Rnumber] = jRecipe.hits[Rnumber].recipe.label;
                            METHOD[Rnumber] = jRecipe.hits[Rnumber].recipe.url;
                            i++;
                        }
                        catch
                        {
                            y = true;
                            while (counter < 20 && y == true)
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

                orderAPI();





            }

            catch 
            {
                //put in error throw 

            }
        }

        private void orderAPI()
        {

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

            //for (int i = 0; i < 9; i++)
            

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

            try
            {
                //string apiGet = string.Format("https://api.edamam.com/search?q=" + array[ingr] + Ingrediendts.listING[r] + "&app_id=32d7bc80&app_key=3ce2b8743eff32886ac3d5aa53ba1bec");
                string apiGet = string.Format("https://api.edamam.com/search?q=" + listING[ingr] + "+" + listING[ingr2] + "&app_id=32d7bc80&app_key=3ce2b8743eff32886ac3d5aa53ba1bec&to=30"/*+randomnumber*/);
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
            catch { MessageBox.Show("Uh Oh something went wrong!", "API Error"); }








            ingrediendts1.Hide();
            favourites1.Hide();
            new1.Show();

            reccomended1.Hide();





        }

        private void algorithmIngredients ()
        {

            /*check they have enough ingredients for the algorithim
             *
             * pick random meat/fish
             * 
             * select random most frequent cuisine (top weighted)
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

            //RanMeatFish = rnd3.Next(0, listING.Count);
            //RanCuisines = rnd4.Next(0, aExclude.Length);

            
            string[,] CC  = {{"Barbecue", "bacon ", "BBQ sauce", "cheese", "corn", "hot sauce", "ketchup", "lettuce", "mustard", "onion", "ribs", "tomatoes", "wings" },
                            { "Caribbean","allspice", "pimento", "thyme", "scotch bonnet", "ginger", "garlic", "paprika", "rice", "chicken", "beef stock", "chicken stock","chicken" },
                            { "Chinese", "chinese five spice","garlic","ginger","oyster sauce","rice","sesame seed","soya","pork","spring onion","wine","sugar","noodles" },
                            { "Italian","basil", "butter", "garlic", "mushroom", "oregano", "parsley", "pasta", "prawns", "rosemary", "spaghetti", "thyme", "tomato" },
                            { "Indian","black pepper", "chilli", "cinnamon", "coriander", "cumin", "curry powder", "rice", "mint","chicken","mustard","turmeric","nutmeg" },
                            { "Mexican","avacado", /*"beans"*/"", "cumin", "garlic", "onion", "oregano", "paprika", "tortillas","coriander","lime","onion","corn" },
                            { "Mediterranean","basil", "garlic", "olive oil", "oregano", "paprika", "parsley", "rosemary", "sage", "thyme", "tomato", "za'atar","lamb" },
                            { "Greek","mint","dill","cinnamon","allspice","oregano","","parsley","saffron","pepper","nutmeg","coriander","onion"},
                            { "British","basil","chilli","oregano","coriander","ginger","rosemary","ketchup","paprika","parsley","cinnamon","thyme","onion"},
                            { "German","nutmeg","caraway","paprika","allspice","mustard seed", "cinnamon","curry","dill","bay leaf","sage","celery","parsley"},
                            { "Thai","basil","turmeric","lemongrass","chili powder","garlic", "onion","ginger","peppercorns","coriander","chinese five spice","lime","cumin"},
                            { "Spanish","paprika","saffron","parsley","cayenne pepper","bay leaf", "olives","tomato","rosemary","peppercorns","onion","",""},
                            {"Japanese","soy sauce","vinegar","rice","noodles","wasabi","mustard","sesame seed","curry","tofu","","","" },
                             {"French","thyme","garlic","olive oil","rosemary","tomato","mustard","Herbes de provence","onion","oregano","","",""} };


            //MessageBox.Show(CC[5,0-11].Count().ToString());

       

            /*
            //add try catch
            con.Open();
            //string Query = "SELECT Type FROM Ingredients WHERE FoodCategory = 'Meats' OR 'Fish/Seafood' AND Type = '" + Chinese[RanMeatFish] + "'AND got = '1';";
            //string Query = "SELECT Type FROM Ingredients WHERE FoodCategory = 'Meats' OR 'Fish/Seafood' AND got = '1';";

            dt = new DataTable();
            SDA = new SqlDataAdapter(Query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            SDA.Fill(dt);*/



            
            for (int i = 0; i != 11; i++)
            {
                Random rnd = new Random();
                int algorithiimRAN1 = 0;
                int algorithiimRAN2 = 0;
                con.Open();

                bool ranCheck = false;
                bool ignCheck1 = false;
                bool ignCheck2 = false;

                while (ranCheck == false || ignCheck1 == false || ignCheck2 == false)
                {
                    //algorithiimRAN1 = rnd.Next(0, CC[2, 0].Count());
                    algorithiimRAN1 = rnd.Next(1, 12);
                    algorithiimRAN2 = rnd.Next(1, 12);

                    if (algorithiimRAN1 != algorithiimRAN2)
                    {
                        ranCheck = true;
                    }

                    RanCuisines = rnd4.Next(0, 6);
                    while (curItem.Contains(CC[RanCuisines, 0]) == false)
                    {
                        RanCuisines = rnd4.Next(0, 6);
                    }

                    try
                    {
                        string Query = "SELECT Type FROM Ingredients WHERE Type =" + "'" + CC[RanCuisines, algorithiimRAN1] + "' AND got = '1';";
                        dt = new DataTable();
                        SDA = new SqlDataAdapter(Query, con);
                        SDA.SelectCommand.ExecuteNonQuery();
                        SDA.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {

                            ingr[0] = ((dr["Type"].ToString()));

                        }

                        ignCheck1 = true;
                    }

                    catch

                    {
                        ignCheck1 = false;

                    }

                    try
                    {
                        string Query = "SELECT Type FROM Ingredients WHERE Type =" + "'" + CC[RanCuisines, algorithiimRAN2] + "' AND got = '1';";
                        dt = new DataTable();
                        SDA = new SqlDataAdapter(Query, con);
                        SDA.SelectCommand.ExecuteNonQuery();
                        SDA.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {

                            ingr[1] = ((dr["Type"].ToString()));

                        }

                        ignCheck2 = true;
                    }


                    catch
                    {
                        ignCheck2 = false;

                    }


                }

                con.Close();
            }

            //check waht happens if exclude is null
            string excludedFood = Properties.Settings.Default.Exclude.Replace(" ", "&excluded=");
            string diet = Properties.Settings.Default.Diet.Replace(" ", "&diet=");
            string alergies = Properties.Settings.Default.Alergies.Replace(" ", "&health=");
            string cuisine = Properties.Settings.Default.Cuisines.Replace(" ", "&cuisineType=");

            if (alergies.Contains("None"))
            { alergies = ""; }
            else {alergies = alergies + "-free"; }

            if (excludedFood.Contains("None"))
            { excludedFood = ""; }
            
            if (diet.Contains("None"))
            { diet = ""; }
           

            //MessageBox.Show(ingr[0] + ingr[1]);
            //MessageBox.Show(cuisine);

            try
            {
                string apiGet = string.Format("https://api.edamam.com/search?q=" + ingr[0] + "+" + ingr[1] + excludedFood + cuisine + diet + "&app_id=32d7bc80&app_key=3ce2b8743eff32886ac3d5aa53ba1bec" + alergies + "&to=30" /*+randomnumber*/);
                //MessageBox.Show(apiGet);
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
            }
            catch { MessageBox.Show("Uh Oh something went wrong!", "API Error"); }
            
               

           

            
            //return ingr1, ingr2;
            
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
 