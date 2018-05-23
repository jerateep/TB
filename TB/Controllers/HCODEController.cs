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

        [HttpPost]
        public IActionResult LoadData()
        {
            //jQuery DataTables Param
            var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
            //Find paging info
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            //Find order columns info
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault()
                                    + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            //find search columns info
            var txtOrg_ID = Request.Form["columns[0][search][value]"].FirstOrDefault();
            var txtname = Request.Form["columns[5][search][value]"].FirstOrDefault();
            var txtch = Request.Form["columns[9][search][value]"].FirstOrDefault();
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt16(start) : 0;
            int recordsTotal = 0;
            var v = (from c in _context.TBL_MS_HOSP_CODE select c);
            //Search
            if (!string.IsNullOrEmpty(txtOrg_ID))
            {
                v = v.Where(m => m.ORG_ID == txtOrg_ID);
            }
            if (!string.IsNullOrEmpty(txtname))
            {
                v = v.Where(m => m.NAME_TH == txtname);
            }
            if (!string.IsNullOrEmpty(txtch))
            {
                v = v.Where(m => m.CHANGWAT == txtch);
            }
            //SORTING...  (For sorting we need to add a reference System.Linq.Dynamic)
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
    }
}
