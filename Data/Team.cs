using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAssist.Data
{
    public class Team
    {
        public string Name { get; set; }
        /// <summary>
        /// This holds the current developers on the team. As Developers can join and leave teams, this is only really used for tagging current notes
        /// </summary>
        List<Developer> Developers { get; set; }
    }
}
