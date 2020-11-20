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
    public class IndexModel : PageModel
    {
        private readonly Team22_Parking.Data.ParkingContext _context;

        public IndexModel(Team22_Parking.Data.ParkingContext context)
        {
            _context = context;
        }

        public IList<Member> Members { get;set; }

        public async Task OnGetAsync()
        {
            Members = await _context.Members.ToListAsync();
        }
    }
}
