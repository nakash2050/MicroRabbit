﻿using System.Collections.Generic;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<TranferLog>> Get()
        {
            return Ok(_transferService.GetTranferLogs());
        }
    }
}
