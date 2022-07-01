using RentVehicle.Forms.ForAdmin.Roles;
using Excel = Microsoft.Office.Interop.Excel;

namespace RentVehicle.Forms.ForAdmin
{
    public partial class RolesForm : Form
    {
        public RolesForm()
        {
            InitializeComponent();
            try
            {
                using (TSContext db = new TSContext())
                {
                    var roles = db.Roles.ToList();
                    DataGridFill(roles);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private Role SearchByID(int id)
        {
            using (TSContext db = new TSContext())
            {
                return db.Roles.FirstOrDefault(e => e.IdRole == id);
            }
        }

        private void RolesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void DataGridFill(List<Role> role)
        {
            dataGridView1.Rows.Clear();
            try
            {
                using (TSContext db = new TSContext())
                {
                    foreach (var r in role)
                    {
                        dataGridView1.Rows.Add($"{r.IdRole}",
                            $"{r.NameRole}",
                            "✎");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                CMB cmb = new CMB();
                cmb.ShowDialog();
                try
                {
                    if (cmb.DialogResult.Equals(DialogResult.Yes))
                    {
                        using (TSContext db = new TSContext())
                        {
                            var roles = SearchByID(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
                            db.Roles.Remove(roles);
                            db.SaveChanges();
                            MessageBox.Show("Удаление прошло успешно", "EZДЖИ");
                            var role = db.Roles.ToList();
                            DataGridFill(role);

                        }
                    }
                    else if (cmb.DialogResult.Equals(DialogResult.No))
                    {
                        UpdateRoleForm updateRoleForm = new UpdateRoleForm();
                        updateRoleForm.Id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                        updateRoleForm.nameRoleTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                        updateRoleForm.Show();
                        updateRoleForm.FormClosed += (object s, FormClosedEventArgs args) =>
                        {
                            using (TSContext db = new TSContext())
                            {
                                var roles = db.Roles.ToList();
                                DataGridFill(roles);
                            }
                        };
                    }
                    else return;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddRoleForm addRoleForm = new AddRoleForm();
            addRoleForm.FormClosed += (object s, FormClosedEventArgs args) =>
            {
                try
                {
                    using (TSContext db = new TSContext())
                    {
                        var roles = db.Roles.ToList();
                        DataGridFill(roles);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            };
            addRoleForm.Show();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Excel.Application application = new Excel.Application();
            application.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)application.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridView1.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 2; j++)
                {
                    ws.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }
            application.Visible = true;
        }
    }
}
