using StockManagement.Business.Abstract;
using StockManagement.DataAccess.Abstract;
using StockManagement.DataAccess.AdoNET;
using StockManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Business.Concrete
{
    public class MyUserManager : IUserService
    {
        IUserDal _userdal;
        public MyUserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }

        public MyUserManager()
        {

        }

        public void TAdd(User entity)
        {
            _userdal.Add(entity);
        }

        public void TDelete(User entity)
        {
            _userdal.Delete(entity);
        }

        public List<User> TGetAll()
        {
            return _userdal.GetAll().ToList();
        }

        public User TGetById(int id)
        {
            return _userdal.GetById(id);
        }

        public void TUpdate(User entity)
        {
            _userdal.Update(entity);
        }

        public string AddUserBL(string UserName, string FullName, string Password, string Address, string City)
        {
            string isUserValid = "true";
            if (isUserValid == "true")
            {
                AdoUserRepository userDAL = new AdoUserRepository();
                bool isDone = userDAL.AdduserDAL(UserName, FullName, Password, Address, City);
                if (isDone != true)
                {
                    return "Server error, ";
                }
                else
                {
                    return "true";
                }
            }
            else
            {
                return isUserValid;
            }

        }

            public string UpdateUserBL(int Id, string Address, string City, string Password, string FullName, string UserName)
            {
                string isUserValid = "true";
                if (isUserValid == "true")
                {
                    AdoUserRepository userDAL = new AdoUserRepository();
                    bool isDone = userDAL.UpdateuserDAL(Id, Address, City, Password, FullName, UserName);
                    if (isDone != true)
                    {
                        return "Server error, ";
                    }
                    else
                    {
                        return "true";
                    }
                }
                else
                {
                    return isUserValid;
                }

            }
        }
    }

