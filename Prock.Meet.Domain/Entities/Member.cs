namespace Prock.Meet.Domain.Entities
{
    public sealed class Member
    {
        public string Name { get; }
        public string Password { get; } // Firebase Authenticationを使用する場合は不要

        public Member(string name, string password)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Password = password; // null許容の場合はチェック不要
        }
    }
}
