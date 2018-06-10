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

        public IActionResult Export()
        {
            var data = (from c in _context.TBL_MS_HOSP_CODE
                     join ch in _context.TBL_MS_CHANGWAT on c.CHANGWAT equals ch.CHANGWAT_ID
                     select new
                     {
                         c.ORG_ID,
                         c.ORG_ID_9,
                         c.ORG_LEVEL,
                         c.ORG_TYPE,
                         c.ORG_TYPE_NHSO,
                         c.NAME_TH,
                         c.NAME_EN,
                         c.ADDR,
                         c.MU,
                         c.CHANGWAT,
                         ch.CHANGWAT_NAME_TH,
                         c.AMPUR,
                         c.TAMBON,
                         c.BED,
                         c.DEPARTMENT,
                         c.TEL,
                         c.FAX,
                         c.NHSO_ID,
                         c.ODPC_ID,
                         c.PHO_ID,
                         c.SSO_ID,
                         c.IS_MDR_TREAT,
                         c.IS_CULTURE_TREAT,
                         c.IS_DST_TREAT,
                         c.IS_MOLECULAR_TREAT,
                         c.STATUS,
                         c.LATITUDE,
                         c.LOGITUDE,
                         c.IS_CUL_SOLID,
                         c.IS_CUL_LIQUID,
                         c.IS_DST_SOLID,
                         c.IS_DST_LIQUID,
                         c.IS_MOL_LPA,
                         c.IS_MOL_XPERT,
                         c.IS_NHSO_ORG,
                         c.IS_OUTOF_TBCM,
                         c.hmain_id
                     });
            return Json(new { data = data });
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
            var v = (from c in _context.TBL_MS_HOSP_CODE
                     join ch in _context.TBL_MS_CHANGWAT on c.CHANGWAT equals ch.CHANGWAT_ID
                     select new {
                         c.ORG_ID,
                         c.ORG_ID_9,
                         c.ORG_LEVEL,
                         c.ORG_TYPE,
                         c.ORG_TYPE_NHSO,
                         c.NAME_TH,
                         c.NAME_EN,
                         c.ADDR,
                         c.MU,
                         c.CHANGWAT,
                         ch.CHANGWAT_NAME_TH,
                         c.AMPUR,
                         c.TAMBON,
                         c.BED,
                         c.DEPARTMENT,
                         c.TEL,
                         c.FAX,
                         c.NHSO_ID,
                         c.ODPC_ID,
                         c.PHO_ID,
                         c.SSO_ID,
                         c.IS_MDR_TREAT,
                         c.IS_CULTURE_TREAT,
                         c.IS_DST_TREAT,
                         c.IS_MOLECULAR_TREAT,
                         c.STATUS,
                         c.LATITUDE,
                         c.LOGITUDE,
                         c.IS_CUL_SOLID,
                         c.IS_CUL_LIQUID,
                         c.IS_DST_SOLID,
                         c.IS_DST_LIQUID,
                         c.IS_MOL_LPA,
                         c.IS_MOL_XPERT,
                         c.IS_NHSO_ORG,
                         c.IS_OUTOF_TBCM,
                         c.hmain_id
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
        public IActionResult Save(string Org_id)
        {
            List<string> Active = new List<string>
            {
                "0","1"
            };
            ViewBag.Active = Active;
            return View(new TBL_MS_HOSP_CODE());
        }

        [HttpPost]
        public IActionResult Save(TBL_MS_HOSP_CODE hc)
        {

            if (hc.ORG_ID != null)
            {
                _context.Add(hc);
                _context.SaveChanges();
            }
            return Json(new { success = true, message = "success" });
        }
    }
}
