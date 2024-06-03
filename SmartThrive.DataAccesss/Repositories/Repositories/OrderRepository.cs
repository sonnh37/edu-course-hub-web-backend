﻿using Microsoft.EntityFrameworkCore;
using SmartThrive.DataAccess.Repositories.Base;
using SmartThrive.DataAccess.Repositories.Repositories.Interface;
using SmartThrive.DataAccesss.Repositories.Repositories.Interface;
using ST.Entities.Data;
using ST.Entities.Data.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartThrive.DataAccess.Repositories.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        private readonly STDbContext context;

        public OrderRepository(STDbContext context_) : base(context_)
        {
            this.context = context_;
        }

        public async Task<bool> AddOrder(Order order)
        {  
            var s = await  base.Add(order);
            return s;
        }

        public async Task<bool> DeleteOrder(Guid id)
        {
           var d = await base.Delete(id);
            return d;

        }

        public async Task<IEnumerable<Order>> GetAllOrder()
        {
           var a = await base.GetAll();
            return a;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersByStudent(Guid id)
        {
            var a = await context.Orders.Where(x => x.PackageId.Equals(id)).ToListAsync();
            return a;
        }

        public async Task<Order> GetOrder(Guid id)
        {
           var g = await base.GetById(id);
            return g;
        }

        public async Task<bool> UpdateOrder(Order order)
        {
           var u = await base.Update(order);
            return u;
        }
    }
}
