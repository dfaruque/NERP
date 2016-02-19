

namespace NERP.Configuration.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services; using NERP.Common;
    using System;
    using System.Data;
    using MyRow = Entities.ItemRow;

    public class ItemRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            request.Entity.ReorderLevel = 0;
            request.Entity.CostPrice = 0;
            request.Entity.SellingPrice = 0;
            request.Entity.PromoPrice = 0;
            request.Entity.UnitWeight = 0;
            request.Entity.Tax1Rate = 0;
            request.Entity.Tax2Rate = 0;
            request.Entity.Tax3Rate = 0;
            request.Entity.Tax4Rate = 0;
            request.Entity.Tax5Rate = 0;


            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public UndeleteResponse Undelete(IUnitOfWork uow, UndeleteRequest request)
        {
            return new MyUndeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : NERP.Common.SaveRequestHandler<MyRow> { }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }

        private class MyUndeleteHandler : UndeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow> { }
    }
}