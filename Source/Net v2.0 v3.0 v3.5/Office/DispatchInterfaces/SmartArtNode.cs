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
	/// DispatchInterface SmartArtNode SupportByLibrary "Office", 14
	///</summary>
	[SupportByLibrary("Office", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SmartArtNode : _IMsoDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartArtNode(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartArtNode(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartArtNode(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartArtNode()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
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
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType OrgChartLayout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OrgChartLayout", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OrgChartLayout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public NetOffice.OfficeApi.ShapeRange Shapes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shapes", paramsArray);
				NetOffice.OfficeApi.ShapeRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.ShapeRange;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public NetOffice.OfficeApi.TextFrame2 TextFrame2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextFrame2", paramsArray);
				NetOffice.OfficeApi.TextFrame2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.TextFrame2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public Int32 Level
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Level", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Hidden
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Hidden", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public NetOffice.OfficeApi.SmartArtNodes Nodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Nodes", paramsArray);
				NetOffice.OfficeApi.SmartArtNodes newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.SmartArtNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public NetOffice.OfficeApi.SmartArtNode ParentNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentNode", paramsArray);
				NetOffice.OfficeApi.SmartArtNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.SmartArtNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public NetOffice.OfficeApi.Enums.MsoSmartArtNodeType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoSmartArtNodeType)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Position">NetOffice.OfficeApi.Enums.MsoSmartArtNodePosition Position</param>
		/// <param name="Type">NetOffice.OfficeApi.Enums.MsoSmartArtNodeType Type</param>
		[SupportByLibrary("Office", 14)]
		public NetOffice.OfficeApi.SmartArtNode AddNode(NetOffice.OfficeApi.Enums.MsoSmartArtNodePosition position, NetOffice.OfficeApi.Enums.MsoSmartArtNodeType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(position, type);
			object returnItem = Invoker.MethodReturn(this, "AddNode", paramsArray);
			NetOffice.OfficeApi.SmartArtNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.SmartArtNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public void Promote()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Promote", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public void Demote()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Demote", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public void Larger()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Larger", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public void Smaller()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Smaller", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public void ReorderUp()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ReorderUp", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public void ReorderDown()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ReorderDown", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}