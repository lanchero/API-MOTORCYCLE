﻿using AutoMapper;
using Contracts;
using Entities.Models;
using Service.Contract;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class MotorcycleService : IMotorcycleService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public MotorcycleService(IRepositoryManager repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            this._mapper = mapper;
        }

        public IEnumerable<MotorcycleDto> GetAllMotorcycles(bool trackChanges)
        {

            var Motorcycles = _repository.Motorcycle.GetAllMotorcycles(trackChanges);

            var MotorcyclesDto = _mapper.Map<IEnumerable<MotorcycleDto>>(Motorcycles);
            return MotorcyclesDto;
        }
    }
}
