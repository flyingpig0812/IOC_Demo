using CTS.Track.Api.Filter;
using CTS.Track.Common.Helper;
using CTS.Track.IService;
using CTS.Track.Model;
using CTS.Track.Model.Enum;
using CTS.Track.Model.MySqlEntity.cts_track;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTS.Track.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class BaseApiController : ControllerBase
    {

        public BaseApiController()
        {

        }

    }
}
