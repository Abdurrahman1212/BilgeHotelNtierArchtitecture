using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BussinessLogicLayer.Services
{
    public class AuthorizationService
    {
        private readonly List<EmployeePosition> _managerPositions = new List<EmployeePosition>
        {
            EmployeePosition.Manager,
            EmployeePosition.ITManager // IT sorumlusu da yönetici yetkilerine sahip olabilir
        };

        private readonly List<EmployeePosition> _itPositions = new List<EmployeePosition>
        {
            EmployeePosition.ITManager // Sadece IT sorumlusu
        };

        public bool IsManager(Employee employee)
        {
            return _managerPositions.Contains(employee.Position) ||
                   employee.EmployeeType == EmployeeType.SalariedEmployee;
        }

        public bool IsITResponsible(Employee employee)
        {
            return _itPositions.Contains(employee.Position);
        }

        public bool CanAccessEmployeeManagement(Employee employee)
        {
            return IsManager(employee);
        }

        public bool CanAccessPayrollManagement(Employee employee)
        {
            return IsManager(employee);
        }

        public bool CanAccessShiftManagement(Employee employee)
        {
            return IsManager(employee);
        }

        public bool CanAccessSystemSettings(Employee employee)
        {
            return IsManager(employee);
        }

        public bool CanAccessDatabaseManagement(Employee employee)
        {
            return IsITResponsible(employee) || IsManager(employee);
        }

        public bool CanCreateBackup(Employee employee)
        {
            return IsITResponsible(employee) || IsManager(employee);
        }

        public bool CanRestoreBackup(Employee employee)
        {
            return IsITResponsible(employee) || IsManager(employee);
        }

        public bool CanManageDatabaseConfiguration(Employee employee)
        {
            return IsITResponsible(employee) || IsManager(employee);
        }

        public bool CanViewEmployeeDetails(Employee employee, Employee targetEmployee)
        {
            // Yönetici kendi bilgilerini ve astlarının bilgilerini görebilir
            if (IsManager(employee))
            {
                return true;
            }

            // Çalışan sadece kendi bilgilerini görebilir
            return employee.Id == targetEmployee.Id;
        }

        public bool CanEditEmployee(Employee employee, Employee targetEmployee)
        {
            // Sadece yöneticiler çalışan bilgilerini düzenleyebilir
            return IsManager(employee);
        }

        public bool CanDeleteEmployee(Employee employee, Employee targetEmployee)
        {
            // Sadece üst düzey yöneticiler çalışan silebilir
            return employee.Position == EmployeePosition.Manager;
        }

        public List<string> GetUserPermissions(Employee employee)
        {
            var permissions = new List<string>();

            if (CanAccessEmployeeManagement(employee))
                permissions.Add("EmployeeManagement");

            if (CanAccessPayrollManagement(employee))
                permissions.Add("PayrollManagement");

            if (CanAccessShiftManagement(employee))
                permissions.Add("ShiftManagement");

            if (CanAccessSystemSettings(employee))
                permissions.Add("SystemSettings");

            if (CanAccessDatabaseManagement(employee))
                permissions.Add("DatabaseManagement");

            if (CanCreateBackup(employee))
                permissions.Add("CreateBackup");

            if (CanRestoreBackup(employee))
                permissions.Add("RestoreBackup");

            if (CanManageDatabaseConfiguration(employee))
                permissions.Add("ManageDatabaseConfiguration");

            return permissions;
        }

        public bool HasPermission(Employee employee, string permission)
        {
            var permissions = GetUserPermissions(employee);
            return permissions.Contains(permission);
        }

        public void ValidateManagerAccess(Employee employee, string requiredPermission)
        {
            if (!HasPermission(employee, requiredPermission))
            {
                throw new UnauthorizedAccessException($"Bu işlem için '{requiredPermission}' yetkisi gereklidir.");
            }
        }

        public void ValidateITAccess(Employee employee, string requiredPermission)
        {
            if (!IsITResponsible(employee) && !IsManager(employee))
            {
                throw new UnauthorizedAccessException("Bu işlem için IT sorumlusu veya yönetici yetkisi gereklidir.");
            }

            if (!HasPermission(employee, requiredPermission))
            {
                throw new UnauthorizedAccessException($"Bu işlem için '{requiredPermission}' yetkisi gereklidir.");
            }
        }

        public List<Employee> GetManagedEmployees(Employee manager)
        {
            if (!IsManager(manager))
            {
                return new List<Employee>();
            }

            // Yönetici pozisyonuna göre yönettiği çalışanları belirle
            switch (manager.Position)
            {
                case EmployeePosition.Manager:
                    // Genel müdür tüm çalışanları yönetir
                    return new List<Employee>(); // Tüm çalışanlar

                case EmployeePosition.ITManager:
                    // IT sorumlusu sadece IT ile ilgili çalışanları yönetir
                    return new List<Employee>(); // Sadece IT çalışanları

                default:
                    return new List<Employee>();
            }
        }

        public bool CanManageEmployee(Employee manager, Employee employee)
        {
            if (!IsManager(manager))
                return false;

            var managedEmployees = GetManagedEmployees(manager);
            return managedEmployees.Any() || managedEmployees.Contains(employee);
        }

        public bool CanAccessDatabaseForEmployee(Employee employee)
        {
            // IT sorumlusu tüm veritabanı işlemlerine erişebilir
            if (IsITResponsible(employee))
                return true;

            // Yöneticiler de veritabanı işlemlerine erişebilir
            if (IsManager(employee))
                return true;

            return false;
        }
    }

    public static class PermissionConstants
    {
        public const string EmployeeManagement = "EmployeeManagement";
        public const string PayrollManagement = "PayrollManagement";
        public const string ShiftManagement = "ShiftManagement";
        public const string SystemSettings = "SystemSettings";
        public const string DatabaseManagement = "DatabaseManagement";
        public const string CreateBackup = "CreateBackup";
        public const string RestoreBackup = "RestoreBackup";
        public const string ManageDatabaseConfiguration = "ManageDatabaseConfiguration";
        public const string ViewReports = "ViewReports";
        public const string ManageReservations = "ManageReservations";
        public const string ViewDatabaseLogs = "ViewDatabaseLogs";
        public const string SystemMaintenance = "SystemMaintenance";
    }
}
