using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ModuleCalculatorWeb.Data;
using ModuleCalculatorWeb.Models;

namespace ModuleCalculatorWeb.Pages.Modules
{
    public class CreateModel : PageModel
    {
        private readonly ModuleCalculatorWeb.Data.ApplicationDbContext _context;

        public CreateModel(ModuleCalculatorWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Module Module { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // Calculations done by the class library
            Module.SelfStudy = CalculateMod.Class1.SelfStudies(Module.Credits, Module.Weeks_in_Semester, Module.HoursPerWeek);
            Module.ReaminingHoursLeft = CalculateMod.Class1.remainingHours(Module.SelfStudy, Module.HoursStudyFor);
            _context.Module.Add(Module);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
