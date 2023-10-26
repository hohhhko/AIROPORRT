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
            frm.button1.Visible = false;
        }

        private async void FormDecor_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.ConnetctionString);
            await DB.OpenAsync();

            Random();
        }

        private void FormDecor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            string Date = DateTimeChose.Value.ToString("d");
            string Time = TimePicker.Value.ToString("t"); 
            string FIO = TextBoxFIO.Text;
            string Place = "Казань" + "-" + ComboBoxPlace.Text;

            if (FIO != "" && Place != "" && Date != "")
            {
                // ДОбаление записи
                SQLiteCommand insert = new SQLiteCommand($"INSERT INTO [{Table_Tablo.main}] (FullNameUser,Place,Time,DateReisa,NumberTicet,Cost) " +
                $"VALUES (@FullNameUser,@Place,@Time,@DateReisa,@NumberTicet,@Cost)", DB);
                insert.Parameters.AddWithValue("FullNameUser", FIO);
                insert.Parameters.AddWithValue("Place", Place);
                insert.Parameters.AddWithValue("Time", Time);
                insert.Parameters.AddWithValue("DateReisa", Date);
                insert.Parameters.AddWithValue("NumberTicet", label6.Text);
                insert.Parameters.AddWithValue("Cost",label5.Text);
                await insert.ExecuteNonQueryAsync();
                MessageBox.Show("Билет оформлен", "Успех", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Проверте все ли поля залнены","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);            
            }

        }

        public void Random()
        {
            Random rnd = new Random();
            int value1 = rnd.Next();
            label6.Text = value1.ToString();
        }

        private void UpdateCell()
        {
            label5.Text = "Выбирите место назанчения";

            if (ComboBoxPlace.SelectedIndex == 0)
            {
                label5.Text = "30000";
            }
            if (ComboBoxPlace.SelectedIndex == 1)
            {
                label5.Text = "25000";
            }
            if (ComboBoxPlace.SelectedIndex == 2)
            {
                label5.Text = "44000";
            }
            if (ComboBoxPlace.SelectedIndex == 3)
            {
                label5.Text = "35000";
            }
            if (ComboBoxPlace.SelectedIndex == 4)
            {
                label5.Text = "20000";
            }

        }

        private void ComboBoxPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCell();
        }
    }
}
