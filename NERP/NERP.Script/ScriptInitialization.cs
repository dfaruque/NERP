using Serenity;
using System.Html;

namespace NERP
{
    public static class ScriptInitialization
    {
        static ScriptInitialization()
        {
            Q.Config.RootNamespaces.Add("NERP");
        }
    }
}