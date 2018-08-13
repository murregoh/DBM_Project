using ExampleCnx.DAL;
using System.Data;

namespace ExampleCnx.BLL
{
    public class LoginBLL
    {
        LoginDAL dal;
        public LoginBLL()
        {
            dal = new LoginDAL();
        }
        public LoginStatus Login(string user, string password)
        {
            LoginStatus result = new LoginStatus();

            DataSet ds = dal.Login(user, password);
            int rowCount = ds.Tables[0].Rows.Count;

            if (rowCount == 0)
            {
                result.Message = "El usuario no existe";
                result.UserResult = Status.Failed;
            }
            else if (rowCount == 1)
            {
                result.data = ds;
                result.UserResult = Status.Success;
            }

            return result;
        }
    }
}
