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
	/// Interface IWorkbookEvents SupportByLibrary "Excel", 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IWorkbookEvents : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IWorkbookEvents(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IWorkbookEvents(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IWorkbookEvents(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IWorkbookEvents()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 Open()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 Activate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Activate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 Deactivate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Deactivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 BeforeClose(ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(cancel);
			object returnItem = Invoker.MethodReturn(this, "BeforeClose", paramsArray);
			cancel = (bool)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="SaveAsUI">bool SaveAsUI</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 BeforeSave(bool saveAsUI, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(saveAsUI, cancel);
			object returnItem = Invoker.MethodReturn(this, "BeforeSave", paramsArray);
			cancel = (bool)paramsArray[1];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 BeforePrint(ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(cancel);
			object returnItem = Invoker.MethodReturn(this, "BeforePrint", paramsArray);
			cancel = (bool)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 NewSheet(object sh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh);
			object returnItem = Invoker.MethodReturn(this, "NewSheet", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 AddinInstall()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddinInstall", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 AddinUninstall()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddinUninstall", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Wn">NetOffice.ExcelApi.Window Wn</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 WindowResize(NetOffice.ExcelApi.Window wn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wn);
			object returnItem = Invoker.MethodReturn(this, "WindowResize", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Wn">NetOffice.ExcelApi.Window Wn</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 WindowActivate(NetOffice.ExcelApi.Window wn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wn);
			object returnItem = Invoker.MethodReturn(this, "WindowActivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Wn">NetOffice.ExcelApi.Window Wn</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 WindowDeactivate(NetOffice.ExcelApi.Window wn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wn);
			object returnItem = Invoker.MethodReturn(this, "WindowDeactivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 SheetSelectionChange(object sh, NetOffice.ExcelApi.Range target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, target);
			object returnItem = Invoker.MethodReturn(this, "SheetSelectionChange", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 SheetBeforeDoubleClick(object sh, NetOffice.ExcelApi.Range target, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(sh, target, cancel);
			object returnItem = Invoker.MethodReturn(this, "SheetBeforeDoubleClick", paramsArray);
			cancel = (bool)paramsArray[2];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 SheetBeforeRightClick(object sh, NetOffice.ExcelApi.Range target, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(sh, target, cancel);
			object returnItem = Invoker.MethodReturn(this, "SheetBeforeRightClick", paramsArray);
			cancel = (bool)paramsArray[2];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 SheetActivate(object sh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh);
			object returnItem = Invoker.MethodReturn(this, "SheetActivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 SheetDeactivate(object sh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh);
			object returnItem = Invoker.MethodReturn(this, "SheetDeactivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 SheetCalculate(object sh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh);
			object returnItem = Invoker.MethodReturn(this, "SheetCalculate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 SheetChange(object sh, NetOffice.ExcelApi.Range target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, target);
			object returnItem = Invoker.MethodReturn(this, "SheetChange", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="Target">NetOffice.ExcelApi.Hyperlink Target</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public Int32 SheetFollowHyperlink(object sh, NetOffice.ExcelApi.Hyperlink target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, target);
			object returnItem = Invoker.MethodReturn(this, "SheetFollowHyperlink", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="Target">NetOffice.ExcelApi.PivotTable Target</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public Int32 SheetPivotTableUpdate(object sh, NetOffice.ExcelApi.PivotTable target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, target);
			object returnItem = Invoker.MethodReturn(this, "SheetPivotTableUpdate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.PivotTable Target</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public Int32 PivotTableCloseConnection(NetOffice.ExcelApi.PivotTable target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target);
			object returnItem = Invoker.MethodReturn(this, "PivotTableCloseConnection", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.PivotTable Target</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public Int32 PivotTableOpenConnection(NetOffice.ExcelApi.PivotTable target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target);
			object returnItem = Invoker.MethodReturn(this, "PivotTableOpenConnection", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 11 12 14 
		/// </summary>
		/// <param name="SyncEventType">NetOffice.OfficeApi.Enums.MsoSyncEventType SyncEventType</param>
		[SupportByLibrary("Excel", 11,12,14)]
		public Int32 Sync(NetOffice.OfficeApi.Enums.MsoSyncEventType syncEventType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(syncEventType);
			object returnItem = Invoker.MethodReturn(this, "Sync", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 11 12 14 
		/// </summary>
		/// <param name="Map">NetOffice.ExcelApi.XmlMap Map</param>
		/// <param name="Url">string Url</param>
		/// <param name="IsRefresh">bool IsRefresh</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("Excel", 11,12,14)]
		public Int32 BeforeXmlImport(NetOffice.ExcelApi.XmlMap map, string url, bool isRefresh, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(map, url, isRefresh, cancel);
			object returnItem = Invoker.MethodReturn(this, "BeforeXmlImport", paramsArray);
			cancel = (bool)paramsArray[3];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 11 12 14 
		/// </summary>
		/// <param name="Map">NetOffice.ExcelApi.XmlMap Map</param>
		/// <param name="IsRefresh">bool IsRefresh</param>
		/// <param name="Result">NetOffice.ExcelApi.Enums.XlXmlImportResult Result</param>
		[SupportByLibrary("Excel", 11,12,14)]
		public Int32 AfterXmlImport(NetOffice.ExcelApi.XmlMap map, bool isRefresh, NetOffice.ExcelApi.Enums.XlXmlImportResult result)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(map, isRefresh, result);
			object returnItem = Invoker.MethodReturn(this, "AfterXmlImport", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 11 12 14 
		/// </summary>
		/// <param name="Map">NetOffice.ExcelApi.XmlMap Map</param>
		/// <param name="Url">string Url</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("Excel", 11,12,14)]
		public Int32 BeforeXmlExport(NetOffice.ExcelApi.XmlMap map, string url, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(map, url, cancel);
			object returnItem = Invoker.MethodReturn(this, "BeforeXmlExport", paramsArray);
			cancel = (bool)paramsArray[2];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 11 12 14 
		/// </summary>
		/// <param name="Map">NetOffice.ExcelApi.XmlMap Map</param>
		/// <param name="Url">string Url</param>
		/// <param name="Result">NetOffice.ExcelApi.Enums.XlXmlExportResult Result</param>
		[SupportByLibrary("Excel", 11,12,14)]
		public Int32 AfterXmlExport(NetOffice.ExcelApi.XmlMap map, string url, NetOffice.ExcelApi.Enums.XlXmlExportResult result)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(map, url, result);
			object returnItem = Invoker.MethodReturn(this, "AfterXmlExport", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="Description">string Description</param>
		/// <param name="Sheet">string Sheet</param>
		/// <param name="Success">bool Success</param>
		[SupportByLibrary("Excel", 12,14)]
		public Int32 RowsetComplete(string description, string sheet, bool success)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(description, sheet, success);
			object returnItem = Invoker.MethodReturn(this, "RowsetComplete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="TargetRange">NetOffice.ExcelApi.Range TargetRange</param>
		[SupportByLibrary("Excel", 14)]
		public Int32 SheetPivotTableAfterValueChange(object sh, NetOffice.ExcelApi.PivotTable targetPivotTable, NetOffice.ExcelApi.Range targetRange)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, targetPivotTable, targetRange);
			object returnItem = Invoker.MethodReturn(this, "SheetPivotTableAfterValueChange", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="ValueChangeStart">Int32 ValueChangeStart</param>
		/// <param name="ValueChangeEnd">Int32 ValueChangeEnd</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("Excel", 14)]
		public Int32 SheetPivotTableBeforeAllocateChanges(object sh, NetOffice.ExcelApi.PivotTable targetPivotTable, Int32 valueChangeStart, Int32 valueChangeEnd, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(sh, targetPivotTable, valueChangeStart, valueChangeEnd, cancel);
			object returnItem = Invoker.MethodReturn(this, "SheetPivotTableBeforeAllocateChanges", paramsArray);
			cancel = (bool)paramsArray[4];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="ValueChangeStart">Int32 ValueChangeStart</param>
		/// <param name="ValueChangeEnd">Int32 ValueChangeEnd</param>
		/// <param name="Cancel">ref bool Cancel</param>
		[SupportByLibrary("Excel", 14)]
		public Int32 SheetPivotTableBeforeCommitChanges(object sh, NetOffice.ExcelApi.PivotTable targetPivotTable, Int32 valueChangeStart, Int32 valueChangeEnd, ref bool cancel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(sh, targetPivotTable, valueChangeStart, valueChangeEnd, cancel);
			object returnItem = Invoker.MethodReturn(this, "SheetPivotTableBeforeCommitChanges", paramsArray);
			cancel = (bool)paramsArray[4];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="ValueChangeStart">Int32 ValueChangeStart</param>
		/// <param name="ValueChangeEnd">Int32 ValueChangeEnd</param>
		[SupportByLibrary("Excel", 14)]
		public Int32 SheetPivotTableBeforeDiscardChanges(object sh, NetOffice.ExcelApi.PivotTable targetPivotTable, Int32 valueChangeStart, Int32 valueChangeEnd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, targetPivotTable, valueChangeStart, valueChangeEnd);
			object returnItem = Invoker.MethodReturn(this, "SheetPivotTableBeforeDiscardChanges", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="Target">NetOffice.ExcelApi.PivotTable Target</param>
		[SupportByLibrary("Excel", 14)]
		public Int32 SheetPivotTableChangeSync(object sh, NetOffice.ExcelApi.PivotTable target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, target);
			object returnItem = Invoker.MethodReturn(this, "SheetPivotTableChangeSync", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Success">bool Success</param>
		[SupportByLibrary("Excel", 14)]
		public Int32 AfterSave(bool success)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(success);
			object returnItem = Invoker.MethodReturn(this, "AfterSave", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Ch">NetOffice.ExcelApi.Chart Ch</param>
		[SupportByLibrary("Excel", 14)]
		public Int32 NewChart(NetOffice.ExcelApi.Chart ch)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(ch);
			object returnItem = Invoker.MethodReturn(this, "NewChart", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}