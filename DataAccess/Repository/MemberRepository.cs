using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMem(int id) => MemberDAO.Instance.Remove(id);

        public IEnumerable<MemberObject> GetMemberID(int id) => MemberDAO.Instance.SearchID(id);

        public MemberObject GetMemberLogin(string email, string password) => MemberDAO.Instance.GetMemberByEmailAndPassword(email, password);

        public MemberObject GetMemberObject(int id) => MemberDAO.Instance.GetMemberByID(id);

        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList();

        public void InsertMember(MemberObject mem) => MemberDAO.Instance.AddNew(mem);

        public void UpdateMem(MemberObject mem) => MemberDAO.Instance.Update(mem);
    }
}
