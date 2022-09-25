using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CuteBus
{
    public partial class MessageAuth : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public MessageAuth()
        {
            InitializeComponent();
        }

        private void MessageAuth_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 1 * 1000;
            t.Tick += new EventHandler(onTick);
            t.Enabled = true;
            con = new SqlConnection(@"Data Source=ALEX-NOTEBOOK\SQLEXPRESS;Initial Catalog=CuteBus;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select [name] from [Auth] where [login] = '" + Program.auth_form.login.Text.Trim() + "'", con);
            reader = cmd.ExecuteReader();
            reader.Read();
            reader.Close();
            label1.Text = cmd.ExecuteScalar().ToString();
        }
        private Timer t;
        void onTick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
