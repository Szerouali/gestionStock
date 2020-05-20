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
    public partial class Views4 : Form
    {
        string connectionString;
        MySqlConnection cnn;
        int currentId;
        int quantity;
        double price;
        View3 view3;

        public Views4()
        {
            InitializeComponent();
        }

        private void textBox12_TextChanged(object sender, EventArgs e){}

        private void textBox4_TextChanged(object sender, EventArgs e){}

        private void label1_Click(object sender, EventArgs e){}

        private void buttonSup_Click(object sender, EventArgs e){}
    
        private void buttonModifier_Click(object sender, EventArgs e){}
      
        private void buttonRetourListe_Click(object sender, EventArgs e){}

        public void refresh()
        {
            try
            {
                String sql = "select * from product where product_id = product_id";

                MySqlCommand command = new MySqlCommand(sql, cnn);
                MySqlDataReader dataReader = command.ExecuteReader();

                listBox1.Items.Clear();
                while (dataReader.Read())
                {
                    currentId = Convert.ToInt32(dataReader.GetValue(0));
                    quantity = Convert.ToInt32(dataReader.GetValue(4));
                    price = Convert.ToDouble(dataReader.GetValue(6));
                    Product P = new Product(currentId, dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString(),
                        dataReader.GetValue(3).ToString(), quantity,
                        dataReader.GetValue(5).ToString(), price, dataReader.GetValue(7).ToString());
                    listBox1.Items.Add(P);
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

        private void View4_Load(object sender, EventArgs e)
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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e){}

        private void Views4_Load(object sender, EventArgs e)
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
