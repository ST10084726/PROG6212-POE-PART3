using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ModuleCalculatorWeb.Data;
using ModuleCalculatorWeb.Models;

namespace ModuleCalculatorWeb.Pages.Semesters
{
    public class IndexModel : PageModel
    {
        private readonly ModuleCalculatorWeb.Data.ApplicationDbContext _context;

        public IndexModel(ModuleCalculatorWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Semester> Semester { get;set; }

        public async Task OnGetAsync()
        {
            Semester = await _context.Semester.ToListAsync();
        }
    }
}
