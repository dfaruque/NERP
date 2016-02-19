
namespace NERP.ItemTransaction
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [Imported, PreserveMemberCase]
    public partial class TransPaymentService
    {
        [InlineConstant] public const string BaseUrl = "ItemTransaction/TransPayment";

        [InlineCode("Q.serviceRequest('ItemTransaction/TransPayment/Create', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Create(SaveRequest<TransPaymentRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [InlineCode("Q.serviceRequest('ItemTransaction/TransPayment/Update', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Update(SaveRequest<TransPaymentRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }
 
        [InlineCode("Q.serviceRequest('ItemTransaction/TransPayment/Delete', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Delete(DeleteRequest request, Action<DeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [InlineCode("Q.serviceRequest('ItemTransaction/TransPayment/Undelete', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Undelete(UndeleteRequest request, Action<UndeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [InlineCode("Q.serviceRequest('ItemTransaction/TransPayment/Retrieve', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Retrieve(RetrieveRequest request, Action<RetrieveResponse<TransPaymentRow>> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [InlineCode("Q.serviceRequest('ItemTransaction/TransPayment/List', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest List(ListRequest request, Action<ListResponse<TransPaymentRow>> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [Imported, PreserveMemberCase]
        public static class Methods
        {
            [InlineConstant] public const string Create = "ItemTransaction/TransPayment/Create";
            [InlineConstant] public const string Update = "ItemTransaction/TransPayment/Update";
            [InlineConstant] public const string Delete = "ItemTransaction/TransPayment/Delete";

            [InlineConstant] public const string Undelete = "ItemTransaction/TransPayment/Undelete";

            [InlineConstant] public const string Retrieve = "ItemTransaction/TransPayment/Retrieve";
            [InlineConstant] public const string List = "ItemTransaction/TransPayment/List";
        }
    }
}