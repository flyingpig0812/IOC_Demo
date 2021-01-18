using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.Track.IRepository;
using CTS.Track.Model.MySqlEntity.cts_track;
using CTS.Track.Repository.Base;
using SqlSugar;

namespace CTS.Track.Repository
{
    public class Track_EventDescriptionRepository : BaseMySqlRepository<track_eventdescription>, ITrack_EventDescriptionRepository
    {


    }
}
