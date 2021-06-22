using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesTurtle4.Data;
using RazorPagesTurtle4.Models;

namespace RazorPagesTurtle4.Pages.Turtles
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesTurtle4.Data.RazorPagesTurtle4Context _context;

        public IndexModel(RazorPagesTurtle4.Data.RazorPagesTurtle4Context context)
        {
            _context = context;
        }

        public IList<Turtle> Turtle { get;set; }

        public async Task OnGetAsync()
        {
            Turtle = await _context.Turtle.ToListAsync();
        }
    }
}
