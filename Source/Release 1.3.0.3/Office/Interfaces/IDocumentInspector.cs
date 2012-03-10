//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// Interface IDocumentInspector SupportByLibraryAttribute Office, 12,14
	///</summary>
	[SupportByLibraryAttribute("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IDocumentInspector : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IDocumentInspector);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocumentInspector(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocumentInspector(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocumentInspector(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocumentInspector() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocumentInspector(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Desc">string Desc</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public Int32 GetInfo(out string name, out string desc)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true);
			name = string.Empty;
			desc = string.Empty;
			object[] paramsArray = Invoker.ValidateParamsArray(name, desc);
			object returnItem = Invoker.MethodReturn(this, "GetInfo", paramsArray);
			name = (string)paramsArray[0];
			desc = (string)paramsArray[1];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Doc">object Doc</param>
		/// <param name="Status">NetOffice.OfficeApi.Enums.MsoDocInspectorStatus Status</param>
		/// <param name="Result">string Result</param>
		/// <param name="Action">string Action</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public Int32 Inspect(object doc, out NetOffice.OfficeApi.Enums.MsoDocInspectorStatus status, out string result, out string action)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true);
			status = 0;
			result = string.Empty;
			action = string.Empty;
			object[] paramsArray = Invoker.ValidateParamsArray(doc, status, result, action);
			object returnItem = Invoker.MethodReturn(this, "Inspect", paramsArray);
			status = (NetOffice.OfficeApi.Enums.MsoDocInspectorStatus)paramsArray[1];
			result = (string)paramsArray[2];
			action = (string)paramsArray[3];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Doc">object Doc</param>
		/// <param name="Hwnd">Int32 Hwnd</param>
		/// <param name="Status">NetOffice.OfficeApi.Enums.MsoDocInspectorStatus Status</param>
		/// <param name="Result">string Result</param>
		[SupportByLibraryAttribute("Office", 12,14)]
		public Int32 Fix(object doc, Int32 hwnd, out NetOffice.OfficeApi.Enums.MsoDocInspectorStatus status, out string result)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true,true);
			status = 0;
			result = string.Empty;
			object[] paramsArray = Invoker.ValidateParamsArray(doc, hwnd, status, result);
			object returnItem = Invoker.MethodReturn(this, "Fix", paramsArray);
			status = (NetOffice.OfficeApi.Enums.MsoDocInspectorStatus)paramsArray[2];
			result = (string)paramsArray[3];
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}