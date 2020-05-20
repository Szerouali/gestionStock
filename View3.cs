using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using MySql.Data.MySqlClient;

namespace Nike
{
    public partial class View3 : Form
    {
        string connectionString;
        MySqlConnection cnn;
        int currentId;
        int quantity;
        double price;

        public View3()
        {
            InitializeComponent();
        }
        private void buttonTop_Click(object sender, EventArgs e){}

        private void buttonBas_Click(object sender, EventArgs e){}

        private void buttonChaussure_Click(object sender, EventArgs e){}

        private void buttonTout_Click(object sender, EventArgs e){}

        private void buttonAccessoire_Click(object sender, EventArgs e){}

        private void buttonRetour_Click(object sender, EventArgs e){}

        private void buttonDetail_Click(object sender, EventArgs e){}

        public void refresh(string s)
        {
            try
            {
                String sql = s;
                
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

        private void View3_Load(object sender, EventArgs e)
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
            refresh("select * from product");
        }

        private void listeProduit_SelectedIndexChanged(object sender, EventArgs e){}
    }
}
