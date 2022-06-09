#pragma warning disable CS8618
namespace ViewModelFun.Models
{
    public class Users
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}

        public string FullName ()
        {
            return FirstName + " " + LastName;
        }
    }
}