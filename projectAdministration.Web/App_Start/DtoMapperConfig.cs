using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using projectAdministration.Domain;
using projectAdministration.Web.Models;


namespace projectAdministration.Web.App_Start
{
    public static class DtoMapperConfig
    {
        public static void CreateMaps()
        {
            Mapper.CreateMap<PeopleDTO, People>();
            Mapper.CreateMap<People, PeopleDTO>();
            //Mapper.CreateMap<IEnumerable<People>, IEnumerable<PeopleDTO>>();
        }
    }
}