using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfTrackerLibrary.Models
{
    public class PlayerModel
    {
        
        
        public string golfName { get; set; }
         
        public int age { get; set; }
        public double handicap { get; set; }

        public PlayerModel(string gname, int gage, double ghandicap)
        {
            this.golfName = gname;
            this.age = gage;
            this.handicap = ghandicap;
        }

    }

     
}

