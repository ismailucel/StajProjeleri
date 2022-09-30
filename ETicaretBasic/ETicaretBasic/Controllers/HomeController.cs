using DevExpress.Data.Browsing;
using ETicaretBasic.Data;
using ETicaretBasic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
//using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ETicaretBasic.Controllers
{

    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IStringLocalizer<HomeController> _localizer;



        public HomeController(ApplicationDbContext context/*, UserManager<ApplicationUser> userManager*/, IStringLocalizer<HomeController> localizer)
        {
            _context = context;
            _localizer = localizer;
        }

        public async Task<IActionResult> Index()
        {
            List<Song> _songs = await _context.Song.OrderByDescending(x => x.CreateDate).Take(10).ToListAsync();
            return View(_songs);
        }

        public async Task<IActionResult> SongDetails(int searchId)
        {
            List<Song> sarkilar = await _context.Song.OrderBy(u => Guid.NewGuid()).Where(u => u.Id != searchId).Take(4).ToListAsync();

            Song _song = _context.Song.Where(x => x.Id == searchId).FirstOrDefault();
            sarkilar.Add(_song);
            if (_song == null)
                return RedirectToAction("ErrorPage", "Home", new { statusCode = 901 });
            else
                return View(sarkilar);
        }

        public async Task<IActionResult> SearchSongs(string searchItem)
        {
            List<Song> sarkilar = await _context.Song.Where(x => x.SongName.ToLower().Contains(searchItem.ToLower())).ToListAsync();
            return View(sarkilar);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddSongToBasket(int songId)
        {
            var basket = await _context.Basket
                .Where(x => x.CustomerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && x.Active == true)
                .FirstOrDefaultAsync();

            Song currentSong = await _context.Song
                .Where(x => x.Id == songId && x.Active == true)
                .FirstOrDefaultAsync();

            if (currentSong == null) return NotFound();
            if (basket != null)
            {
                BasketItem newBasketItem = new BasketItem
                {
                    BasketId = basket.Id,
                    Song = currentSong,
                    Active = true
                };

                _context.Add(newBasketItem);
                await _context.SaveChangesAsync();
            }
            else
            {
                Basket newBasket = new Basket
                {
                    Status = "YENI",
                    Active = true,
                    CustomerId = User.FindFirstValue(ClaimTypes.NameIdentifier)
                };

                _context.Add(newBasket);
                _context.SaveChanges();

                BasketItem newBasketItem = new BasketItem
                {
                    BasketId = newBasket.Id,
                    Song = currentSong,
                    Active = true
                };

                _context.Add(newBasketItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Baskets", new { area = "Customer" });
        }

        public async Task<IActionResult> MyOrder()
        {
            List<Basket> baskets = await _context.Basket
                .Where(x => x.CustomerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && x.Active == false)
                .ToListAsync();

            return View(baskets);
        }

        [Authorize]
        public async Task<IActionResult> CancelOrder(int? orderId)
        {
            if (orderId == null)
            {
                return NotFound();
            }

            Basket basket = await _context.Basket
                .Where(x => x.Id == orderId)
                .FirstOrDefaultAsync();

            if (basket == null)
            {
                //TempData["HataMesaj"] = _localizer["ErrorMessage3"];
            }
            else
            {
                basket.Status = "Cancelled";
                basket.Active = false;
                _context.Update(basket);
                await _context.SaveChangesAsync();
            }

            List<Basket> basketList = await _context.Basket
                .Where(x => x.CustomerId == User.FindFirstValue(ClaimTypes.NameIdentifier) && x.Active == false)
                .ToListAsync();

            return View("MyOrder", basketList);
        }

       /* [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddReviews(int songId)
        {


            Song currentSong = await _context.Song
                .Where(x => x.Id == songId && x.Active == true)
                .FirstOrDefaultAsync();

            Review newReview = new Review
            {
                
                Song = currentSong,
                Active = true,
                Content = "deneme"
            };

            _context.Add(newReview);
            await _context.SaveChangesAsync();



            return RedirectToAction("Index", "Baskets", new { area = "Customer" });
        }
       */
        [Authorize]
        public async Task<IActionResult> OrderDetails(int? orderId)
        {
            if (orderId == null)
            {
                return NotFound();
            }

            List<BasketItem> basketItems = await _context.BasketItem
                .Where(b => b.BasketId == orderId && b.Active == true)
                .Include(b => b.Song)
                .Include(b => b.Song.Category)
                .Include(b => b.Song.Artist)
                .ToListAsync();

            return View(basketItems);
        }
        
        
        public IActionResult Details(int songId)
        {
            var details = _context.Song.Find(songId);

            var productsComment = _context.Comment.Where(x => x.ProductId == songId).ToList();
            ViewBag.comment = productsComment;

            var sayi = _context.Comment.Where(x => x.ProductId == songId).ToList().Count();
            var ortalama = _context.Comment.Where(x => x.ProductId == songId).ToList().Select(x => x.RatingProduct).DefaultIfEmpty(0).Average();

            ViewBag.sayi = sayi;
            ViewBag.ortalama = Math.Round(ortalama);

            return View(details);


        }
        [HttpPost]
        public IActionResult Details(Comment data)
        {
            _context.Comment.Add(data);
            _context.SaveChanges();

            return RedirectToAction("SongDetails");
        }
        public IActionResult AddReviews()
        {
            return View();
        }
    }
}
