

namespace BillionaireServiceStackRazorSelfHosting
{
//    [ServiceStack.ServiceHost.Route("/rockstars/{Id}")]
//    [ServiceStack.ServiceHost.Route("/rockstars")]
//    [ServiceStack.ServiceHost.Route("/rockstars/aged/{Age}")]
    public class Rockstars
    {
        public int? Age { get; set; }
        public int Id { get; set; }
    }

    public class RockstarsResponse
    {
        public int Total { get; set; }
        public int? Aged { get; set; }
    }

    public class RockstarsService : ServiceStack.ServiceInterface.Service
    {
        public object Get(Rockstars request)
        {
            return new RockstarsResponse { Total = request.Age.Value + 500 };
        }
    }

}