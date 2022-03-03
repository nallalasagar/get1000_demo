using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjunittestEg2
{

    public class EmployeeDetails
    {
        public int id { get; set; }
        public string Name{ get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }

    }

    public class Logic
    {
        #region Login

        public string Login(string userid, string password)
        {
            if (string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(password))
            {
                return "userid or password cant be null!!";
            }
            else
            {
                if (userid == "Admin" && password == "admin")
                {
                    return "welcome Admin";
                }
                else
                {
                    return "Incorrect username or password!!";
                }
            }

        }

        public List<EmployeeDetails> AllUsers()
        {
            List<EmployeeDetails> li = new List<EmployeeDetails>();
            li.Add(new EmployeeDetails { id = 101, Name = "sai", Gender = "male", Salary = 34000 });
            li.Add(new EmployeeDetails { id = 102, Name = "Nisha", Gender = "Female", Salary = 44000 });
            li.Add(new EmployeeDetails { id = 103, Name = "Sunil", Gender = "male", Salary = 74000 });
            li.Add(new EmployeeDetails { id = 104, Name = "Kumar", Gender = "male", Salary = 54000 });
            return li;
        }
        #endregion
        public List<EmployeeDetails> GetDetails(int id)
        {
            List<EmployeeDetails> li1 = new List<EmployeeDetails>();
            Logic logic = new Logic();
            var liuser = logic.AllUsers();
            foreach (var x in liuser)
            {
                if (x.id == id)
                {
                    li1.Add(x);
                }
            }

            return li1;

        }

    }
    class EmployeeProject
    {

    }
        
}
