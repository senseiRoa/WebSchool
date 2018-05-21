using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSchool.Infraestructure;
using WebSchool.Models;

namespace WebSchool.Services.DAL
{
    public class Person_DAL
    {

        private ApplicationDbContext dataContext;

        public List<PersonViewModel> Users()
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    var users = (from u in dataContext.Users
                                 from ur in u.Roles
                                 join r in dataContext.Roles on ur.RoleId equals r.Id
                                 select new PersonViewModel
                                 {
                                     Id = u.Id,
                                     FirstName = u.FirtsName,
                                     LastName = u.LastName,
                                     Role = r.Name,
                                     Email=u.Email,
                                     UserName=u.UserName
                                 }
                               ).ToList();
                    return users;
                              
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
            }
            return new List<PersonViewModel>();
        }



    }
}