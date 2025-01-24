namespace Prock.Meet.Domain.Entities
{
    public sealed class Team
    {
        public string Name { get; }
        public Dictionary<string, Member> Members { get; }
        public Dictionary<string, Meeting> Meetings { get; }

        public Team(string name, Dictionary<string, Member> members, Dictionary<string, Meeting> meetings)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Members = members ?? new Dictionary<string, Member>(); // 空の辞書で初期化
            Meetings = meetings ?? new Dictionary<string, Meeting>(); // 空の辞書で初期化
        }
    }
}
