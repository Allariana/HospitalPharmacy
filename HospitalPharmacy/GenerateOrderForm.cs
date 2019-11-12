using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class GenerateOrderForm : Form
    {
        PharmacyEntities pharmacyContext;
        private ConnectionManager orderConnection;
        public GenerateOrderForm()
        {
            InitializeComponent();
            ConnectionManager connection = new ConnectionManager();
            DataTable price = new DataTable();
            connection.getPrice(price);
            this.priceLabel.Text = price.ToString();
            //priceGridView.DataSource = price.ToString();
            try
            {
                pharmacyContext = new PharmacyEntities();
                generateOrderViewGrid.DataSource = pharmacyContext.GenerateOrderViews.ToList();
                //priceGridView.DataSource = pharmacyContext.TotalPriceView.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = this.orderConnection.connection;
                connection.Open();
                string insertOrder = "insert into NewMedicineOrders([NewMedicineOrderID]) values (1);";
                new SqlCommand(insertOrder, connection).ExecuteNonQuery();
                connection.Close();
                /*
                 * SqlConnection con = this.tcon.con;
                con.Open();
                string getSubjectId = "select id from subjects where subject_name = '" + comboBoxSubject.Text + "'";
                SqlCommand cmd = new SqlCommand(getSubjectId, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string subject_id = reader[0].ToString();
                reader.Close();
                string insert = "insert into Marks values ("
                    + textBoxMark.Text + ", " + comboBoxIndex.Text + ", "
                    + subject_id + ")";
                new SqlCommand(insert, con).ExecuteNonQuery();
                con.Close();
                this.behind.Show();
                this.Close();
                 */
            }
            catch (Exception ex)
            {
                //do nothing
            }
            finally
            {
                this.Close();
            }
        }
    }
}
