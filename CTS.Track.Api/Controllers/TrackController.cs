using CTS.Track.Api.Filter;
using CTS.Track.Api.JWT;
using CTS.Track.Common.Helper;
using CTS.Track.IService;
using CTS.Track.Model;
using CTS.Track.Model.MySqlEntity.cts_track;
using CTS.Track.Model.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CTS.Track.Api.JWT.Enums;
using CTS.Track.Common.LogHelper;

namespace CTS.Track.Api.Controllers
{

    [ServiceFilter(typeof(Authentication))]
    [ServiceFilter(typeof(RequestLogsFilterAttribute))]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TrackController : BaseApiController
    {

        private static string ApiUrl = Appsettings.app(new string[] { "AppSettings", "ApiConfig", "ApiUrl" });
        private static string Token = Appsettings.app(new string[] { "AppSettings", "ApiConfig", "Token" });


        private readonly ITrack_EventDescriptionService _iTrack_EventDescriptionService;
        public TrackController(ITrack_EventDescriptionService iTrack_EventDescriptionService)
        {

            _iTrack_EventDescriptionService = iTrack_EventDescriptionService;
        }

        [HttpPost]
        public async Task<string> GetTrackInfo([FromBody] List<NumberInfo> tracks)
        {
            try
            {

                var AddTrack = await _iTrack_EventDescriptionService.AddTrackDescription(new track_eventdescription());
                return AddTrack ? "" : "";

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
                var res = new TrackResponse<NumberInfo>()
                { code = "0", data = null };
                return Newtonsoft.Json.JsonConvert.SerializeObject(res);
            }
        }


    }
}
