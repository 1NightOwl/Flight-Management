using FlightManagement.Core.Common;
using FlightManagement.Core.Logic.Managers;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.PL.Admin.Perdoruesit
{
    public partial class FrmActiveUsers : Form
    {
        int userId = -1;
        public FrmActiveUsers()
        {
            InitializeComponent();
        }

        private void FrmActiveUsers_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            cbFilterRoles.SelectedIndex = 0;
            cbChangeRole.SelectedIndex = 0;
        }
        private void FillDataGridView()
        {
            dgActiveUsers.AutoGenerateColumns = true;
            dgActiveUsers.DataSource = null;
            dgActiveUsers.DataSource = Program.UsersManager.GetAll().ToList();
            dgActiveUsers.Columns["Password"].Visible = false;
            dgActiveUsers.Columns["Biletat"].Visible = false;

            dgActiveUsers.Columns["Id"].HeaderText = "ID";
            dgActiveUsers.Columns["Username"].HeaderText = "Emri i Përdoruesit";
            dgActiveUsers.Columns["Email"].HeaderText = "Email";
            dgActiveUsers.Columns["Role"].HeaderText = "Roli";
            dgActiveUsers.Columns["CreatedDate"].HeaderText = "Data e Krijimit";
            dgActiveUsers.Columns["UpdatedDate"].HeaderText = "Data e Përditësimit";
            dgActiveUsers.Columns["UpdatedDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgActiveUsers.Columns["UpdatedDate"].DefaultCellStyle.NullValue = "—";
        }
        private void RefreshUserGrid()
        {
            FillDataGridView();
            userId = -1;
            btnDelete.Enabled = false;
            btnChangeRole.Enabled = false;
            cbChangeRole.Enabled = false;
        }
        private void FilterUsers()
        {
            var users = Program.UsersManager;
            var list = users
                            .GetAll()
                            .AsEnumerable();

            if (cbFilterRoles.SelectedItem.ToString() != "All")
                list = list.Where(u => u.Role == cbFilterRoles.SelectedItem.ToString());

            var id = txtFilterId
                            .Text
                            .Trim()
                            .ToLower();

            var term = txtFilterId.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(id))
                list = list.Where(u =>
                    u.Id.ToString().Contains(term) ||
                    u.Username.ToLower().Contains(term) ||
                    u.Email.ToLower().Contains(term)
                );

            dgActiveUsers.DataSource = list.ToList();
        }

        private void cbFilterRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterUsers();
        }

        private void dgActiveUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kontrollim nese rrjeshti qe admini ka shtypur eshte ai qe deshiron, 
            //dhe gjithashtu si mase brojtese kunder klikimit pa qellim mbi cell dhe fshirja e te dhenave te meparshme
            DialogResult result = MessageBox.Show(
                "Deshiron te marresh te dhenat e ketij avioni?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                if (e.RowIndex < 0) return;

                cbChangeRole.Enabled = true;
                btnDelete.Enabled = true;
                btnChangeRole.Enabled = true;

                userId = Convert.ToInt32(dgActiveUsers.Rows[e.RowIndex].Cells["Id"].Value);
            }
            else
            {

            }
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            if (dgActiveUsers.CurrentRow == null) return;
            string role = cbChangeRole.SelectedItem?.ToString() ?? "User";

            if (MessageBox.Show("Jeni te sigurt qe deshironi te ndryshoni rolin?", "Konfirmim",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                new UsersManager().ChangeUserRole(userId, cbChangeRole.SelectedItem.ToString());
                RefreshUserGrid();
            }
            catch (FlightManagementException ex)
            {
                MessageBox.Show(ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgActiveUsers.CurrentRow == null) return;
            if (MessageBox.Show("Jeni te sigurt qe doni te fshini kete perdorues?", "Konfirmim",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                Program.UsersManager.Delete(userId);
                RefreshUserGrid();
            }
            catch (FlightManagementException ex)
            {
                MessageBox.Show(ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFilterId_TextChanged(object sender, EventArgs e)
        {
            FilterUsers();
        }
    }
}
