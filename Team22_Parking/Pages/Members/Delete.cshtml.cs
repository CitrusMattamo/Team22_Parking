using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Team22_Parking.Data;
using Team22_Parking.Models;

namespace Team22_Parking.Pages.Members
{
    public class DeleteModel : PageModel
    {
        private readonly Team22_Parking.Data.ParkingContext _context;

        public DeleteModel(Team22_Parking.Data.ParkingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Member Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Member = await _context.Members.FirstOrDefaultAsync(m => m.Id == id);

            if (Member == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Member = await _context.Members.FindAsync(id);

            if (Member != null)
            {
                _context.Members.Remove(Member);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
