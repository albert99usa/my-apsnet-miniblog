using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading.Tasks;
using Blog.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace Blog.Controllers
{
    public class ArticlesController : Controller
    {
        // Something something Database Something Something
        private readonly ApplicationDbContext _context;

        public ArticlesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Index Page
        public async Task<IActionResult> Index()
        {
            return View(await _context.Article.ToListAsync());
        }

        // Case Agaisnt The NHS Article
        public async Task<IActionResult> A_Case_Against_The_NHS()
        {
            ModelsCombined CombinedModel = new ModelsCombined();
            Comment CommentModel = new Comment();

            CombinedModel.IEnumerableComment = await _context.Comment.ToListAsync();
            CombinedModel.Comment = CommentModel;


            return View(CombinedModel);
        }



        // POST: Comments/Create
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> A_Case_Against_The_NHS([Bind("Id,Body,Name,ArticleTitle")] Comment comment)
        {
            comment.ArticleTitle = "A Case Against The NHS";

            if (ModelState.IsValid)
            {
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(A_Case_Against_The_NHS));
            }
            return View(comment);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}