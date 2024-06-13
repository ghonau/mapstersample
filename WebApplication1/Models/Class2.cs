using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace WebApplication1.Models
{
    public static class MapsterConfig
    {   

        public static void ConfigMappings()
        {
            TypeAdapterConfig<Source, Destination>.NewConfig()
           .Map(dest => dest.DestinationProp, src => src.SourceProp)
           .Map(dest => dest.Name, src => (string)MapContext.Current.Parameters["Name"]);

            TypeAdapterConfig<Source1, Destination1>.NewConfig()
           .Map(dest => dest.DestinationProp, src => src.SourceProp)
           .Map(dest => dest.Name, src => (string)MapContext.Current.Parameters["Name"]);
        }
        
    }
}