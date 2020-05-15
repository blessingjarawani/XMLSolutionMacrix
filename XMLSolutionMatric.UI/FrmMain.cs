using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLSolutionMatrics.BLL.DTO;
using XMLSolutionMatrics.BLL.Entities;
using XMLSolutionMatrics.BLL.Infrastructure.Shared.Interfaces;
using XMLSolutionMatrics.BLL.Infrastructure.Util;
using static XMLSolutionMatrics.BLL.Infrastructure.Shared.Dictionaries.Dictionaries;

namespace XMLSolutionMatric.UI
{
    public partial class FrmMain : Form
    {
        private List<string> ArrayDeletions = new List<string>();
        private readonly IPersonService _personService;
        public FrmMain(IPersonService personService)
        {

            _personService = personService;

            InitializeComponent();
            DisableButtons();

        }
        void DisableButtons()
        {
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
        }

        void EnableButtons()
        {
            btnCancel.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            initEnum();
            fillGrid();
            SetMaxDate();
        }


        void SetMaxDate()
        {
            var today = DateTime.Now;
            DOB.MaxDate = today;
        }
        private void fillGrid()
        {
            try
            {
                dgrid.Rows.Clear(); ;
                var result = _personService.GetAll();
                if (!result.Success)
                {
                    MessageBox.Show(result.Message);
                }
                if (result.Data?.Any() != true)
                {
                    return;
                }
                foreach (var person in result.Data)
                {
                    dgrid.Rows.Add(person.Id, person.LastName, person.FirstName, person.StreetName, person.StreetName,
                        person.ApartmentNumber, person.Town.ToString(), person.PostalCode, person.PhoneNumber, person.DateOfBirth.ToShortDateString(), person.Age);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        void initEnum()
        {
            Town.Items?.Clear();
            var towns = Enum.GetValues(typeof(Town));
            foreach (var town in towns)
            {
                Town.Items.Add(town.ToString());
            }
        }


        bool validateGrid(int index)
        {
            var validationError =
                string.IsNullOrWhiteSpace(dgrid.Rows[index].Cells[1].Value?.ToString()) ||
                string.IsNullOrWhiteSpace(dgrid.Rows[index].Cells[2].Value?.ToString()) ||
                string.IsNullOrWhiteSpace(dgrid.Rows[index].Cells[3].Value?.ToString()) ||
                string.IsNullOrWhiteSpace(dgrid.Rows[index].Cells[4].Value?.ToString()) ||
                string.IsNullOrWhiteSpace(dgrid.Rows[index].Cells[6].Value?.ToString()) ||
                string.IsNullOrWhiteSpace(dgrid.Rows[index].Cells[7].Value?.ToString()) ||
                string.IsNullOrWhiteSpace(dgrid.Rows[index].Cells[8].Value?.ToString()) ||
                string.IsNullOrWhiteSpace(dgrid.Rows[index].Cells[9].Value?.ToString());
            if (validationError)
            {
                return false;
            }

            return true;
        }

        private void dgrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (!string.IsNullOrWhiteSpace(dgrid.CurrentCell.Value?.ToString()))
                {
                    var townId = (Town)Enum.Parse(typeof(Town), dgrid.CurrentCell.Value?.ToString());
                    dgrid.CurrentRow.Cells[7].Value = PostalCodes.FirstOrDefault(x => x.Key == (int)townId).Value;
                }
            }

            if (!validateGrid(e.RowIndex))
            {
                dgrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                return;
            }
            var addCommand = AddtoPersonCommand(e.RowIndex);
            dgrid.Rows[e.RowIndex].Cells[10].Value = addCommand.Age;
            if (addCommand.IsValid)
            {
                dgrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                EnableButtons();
            }
        }
        private AddPersonCommand AddtoPersonCommand(int rowIndex)
        {
            return new AddPersonCommand
            {
                Id = string.IsNullOrWhiteSpace(dgrid.Rows[rowIndex].Cells[0].Value?.ToString())
                ? 0 : int.Parse(dgrid.Rows[rowIndex].Cells[0].Value?.ToString()),
                LastName = dgrid.Rows[rowIndex].Cells[1].Value?.ToString(),
                FirstName = dgrid.Rows[rowIndex].Cells[2].Value?.ToString(),
                StreetName = dgrid.Rows[rowIndex].Cells[3].Value?.ToString(),
                HouseNumber = dgrid.Rows[rowIndex].Cells[4].Value?.ToString(),
                ApartmentNumber = dgrid.Rows[rowIndex].Cells[5].Value?.ToString(),
                Town = (Town)Enum.Parse(typeof(Town), dgrid.Rows[rowIndex].Cells[6].Value.ToString()),
                PostalCode = dgrid.Rows[rowIndex].Cells[7].Value?.ToString(),
                PhoneNumber = dgrid.Rows[rowIndex].Cells[8].Value?.ToString(),
                DateOfBirth = DateTime.Parse(dgrid.Rows[rowIndex].Cells[9].Value?.ToString()),
            };
        }

        void SaveListToXml()
        {
            for (int i = 0; i < dgrid.RowCount - 1; i++)
            {
                if (validateGrid(i))
                {
                    var person = AddtoPersonCommand(i);
                    var result = _personService.AddOrUpdate(person);
                    if (result.Success)
                    {
                        dgrid.Rows[i].Cells[0].Value = result.Data;
                        dgrid.Rows[i].Cells[1].Style.BackColor = Color.Green;
                        continue;
                    }
                    dgrid.Rows[i].Cells[1].Style.BackColor = Color.Red;
                }
            }
        }

        private void Delete()
        {
            if (ArrayDeletions?.Any() != true)
            {
                return;
            }
            if (_personService.Delete(ArrayDeletions?.ToArray()).Success)
            {
                ArrayDeletions.Clear();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveListToXml();
            Delete();
            fillGrid();
            DisableButtons();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Cancel UnSaved Data", "Cancel ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fillGrid();
                DisableButtons();
            }
        }

        private void dgrid_KeyDown(object sender, KeyEventArgs e)
        {
            var id = dgrid.CurrentRow.Cells[0].Value?.ToString();
            if (!string.IsNullOrWhiteSpace(id))
            {
                ArrayDeletions.Add(id);
                EnableButtons();
            }
        }


        private void dgrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgrid.CurrentCell.ColumnIndex == 8)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void dgrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            e.Control.KeyPress += new KeyPressEventHandler(dgrid_KeyPress);

        }
    }
}
