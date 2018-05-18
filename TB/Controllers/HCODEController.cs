using System;
using System.Collections.Generic;
using System.Linq;
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

        // GET: HCODE
        public async Task<IActionResult> GetHosp()
        {
            return Json(await _context.TBL_MS_HOSP_CODE.ToListAsync());
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.TBL_MS_HOSP_CODE.ToListAsync());
        }

        // GET: HCODE/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBL_MS_HOSP_CODE = await _context.TBL_MS_HOSP_CODE
                .SingleOrDefaultAsync(m => m.ORG_ID == id);
            if (tBL_MS_HOSP_CODE == null)
            {
                return NotFound();
            }

            return View(tBL_MS_HOSP_CODE);
        }

        // GET: HCODE/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HCODE/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ORG_ID,ORG_ID_9,ORG_LEVEL,ORG_TYPE,ORG_TYPE_NHSO,NAME_TH,NAME_EN,ADDR,MU,CHANGWAT,AMPUR,TAMBON,BED,DEPARTMENT,TEL,FAX,NHSO_ID,ODPC_ID,PHO_ID,SSO_ID,IS_MDR_TREAT,IS_CULTURE_TREAT,IS_DST_TREAT,IS_MOLECULAR_TREAT,STATUS,LATITUDE,LONGTITUDE,IS_CUL_SOLID,IS_CUL_LIQUID,IS_DST_SOLID,IS_DST_LIQUID,IS_MOL_LPA,IS_MOL_XPERT,IS_NHSO_ORG,IS_OUTOF_TBCM,hmain_id")] TBL_MS_HOSP_CODE tBL_MS_HOSP_CODE)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBL_MS_HOSP_CODE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tBL_MS_HOSP_CODE);
        }

        // GET: HCODE/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBL_MS_HOSP_CODE = await _context.TBL_MS_HOSP_CODE.SingleOrDefaultAsync(m => m.ORG_ID == id);
            if (tBL_MS_HOSP_CODE == null)
            {
                return NotFound();
            }
            return View(tBL_MS_HOSP_CODE);
        }

        // POST: HCODE/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ORG_ID,ORG_ID_9,ORG_LEVEL,ORG_TYPE,ORG_TYPE_NHSO,NAME_TH,NAME_EN,ADDR,MU,CHANGWAT,AMPUR,TAMBON,BED,DEPARTMENT,TEL,FAX,NHSO_ID,ODPC_ID,PHO_ID,SSO_ID,IS_MDR_TREAT,IS_CULTURE_TREAT,IS_DST_TREAT,IS_MOLECULAR_TREAT,STATUS,LATITUDE,LONGTITUDE,IS_CUL_SOLID,IS_CUL_LIQUID,IS_DST_SOLID,IS_DST_LIQUID,IS_MOL_LPA,IS_MOL_XPERT,IS_NHSO_ORG,IS_OUTOF_TBCM,hmain_id")] TBL_MS_HOSP_CODE tBL_MS_HOSP_CODE)
        {
            if (id != tBL_MS_HOSP_CODE.ORG_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBL_MS_HOSP_CODE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBL_MS_HOSP_CODEExists(tBL_MS_HOSP_CODE.ORG_ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tBL_MS_HOSP_CODE);
        }

        // GET: HCODE/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBL_MS_HOSP_CODE = await _context.TBL_MS_HOSP_CODE
                .SingleOrDefaultAsync(m => m.ORG_ID == id);
            if (tBL_MS_HOSP_CODE == null)
            {
                return NotFound();
            }

            return View(tBL_MS_HOSP_CODE);
        }

        // POST: HCODE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tBL_MS_HOSP_CODE = await _context.TBL_MS_HOSP_CODE.SingleOrDefaultAsync(m => m.ORG_ID == id);
            _context.TBL_MS_HOSP_CODE.Remove(tBL_MS_HOSP_CODE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBL_MS_HOSP_CODEExists(string id)
        {
            return _context.TBL_MS_HOSP_CODE.Any(e => e.ORG_ID == id);
        }
    }
}
