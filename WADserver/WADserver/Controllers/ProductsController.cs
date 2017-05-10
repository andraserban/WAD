using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WADserver.Models;

namespace WADserver.Controllers
{
    public class ProductsController : ApiController
    {
        private WADEntities db = new WADEntities();

        // GET: api/Product
        public IQueryable<ProductTable> GetProductTables()
        {
            return db.ProductTables;
        }
        [Route("api/Products/{category}")]
        public IQueryable<ProductTable> GetProductsByCategory(string category)
        {
           return db.ProductTables.Where(p => string.Compare(p.productCategory, category, true) == 0);     
        }
        // GET: api/Product/5
        [ResponseType(typeof(ProductTable))]
        public IHttpActionResult GetProductTable(int id)
        {
            ProductTable productTable = db.ProductTables.Find(id);
            if (productTable == null)
            {
                return NotFound();
            }

            return Ok(productTable);
        }

        // PUT: api/Product/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProductTable(int id, ProductTable productTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productTable.ProductId)
            {
                return BadRequest();
            }

            db.Entry(productTable).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTableExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Product
        [ResponseType(typeof(ProductTable))]
        public IHttpActionResult PostProductTable(ProductTable productTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProductTables.Add(productTable);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ProductTableExists(productTable.ProductId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = productTable.ProductId }, productTable);
        }

        // DELETE: api/Product/5
        [ResponseType(typeof(ProductTable))]
        public IHttpActionResult DeleteProductTable(int id)
        {
            ProductTable productTable = db.ProductTables.Find(id);
            if (productTable == null)
            {
                return NotFound();
            }

            db.ProductTables.Remove(productTable);
            db.SaveChanges();

            return Ok(productTable);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductTableExists(int id)
        {
            return db.ProductTables.Count(e => e.ProductId == id) > 0;
        }
    }
}