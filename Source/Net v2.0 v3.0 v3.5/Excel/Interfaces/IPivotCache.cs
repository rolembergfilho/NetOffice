//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IPivotCache SupportByLibrary "Excel", 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IPivotCache : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotCache(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotCache(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotCache(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotCache()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool BackgroundQuery
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackgroundQuery", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackgroundQuery", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public object Connection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Connection", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Connection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool EnableRefresh
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableRefresh", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableRefresh", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 MemoryUsed
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MemoryUsed", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool OptimizeCache
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OptimizeCache", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OptimizeCache", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 RecordCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecordCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public DateTime RefreshDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RefreshDate", paramsArray);
				return (DateTime)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public string RefreshName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RefreshName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool RefreshOnFileOpen
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RefreshOnFileOpen", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RefreshOnFileOpen", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public object Sql
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sql", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Sql", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool SavePassword
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SavePassword", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SavePassword", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public object SourceData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceData", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SourceData", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public object CommandText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandText", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CommandText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCmdType CommandType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandType", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCmdType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CommandType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Enums.xlQueryType QueryType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "QueryType", paramsArray);
				return (NetOffice.ExcelApi.Enums.xlQueryType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool MaintainConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MaintainConnection", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MaintainConnection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 RefreshPeriod
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RefreshPeriod", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RefreshPeriod", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public COMObject Recordset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Recordset", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Recordset", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public object LocalConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LocalConnection", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LocalConnection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool UseLocalConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UseLocalConnection", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UseLocalConnection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public COMObject ADOConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ADOConnection", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public bool IsConnected
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsConnected", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public bool OLAP
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OLAP", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlPivotTableSourceType SourceType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceType", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlPivotTableSourceType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlPivotTableMissingItems MissingItemsLimit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MissingItemsLimit", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlPivotTableMissingItems)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MissingItemsLimit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public string SourceConnectionFile
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceConnectionFile", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SourceConnectionFile", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public string SourceDataFile
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceDataFile", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlRobustConnect RobustConnect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RobustConnect", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlRobustConnect)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RobustConnect", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.WorkbookConnection WorkbookConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WorkbookConnection", paramsArray);
				NetOffice.ExcelApi.WorkbookConnection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.WorkbookConnection;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.Enums.XlPivotTableVersionList Version
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Version", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlPivotTableVersionList)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public bool UpgradeOnRefresh
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UpgradeOnRefresh", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UpgradeOnRefresh", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 Refresh()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Refresh", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 ResetTimer()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ResetTimer", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 
		/// </summary>
		/// <param name="TableDestination">object TableDestination</param>
		/// <param name="TableName">optional object TableName</param>
		/// <param name="ReadData">optional object ReadData</param>
		[SupportByLibrary("Excel", 9)]
		public NetOffice.ExcelApi.PivotTable CreatePivotTable(object tableDestination, object tableName, object readData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tableDestination, tableName, readData);
			object returnItem = Invoker.MethodReturn(this, "CreatePivotTable", paramsArray);
			NetOffice.ExcelApi.PivotTable newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.PivotTable;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="TableDestination">object TableDestination</param>
		/// <param name="TableName">optional object TableName</param>
		/// <param name="ReadData">optional object ReadData</param>
		/// <param name="DefaultVersion">optional object DefaultVersion</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.PivotTable CreatePivotTable(object tableDestination, object tableName, object readData, object defaultVersion)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tableDestination, tableName, readData, defaultVersion);
			object returnItem = Invoker.MethodReturn(this, "CreatePivotTable", paramsArray);
			NetOffice.ExcelApi.PivotTable newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.PivotTable;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="TableDestination">object TableDestination</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.PivotTable CreatePivotTable(object tableDestination)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tableDestination);
			object returnItem = Invoker.MethodReturn(this, "CreatePivotTable", paramsArray);
			NetOffice.ExcelApi.PivotTable newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.PivotTable;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public Int32 MakeConnection()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "MakeConnection", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="ODCFileName">string ODCFileName</param>
		/// <param name="Description">optional object Description</param>
		/// <param name="Keywords">optional object Keywords</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public Int32 SaveAsODC(string oDCFileName, object description, object keywords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(oDCFileName, description, keywords);
			object returnItem = Invoker.MethodReturn(this, "SaveAsODC", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="ODCFileName">string ODCFileName</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public Int32 SaveAsODC(string oDCFileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(oDCFileName);
			object returnItem = Invoker.MethodReturn(this, "SaveAsODC", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}