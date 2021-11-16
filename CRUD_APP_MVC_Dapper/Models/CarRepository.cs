using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CRUD_APP_MVC_Dapper.Models;
using Dapper;

namespace CRUD_APP_MVC_Dapper.Repository
{
    public class CarRepository
    {
        private string connectionString;
        public CarRepository()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
        }
        public List<Car> GetAll()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
                return db.Query<Car>("Cars_ViewAll", commandType: CommandType.StoredProcedure).ToList();
        }

        public Car Get(int Id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
                return db.Query<Car>("Cars_Get", new { Id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public Car Create(Car cr)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
                return db.Query<Car>("Cars_Add", cr, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public Car Update(Car cr)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
                return db.Query<Car>("Cars_Update", cr, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        internal void Delete(Car c)
        {
            throw new NotImplementedException();
        }

        public Car Delete(int Id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
                return db.Query<Car>("Cars_Delete", new { Id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        internal void Get(Car c)
        {
            throw new NotImplementedException();
        }
    }
}


