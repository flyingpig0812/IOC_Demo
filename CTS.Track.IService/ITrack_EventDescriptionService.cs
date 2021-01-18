using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.Track.IService.Base;
using CTS.Track.Model;
using CTS.Track.Model.MySqlEntity.cts_track;

namespace CTS.Track.IService
{
    public interface ITrack_EventDescriptionService : IBaseService<track_eventdescription>
    {
        /// <summary>
        /// 添加跟踪信息描述
        /// </summary>
        /// <returns></returns>
        Task<bool> AddTrackDescription(track_eventdescription model);
    }
}
