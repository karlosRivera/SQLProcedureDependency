﻿using DBConnection;
using DBConnectionTests.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DBConnectionTests
{
    static class SetDBState
    {
        private static AccessDB serviceAccessDB = new AccessDB(CommonTestsValues.ServiceConnectionString);
        private static AccessDB serviceAccessDBAdmin = new AccessDB(CommonTestsValues.AdminConnectionString);

        public static void SetEmptyDB(string DBName)
        {
            RunFile(Resources.SetEmptyDB, true, DBName);
        }

        public static void SetAdminInstalledDB(string DBName, string mainServiceName, string password)
        {
            SetEmptyDB(DBName);
            AdminDependencyDB adminDependencyDB = new AdminDependencyDB(serviceAccessDBAdmin);
            adminDependencyDB.AdminInstall(DBName, mainServiceName, password);
        }

        public static void SetSingleSubscriptionInstalledDB(string DBName, string mainServiceName, string password, string subscriber,SqlParameterCollection testProcedureParameters)
        {
            SetAdminInstalledDB(DBName, mainServiceName, password);
            Subscription subscription = new Subscription(mainServiceName, subscriber, CommonTestsValues.SubscribedProcedureSchema, CommonTestsValues.SubscribedProcedureName, testProcedureParameters);
            SqlProcedures sqlProcedures = new SqlProcedures(serviceAccessDB);
            sqlProcedures.InstallSubscription(subscription);
        }

        public static void SetTwoSubscriptionInstalledDB(string DBName, string mainServiceName, string password, string firstSubscriber, SqlParameterCollection firstTestProcedureParameters, string secondSubscriber, SqlParameterCollection secondTestProcedureParameters)
        {
            SetSingleSubscriptionInstalledDB( DBName,  mainServiceName,  password,  firstSubscriber,  firstTestProcedureParameters);
            Subscription subscription = new Subscription(mainServiceName, secondSubscriber, CommonTestsValues.SubscribedProcedureSchema, CommonTestsValues.SubscribedProcedureName, secondTestProcedureParameters);
            SqlProcedures sqlProcedures = new SqlProcedures(serviceAccessDB);
            sqlProcedures.InstallSubscription(subscription);
        }

        public static void RunFile(string fileContent, bool asAdmin = true, params string[] replacements)
        {
            string slqCommandText = string.Format(fileContent, replacements);
            SqlCommand sqlCommand = new SqlCommand(slqCommandText);
            if(asAdmin)
                serviceAccessDBAdmin.SQLRunNonQueryProcedure(sqlCommand);
            else
                serviceAccessDB.SQLRunNonQueryProcedure(sqlCommand);
        }

        public static List<T> RunFile<T>(string fileContent, bool asAdmin = true, params string[] replacements)
        {
            string slqCommandText = string.Format(fileContent, replacements);
            SqlCommand sqlCommand = new SqlCommand(slqCommandText);
            if (asAdmin)
                return serviceAccessDBAdmin.SQLRunQueryProcedure<T>(sqlCommand);
            else
                return serviceAccessDB.SQLRunQueryProcedure<T>(sqlCommand);
        }

    }
}
