using NERP.Configuration.Entities;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NERP.Common
{
    public class SaveRequestHandler<TRow> : SaveRequestHandler<TRow, SaveRequest<TRow>, SaveResponse> where TRow : Serenity.Data.Row, Serenity.Data.IIdRow, new()
    {
        //public SaveRequestHandler();

        protected override void BeforeSave()
        {
            base.BeforeSave();

            if (IsCreate)
            {
                int NextId = Connection.Count<TRow>() + 2;
                Row["Id"] = NextId;
                if(string.IsNullOrWhiteSpace(Convert.ToString(Row["Code"])))
                    Row["Code"] = NextId.ToString();
            }
        }
    }

}