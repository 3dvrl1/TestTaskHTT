using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTTTest.Core.Interfaces;
using HTTTest.Infrastructure.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Item = HTTTest.Core.Entities.Item;

namespace HTTTest.Core.Controllers
{
    /// <summary>
    /// Контроллер для получения списка продуктов
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }
        // GET: api/Item
        [HttpGet]
        public async Task<IEnumerable<Item>> Get()
        {
            return await _itemService.GetAllItemsAsync();
        }
    }
}
