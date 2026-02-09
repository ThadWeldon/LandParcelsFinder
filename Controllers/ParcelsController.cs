using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LandParcelFinder.Data;
using LandParcelFinder.Models;

namespace LandParcelFinder.Controllers
{
    public class ParcelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParcelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: Parcels request
        public async Task<IActionResult> Index()
        {
            var parcels = await _context.Parcels.ToListAsync();
            return View(parcels);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var parcel = await _context.Parcels.FirstOrDefaultAsync(m => m.ParcelId == id);

            if(parcel == null)
            {
                return NotFound();
            }

            return View(parcel);
        }

        // GET: Parcels/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParcelNumber,Address,county,SizeInAcres,Price,HasWetLands,Status,notes")] Parcel parcel)
        {
            if(ModelState.IsValid)
            {
                _context.Add(parcel);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Parcel added!";
                return RedirectToAction(nameof(Index));
            }
            return View(parcel);
        }
    }
}