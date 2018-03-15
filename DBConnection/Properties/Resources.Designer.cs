﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBConnection.Properties {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DBConnection.Properties.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @V_MainName sysname = &apos;DependencyDB&apos;;
        ///DECLARE @V_Cmd nvarchar(2000);
        ///
        ///SET @V_Cmd = &apos;
        ///	GRANT ALTER ON SCHEMA::{0} TO &apos; + quotename(@V_MainName)  + &apos;;
        ///	GRANT SELECT ON SCHEMA::{0} TO &apos; + quotename(@V_MainName)  + &apos;;
        ///&apos;
        ///EXEC( @V_Cmd );.
        /// </summary>
        public static string AdminAddObservedShema {
            get {
                return ResourceManager.GetString("AdminAddObservedShema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @V_MainName sysname = &apos;{0}&apos;;
        ///DECLARE @V_Cmd nvarchar(2000);
        ///
        ///-- Create or ReCreate DependencyDB login
        ///BEGIN TRANSACTION
        ///	IF EXISTS (
        ///		SELECT name 
        ///		FROM master.sys.server_principals
        ///		WHERE name = @V_MainName)
        ///		BEGIN
        ///			SET @V_Cmd = &apos;
        ///				DROP LOGIN &apos; + quotename(@V_MainName)
        ///			EXEC ( @V_Cmd );
        ///		END
        ///	SET @V_Cmd = &apos;
        ///		CREATE LOGIN &apos; + quotename(@V_MainName) + &apos;
        ///			WITH PASSWORD = &apos;&apos;{1}&apos;&apos;, 
        ///			CHECK_EXPIRATION = OFF, 
        ///			CHECK_POLICY = OFF&apos;
        ///	EXEC ( @V_Cmd )
        ///COMMIT TRANSACTION        /// [rest of string was truncated]&quot;;.
        /// </summary>
        public static string AdminInstall {
            get {
                return ResourceManager.GetString("AdminInstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @V_MainName sysname = &apos;DependencyDB&apos;
        ///
        ///SET @V_Cmd = &apos;
        ///	REVOKE ALTER ON SCHEMA::{0} TO &apos; + quotename(@V_MainName)  + &apos;;
        ///	REVOKE SELECT ON SCHEMA::{0} TO &apos; + quotename(@V_MainName)  + &apos;;
        ///&apos;
        ///EXEC( @V_Cmd);
        ///GO.
        /// </summary>
        public static string AdminRemoveObservedShema {
            get {
                return ResourceManager.GetString("AdminRemoveObservedShema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @V_MainName sysname = &apos;DependencyDB&apos;
        ///DECLARE @V_Cmd nvarchar(2000)
        ///
        ///-- Do not disable brooker as other things in db may require it
        ///-- do not drop Route as it may be required by other things
        ///-- TODO remove active subscriptions
        ///
        ///-- Remove UserDefined type required by DependencyDb
        ///SET @V_Cmd = &apos;
        ///	IF EXISTS (
        ///		SELECT name 
        ///		FROM sys.types 
        ///		WHERE 
        ///			is_table_type = 1 AND 
        ///			name = &apos;&apos;SpParametersType&apos;&apos;)
        ///	DROP TYPE &apos; + quotename(@V_MainName)  + &apos;.[SpParametersType]
        ///	GO&apos;
        ///EXEC( @V_Cmd) [rest of string was truncated]&quot;;.
        /// </summary>
        public static string AdminUnInstall {
            get {
                return ResourceManager.GetString("AdminUnInstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to USE [sgdb]
        ///GO
        ////****** Object:  StoredProcedure [NotificationBroker].[ListenerInstall]    Script Date: 2018-03-14 15:07:24 ******/
        ///SET ANSI_NULLS ON
        ///GO
        ///SET QUOTED_IDENTIFIER ON
        ///GO
        ///ALTER PROCEDURE [DependencyDB].[Install]
        ///	@AppName NVARCHAR(110), -- max object name length is 128 ex. &apos;MemSourceAPI&apos;
        ///	@SubscriberString NVARCHAR(128), -- ex. &apos;A_JobPart_Select&apos;
        ///	@ProcedureSchemaName NVARCHAR(128),
        ///	@ProcedureName NVARCHAR(128),
        ///	@ProcedureParameters dbo.SpParametersType READONLY, -- ex. &apos;dbo&apos;
        ///	@ValidF [rest of string was truncated]&quot;;.
        /// </summary>
        public static string DependencyDB_Install {
            get {
                return ResourceManager.GetString("DependencyDB_Install", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///SET ANSI_NULLS ON
        ///GO
        ///SET QUOTED_IDENTIFIER ON
        ///GO
        ///
        ///CREATE PROCEDURE [DependencyDB].[ReceiveNotification]
        ///	@AppName NVARCHAR(200),
        ///	@ReceiveTimeout int
        ///AS
        ///BEGIN
        ///	DECLARE @ListenerQueue NVARCHAR(200)
        ///	SET @ListenerQueue = N&apos;Queue_&apos; + @AppName
        ///
        ///	DECLARE @Listenercmd NVARCHAR(MAX)
        ///    -- Create a queue which will hold the tracked information 
        ///    IF NOT EXISTS (
        ///		SELECT name
        ///			FROM sys.service_queues 
        ///			WHERE name = @ListenerQueue
        ///	)
        ///		BEGIN
        ///			SET @Listenercmd = null
        ///			SET @Listenerc [rest of string was truncated]&quot;;.
        /// </summary>
        public static string DependencyDB_ReceiveNotification {
            get {
                return ResourceManager.GetString("DependencyDB_ReceiveNotification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///SET ANSI_NULLS ON
        ///GO
        ///SET QUOTED_IDENTIFIER ON
        ///GO
        ///
        ///ALTER PROCEDURE [DependencyDB].[Uninstall]
        ///	@AppName NVARCHAR(110), -- max object name length is 128 ex. &apos;MemSourceAPI&apos;
        ///	@SubscriberString NVARCHAR(128), -- ex. &apos;A_JobPart_Select&apos;
        ///	@ProcedureSchemaName NVARCHAR(128),
        ///	@ProcedureName NVARCHAR(128),
        ///	@ProcedureParameters dbo.SpParametersType READONLY
        ///AS
        ///BEGIN
        ///
        ///	DECLARE @ListenerQueue NVARCHAR(128)
        ///	SET @ListenerQueue = N&apos;ListenerQueue_&apos; + @ListenerAppName
        ///	DECLARE @ListenerService NVARCHAR(12 [rest of string was truncated]&quot;;.
        /// </summary>
        public static string DependencyDB_Uninstall {
            get {
                return ResourceManager.GetString("DependencyDB_Uninstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///SET ANSI_NULLS ON
        ///GO
        ///SET QUOTED_IDENTIFIER ON
        ///GO
        ///
        ///ALTER PROCEDURE [DependencyDB].[UninstallAll]
        ///	@AppName NVARCHAR(110) -- max object name length is 128 ex. &apos;MemSourceAPI&apos;
        ///AS
        ///BEGIN
        ///
        ///	-- this is run only on start of application
        ///	DECLARE @ListenerQueue NVARCHAR(128)
        ///	SET @ListenerQueue = N&apos;ListenerQueue_&apos; + @ListenerAppName
        ///	DECLARE @ListenerService NVARCHAR(128)
        ///	SET @ListenerService = N&apos;ListenerService_&apos; + @ListenerAppName
        ///	
        ///	DECLARE @cmd NVARCHAR(MAX)
        ///	-- drop triggers
        ///	DECLARE @triger  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string DependencyDB_UninstallAll {
            get {
                return ResourceManager.GetString("DependencyDB_UninstallAll", resourceCulture);
            }
        }
    }
}
