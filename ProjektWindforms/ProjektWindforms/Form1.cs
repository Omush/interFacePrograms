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

namespace ProjektWindforms
{
    public partial class Szafkomat : Form
    {
        private static readonly Random random = new();
        int indeksSzafki = 0;
        public List<int> NumerSzafek = new();
        private int _ticks;
        public Szafkomat()
        {
            InitializeComponent();
            timer1.Start();
            lab_time.Text = DateTime.Now.ToString();
            NumerSzafek = Enumerable.Range(1, 50).OrderBy(x => Guid.NewGuid()).ToList();
            lab_info.Text = "Szafki ATH";

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lab_time.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void pnl_firstpanel_Click(object sender, EventArgs e)
        {
            pnl_chose_but.Show();
        }

        private void lab_start_Click(object sender, EventArgs e)
        {
            pnl_chose_but.Show();
        }

        private void btn_null_locker_Click(object sender, EventArgs e)
        {
            pnl_chose_but.Hide();
            pnl_null_locker.Show();
            btn_back.Show();

        }
        private void btn_have_locker_Click(object sender, EventArgs e)
        {
            pnl_chose_but.Hide();
            pnl_have_locker1.Show();



            // btn_null_back.Show();
        }
        public void SendDate(int x)
        {

            using var connection = new SqlConnection(
                  "Server=.;Database=sza;Integrated Security=true;");
            connection.Open();
            //var rnd = new Random();
            //int x = rnd.Next(1000, 10000);
            var command = new SqlCommand("insert into KlienciSzafek values(@Imie,@Nazwisko,@Indeks,@Email,@Kod,@NumerSzafki)", connection);
            command.Parameters.AddWithValue("Imie", txb_name.Text);
            command.Parameters.AddWithValue("Nazwisko", txb_surname.Text);
            command.Parameters.AddWithValue("Indeks", txb_indeks.Text);
            command.Parameters.AddWithValue("Email", txb_email.Text);
            command.Parameters.AddWithValue("Kod", x);
            command.Parameters.AddWithValue("NumerSzafki", NumerSzafek[indeksSzafki++]);
            command.ExecuteNonQuery();
            connection.Close();
        }
        int los()
        {
            int x = random.Next(1000, 10000);
            return x;
        }

        private void btn_send_date_Click_1(object sender, EventArgs e)
        {
            var kod = los();
            SendDate(kod);
            pnl_codeall.Show();
            btn_back.Hide();
            if (pnl_codeall.Visible == true)
            {
                lab_Code.Text = "Twój kod : " + kod.ToString();
                lab_Code_Tekst.Text = "Twoja szafka: " + NumerSzafek[indeksSzafki] + " Otwarła się";
            }
            tmr_finish_null.Start();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            pnl_chose_but.Show();
            pnl_null_locker.Hide();

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks == 5)
            {
                pnl_codeall.Hide();
                pnl_finish.Show();
            }
            if (_ticks == 10)
            {
                pnl_finish.Hide();
                pnl_null_locker.Hide();
                pnl_firstpanel.Show();
                tmr_finish_null.Stop();
            }
        }
        void SerchDate()
        {

            using var connection = new SqlConnection(
                 "Server=.;Database=sza;Integrated Security=true;");
            connection.Open();

            var command = new SqlCommand("SELECT top(1) NumerSzafki FROM KlienciSzafek WHERE kod = @kod", connection);
            command.Parameters.AddWithValue("kod", txb_code.Text);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            // ZRÓB JAK NIE SPISZESZ KODU 

            if (reader.HasRows)
            {
                lab_searchcode.Text = $"Szafka nr: {reader[0]} otwarła się";
            }
            else
            {
                lab_searchcode.Text = "nie ma takiej szfki debilu";
            }
        }

        private void btn_have_back_Click(object sender, EventArgs e)
        {
            pnl_chose_but.Show();
            pnl_have_locker1.Hide();
        }

        private void but_send_date_Click_1(object sender, EventArgs e)
        {
            pln_have_back.Hide();
            
            SerchDate();
            tmr_locker_have.Start();
            pbr_loading.Show();
        }

        private void tmr_locker_have_Tick(object sender, EventArgs e)
        {

        }

        private void tmr_locker_have_Tick_1(object sender, EventArgs e)
        {
            _ticks++;
            
            pbr_loading.Increment(80);
            if (_ticks == 5)
            {
                pbr_loading.Hide();
                pnl_msg_open.Show();
                lab_searchcode.Show();
                
            }
            if (_ticks == 10)
            {
                pnl_msg_open.Hide();
                lab_searchcode.Hide();
                pnl_have_locker1.Hide();
                pnl_firstpanel.Show();
                tmr_locker_have.Stop();
            }
        }

    }
}

