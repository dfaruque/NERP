
namespace NERP.Configuration.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services; using NERP.Common;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.BrandRepository;
    using MyRow = Entities.BrandRow;

    [RoutePrefix("Services/Configuration/Brand"), Route("{action}")]
    [ConnectionKey("NERPDB"), ServiceAuthorize("Administration")]
    public class BrandController : ServiceEndpoint
    {
        [HttpPost]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        [HttpPost]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Update(uow, request);
        }
 
        [HttpPost]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyRepository().Delete(uow, request);
        }

        [HttpPost]
        public UndeleteResponse Undelete(IUnitOfWork uow, UndeleteRequest request)
        {
            return new MyRepository().Undelete(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}
