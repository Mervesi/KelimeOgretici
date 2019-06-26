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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        List<Word> wordList = new List<Word>();
        Word word = new Word();
        WordDataAccess wordAccess = new WordDataAccess();
        private void HomePage_Load(object sender, EventArgs e)
        {
            wordList = wordAccess.GetAll();
            lstTurk.DataSource = wordList;
            lstIng.DataSource = wordList;
            lstTurk.ValueMember = "WordID";
            lstIng.ValueMember = "WordID";
            lstTurk.DisplayMember = "WordTurkish";
            lstIng.DisplayMember = "WordEnglish";

            List<DataAccessLayer.Type> type = wordAccess.GetTip();
            //foreach (var item in type)
            //{
            //    comboBoxTip.Items.Add(item.Type1);
            //}

            comboBoxTip.DataSource = type;
            comboBoxTip.ValueMember = "TypeID";
            comboBoxTip.DisplayMember = "Type";



            //foreach (var item in wordList)
            //{
            //    lstTurk.Items.Add(item.WordTurkish);
            //    lstIng.Items.Add(item.WordEnglish);
            //}
       
            timer1.Interval = 10000;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            word.WordTurkish = txtBoxTurk.Text;
            word.WordEnglish = txtBoxIng.Text;
            word.WordTypeID = (int)comboBoxTip.SelectedValue;

           int sonuc = wordAccess.Create(word);
            if (sonuc > 0)
                MessageBox.Show("Kayıt Başarılı");
            else
                MessageBox.Show("Hata Oluştu");
        }

        int id;
        private void btnSil_Click(object sender, EventArgs e)
        {
            wordAccess.Delete(id);
        }

        private void lstTurk_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedId = (Word)lstTurk.SelectedItem;
            id = selectedId.WordID;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            wordList = wordAccess.GetAll();
            lstTurk.DataSource = wordList;
            lstIng.DataSource = wordList;
            lstTurk.ValueMember = "WordID";
            lstIng.ValueMember = "WordID";
            lstTurk.DisplayMember = "WordTurkish";
            lstIng.DisplayMember = "WordEnglish";
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PopUpWin pop = new PopUpWin();
            pop.Show();
        }
    }
}
