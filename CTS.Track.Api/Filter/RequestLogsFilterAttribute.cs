using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CTS.Track.Model.MySqlEntity.cts_track;
using Microsoft.AspNetCore.Mvc.Controllers;
using CTS.Track.Common.Helper;
using CTS.Track.IService;
using System.IO;
using System.Text;
using CTS.Track.Model.Enum;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CTS.Track.Common.LogHelper;

namespace CTS.Track.Api.Filter
{
    public class RequestLogsFilterAttribute : ActionFilterAttribute, IActionFilter
    {


        public RequestLogsFilterAttribute() //通过依赖注入得到数据访问层实例
        {

        }

        public async override void OnActionExecuted(ActionExecutedContext context)
        {
            try
            {
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }

        }
        public async override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
        }
    }
}