using YamifoofProject.DataAccessLayer.Entities.Common;

namespace YamifoofProject.DataAccessLayer.Entities;

public class Category : BaseEntity
{
    public string  Name { get; set; }
    public string ImageUrl { get; set; }
    public ICollection<Menu> Menus { get; set; } = new List<Menu>();
}

