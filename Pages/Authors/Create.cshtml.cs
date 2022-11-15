﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dragut_Diana_Lab2.Data;
using Dragut_Diana_Lab2.Models;

namespace Dragut_Diana_Lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Dragut_Diana_Lab2.Data.Dragut_Diana_Lab2Context _context;

        public CreateModel(Dragut_Diana_Lab2.Data.Dragut_Diana_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
               
                //ViewData["AuthorID"] = new SelectList(_context.Set<Author>(), "ID", "FullName");
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
