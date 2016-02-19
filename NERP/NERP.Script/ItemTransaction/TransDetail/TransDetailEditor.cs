
namespace NERP.ItemTransaction
{
    using jQueryApi;
    using NERP.Common;
    using NERP.Configuration;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;


    [ColumnsKey("ItemTransaction.TransDetail"), LocalTextPrefix("ItemTransaction.TransDetail")]
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
                AddEntity(new TransDetailRow { ItemId=3, Name = "dfsa" });
            });
            base.CreateToolbarExtensions();
        }

        protected override bool ValidateEntity(TransDetailRow row, int? id)
        {
            if (!base.ValidateEntity(row, id))
                return false;

            row.ItemName = ItemRow.Lookup.ItemById[row.ItemId.Value].Name;
            row.UomName = UomRow.Lookup.ItemById[row.UomId.Value].Name;

            return true;
        }
    }
}