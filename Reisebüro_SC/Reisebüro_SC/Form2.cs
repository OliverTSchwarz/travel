using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Reisebüro_SC
{
    public partial class Buchung : Form
    {
        public Buchung() => InitializeComponent();
        Buchung(Reisebüro parentForm):base()
        {
            this.parentForm = parentForm;
        }
        Reisebüro parentForm;

        private void buchen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vielen Dank für Ihre Buchung!");
        }

        /*private void GeburtsdatumBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            InitializeComponent();
            GeburtsdatumBox.Mask = "00.00.0000";
        }

        private void TelefonnummerBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            InitializeComponent();
            TelefonnummerBox.Mask = "00 00 00 000 000";
        }*/
    }
}
