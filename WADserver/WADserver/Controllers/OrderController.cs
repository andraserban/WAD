﻿using System;
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
    public class OrderController : ApiController
    {
        private WADEntities db = new WADEntities();

        // GET: api/Order
        public IQueryable<OrderTable> GetOrderTables()
        {
            return db.OrderTables;
        }

        // GET: api/Order/5
        [ResponseType(typeof(OrderTable))]
        public IHttpActionResult GetOrderTable(int id)
        {
            OrderTable orderTable = db.OrderTables.Find(id);
            if (orderTable == null)
            {
                return NotFound();
            }

            return Ok(orderTable);
        }

        // PUT: api/Order/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrderTable(int id, OrderTable orderTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orderTable.OrderId)
            {
                return BadRequest();
            }

            db.Entry(orderTable).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderTableExists(id))
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

        // POST: api/Order
        [ResponseType(typeof(OrderTable))]
        public IHttpActionResult PostOrderTable(OrderTable orderTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OrderTables.Add(orderTable);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (OrderTableExists(orderTable.OrderId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = orderTable.OrderId }, orderTable);
        }

        // DELETE: api/Order/5
        [ResponseType(typeof(OrderTable))]
        public IHttpActionResult DeleteOrderTable(int id)
        {
            OrderTable orderTable = db.OrderTables.Find(id);
            if (orderTable == null)
            {
                return NotFound();
            }

            db.OrderTables.Remove(orderTable);
            db.SaveChanges();

            return Ok(orderTable);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderTableExists(int id)
        {
            return db.OrderTables.Count(e => e.OrderId == id) > 0;
        }
    }
}