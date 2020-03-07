using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DesktopApp1
{
    class Json
    {
        public string hits { get; set; }
        static public List<hits> hitList {get; set;}
        
    }

    public class Json2
    {
        public string hits { get; set; }
        static public List<hits> hitList { get; set; }

    }



    public class hits
    {
        public Array ingredientLines { get; set; }
        public string lable {get; set;}

    }

    

  


}
