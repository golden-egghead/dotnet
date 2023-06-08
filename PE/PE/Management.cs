using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Services.Models;
using Services.Services;

namespace PE
{
    public partial class Management : Form
    {
        BankAccountServices bankAccountService = new BankAccountServices();
        AccountTypeServices accountTypeService = new AccountTypeServices();
        int referenceIndex;
        public Management()
        {
            InitializeComponent();

            var listBankAccount = bankAccountService.GetAll();

            RefreshDataGridView();

            cboTypeName.DataSource = accountTypeService.GetAll();
            cboTypeName.DisplayMember = "TypeName";
            cboTypeName.ValueMember = "TypeId";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*dgvManagement.DataSource = new BindingSource
            {
                DataSource = bankAccountService.GetAll().Where(p => p.BranchName.ToLower().Contains(txtSearch.Text.ToLower()))
            };*/

            dgvManagement.DataSource = new BindingSource
            {
                DataSource = bankAccountService.GetAll().Select(ba => new
                {
                    ba.AccountId,
                    ba.AccountName,
                    ba.OpenDate,
                    ba.BranchName,
                    ba.TypeId,
                    TypeName = accountTypeService.GetAll().FirstOrDefault(at =>
                        at.TypeId == ba.TypeId)?.TypeName,
                }).ToList().Where(p => p.BranchName.ToLower().Contains(txtSearch.Text.ToLower()))
            };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvManagement.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvManagement.SelectedRows[0];
                var accountId = selectedRow.Cells["AccountId"].Value.ToString();

                var existingBankAccount = bankAccountService.GetAll().FirstOrDefault(ba => ba.AccountId == accountId);

                if (existingBankAccount != null)
                {
                    if (bankAccountService.Delete(existingBankAccount))
                    {
                        MessageBox.Show("Delete Successful");
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Delete Failed");
                    }
                }
                else
                {
                    MessageBox.Show("BankAccount not found");
                }
            }
            else
            {
                MessageBox.Show("Please select a BankAccount to delete");
            }

        }

        private void RefreshDataGridView()
        {
            dgvManagement.DataSource = new BindingSource
            {
                DataSource = bankAccountService.GetAll().Select(ba => new
                {
                    ba.AccountId,
                    ba.AccountName,
                    ba.OpenDate,
                    ba.BranchName,
                    ba.TypeId,
                    TypeName = accountTypeService.GetAll().FirstOrDefault(at =>
                        at.TypeId == ba.TypeId)?.TypeName,
                }).ToList()
            };
        }

        private void dgvManagement_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var listResult = bankAccountService.GetAll()[e.RowIndex];
            referenceIndex = e.RowIndex;
            txtAccountID.Text = listResult.AccountId.ToString();
            txtAccountName.Text = listResult.AccountName.ToString();
            txtBranchName.Text = listResult.BranchName.ToString();
            dtpOpenDate.Text = listResult.OpenDate.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BankAccount newBankAccount = new BankAccount();
            newBankAccount.AccountId = txtAccountID.Text;
            newBankAccount.AccountName = txtAccountName.Text;
            newBankAccount.OpenDate = DateTime.Parse(dtpOpenDate.Text);
            newBankAccount.BranchName = txtBranchName.Text;
            newBankAccount.TypeId = cboTypeName.SelectedValue.ToString();

            try
            {
                if (IsIDUnique(txtAccountID.Text))
                {
                    throw new ArgumentException("ID must be unique");
                }

                if (dtpOpenDate.Value.Year <= 2000 || dtpOpenDate.Value.Year >= 2022)
                {
                    throw new ArgumentException("Open Date Must between 2000 and 2022");
                }

                if (txtBranchName.Text.Length <= 5)
                {
                    throw new ArgumentException("Branch Name Must be more than 5 letter");
                }

                if (!char.IsUpper(txtBranchName.Text[0]))
                {
                    throw new ArgumentException("Branch Name must begin with capital letter");
                }

                bankAccountService.Create(newBankAccount);
                MessageBox.Show("Add Successful");
                RefreshDataGridView();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Validation error occurred:\n\n" + ex.Message,
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private bool IsIDUnique(string id)
        {
            return bankAccountService.GetAll().Any(ba => ba.AccountId.Equals(id));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            BankAccount editBankAccount = new BankAccount();
            editBankAccount.AccountId = txtAccountID.Text;
            editBankAccount.AccountName = txtAccountName.Text;
            editBankAccount.OpenDate = DateTime.Parse(dtpOpenDate.Text);
            editBankAccount.BranchName = txtBranchName.Text;
            editBankAccount.TypeId = cboTypeName.SelectedValue.ToString();

            BankAccount existingBankAccount = bankAccountService.GetAll().FirstOrDefault(ba => ba.AccountId.Equals(editBankAccount.AccountId));
            try
            {

                if (dtpOpenDate.Value.Year <= 2000 || dtpOpenDate.Value.Year >= 2022)
                {
                    throw new ArgumentException("Open Date Must between 2000 and 2022");
                }

                if (txtBranchName.Text.Length <= 5)
                {
                    throw new ArgumentException("Branch Name Must be more than 5 letter");
                }

                if (!char.IsUpper(txtBranchName.Text[0]))
                {
                    throw new ArgumentException("Branch Name must begin with capital letter");
                }


                if (existingBankAccount != null)
                {
                    existingBankAccount.AccountName = editBankAccount.AccountName;
                    existingBankAccount.OpenDate = editBankAccount.OpenDate;
                    existingBankAccount.BranchName = editBankAccount.BranchName;
                    existingBankAccount.TypeId = editBankAccount.TypeId;
                    bankAccountService.Update(existingBankAccount);
                    MessageBox.Show("Update Successful");
                    RefreshDataGridView();
                }
                else
                {
                    throw new Exception("Update not success!");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Validation error occurred:\n\n" + ex.Message,
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excute Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
