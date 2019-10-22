﻿using GHM.Infrastructure.SqlServer;
using GHM.Warehouse.Domain.Constants;
using GHM.Warehouse.Domain.IRepository;
using GHM.Warehouse.Domain.Models;
using GHM.Warehouse.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace GHM.Warehouse.Infrastructure.Repository
{
    public class OrderDetailRepository : RepositoryBase, IOrderDetailRepository
    {
        private readonly IRepository<OrderDetail> _orderDetailRepository;
        public OrderDetailRepository(IDbContext context) : base(context)
        {
            _orderDetailRepository = Context.GetRepository<OrderDetail>();
        }

        public async Task<bool> CheckExists(string tenantId, string orderId, string productId)
        {
            return await _orderDetailRepository.ExistAsync(x => x.TenantId == tenantId
            && x.OrderId == orderId & x.ProductId == productId && !x.IsDelete);
        }

        public async Task<int> Delete(string tenantId, string id)
        {
            var orderInfo = await GetInfo(tenantId, id, false);
            if (orderInfo == null)
                return -1;
            _orderDetailRepository.Delete(orderInfo);

            return await Context.SaveChangesAsync();
        }

        public async Task<OrderDetail> GetInfo(string tenantId, string id, bool isReadOnly = false)
        {
            return await _orderDetailRepository.GetAsync(isReadOnly, x => x.TenantId == tenantId && x.Id == id && !x.IsDelete);

        }

        public async Task<OrderDetail> GetInfo(string tenantId, string orderId, string productId, bool isReadOnly = false)
        {
            return await _orderDetailRepository.GetAsync(isReadOnly, x => x.TenantId == tenantId
             && x.OrderId == orderId & x.ProductId == productId && !x.IsDelete);

        }

        public async Task<List<OrderDetail>> GetsAll(string tenantId, string orderId, bool isReadOnly = false)
        {
            return await _orderDetailRepository.GetsAsync(isReadOnly, x => x.TenantId == tenantId && x.OrderId == orderId && !x.IsDelete);
        }

        public async Task<int> Insert(OrderDetail orderDetail)
        {
            _orderDetailRepository.Create(orderDetail);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> Inserts(List<OrderDetail> orderDetails)
        {
            _orderDetailRepository.Creates(orderDetails);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> Update(OrderDetail orderDetail)
        {
            return await Context.SaveChangesAsync();
        }

        public async Task<int> Updates(List<OrderDetail> orderDetails)
        {
            return await Context.SaveChangesAsync();
        }
    }
}