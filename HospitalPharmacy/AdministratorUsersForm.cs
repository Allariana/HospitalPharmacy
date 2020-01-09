using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    public partial class AdministratorUsersForm : Form
    {
        ConnectionManager connection = ConnectionManager.getInstance();
        public AdministratorUsersForm()
        {

            InitializeComponent();
            
                /*DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                comboBoxColumn.HeaderText = "Role Name";
                comboBoxColumn.Width = 100;
                comboBoxColumn.Name = "comboBoxColumn";
                DataTable roleColumn = new DataTable();
                connection.getColumn("Roles", "RoleName", roleColumn);
                List<string> list = roleColumn.Rows.OfType<DataRow>().Select(dr => (string)dr["RoleName"]).ToList();
                comboBoxColumn.DataSource = list;
                usersDataGridView.Columns.Add(comboBoxColumn);*/
            }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
                Validate();
            usersBindingSource.EndEdit();
            /*foreach (DataGridViewRow row in usersDataGridView.Rows)
            {
                try
                {
                    if (row.Cells[0].Value.ToString() == null) row.Cells[0].Value = 10;
                }
                catch (NullReferenceException) { row.Cells[0].Value = 10; }
            }*/
            /*foreach (DataGridViewRow row in usersDataGridView.Rows)
            {
                try
                {
                    connection.update("RoleID", "Roles", "RoleName", row.Cells[5].Value.ToString(), row.Cells[0].Value.ToString(), "Users", "UserID");
                }
                catch (Exception) { }
            }*/
            tableAdapterManager.UpdateAll(pharmacyDataSet);
            //this.Hide();
        }

        private void AdministratorUsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.pharmacyDataSet.Roles);
            usersTableAdapter.Fill(pharmacyDataSet.Users);
            foreach (DataGridViewRow row in usersDataGridView.Rows)
            {
                int index = usersDataGridView.Rows.IndexOf(row);
                if ((index % 2) == 0) usersDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            /*foreach (DataGridViewRow row in usersDataGridView.Rows)
            {
                try
                {
                    String id = row.Cells[1].Value.ToString();
                    String roleName = connection.getRecordWithCondition("RoleName", "Roles", "RoleID", int.Parse(id));
                    row.Cells[5].Value = roleName;
                }
                catch (Exception) { }
            }*/
            foreach (DataGridViewRow row in usersDataGridView.Rows)
            {
                try
                {
                    if (row.Cells[0].Value.ToString() == null) row.Cells[0].Value = 10;
                }
                catch (NullReferenceException) { row.Cells[0].Value = 10; }
            }

        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
    }
}
