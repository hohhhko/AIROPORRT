using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Аэропрот
{
    public partial class FormDelete : Form
    {
        private SQLiteConnection DB;
        public FormDelete()
        {
            InitializeComponent();
        }

        private async void FormDelete_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.ConnetctionString);
            await DB.OpenAsync();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string Surname = textBox2.Text;

            DialogResult dr =  MessageBox.Show("Вы Увенены что хотите удалить","Уверены",MessageBoxButtons.OKCancel);
            if (name != "" && Surname != "" && dr == DialogResult.OK)
            {
                SQLiteCommand Delete = new SQLiteCommand($"DELETE FROM Users " +
                $"WHERE name = '{name}' AND Suranme = '{Surname}'", DB);
                await Delete.ExecuteNonQueryAsync();
                MessageBox.Show("Пользователь удален", "Удалено", MessageBoxButtons.OK);
            }
            else 
            {
                MessageBox.Show("Проверте что все поля заполнены и без ошибок","Ошибка",MessageBoxButtons.OK);            
            }

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
