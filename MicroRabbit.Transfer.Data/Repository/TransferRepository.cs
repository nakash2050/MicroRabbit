using System;
using System.Collections.Generic;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _context;

        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }

        public void Add(TranferLog transferLog)
        {
            _context.Add(transferLog);
            _context.SaveChanges();
        }

        public IEnumerable<TranferLog> GetTransferLogs()
        {
            return _context.TranferLogs;
        }
    }
}
