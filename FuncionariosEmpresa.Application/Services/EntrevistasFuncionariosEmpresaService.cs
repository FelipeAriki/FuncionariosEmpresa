﻿using FuncionariosEmpresa.Domain.Entities;
using FuncionariosEmpresa.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Application.Services
{
    public class EntrevistasFuncionariosEmpresaService : IEntrevistaFuncionariosEmpresaService
    {
        public Task CreateAsync(EntrevistaFuncionariosEmpresa entrevistas)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EntrevistaFuncionariosEmpresa>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EntrevistaFuncionariosEmpresa> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(EntrevistaFuncionariosEmpresa entrevistas)
        {
            throw new NotImplementedException();
        }
    }
}