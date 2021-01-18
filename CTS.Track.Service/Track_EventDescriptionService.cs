using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.Track.Common.LogHelper;
using CTS.Track.IRepository;
using CTS.Track.IRepository.Base;
using CTS.Track.IService;
using CTS.Track.Model;
using CTS.Track.Model.MySqlEntity.cts_track;
using CTS.Track.Service.Base;

namespace CTS.Track.Service
{
    public class Track_EventDescriptionService : BaseService<track_eventdescription>, ITrack_EventDescriptionService
    {
        private readonly ITrack_EventDescriptionRepository _iTrack_EventDescriptionRepository;

        public Track_EventDescriptionService(IBaseRepository<track_eventdescription> baseRepository, ITrack_EventDescriptionRepository iTrack_EventDescriptionRepository) : base(baseRepository)
        {
            _iTrack_EventDescriptionRepository = iTrack_EventDescriptionRepository;
        }

        public async Task<bool> AddTrackDescription(track_eventdescription model)
        {
            try
            {
                return await _iTrack_EventDescriptionRepository.Add(model);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
                return false;
            }


        }
    }
}
