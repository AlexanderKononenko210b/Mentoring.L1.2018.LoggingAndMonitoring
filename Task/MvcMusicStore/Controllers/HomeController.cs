using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using MvcMusicStore.Infrastructure.PerformanceCounters;
using MvcMusicStore.Infrastructure.Interfaces;
using MvcMusicStore.Models;
using PerformanceCounterHelper;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly MusicStoreEntities _storeContext = new MusicStoreEntities();
        private readonly ILoggerService _logger;
        private readonly CounterHelper<Counters> _counterHelper;

        /// <summary>
        /// Initialize a <see cref="HomeController"/> instance.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="counterHelper">The counter helper.</param>
        public HomeController(ILoggerService logger, CounterHelper<Counters> counterHelper)
        {
            _logger = logger;
            _counterHelper = counterHelper;
            _logger.Trace("HomeController created");
        }

        // GET: /Home/
        public async Task<ActionResult> Index()
        {

            _logger.Trace("Index method started");
            _counterHelper.Increment(Counters.VisitSite);

            try
            {
                return View(await _storeContext.Albums
                    .OrderByDescending(a => a.OrderDetails.Count)
                    .Take(6)
                    .ToListAsync());
            }
            catch (Exception e)
            {
                _logger.Error(e.Message);
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _storeContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}