using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sutea_Paul_Vasile_Lab6.Data;
using Sutea_Paul_Vasile_Lab6.Models;

namespace Sutea_Paul_Vasile_Lab6.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Sutea_Paul_Vasile_Lab6.Data.Sutea_Paul_Vasile_Lab6Context _context;

        public DetailsModel(Sutea_Paul_Vasile_Lab6.Data.Sutea_Paul_Vasile_Lab6Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
