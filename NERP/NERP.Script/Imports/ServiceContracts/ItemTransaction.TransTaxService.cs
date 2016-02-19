
namespace NERP.ItemTransaction
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [Imported, PreserveMemberCase]
    public partial class TransTaxService
    {
        [InlineConstant] public const string BaseUrl = "ItemTransaction/TransTax";

        [InlineCode("Q.serviceRequest('ItemTransaction/TransTax/Create', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Create(SaveRequest<TransTaxRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [InlineCode("Q.serviceRequest('ItemTransaction/TransTax/Update', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Update(SaveRequest<TransTaxRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }
 
        [InlineCode("Q.serviceRequest('ItemTransaction/TransTax/Delete', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Delete(DeleteRequest request, Action<DeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [InlineCode("Q.serviceRequest('ItemTransaction/TransTax/Undelete', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Undelete(UndeleteRequest request, Action<UndeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [InlineCode("Q.serviceRequest('ItemTransaction/TransTax/Retrieve', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Retrieve(RetrieveRequest request, Action<RetrieveResponse<TransTaxRow>> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [InlineCode("Q.serviceRequest('ItemTransaction/TransTax/List', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest List(ListRequest request, Action<ListResponse<TransTaxRow>> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [Imported, PreserveMemberCase]
        public static class Methods
        {
            [InlineConstant] public const string Create = "ItemTransaction/TransTax/Create";
            [InlineConstant] public const string Update = "ItemTransaction/TransTax/Update";
            [InlineConstant] public const string Delete = "ItemTransaction/TransTax/Delete";

            [InlineConstant] public const string Undelete = "ItemTransaction/TransTax/Undelete";

            [InlineConstant] public const string Retrieve = "ItemTransaction/TransTax/Retrieve";
            [InlineConstant] public const string List = "ItemTransaction/TransTax/List";
        }
    }
}