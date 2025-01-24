namespace Prock.Meet.Domain.Entities
{
    public sealed class Meeting
    {
        public Dictionary<string, Report> Reports { get; }

        public Meeting(Dictionary<string, Report> reports)
        {
            Reports = reports ?? new Dictionary<string, Report>(); // 空の辞書で初期化
        }
    }
}
