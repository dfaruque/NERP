
namespace NERP.Configuration
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [Imported, PreserveMemberCase]
    public partial class PaymentMethodService
    {
        [InlineConstant] public const string BaseUrl = "Configuration/PaymentMethod";

        [InlineCode("Q.serviceRequest('Configuration/PaymentMethod/Create', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Create(SaveRequest<PaymentMethodRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [InlineCode("Q.serviceRequest('Configuration/PaymentMethod/Update', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Update(SaveRequest<PaymentMethodRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }
 
        [InlineCode("Q.serviceRequest('Configuration/PaymentMethod/Delete', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Delete(DeleteRequest request, Action<DeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [InlineCode("Q.serviceRequest('Configuration/PaymentMethod/Undelete', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Undelete(UndeleteRequest request, Action<UndeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [InlineCode("Q.serviceRequest('Configuration/PaymentMethod/Retrieve', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Retrieve(RetrieveRequest request, Action<RetrieveResponse<PaymentMethodRow>> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [InlineCode("Q.serviceRequest('Configuration/PaymentMethod/List', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest List(ListRequest request, Action<ListResponse<PaymentMethodRow>> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }

        [Imported, PreserveMemberCase]
        public static class Methods
        {
            [InlineConstant] public const string Create = "Configuration/PaymentMethod/Create";
            [InlineConstant] public const string Update = "Configuration/PaymentMethod/Update";
            [InlineConstant] public const string Delete = "Configuration/PaymentMethod/Delete";

            [InlineConstant] public const string Undelete = "Configuration/PaymentMethod/Undelete";

            [InlineConstant] public const string Retrieve = "Configuration/PaymentMethod/Retrieve";
            [InlineConstant] public const string List = "Configuration/PaymentMethod/List";
        }
    }
}