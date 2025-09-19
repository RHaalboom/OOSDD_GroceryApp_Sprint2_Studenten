
namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        public string Emailaddress;
        public string Password { get; set; }
        public Client(int id, string name, string emailAddress, string password) : base(id, name)
        {
            Emailaddress = emailAddress;
            Password = password;
        }
    }
}
