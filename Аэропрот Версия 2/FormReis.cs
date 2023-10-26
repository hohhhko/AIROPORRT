using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Аэропрот
{
    public partial class FormReis : Form
    {
        private SQLiteConnection DB;
        public FormReis()
        {
            InitializeComponent();
        }

        private async void FormReis_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.ConnetctionString);
            await DB.OpenAsync();

            SQLiteDataReader read;
            SQLiteCommand commandRead = new SQLiteCommand($"SELECT NamePilot FROM {Table_Reisi.main}", DB);
            read = (SQLiteDataReader)await commandRead.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                ComboBoxName.Items.Add((string)read["NamePilot"]);
            }
            SQLiteCommand commandRead1 = new SQLiteCommand($"SELECT Time FROM {Table_Tablo.main}", DB);
            read = (SQLiteDataReader)await commandRead1.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                ComboBoxTime.Items.Add((string)read["Time"]);
            }
            SQLiteCommand commandRead2 = new SQLiteCommand($"SELECT Place FROM {Table_Tablo.main}", DB);
            read = (SQLiteDataReader)await commandRead2.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                ComboBoxPlace.Items.Add((string)read["Place"]);
            }
            SQLiteCommand commandRead3 = new SQLiteCommand($"SELECT NumberTicet FROM {Table_Tablo.main}", DB);
            read = (SQLiteDataReader)await commandRead3.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                ComboBoxTicek.Items.Add((string)read["NumberTicet"]);
            }
            read.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormWorker frm = new FormWorker();
            frm.Show();
            this.Hide();
        }

        private void FormReis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            string name = ComboBoxName.Text;
            string place = ComboBoxPlace.Text;
            string time = ComboBoxTime.Text;
            string nuumber = ComboBoxTicek.Text;

            if (name != "" && place != "" && time != "" && nuumber != "")
            {
                SQLiteCommand ins = new SQLiteCommand($"INSERT INTO [{Table_Reisi.main}] (NamePilot,Time,Place,NumberTicet) " +
                $"VALUES (@NamePilot,@Time,@Place,@NumberTicet)", DB);
                ins.Parameters.AddWithValue("NamePilot", name);
                ins.Parameters.AddWithValue("Time", time);
                ins.Parameters.AddWithValue("Place", place);
                ins.Parameters.AddWithValue("NumberTicet", nuumber);
                await ins.ExecuteNonQueryAsync();
                MessageBox.Show("Рейс добавлен", "Добавлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Проверте данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ComboBoxName.Text = "";
            ComboBoxPlace.Text = "";
            ComboBoxTime.Text = "";
            ComboBoxTicek.Text = "";

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("SELECT * FROM Reisi", DB);
            DataSet ds = new DataSet();

            dataadapter.Fill(ds, "Info");
            Datareais.DataSource = ds.Tables[0];
        }

        private async void Datareais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                int id_table = Convert.ToInt32(Datareais.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());

                SQLiteCommand commandDelate = new SQLiteCommand($"DELETE FROM {Table_Reisi.main} " +
                $"WHERE id = '" + id_table + "' ", DB);
                await commandDelate.ExecuteNonQueryAsync();
                MessageBox.Show("Запись удаелна", "Удалено", MessageBoxButtons.OK);
            }
        }
    }
}
