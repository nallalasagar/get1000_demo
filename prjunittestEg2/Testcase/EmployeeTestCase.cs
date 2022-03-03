using NUnit.Framework;
using prjunittestEg2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testcase
{
    class EmployeeTestCase
    {
        List<EmployeeDetails> li;
        Logic logic = new Logic();
        [Test]

        public void CheckDetails()
        {

            li = logic.AllUsers();
            foreach(var item in li)
            {
                Assert.IsNotNull(item.id);
                Assert.IsNotNull(item.Name);
                Assert.IsNotNull(item.Gender);
                Assert.IsNotNull(item.Salary);
                Assert.GreaterOrEqual(Convert.ToInt32(item.Salary), 0);
            }
        }

        [Test]

        public void TestLogin()
        {
            string a = logic.Login("kani", "123");
            string b = logic.Login("", "");
            string c = logic.Login("Admin", "admin");
            string d = logic.Login("ka", "dd");

            Assert.AreEqual("Password lenghth should be <3", d);
            Assert.AreEqual("userid or password cant be null!!", b);
            Assert.AreEqual("Incorrect Username or Password", a);
            Assert.AreEqual("Welcome Admin", c);

        }
    }
}
