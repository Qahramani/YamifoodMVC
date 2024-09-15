using YamifoofProject.DataAccessLayer.Entities.Common;

namespace YamifoofProject.DataAccessLayer.Entities;

public class Menu : BaseEntity
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public string ImageUrl { get; set; }
    public Category? Category { get; set; }
}
