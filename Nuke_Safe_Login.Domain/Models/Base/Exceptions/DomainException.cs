namespace Nuke_Safe_Login.Models.Base.Exceptions
{
    public abstract class DomainException : Exception
    {
        protected DomainException(string message) : base(message) { }
    }
}
