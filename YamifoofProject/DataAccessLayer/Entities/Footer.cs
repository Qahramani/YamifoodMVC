using YamifoofProject.DataAccessLayer.Entities.Common;

namespace YamifoofProject.DataAccessLayer.Entities;

public class Footer :BaseEntity
{
    public string Address { get; set; }
    public string Phone { get; set; }
    public string GmailLink { get; set; }
    public string FbLink { get; set; }
    public string TwLink { get; set; }
    public string LinkedInLink { get; set; }
    public string GLink { get; set; }
    public string InstLink { get; set; }
}
