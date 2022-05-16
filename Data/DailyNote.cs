using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAssist.Data
{
    public class DailyNote
    {
        public DateTime NoteDate { get; set; }
        /// <summary>
        /// This will typically only be one developer, but there does exist the possibility to have more than one developer
        /// </summary>
        public List<string> Developers { get; set; }
        /// <summary>
        /// Typically there should only be one team, but this is built as a list to provide support for multiple teams
        /// </summary>
        public List<string> Teams { get; set; }
        /// <summary>
        /// This holds all the tags for a given note, by default Developers and Teams are all just Tags
        /// </summary>
        public HashSet<string> Tags { get; set; }

        /// <summary>
        /// The actual note itself
        /// </summary>
        public string Note { get; set; }
    }
}
