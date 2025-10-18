using Models.Entities;
using DataAccessLayer.Services.Concretes;
using DataAccessLayer.Configurations.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace AdminDesktopApp
{
    public partial class EmployeeManagementForm : Form
    {
        private List<Employee> _employees;

        public EmployeeManagementForm()
        {
            this.Text = "Çalışan Yönetimi";
            this.Size = new System.Drawing.Size(600, 400);
            // TODO: Implement employee management functionality
            MessageBox.Show("Employee management is not yet implemented.");
        }

        private void LoadEmployees()
        {
            // TODO: Implement employee loading
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add employee functionality not yet implemented.");
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit employee functionality not yet implemented.");
        }
    }
}
