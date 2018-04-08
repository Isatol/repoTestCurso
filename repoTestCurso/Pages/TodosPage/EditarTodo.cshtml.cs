using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using repoTestCurso.Data;
using repoTestCurso.Data.Entities;

namespace repoTestCurso.Pages.TodosPage
{
    public class EditarTodoModel : PageModel
    {
        private TodoContext _context { get; set; }

        [BindProperty]
        public Todo Todo { get; set; }

        public EditarTodoModel(TodoContext context) {
            _context = context;
        }

        public IActionResult OnGet(int id)
        {
            Todo = _context.Todos.Find(id);

            if (Todo == null) {
                return RedirectToPage("/Index");
            }
            return Page();
        }

        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Attach(Todo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException) {
                throw new Exception($"Todo {Todo.Id} no fue encontrado");
            }

            return RedirectToPage("/Index");
        }


    }
}