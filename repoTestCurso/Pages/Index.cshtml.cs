using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using repoTestCurso.Data;
using repoTestCurso.Data.Entities;

namespace repoTestCurso.Pages
{
    public class IndexModel : PageModel
    {
        private TodoContext _context { get; set; }

        
        public List<Todo> Todos { get; set; }

        [BindProperty]
        public Todo Todo { get; set; }

        public IndexModel(TodoContext context) {
            _context = context;
        }

        public void OnGet()
        {
            Todos = _context.Todos.ToList();   
        }

        public IActionResult OnPostDelete(int id) {
            var todoId = _context.Todos.Find(id);

            if (todoId != null) {
                _context.Todos.Remove(todoId);
                _context.SaveChanges();
            }

            return RedirectToPage("/Index");
        }

    }
}
