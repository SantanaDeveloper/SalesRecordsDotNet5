﻿using SalesRecordsDotNet5.Data;
using SalesRecordsDotNet5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesRecordsDotNet5.Services
{
    public class SellerService
    {
        private readonly SalesRecordsDotNet5Context _context;

        public SellerService(SalesRecordsDotNet5Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
