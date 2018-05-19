using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSchool.Models;

namespace WebSchool.Services.DAL
{
    public class Person_DAL
    {

        private ApplicationDbContext dataContext;

        public List<ApplicationUser> Users(string roleID)
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    var users = (from u in dataContext.Users
                                 from ur in u.Roles
                                 join r in dataContext.Roles on ur.RoleId equals r.Id
                                 select new
                                 {
                                     Id = u.Id,
                                     FirstName = u.FirtsName,
                                     LastName = u.LastName,
                                     Role = r.Name,
                                 }
                               ).ToList();
                              
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
            }
            return null;
        }


    }
}