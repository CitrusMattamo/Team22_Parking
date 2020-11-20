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
    public class DetailsModel : PageModel
    {
        private readonly Team22_Parking.Data.ParkingContext _context;

        public DetailsModel(Team22_Parking.Data.ParkingContext context)
        {
            _context = context;
        }

        public Member Members { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Members = await _context.Members.FirstOrDefaultAsync(m => m.Id == id);

            if (Members == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
