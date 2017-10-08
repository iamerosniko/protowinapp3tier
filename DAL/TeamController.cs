using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TeamController
    {
        private PWContext db = new PWContext();
        public List<PW_Teams> get()
        {
            return db.PW_Teams.ToList();
        }
        public PW_Teams get(System.Guid id)
        {
            var team = db.PW_Teams.Find(id);
            return team;
        }
    }
}
