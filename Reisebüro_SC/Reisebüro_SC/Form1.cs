using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;


namespace Reisebüro_SC
{
    public partial class Reisebüro : Form
    {
        public Reisebüro() => InitializeComponent();

        /*void  connectDatabase()
        {
            
        }

        connectDatabase();*/

        public void ZurBuchung_Click(object sender, EventArgs e)
        {
            Buchung buchung = new Buchung();
            buchung.ShowDialog(this);
        }

        /*private void Reisebüro_Load(object sender, EventArgs e)
        {

        }*/
    }
}
