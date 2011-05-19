//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface CommandBarControl SupportByLibrary "Office", 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Office", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CommandBarControl : _IMsoOleAccDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandBarControl(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandBarControl(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandBarControl(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandBarControl()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public COMObject accParent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accParent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 accChildCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accChildCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public COMObject get_accChild(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accChild", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accName(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accName", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void set_accName(object varChild, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			Invoker.PropertySet(this, "accName", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "accName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accValue(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accValue", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void set_accValue(object varChild, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			Invoker.PropertySet(this, "accValue", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accValue", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "accValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accDescription(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accDescription", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accDescription
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accDescription", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object get_accRole(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accRole", paramsArray);
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

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accRole
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accRole", paramsArray);
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
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object get_accState(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accState", paramsArray);
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

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accState", paramsArray);
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
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accHelp(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accHelp", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accHelp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accHelp", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="pszHelpFile">ref string pszHelpFile</param>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 get_accHelpTopic(ref string pszHelpFile, object varChild)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,false);
			object[] paramsArray = Invoker.ValidateParamsArray(pszHelpFile, varChild);
			object returnItem = Invoker.PropertyGet(this, "accHelpTopic", paramsArray);
			pszHelpFile = (string)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="pszHelpFile">ref string pszHelpFile</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 get_accHelpTopic(ref string pszHelpFile)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(pszHelpFile);
			object returnItem = Invoker.PropertyGet(this, "accHelpTopic", paramsArray);
			pszHelpFile = (string)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accKeyboardShortcut(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accKeyboardShortcut", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accKeyboardShortcut
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accKeyboardShortcut", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accFocus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accFocus", paramsArray);
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
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accSelection", paramsArray);
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
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accDefaultAction(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accDefaultAction", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accDefaultAction
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accDefaultAction", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public bool BeginGroup
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BeginGroup", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BeginGroup", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public bool BuiltIn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BuiltIn", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Caption", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public COMObject Control
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Control", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string DescriptionText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DescriptionText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DescriptionText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public bool Enabled
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Enabled", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Enabled", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 HelpContextId
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HelpContextId", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HelpContextId", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string HelpFile
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HelpFile", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HelpFile", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 Id
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Id", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
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
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 InstanceId
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InstanceId", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoControlOLEUsage OLEUsage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OLEUsage", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoControlOLEUsage)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OLEUsage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string OnAction
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnAction", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnAction", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBar Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CommandBar;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string Parameter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parameter", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Parameter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 Priority
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Priority", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Priority", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string Tag
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Tag", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Tag", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string TooltipText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TooltipText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TooltipText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoControlType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoControlType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public bool Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public bool IsPriorityDropped
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsPriorityDropped", paramsArray);
				return (bool)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="flagsSelect">Int32 flagsSelect</param>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accSelect(Int32 flagsSelect, object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(flagsSelect, varChild);
			Invoker.Method(this, "accSelect", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="flagsSelect">Int32 flagsSelect</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accSelect(Int32 flagsSelect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(flagsSelect);
			Invoker.Method(this, "accSelect", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="pxLeft">ref Int32 pxLeft</param>
		/// <param name="pyTop">ref Int32 pyTop</param>
		/// <param name="pcxWidth">ref Int32 pcxWidth</param>
		/// <param name="pcyHeight">ref Int32 pcyHeight</param>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accLocation(ref Int32 pxLeft, ref Int32 pyTop, ref Int32 pcxWidth, ref Int32 pcyHeight, object varChild)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,false);
			object[] paramsArray = Invoker.ValidateParamsArray(pxLeft, pyTop, pcxWidth, pcyHeight, varChild);
			Invoker.Method(this, "accLocation", paramsArray, modifiers);
			pxLeft = (Int32)paramsArray[0];
			pyTop = (Int32)paramsArray[1];
			pcxWidth = (Int32)paramsArray[2];
			pcyHeight = (Int32)paramsArray[3];
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="pxLeft">ref Int32 pxLeft</param>
		/// <param name="pyTop">ref Int32 pyTop</param>
		/// <param name="pcxWidth">ref Int32 pcxWidth</param>
		/// <param name="pcyHeight">ref Int32 pcyHeight</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accLocation(ref Int32 pxLeft, ref Int32 pyTop, ref Int32 pcxWidth, ref Int32 pcyHeight)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(pxLeft, pyTop, pcxWidth, pcyHeight);
			Invoker.Method(this, "accLocation", paramsArray, modifiers);
			pxLeft = (Int32)paramsArray[0];
			pyTop = (Int32)paramsArray[1];
			pcxWidth = (Int32)paramsArray[2];
			pcyHeight = (Int32)paramsArray[3];
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="navDir">Int32 navDir</param>
		/// <param name="varStart">optional object varStart</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accNavigate(Int32 navDir, object varStart)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(navDir, varStart);
			object returnItem = Invoker.MethodReturn(this, "accNavigate", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="navDir">Int32 navDir</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accNavigate(Int32 navDir)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(navDir);
			object returnItem = Invoker.MethodReturn(this, "accNavigate", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="xLeft">Int32 xLeft</param>
		/// <param name="yTop">Int32 yTop</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accHitTest(Int32 xLeft, Int32 yTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xLeft, yTop);
			object returnItem = Invoker.MethodReturn(this, "accHitTest", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accDoDefaultAction(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			Invoker.Method(this, "accDoDefaultAction", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accDoDefaultAction()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "accDoDefaultAction", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Bar">optional object Bar</param>
		/// <param name="Before">optional object Before</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControl Copy(object bar, object before)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bar, before);
			object returnItem = Invoker.MethodReturn(this, "Copy", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControl Copy()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Copy", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Temporary">optional object Temporary</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Delete(object temporary)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(temporary);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Execute()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Execute", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Bar">optional object Bar</param>
		/// <param name="Before">optional object Before</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControl Move(object bar, object before)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bar, before);
			object returnItem = Invoker.MethodReturn(this, "Move", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBarControl Move()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Move", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Reset()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reset", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void SetFocus()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetFocus", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Reserved1()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reserved1", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Reserved2()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reserved2", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Reserved3()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reserved3", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Reserved4()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reserved4", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Reserved5()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reserved5", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Reserved6()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reserved6", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Reserved7()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reserved7", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}