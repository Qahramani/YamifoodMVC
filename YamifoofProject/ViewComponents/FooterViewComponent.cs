using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using YamifoofProject.DataAccessLayer.Context;

namespace YamifoofProject.ViewComponents;

public class FooterViewComponent : ViewComponent
{
    private readonly AppDbContext _dpContext;

    public FooterViewComponent(AppDbContext dpContext)
    {
        _dpContext = dpContext;
    }

    public async Task<ViewViewComponentResult> InvokeAsync()
    {
        var footer = _dpContext.Footers.SingleOrDefault();

        return View(footer);
    }
}
