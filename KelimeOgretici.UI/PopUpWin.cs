using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOgretici.UI
{
    public partial class PopUpWin : Form
    {
        public PopUpWin()
        {
            InitializeComponent();
        }
        int supriz;
        WordDataAccess wordAccess = new WordDataAccess();
        private void PopUpWin_Load(object sender, EventArgs e)
        {
            var m =wordAccess.GetAll();
            int sinir = m.Count();
            Random rnd = new Random();
            supriz = rnd.Next(0, sinir);
            var m2 = m[supriz];
            lblIng.Text = m2.WordEnglish.ToString();
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            var m = wordAccess.GetAll();
            var m2 = m[supriz];
            lblTurk.Text = m2.WordTurkish.ToString();
            lblTurk.Visible = true;
        }
    }
}
