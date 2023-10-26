using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Аэропрот
{
    public partial class FormAutoriztion : Form
    {
        private SQLiteConnection DB;
        public FormAutoriztion()
        {
            InitializeComponent();
        }

        private async void FormAutoriztion_Load(object sender, EventArgs e)
        {
           DB = new SQLiteConnection(DataBase.ConnetctionString);
           await DB.OpenAsync();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Surename = textBox2.Text;

            if (Name != "" && Surename != "")
            {
                SQLiteDataReader read;
                SQLiteCommand commandRead = new SQLiteCommand($"SELECT * FROM [{Table_Users.main}]" +
                $" WHERE {Table_Users.Name}=@Name " +
                $"AND {Table_Users.Suranme}=@Suranme", DB);
                commandRead.Parameters.AddWithValue("Name", Name);
                commandRead.Parameters.AddWithValue("Suranme", Surename);
                read = (SQLiteDataReader)await commandRead.ExecuteReaderAsync();
                if (await read.ReadAsync())
                {
                    MessageBox.Show("Успешный вход", "Успех", MessageBoxButtons.OK);
                    FormTablo frm = new FormTablo();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Проеарете данные", "Ошибка", MessageBoxButtons.OK);
                }
                read.Close();
            }
        }

        private void решистарцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistarion frm = new FormRegistarion();
            frm.Show();
        }

        private void рукодтсвоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Руководтсво Пользователя.docx");
        }

        private void удалениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelete frm = new FormDelete();
            frm.Show();
        }

        private void FormAutoriztion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
