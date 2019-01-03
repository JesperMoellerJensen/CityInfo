using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    public class DummyController : Controller
    {
        private CityInfoContex _ctx;

        public DummyController(CityInfoContex ctx)
        {
            _ctx = ctx;
        }


    }
}
