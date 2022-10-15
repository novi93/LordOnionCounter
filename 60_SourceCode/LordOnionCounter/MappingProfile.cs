using AutoMapper;
using LOC.Core.Download;
using LOC.Entites;

namespace LOC
{
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GridEntryEntity, IDownloadItem>();
            CreateMap<GridEntryEntity, TfsDownloadItem>();
            CreateMap<GridEntryEntity, TfsGuildPathDownloadItem>();
        }
    }
}
