using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapImprove
{


     struct Books
    {
        public string name;
        public int id;
        public void Book(string name,int id)
        {
            this.name = name;
            this.id = id;
        }
    }
     internal class Toturial
    {
        internal enum Days { Mon,Tue,Wed,Thur,Fri,Sta,Sun};
        internal  void displayInfoTruct()
        {
            string Monday = Days.Mon.ToString();
            int MonInt = (int)Days.Mon;
            string FriDay = Days.Fri.ToString();
            int FriInt = (int)Days.Fri;

            Console.WriteLine($"Monday:{Monday} - MonInt:{MonInt} - FriDay:{FriDay} - FriInt:{FriInt}");
        }

    }
}
