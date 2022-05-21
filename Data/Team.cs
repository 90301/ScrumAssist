using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        BindingList<Developer> Developers { get; set; } = new BindingList<Developer>();


        public override string ToString()
        {
            return Name;
        }
    }
}
