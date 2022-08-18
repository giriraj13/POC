using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CMS.DocumentEngine;
using CMS.Core;
using CMS.DocumentEngine.Routing;
using MEDIOClinic.Models;

namespace MEDIOClinic.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly IPageRetriever pageRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;

        public NavigationMenuViewComponent(IPageRetriever pageRetriever, IPageUrlRetriever pageUrlRetriever)
        {
            this.pageRetriever = pageRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<TreeNode> menuItems = await pageRetriever.RetrieveAsync<TreeNode>(query => query
                                                    .MenuItems()
                                                    .NestingLevel(1)
                                                    .Columns("DocumentName", "NodeID", "NodeSiteID")
                                                    .WithPageUrlPaths()
                                                    .OrderByAscending("NodeOrder"));
            IEnumerable<MenuItemViewModel> model = menuItems.Select(item => new MenuItemViewModel()
            {
                MenuItemText=item.DocumentName,
                MenuItemRelativeUrl=pageUrlRetriever.Retrieve(item).RelativePath
            });
            return View(model);
        }

        
    }
}
