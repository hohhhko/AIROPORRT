using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Аэропрот
{
    public partial class FormDecor : Form
    {
        private SQLiteConnection DB;
        public FormDecor()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormTablo frm = new FormTablo();
            frm.Show();
            this.Hide();
        }

        private async void FormDecor_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.ConnetctionString);
            await DB.OpenAsync();

            label5.Text = DateTime.Now.ToString("t");

            Random();
        }

        private void FormDecor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            string Date = DateTimeChose.Value.ToString("d");
            string Time = label5.Text;
            string FIO = TextBoxFIO.Text;
            string Place = "Казань" + "-" + ComboBoxPlace.Text;

            if (FIO != "" && Place != "" && Date != "")
            {
                SQLiteCommand insert = new SQLiteCommand($"INSERT INTO [{Table_Tablo.main}] (FullNameUser,Place,Time,DateReisa,NumberTicet) " +
                $"VALUES (@FullNameUser,@Place,@Time,@DateReisa,@NumberTicet)", DB);
                insert.Parameters.AddWithValue("FullNameUser", FIO);
                insert.Parameters.AddWithValue("Place", Place);
                insert.Parameters.AddWithValue("Time", Time);
                insert.Parameters.AddWithValue("DateReisa", Date);
                insert.Parameters.AddWithValue("NumberTicet", label6.Text);
                await insert.ExecuteNonQueryAsync();
                MessageBox.Show("Билет оформлен", "Успех", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Проверте все ли поля залнены","Ошибка",MessageBoxButtons.OK);            
            }

        }

        public void Random()
        {
            Random rnd = new Random();
            int value1 = rnd.Next();
            label6.Text = value1.ToString();
        }
    }
}
