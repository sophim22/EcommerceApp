using EcommerceApp.Data;
using EcommerceApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Controllers
{
  public class ProductController : Controller
  {
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
      _context = context;
    }

    // List all products
    public IActionResult Index()
    {
      var products = _context.Products.ToList();
      return View(products);
    }

    // GET: Create a new product
    public IActionResult Create()
    {
      return View();
    }

    // POST: Save new product
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Product product)
    {
      if (ModelState.IsValid)
      {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      return View(product);
    }

    // GET: Edit product
    public IActionResult Edit(int id)
    {
      var product = _context.Products.Find(id);
      if (product == null)
      {
        return NotFound();
      }
      return View(product);
    }

    // POST: Save updated product
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Product product)
    {
      if (id != product.Id)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      return View(product);
    }

    // POST: Delete product
    [HttpPost]
    public IActionResult Delete(int id)
    {
      var product = _context.Products.Find(id);
      if (product != null)
      {
        _context.Products.Remove(product);
        _context.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    // View product details
    public IActionResult Details(int id)
    {
      var product = _context.Products.Find(id);
      if (product == null)
      {
        return NotFound();
      }
      return View(product);
    }
  }
}