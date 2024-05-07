using BookWinForm.Classes;
using System.Data.SqlClient;

namespace BookWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            connectToDbBook();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        public void connectToDbBook()
        {
            string connectionString = @"Server=DESKTOP-VI9VLOB\SQLEXPRESS;Database=BookSystem;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            //string cmdText = "Select*from Book";
            //SqlCommand cmd = new SqlCommand(cmdText, connection);
            //var data = cmd.ExecuteReader();

            //while (data.Read())
            //{
            //    string bookname = data.GetValue(1).ToString();
            //    MessageBox.Show(bookname);
            //}
            //connection.Close();

            string cmdText = @"Select Id ID, BookName BookName, Price Price  from Book";
            SqlCommand cmd = new SqlCommand(cmdText, connection);
            var data = cmd.ExecuteReader();
            List<Book> list = new List<Book>();

            while (data.Read())
            {
                Book book = new Book
                {
                    ID = (int)data["ID"],
                    BookName = data["BookName"].ToString(),
                    Price = (int)data["Price"]
                };

                list.Add(book);
            }
            dataGridView1.DataSource = list;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-VI9VLOB\SQLEXPRESS;Database=BookSystem;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string insertQuery = @"Insert Into Book (BookName,Price,InStock)
                                  values (@Book_Name,@Price,1)";

            SqlCommand Command = new SqlCommand(insertQuery, connection);

            Command.Parameters.AddWithValue("@Book_Name", BookNameTextBox.Text);
            Command.Parameters.AddWithValue("@Price", PriceTextBox.Text);
            
            int rowAffected=Command.ExecuteNonQuery();
            MessageBox.Show($"{rowAffected} row affected");
            connection.Close();

            connectToDbBook();
        }
    }
}
