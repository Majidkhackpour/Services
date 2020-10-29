using Services;

namespace Servicess.Interfaces.Department
{
    public interface IUsers : IHasGuid
    {
        string Name { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Mobile { get; set; }
        string Email { get; set; }
        bool IsBlock { get; set; }
        EnUserType Type { get; set; }
    }
}
