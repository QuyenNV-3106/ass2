using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<MemberObject> GetMemberList()
        {
            IDataReader dataReader = null;
            string sqlSelect = "Select MemberId, Email, CompanyName, City, Country, Password From Member";
            var members = new List<MemberObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(sqlSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    members.Add(new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        CompanyName = dataReader.GetString(2),
                        Email = dataReader.GetString(1),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.StackTrace);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                CloseConnection();
            }
            return members;
        }
        public MemberObject GetMemberByID(int nameID)
        {
            MemberObject mem = null;
            IDataReader dataReader = null;
            string sql = "Select MemberId, Email, CompanyName, City, Country, Password " +
                         "From Member " +
                         "Where MemberId = @MemberId";
            try
            {
                var param = dataProvider.CreateParameter("@MemberId", 5, nameID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(sql, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    mem = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        CompanyName = dataReader.GetString(2),
                        Email = dataReader.GetString(1),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                CloseConnection();
            }
            return mem;
        }
        public MemberObject GetMemberByEmailAndPassword(string email, string password)
        {
            MemberObject mem = GetMemberList().SingleOrDefault(member => (member.Email.Equals(email) && member.Password.Equals(password)));

            return mem;
        }
        public void AddNew(MemberObject mem)
        {
            try
            {
                MemberObject member = GetMemberByID(mem.MemberID);
                if (member == null)
                {
                    string sql = "Insert Member Values(@MemberId, @Email, @CompanyName, @City, @Country, @Password)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 5, mem.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Email", 5, mem.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CompanyName", 40, mem.CompanyName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 20, mem.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 50, mem.Country, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 10, mem.Password, DbType.String));
                    dataProvider.Insert(sql, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("Member is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Update(MemberObject mem)
        {
            try
            {
                MemberObject member = GetMemberByID(mem.MemberID);
                if (member != null)
                {
                    string sql = "Update Member set Email = @Email, CompanyName = @CompanyName, " +
                        "City = @City, Country = @Country, Password = @Password Where MemberId = @MemberId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 5, mem.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Email", 90, mem.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CompanyName", 40, mem.CompanyName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 20, mem.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 50, mem.Country, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 10, mem.Password, DbType.String));
                    dataProvider.Update(sql, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("Member is not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Remove(int memId)
        {
            try
            {
                MemberObject pro = GetMemberByID(memId);
                if (pro != null)
                {
                    string sql = "Delete Member Where MemberId = @MemberId";
                    var param = dataProvider.CreateParameter("@MemberId", 5, memId, DbType.Int32);
                    dataProvider.Delete(sql, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("Member is not already exist.");

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public IEnumerable<MemberObject> SearchID(int searchID)
        {
            IEnumerable<MemberObject> list = from member in GetMemberList()
                                             where member.MemberID == searchID
                                             select member;
            return list;
        }
    }
}
