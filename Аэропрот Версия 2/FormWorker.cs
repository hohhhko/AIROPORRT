using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Аэропрот
{
    public partial class FormWorker : Form
    {
        private SQLiteConnection DB;
        public FormWorker()
        {
            InitializeComponent();
        }

        private async void FormWhat_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.ConnetctionString);
            await DB.OpenAsync();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormTablo frm = new FormTablo();
            frm.Show();
            this.Hide();
            frm.ButtonDecore.Visible = false;
        }

        private async void Button1_Click_1(object sender, EventArgs e)
        {
            SQLiteDataReader read;
            SQLiteCommand commandRead = new SQLiteCommand($"SELECT sum(Cost) " +
            $"FROM {Table_Tablo.main}", DB);
            read = (SQLiteDataReader)await commandRead.ExecuteReaderAsync();           
            while(await read.ReadAsync())
            {
                SQLiteDataAdapter dataadapter = new SQLiteDataAdapter($"SELECT sum(Cost) " +
                $"FROM {Table_Tablo.main}", DB);
                DataSet ds = new DataSet();

                dataadapter.Fill(ds, "Info");
                GridView.DataSource = ds.Tables[0];
                break;
            }
            read.Close();
        }
    

        private void FormWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            SQLiteDataReader read;
            SQLiteCommand commandRead = new SQLiteCommand($"SELECT count(*) " +
            $"FROM { Table_Tablo.main }", DB);
            read = (SQLiteDataReader)await commandRead.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                SQLiteDataAdapter dataadapter = new SQLiteDataAdapter($"SELECT count(*) " +
                $"FROM { Table_Tablo.main }", DB);
                DataSet ds = new DataSet();

                dataadapter.Fill(ds, "Info");
                GridView.DataSource = ds.Tables[0];
                break;
            }
            read.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("SELECT * FROM Tablo", DB);
            DataSet ds = new DataSet();

            dataadapter.Fill(ds, "Info");
            GridView.DataSource = ds.Tables[0];
        }

        private async void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                int id_table = Convert.ToInt32(GridView.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());

                SQLiteCommand commandDelate = new SQLiteCommand($"DELETE FROM {Table_Tablo.main} " +
                $"WHERE id = '" + id_table + "' ", DB);
                await commandDelate.ExecuteNonQueryAsync();
                MessageBox.Show("Запись удаелна", "Удалено", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormReis frm = new FormReis();
            frm.Show();
            this.Hide();
        }
    }
}