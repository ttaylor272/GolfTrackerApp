using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfTrackerLibrary.Models
{
    public class CourseModel
    {
        public string Name;
        public string Tees;
        public decimal Slope;
        public decimal Rating;
        public List<int> holes = new List<int>();
        // generating a list of courses to choose from

        public static void GrabCourses()
        {
            List<string> golfcourses = new List<string>();
            golfcourses.Add("Paint Branch");
            golfcourses.Add("Enterprise");
            golfcourses.Add("Woodlands");

        }

    }
}
