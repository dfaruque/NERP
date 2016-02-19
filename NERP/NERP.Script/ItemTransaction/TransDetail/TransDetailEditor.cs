
namespace NERP.ItemTransaction
{
    using jQueryApi;
using NERP.Common;
using Serenity;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


    [ColumnsKey(TransDetailRow.LocalTextPrefix), LocalTextPrefix(TransDetailRow.LocalTextPrefix)]
    [DialogType(typeof(TransDetailEditDialog))]
    public class TransDetailEditor : GridEditorBase<TransDetailRow>
    {
        public TransDetailEditor(jQueryObject container)
            : base(container)
        {
        }

        protected override void CreateToolbarExtensions()
        {
            var input = J(@"<input type=""text"" id=""txtBarcode""/>");
            toolbar.Element.Append(input);
            input.Click(e =>
            {

                Items.As<dynamic>().Add(new { ItemId=3, Name = "dfsa" });
            });
            base.CreateToolbarExtensions();
        }
    }
}