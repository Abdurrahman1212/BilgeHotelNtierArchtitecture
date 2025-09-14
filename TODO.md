- [x] Fix NullReferenceException in Presentation/Views/Reservation/Edit.cshtml by updating ReservationController.Edit to pass the model
- [x] Add null check in the view for Model.ReservationStatus
- [x] Use GetByIdWithCustomerAsync to include navigation properties Customer and Room
- [x] Make Edit action async

**SQL Server Connection Fix:**
- [x] Update BilgeoHotel/Program.cs to use connection string from appsettings.json via DI
- [x] Remove hardcoded connection string from ProjectDatabaseDbContext.cs OnConfiguring method
- [ ] Verify SQL Server instance name and server name (run `hostname` in cmd)
- [ ] Check if SQL Server (SQLEXPRESS) service is running
- [ ] Check if SQL Server Browser service is running
- [ ] Configure SQL Server to allow remote connections (enable TCP/IP in SSMS)
- [ ] Check Windows Firewall settings for SQL Server traffic
- [ ] Test the application connection after verification
