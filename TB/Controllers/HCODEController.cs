using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TB.Models;

namespace TB.Controllers
{
    public class HCODEController : Controller
    {
        private readonly DBContext _context;

        public HCODEController(DBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.ch = new SelectList(_context.TBL_MS_CHANGWAT, "CHANGWAT_ID", "CHANGWAT_NAME_TH");
            return View();
        }
        // GET: HCODE
        [HttpPost]
        public IActionResult GetHosp()
        {
            var draw = Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            //Find Order Column
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            var hospname = Request.Form["[search][value]"].FirstOrDefault();
            var changwat = Request.Form["columns[9][search][value]"].FirstOrDefault();
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;
            var v = (from c in _context.TBL_MS_HOSP_CODE select c);
            if(!string.IsNullOrEmpty(hospname))
            {
                v = v.Where(c => c.NAME_TH.Contains(hospname));
            }
            if (!string.IsNullOrEmpty(changwat))
            {
                v = v.Where(c => c.CHANGWAT.Contains(changwat));
            }
            //SORT
            if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
            {
                v = v.OrderBy(sortColumn + " " + sortColumnDir);
            }
            recordsTotal = v.Count();
            var data = v.Skip(skip).Take(pageSize).ToList();
            return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var v = _context.TBL_MS_HOSP_CODE.Where(a => a.ORG_ID == id).FirstOrDefault();
            return View(v);
        }

        //public IActionResult GetHosp2()
        //{
        //    var v = (from c in _context.TBL_MS_HOSP_CODE select c).ToList();
        //    return Json(new { data = v });
        //}
    }
}
