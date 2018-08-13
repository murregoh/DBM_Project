using System.Data;

namespace ExampleCnx.BLL
{
    public class LoginStatus
    {
        public string Message { get; set; }
        public Status UserResult { get; set; }

        public DataSet data { get; set; }
    }
}
