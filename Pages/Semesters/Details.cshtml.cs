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
    public class DetailsModel : PageModel
    {
        private readonly ModuleCalculatorWeb.Data.ApplicationDbContext _context;

        public DetailsModel(ModuleCalculatorWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Semester Semester { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Semester = await _context.Semester.FirstOrDefaultAsync(m => m.SemId == id);

            if (Semester == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
