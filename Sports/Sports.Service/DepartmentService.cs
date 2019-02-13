﻿using Sports.Data.Repository;
using Sports.Data.Infrastructure;
using Sports.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sports.Core.Common;
using Sports.LoggerService;

namespace Sports.Service
{
    public interface IDepartmentService
    {

        bool CreateDepartment(Department department);
        bool UpdateDepartment(Department department);
        bool DeleteDepartment(int id);
        Department GetDepartment(int id);
        
        IEnumerable<Department> GetAllDepartment();
        void SaveRecord();

        bool CheckIsExist(Department department);
    }

    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly LoggingService logger = new LoggingService(typeof(DepartmentService));

        public DepartmentService()
        {
        }
                
        public DepartmentService(IDepartmentRepository departmentRepository, IUnitOfWork unitOfWork)
        {
            this.departmentRepository = departmentRepository;
            this.unitOfWork = unitOfWork;
        }

        public bool CheckIsExist(Department department)
        {
            return departmentRepository.Get(chk => chk.Name == department.Name) == null ? false : true;
        }

        public bool CreateDepartment(Department department)
        {
            bool isSuccess = true;
            try
            {
                departmentRepository.Add(department);                
                this.SaveRecord();
                ServiceUtil<Department>.WriteActionLog(department.Id, ENUMOperation.CREATE, department);
            }
            catch(Exception ex)
            {
                isSuccess = false;
                logger.Error("Error in creating Department", ex);
            }
            return isSuccess;
        }

        public bool UpdateDepartment(Department department)
        {
            bool isSuccess = true;
            try
            {
                departmentRepository.Update(department);
                this.SaveRecord();
                ServiceUtil<Department>.WriteActionLog(department.Id, ENUMOperation.UPDATE, department);
            }
            catch(Exception ex)
            {
                isSuccess = false;
                logger.Error("Error in updating Department", ex);
            }
            return isSuccess;
        }

        public bool DeleteDepartment(int id)
        {
            bool isSuccess = true;
            var department = departmentRepository.GetById(id);
            try
            {
                departmentRepository.Delete(department);
                SaveRecord();
                ServiceUtil<Department>.WriteActionLog(id, ENUMOperation.DELETE);
            }
            catch(Exception ex)
            {
                isSuccess = false;
                logger.Error("Error in deleting Department", ex);
            }
            return isSuccess;
        }

        public Department GetDepartment(int id)
        {
            return departmentRepository.GetById(id);
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return departmentRepository.GetAll();
        }

        
        public void SaveRecord()
        {
            unitOfWork.Commit();
        }
    }
}
