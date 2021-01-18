using AutoMapper;
using CTS.Track.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTS.Track.Api.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CarrierTrackDescription, v_TrackDetail>()
                .ForMember(t => t.TrackTime, s => s.MapFrom(a => a.a))
                .ForMember(t => t.TrackContent, s => s.MapFrom(a => a.z))
                .ForMember(t => t.Location, s => s.MapFrom(a => a.c));
            CreateMap<TrackDetailsItem, v_TrackDetail>()
               .ForMember(t => t.TrackTime, s => s.MapFrom(a => a.track_date))
               .ForMember(t => t.TrackContent, s => s.MapFrom(a => a.track_content))
               .ForMember(t => t.Location, s => s.MapFrom(a => a.track_location));
        }

    }
}
