using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Team22_Parking.Data;
using Team22_Parking.Models;

namespace Team22_Parking.Pages.Members
{
    public class CreateModel : PageModel
    {
        private readonly Team22_Parking.Data.ParkingContext _context;

        public CreateModel(Team22_Parking.Data.ParkingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Member Members { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Members.Add(Members);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
