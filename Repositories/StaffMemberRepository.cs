using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StaffMemberRepository : IStaffMemberRepository
    {
        public StaffMember? GetStaffMember(string email, string password) => StaffMemberDAO.Instance.GetStaffMember(email, password);

    }
}
