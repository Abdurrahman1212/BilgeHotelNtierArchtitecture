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
    public partial class RoomManagementForm : Form
    {
        private RoomRepo _roomRepo;
        private List<Room> _rooms;

        public RoomManagementForm()
        {
            InitializeComponent();
            var optionsBuilder = new DbContextOptionsBuilder<ProjectDatabaseContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=HotelDB;Trusted_Connection=True;TrustServerCertificate=True;");
            var context = new ProjectDatabaseContext(optionsBuilder.Options);
            _roomRepo = new RoomRepo(context);
            LoadRooms();
        }

        private void LoadRooms()
        {
            _rooms = _roomRepo.GetAllRooms();
            dgvRooms.DataSource = _rooms;

            dgvRooms.Columns["Id"].HeaderText = "Oda No";
            dgvRooms.Columns["Description"].HeaderText = "Açıklama";
            dgvRooms.Columns["RoomType"].HeaderText = "Oda Tipi";
            dgvRooms.Columns["IsAvailable"].HeaderText = "Müsait";
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            var addForm = new AddRoomForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadRooms();
            }
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                var roomId = (int)dgvRooms.SelectedRows[0].Cells["Id"].Value;
                var editForm = new EditRoomForm(roomId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadRooms();
                }
            }
        }
    }
}
