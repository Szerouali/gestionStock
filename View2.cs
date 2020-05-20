using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Nike
{
    public partial class View2 : Form
    {
        string connectionString;
        MySqlConnection cnn;
        int currentId;
        int selectedId;
        int quantity;
        double price;

        public object ListeProduit { get; private set; }

        public View2()
        {
            InitializeComponent();
        }
        private void buttonAnnuler_Click(object sender, EventArgs e){}

        private void textBoxLabel_TextChanged(object sender, EventArgs e){}

        private void textBoxCategory_TextChanged(object sender, EventArgs e) { }

        private void textBoxSize_TextChanged(object sender, EventArgs e) { }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e) { }

        private void textBoxReference_TextChanged(object sender, EventArgs e) { }

        private void textBoxPrice_TextChanged(object sender, EventArgs e) { }

        private void textBoxColor_TextChanged(object sender, EventArgs e) { }

        public void refresh()
        {
            try
            {
                String sql = "select * from product";

                MySqlCommand command = new MySqlCommand(sql, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                listeProduit.Items.Clear();
                while (dataReader.Read())
                {
                    currentId = Convert.ToInt32(dataReader.GetValue(0));
                    quantity = Convert.ToInt32(dataReader.GetValue(4));
                    price = Convert.ToDouble(dataReader.GetValue(6));
                    Product P = new Product(currentId, dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString(),
                        dataReader.GetValue(3).ToString(), quantity,
                        dataReader.GetValue(5).ToString(), dataReader.GetFloat(6), dataReader.GetValue(7).ToString());
                    listeProduit.Items.Add(P);
                }
                currentId++;
                dataReader.Close();
                command.Dispose();
            }
            catch (MySql.Data.MySqlClient.MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void View2_Load(object sender, EventArgs e)
        {
            connectionString = "Server=127.0.0.1; Database=nike;port=3306;User Id=root;password=";
            try
            {
                cnn = new MySqlConnection(connectionString);
                cnn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            refresh();
        }

        public void button_insert_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Insert into product (product_id, label, category, size, quantity, reference, price, color)" +
                    "values ( @id, @label, @category, @size, @quantity, @reference, @price, @color)";
                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = sql;
                // creez un objet parametre.
                MySqlParameter idParam = new MySqlParameter("@id", SqlDbType.Int);
                idParam.Value = currentId;
                cmd.Parameters.Add(idParam);

                
                MySqlParameter labelParam = cmd.Parameters.AddWithValue("@label", this.textBoxLabel.Text.ToString());

                MySqlParameter categoryParam = cmd.Parameters.AddWithValue("@category", this.textBoxCategory.Text.ToString());

                MySqlParameter sizeParam = cmd.Parameters.AddWithValue("@size", this.textBoxSize.Text.ToString());

                MySqlParameter quantityParam = cmd.Parameters.AddWithValue("@quantity", this.textBoxQuantity.Text.ToString());

                MySqlParameter referenceParam = cmd.Parameters.AddWithValue("@reference", this.textBoxReference.Text.ToString());

                MySqlParameter priceParam = cmd.Parameters.AddWithValue("@price", this.textBoxPrice.Text.ToString());

                MySqlParameter colorParam = cmd.Parameters.AddWithValue("@color", this.textBoxColor.Text.ToString());

                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Insert -> Row Count affected =" + rowCount);
                refresh();
            }
            catch (MySqlException exc)
            {
                Console.WriteLine("error: " + exc);
                Console.WriteLine(exc.StackTrace);
            }
        }
        public void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Delete from product where product_id = @product_id";
                Product P = (Product)listeProduit.SelectedItem;
                if (P != null)
                {
                    selectedId = l.Id;
                }

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = sql; cmd.Parameters.AddWithValue("@product_id", selectedId);

                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Delete -> Row Count affected = " + rowCount);

                refresh();
            }
            catch(MySqlException exc) 
            {
                Console.WriteLine("error: " + exc);
                Console.WriteLine(exc.StackTrace);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "Server=127.0.0.1; Database=nike;port=3306;User Id=root;password=";
            try
            {
                cnn = new MySqlConnection(connectionString);
                cnn.Open();

            }
            catch (MySql.Data.MySqlClient.MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            refresh();
        }
    }  
}
