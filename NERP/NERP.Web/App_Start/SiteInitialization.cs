namespace NERP
{
    using Administration;
    using Serenity;
    using Serenity.Abstractions;
    using Serenity.Data;
    using System;
    using System.Configuration;

    public static partial class SiteInitialization
    {
        public static void ApplicationStart()
        {
            try
            {
                SqlConnections.GetConnectionString("Default").Dialect = SqlServer2005Dialect.Instance;
                //SqlConnections.GetConnectionString("Northwind").Dialect = SqlServer2005Dialect.Instance;

                SqlSettings.AutoQuotedIdentifiers = true;
                Serenity.Web.CommonInitialization.Run();

                var registrar = Dependency.Resolve<IDependencyRegistrar>();
                registrar.RegisterInstance<IAuthorizationService>(new Administration.AuthorizationService());
                registrar.RegisterInstance<IAuthenticationService>(new Administration.AuthenticationService());
                registrar.RegisterInstance<IPermissionService>(new Administration.PermissionService());
                registrar.RegisterInstance<IUserRetrieveService>(new Administration.UserRetrieveService());

                if (!ConfigurationManager.AppSettings["LDAP"].IsTrimmedEmpty())
                    registrar.RegisterInstance<IDirectoryService>(new LdapDirectoryService());

                if (!ConfigurationManager.AppSettings["ActiveDirectory"].IsTrimmedEmpty())
                    registrar.RegisterInstance<IDirectoryService>(new ActiveDirectoryService());
            }
            catch (Exception ex)
            {
                ex.Log();
                throw;
            }

            //foreach (var databaseKey in databaseKeys)
            //{
            //    EnsureDatabase(databaseKey);
            //    RunMigrations(databaseKey);
            //}
        }

        public static void ApplicationEnd()
        {
        }
    }
}