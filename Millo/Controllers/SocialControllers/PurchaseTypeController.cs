using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Millo.Data;
using Millo.Models;
using Millo.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Millo.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/PurchaseType")]
    public class PurchaseTypeController : ApiController
    {
        private readonly MilloDbContext _context;

        public PurchaseTypeController(MilloDbContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseType
        [HttpGet]
        public async Task<IActionResult> GetPurchaseType()
        {
            List<PurchaseType> Items = await _context.PurchaseType.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<PurchaseType> payload)
        {
            PurchaseType purchaseType = payload.value;
            _context.PurchaseType.Add(purchaseType);
            _context.SaveChanges();
            return Ok(purchaseType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<PurchaseType> payload)
        {
            PurchaseType purchaseType = payload.value;
            _context.PurchaseType.Update(purchaseType);
            _context.SaveChanges();
            return Ok(purchaseType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<PurchaseType> payload)
        {
            PurchaseType purchaseType = _context.PurchaseType
                .Where(x => x.PurchaseTypeId == (int)payload.key)
                .FirstOrDefault();
            _context.PurchaseType.Remove(purchaseType);
            _context.SaveChanges();
            return Ok(purchaseType);

        }
    }
}