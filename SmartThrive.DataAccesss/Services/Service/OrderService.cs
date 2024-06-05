﻿using AutoMapper;
using SmartThrive.DataAccesss.Services.Interface;
using ST.Entities.Data.Table;
using SWD.DataAccesss.Model;
using SWD.Entities.Repositories.Repositories.Interface;
using SWD.Entities.Repositories.Repositories.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD.DataAccesss.Services.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repo;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository repository, IMapper mapper)
        {
            _repo = repository;
            _mapper = mapper;
        }

        public async Task<bool> AddOrder(OrderModel order)
        {
            var s = _mapper.Map<Order>(order);
            return await _repo.AddOrder(s);
        }

        public async Task<bool> DeleteOrder(Guid id)
        {
           var s = await _repo.GetOrder(id);
            if (s!= null)
            {
                s.IsDeleted= true; 
                var order = await _repo.UpdateOrder(s);
                if (order)
                {
                    return true;
                }
                return false;
            }
            return false;
           
        }

        public async Task<IEnumerable<OrderModel>> GetAllOrder()
        {
            var s = await _repo.GetAllOrder();
            return _mapper.Map<IEnumerable<OrderModel>>(s);


        }

        public async Task<IEnumerable<OrderByStudent>> GetAllOrdersByStudent(Guid id)
        {
            var s = await _repo.GetAllOrdersByStudent(id);
            if (s != null)
            {
                return s;
            }
            return null;
        }

        public async Task<OrderModel> GetOrder(Guid id)
        {
            var s = await _repo.GetOrder(id);

            return _mapper.Map<OrderModel>(s);
        }

        public async Task<bool> UpdateOrder(OrderModel order)
        {
            return await _repo.UpdateOrder(_mapper.Map<Order>(order));
        }
    }
}