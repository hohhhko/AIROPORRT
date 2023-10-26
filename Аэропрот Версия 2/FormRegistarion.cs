using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Аэропрот
{
    public partial class FormRegistarion : Form
    {
        private SQLiteConnection DB;  
        public FormRegistarion()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;        
            string Surname = textBox2.Text;
            string age = trackYear.Value.ToString();
            string Pasport = textBox4.Text;
            string Rolue = ComboBoxRolue.Text;

            if (name !="" && Surname !="" && age !="")
            {
                SQLiteCommand insert = new SQLiteCommand($"INSERT INTO [{Table_Users.main}] (Name,Suranme,Age,Pasport,Rolue) " +
                $"VALUES (@Name, @Suranme, @Age, @Pasport, @Rolue) ",DB);
                insert.Parameters.AddWithValue("Name", name);
                insert.Parameters.AddWithValue("Suranme", Surname);
                insert.Parameters.AddWithValue("Age",age);
                insert.Parameters.AddWithValue("Pasport", Pasport);
                insert.Parameters.AddWithValue("Rolue", Rolue);
                await insert.ExecuteNonQueryAsync();
                MessageBox.Show($"Пользователь дОбавлен\nИмя:{name},Фамилия:{Surname},Возраст:{age},Роль:{Rolue}","Успех",MessageBoxButtons.OK);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                ComboBoxRolue.Text = "";
            }

        }

        private async void FormRegistarion_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.ConnetctionString);
            await DB.OpenAsync();
        }

        private void TrackYear_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackYear.Value.ToString();
        }
    }
}
