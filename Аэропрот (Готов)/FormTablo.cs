using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Аэропрот
{
    public partial class FormTablo : Form
    {
        private SQLiteConnection DB;
        public FormTablo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormAutoriztion frm = new FormAutoriztion();
            frm.Show();
            this.Hide();
        }

        private async void FormTablo_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.ConnetctionString);
            await DB.OpenAsync();

            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("SELECT * FROM Tablo", DB);
            DataSet ds = new DataSet();

            dataadapter.Fill(ds, "Info");
            DataGrid.DataSource = ds.Tables[0];

            timer1.Enabled = true;
        }

        private void FormTablo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormDecor frm = new FormDecor();
            frm.Show();
            this.Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Time();
        }

        public void Time()
        {
            label2.Text = DateTime.Now.ToString("T");

            var dt = DateTime.Now.Subtract(new TimeSpan(1,0,0));
            label4.Text = dt.ToString("T");

            var ds = DateTime.Now.Subtract(new TimeSpan(-1, 0, 0));
            label5.Text = ds.ToString("T");

            var ir = DateTime.Now.Subtract(new TimeSpan(-4, 0, 0));
            label6.Text = ir.ToString("T");
        }
    }
}
