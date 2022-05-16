using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAssist.Data
{
    public class Developer
    {
        public string Name { get; set; }

        /// <summary>
        /// This is a shorthand way to get all the teams a given developer is on
        /// </summary>
        public List<Team> TeamsOn { get; set; }
    }
}
