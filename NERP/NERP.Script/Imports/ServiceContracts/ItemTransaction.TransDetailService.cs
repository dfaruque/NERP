namespace NERP.ItemTransaction
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [Imported, PreserveMemberCase]
    public partial class TransDetailService
    {
        [InlineConstant] public const string BaseUrl = "ItemTransaction/TransDetail";
    
        [InlineCode("Q.serviceRequest('ItemTransaction/TransDetail/Create', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Create(SaveRequest<TransDetailRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }
    
        [InlineCode("Q.serviceRequest('ItemTransaction/TransDetail/Update', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Update(SaveRequest<TransDetailRow> request, Action<SaveResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }
    
        [InlineCode("Q.serviceRequest('ItemTransaction/TransDetail/Delete', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Delete(DeleteRequest request, Action<DeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }
    
        [InlineCode("Q.serviceRequest('ItemTransaction/TransDetail/Undelete', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Undelete(UndeleteRequest request, Action<UndeleteResponse> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }
    
        [InlineCode("Q.serviceRequest('ItemTransaction/TransDetail/Retrieve', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest Retrieve(RetrieveRequest request, Action<RetrieveResponse<TransDetailRow>> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }
    
        [InlineCode("Q.serviceRequest('ItemTransaction/TransDetail/List', {request}, {onSuccess}, {options})")]
        public static jQueryXmlHttpRequest List(ListRequest request, Action<ListResponse<TransDetailRow>> onSuccess, ServiceCallOptions options = null)
        {
            return null;
        }
    
        [Imported, PreserveMemberCase]
        public static class Methods
        {
            [InlineConstant] public const string Create = "ItemTransaction/TransDetail/Create";
            [InlineConstant] public const string Update = "ItemTransaction/TransDetail/Update";
            [InlineConstant] public const string Delete = "ItemTransaction/TransDetail/Delete";
            [InlineConstant] public const string Undelete = "ItemTransaction/TransDetail/Undelete";
            [InlineConstant] public const string Retrieve = "ItemTransaction/TransDetail/Retrieve";
            [InlineConstant] public const string List = "ItemTransaction/TransDetail/List";
        }
    }
    
}

