using YamifoofProject.DataAccessLayer.Entities;

namespace YamifoofProject.Models;

public class HomeViewModel
{
    public List<Menu> Menus{ get; set; } = new List<Menu>();
    public List<Category> Categories { get; set; } = new List<Category>();
} 
