using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrtizPC02.Models;
using OrtizPC02.Repositories;

namespace OrtizPC02.Controllers
{
    [Route("api/supplier")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private ISupplierRepository _supplierRepository;

        public SupplierController(ISupplierRepository repository)
        {
            _supplierRepository = repository;
        }

        // GET: api/supplier
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _supplierRepository.GetSuppliers());
        }

        // GET: api/supplier/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _supplierRepository.GetSupplier(id));
        }

        // POST: api/supplier
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Supplier supplier)
        {
            return Ok(await _supplierRepository.Insert(supplier));
        }

        // PUT: api/supplier/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Supplier supplier)
        {
            if (id != supplier.Id) return BadRequest();
            else return Ok(await _supplierRepository.Update(supplier));
        }

        // DELETE: api/supplier/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _supplierRepository.Delete(id));
        }
    }
}
