#pragma warning disable CS8618
namespace ViewModelFun.Models
{
    public class OneUser
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}