﻿using EntityLayer.Departaments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entity;

namespace DataAccessLayer.Departaments
{
    public class DepartamentRepository
    {
        
        private readonly ApplicationDbContext _context;

        public DepartamentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<EntityLayer.Departaments.Departaments> GetDepartaments()
        {
            return _context.Departaments.ToList();
        }
    }
}
