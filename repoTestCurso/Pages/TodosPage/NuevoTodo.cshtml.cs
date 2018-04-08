using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using repoTestCurso.Data;
using repoTestCurso.Data.Entities;

namespace repoTestCurso.Pages.TodosPage
{
    public class NuevoTodoModel : PageModel
    {
        private TodoContext _context { get; set; }

        public NuevoTodoModel(TodoContext context) {
            _context = context;
        }

        [BindProperty]
        public Todo Todo { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost() {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else {
                _context.Todos.Add(Todo);
                _context.SaveChanges();
                return RedirectToPage("/Index");
            }
        }
    }
}