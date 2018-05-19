using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebSchool.Models;

namespace WebSchool.Services.DAL
{
    public class Menu_DAL
    {
        private ApplicationDbContext dataContext;

        public List<T_Menu> LoadMenuByUser(string userID)
        {
            try
            {
                using (dataContext = new ApplicationDbContext())
                {
                    SqlParameter parameter1 = new SqlParameter("UserID", userID);

                    var menuList = (dataContext.Database.SqlQuery<T_Menu>("exec SP_LoadMenuByUser @UserID", parameter1)).ToList();

                    return getMenu(menuList, 0);
                }
            }
            catch (Exception ex)
            {
                //TODO: guardar en api log
            }
            return new List<T_Menu>();
        }

        private List<T_Menu> getMenu(List<T_Menu> menuList, int parentMenuID)
        {
            List<T_Menu> mL = new List<T_Menu>();
            var subMenu = menuList.Where(i => i.ParentMenuID.Equals(parentMenuID));
            if (subMenu == null || subMenu.Count() == 0)
            {
                return mL;
            }
            foreach (var item in subMenu)
            {
                T_Menu m = new T_Menu
                {
                    DisplayName = item.DisplayName,
                    MenuIcon = item.MenuIcon,
                    MenuID = item.MenuID,
                    MenuURL = item.MenuURL,
                    OrderNumber = item.OrderNumber,
                    ParentMenuID = item.ParentMenuID,
                };
                m.SubMenu = getMenu(menuList, item.MenuID);
                mL.Add(m);
            }
            return mL;
        }
    }
}
