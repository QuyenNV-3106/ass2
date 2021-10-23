using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMembers();
        IEnumerable<MemberObject> GetMemberID(int id);
        MemberObject GetMemberObject(int id);
        MemberObject GetMemberLogin(string email, string password);

        void InsertMember(MemberObject mem);
        void DeleteMem(int id);
        void UpdateMem(MemberObject mem);
    }
}
