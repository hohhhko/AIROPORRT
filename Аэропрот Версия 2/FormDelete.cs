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

        private async void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string Surname = textBox2.Text;

            if (name != "" && Surname != "")
            {
                SQLiteDataReader read;
                SQLiteCommand commandRead = new SQLiteCommand($"SELECT * FROM [{Table_Users.main}]" +
                $" WHERE {Table_Users.Name}=@Name " +
                $"AND {Table_Users.Suranme}=@Suranme", DB);
                commandRead.Parameters.AddWithValue("Name", name);
                commandRead.Parameters.AddWithValue("Suranme", Surname);
                read = (SQLiteDataReader)await commandRead.ExecuteReaderAsync();
                if (await read.ReadAsync())
                {
                    SQLiteCommand Delete = new SQLiteCommand($"DELETE FROM Users " +
                     $"WHERE name = '{name}' AND Suranme = '{Surname}'", DB);
                    await Delete.ExecuteNonQueryAsync();
                    MessageBox.Show("Пользоватль удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {                 
                    MessageBox.Show("Такого польлователя нет", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
