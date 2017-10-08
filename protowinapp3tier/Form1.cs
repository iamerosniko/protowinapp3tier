using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace protowinapp3tier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TeamController tc = new TeamController();
            List<PW_Teams> teams = tc.get();
            PW_Teams team = tc.get(new Guid("665bef80-9692-4550-80bb-01ff91e5829e"));
        }


    }
}
