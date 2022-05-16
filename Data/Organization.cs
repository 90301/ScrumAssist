using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAssist.Data
{
    public class Organization
    {
        HashSet<Developer> AllDevelopers = new HashSet<Developer>();
        HashSet<Team> AllTeams = new HashSet<Team>();
    }
}
