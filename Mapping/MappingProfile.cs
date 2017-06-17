using AutoMapper;
using vega.Controllers.Resources;
using vega.Models;

namespace vega.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // <Source, Target>
            //  currently unidirectional (make => makeresource) not (makeresource => make)
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();

        }
    }
}