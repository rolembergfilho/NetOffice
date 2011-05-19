//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface IRtdServer SupportByLibrary "Excel", 10,11,12,14
	///</summary>
	[SupportByLibrary("Excel", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IRtdServer : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRtdServer(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRtdServer(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRtdServer(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRtdServer()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="CallbackObject">NetOffice.ExcelApi.IRTDUpdateEvent CallbackObject</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public Int32 ServerStart(NetOffice.ExcelApi.IRTDUpdateEvent callbackObject)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(callbackObject);
			object returnItem = Invoker.MethodReturn(this, "ServerStart", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="TopicID">Int32 TopicID</param>
		/// <param name="Strings">ref object[] Strings</param>
		/// <param name="GetNewValues">ref bool GetNewValues</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public object ConnectData(Int32 topicID, ref object[] strings, ref bool getNewValues)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(topicID, (object)strings, getNewValues);
			object returnItem = Invoker.MethodReturn(this, "ConnectData", paramsArray, modifiers);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				strings = (object[])paramsArray[1];
			getNewValues = (bool)paramsArray[2];
			return newObject;
			}
			else
			{
				strings = (object[])paramsArray[1];
			getNewValues = (bool)paramsArray[2];
			return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="TopicCount">ref Int32 TopicCount</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public object[] RefreshData(ref Int32 topicCount)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(topicCount);
			object returnItem = Invoker.MethodReturn(this, "RefreshData", paramsArray, modifiers);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject[] newObject = LateBindingApi.Core.Factory.CreateObjectArrayFromComProxy(this, (object[])returnItem);
				topicCount = (Int32)paramsArray[0];
			return newObject;
			}
			else
			{
				topicCount = (Int32)paramsArray[0];
			return (object[]) returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="TopicID">Int32 TopicID</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public void DisconnectData(Int32 topicID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(topicID);
			Invoker.Method(this, "DisconnectData", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public Int32 Heartbeat()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Heartbeat", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public void ServerTerminate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ServerTerminate", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}