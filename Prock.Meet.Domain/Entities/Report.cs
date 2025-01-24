namespace Prock.Meet.Domain.Entities
{
    public sealed class Report
    {
        public string WhatYouDid { get; }
        public string Remarks { get; }
        public string Period { get; }

        public Report(string whatYouDid, string remarks, string period)
        {
            WhatYouDid = whatYouDid ?? throw new ArgumentNullException(nameof(whatYouDid));
            Remarks = remarks; // null許容の場合はチェック不要
            Period = period ?? throw new ArgumentNullException(nameof(period));
        }
    }
}
