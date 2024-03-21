using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class StaffMemberDAO
    {
        private static StaffMemberDAO instance = null;
        private static object lockObject = new object();

        private StaffMemberDAO(){}
        public static StaffMemberDAO Instance
        {
            get
            {
                lock(lockObject)
                {
                    if(instance == null)
                    {
                        instance = new StaffMemberDAO();
                    }
                    return instance;
                }
            }
        }

        public StaffMember GetStaffMember(string email, string password)
        {
            try 
            {
                using (AirConditionerShop2023DbHackerLoContext? context = new AirConditionerShop2023DbHackerLoContext())
                {
                    StaffMember member = context.StaffMembers.SingleOrDefault(s => s.EmailAddress == email && s.Password == password);
                    return member;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
