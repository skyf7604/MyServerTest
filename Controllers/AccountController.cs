using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspTest3.Controllers
{

    [ApiController]
    [Route( "[controller]" )]
    public class AccountController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public string Get()
        {
            return "!!~혜민이 화이팅~!!";
        }

        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        /// 
        public IActionResult Login()
        {
            return View();
        }



        /// <summary>
        /// 회원가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }



    }
}
