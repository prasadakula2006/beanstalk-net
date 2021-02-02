using System.Linq;
using System.Threading.Tasks;
using beanstalk_net.Models;
using beanstalk_net.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace beanstalk_net.Controllers
{
    public class NotesController : Controller {
        private readonly AppDbContext _dbContext;

        public NotesController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<IActionResult> Index () {
            var notes = await _dbContext.Notes.Select(note => new NoteViewModel {
                Id = note.Id,
                CreatedOn = note.CreatedOn,
                UpdatedOn = note.UpdatedOn,
                Content = note.Content
            }).ToListAsync();

            var notesViewModel = new NotesViewModel{Notes = notes};
                
            return View(notesViewModel);
        }
       
    }
}
