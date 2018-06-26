using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TB.Models;

namespace TB.Controllers
{
    public class UserController : Controller
    {
        private readonly DBContext _context;

        public UserController(DBContext context)
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
            var txtOrg_ID = Request.Form["columns[4][search][value]"].FirstOrDefault();
            var txtname = Request.Form["columns[5][search][value]"].FirstOrDefault();
            var txtch = Request.Form["columns[8][search][value]"].FirstOrDefault();
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt16(start) : 0;
            int recordsTotal = 0;
            var v = (from x in _context.TBL_MS_USER
                      where x.IS_DELETED != "1"  
                      join h in _context.TBL_MS_HOSP_CODE on x.ORG_ID equals h.ORG_ID
                      join o in _context.TBL_MS_HOSP_CODE on h.ODPC_ID equals o.ORG_ID
                      join p in _context.TBL_MS_HOSP_CODE on h.PHO_ID equals p.ORG_ID
                      join c in _context.TBL_MS_CHANGWAT on h.CHANGWAT equals c.CHANGWAT_ID
                      select new
                      {
                          x.FNAME,
                          x.LNAME,
                          x.PHONE,
                          x.EMAIL,
                          x.ORG_ID,
                          h.NAME_TH,
                          h.ODPC_ID,
                          odpc_name = o.NAME_TH,
                          h.PHO_ID,
                          pho_name = p.NAME_TH,
                          h.CHANGWAT,
                          c.CHANGWAT_NAME_TH
                      });
            List<string> strCh = txtch.Split(',').ToList();
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
                v = v.Where(m => strCh.Contains(m.CHANGWAT));
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
        public IActionResult LoadData2()
        {
            var ds = (from x in _context.TBL_MS_USER
                     join h in _context.TBL_MS_HOSP_CODE on x.ORG_ID equals h.ORG_ID
                     join o in _context.TBL_MS_HOSP_CODE on h.ODPC_ID equals o.ORG_ID
                     join p in _context.TBL_MS_HOSP_CODE on h.PHO_ID equals p.ORG_ID
                     join c in _context.TBL_MS_CHANGWAT on h.CHANGWAT equals c.CHANGWAT_ID
                     select new
                     {
                         x.FNAME,
                         x.LNAME,
                         x.PHONE,
                         x.EMAIL,
                         x.ORG_ID,
                         h.NAME_TH,
                         h.ODPC_ID,
                         odpc_name = o.NAME_TH,
                         h.PHO_ID,
                         pho_name = p.NAME_TH,
                         h.CHANGWAT,
                         c.CHANGWAT_NAME_TH
                     });
            var data = ds.Take(10).ToList();
            return Json(new { data = data });
        }
    }
}