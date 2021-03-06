﻿using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestaodeFrota.Services.Exceptions;

namespace GestaodeFrota.Services
{
    public class AbastecimentoService
    {
        private readonly ApplicationDbContext _context;


        public AbastecimentoService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Metodo para buscar um abastecimento do banco ordenado por data
        public List<Abastecimento> FindAll()
        {
            return _context.Abastecimento.OrderBy(x => x.DataAbaste).ToList();
        }

        //Inserindo Um abastecimento no banco de dados
        public void Insert(Abastecimento obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Abastecimento FindById(int id)
        {
            return _context.Abastecimento.Include(obj => obj.Automovel).Include(obj => obj.Posto).FirstOrDefault(obj => obj.Id == id);
        }
        // Metodo de remover um abastecimento por ID
        public void Remove(int id)
        {
            var obj = _context.Abastecimento.Find(id);
            _context.Abastecimento.Remove(obj);
            _context.SaveChanges();
        }

        //Metodo de Editar um abastecimento po ID
        public void Update(Abastecimento obj)
        {
            if (!_context.Abastecimento.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id nao existe");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

    }
}