using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface _CustomXMLParts 
	/// SupportByVersion Office, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Office", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _CustomXMLParts : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.CustomXMLPart>
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
                    _type = typeof(_CustomXMLParts);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public _CustomXMLParts(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLParts(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLParts(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLParts(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLParts(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLParts() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLParts(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.CustomXMLPart this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.CustomXMLPart newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLPart.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLPart;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="xML">optional string XML = </param>
		/// <param name="schemaCollection">optional object SchemaCollection</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLPart Add(object xML, object schemaCollection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML, schemaCollection);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CustomXMLPart newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLPart.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLPart;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLPart Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CustomXMLPart newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLPart.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLPart;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="xML">optional string XML = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLPart Add(object xML)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CustomXMLPart newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLPart.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLPart;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="id">string Id</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLPart SelectByID(string id)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(id);
			object returnItem = Invoker.MethodReturn(this, "SelectByID", paramsArray);
			NetOffice.OfficeApi.CustomXMLPart newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLPart.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLPart;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14, 15
		/// </summary>
		/// <param name="namespaceURI">string NamespaceURI</param>
		[SupportByVersionAttribute("Office", 12,14,15)]
		public NetOffice.OfficeApi.CustomXMLParts SelectByNamespace(string namespaceURI)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(namespaceURI);
			object returnItem = Invoker.MethodReturn(this, "SelectByNamespace", paramsArray);
			NetOffice.OfficeApi.CustomXMLParts newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLParts.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLParts;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.CustomXMLPart> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 12,14,15
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
       public IEnumerator<NetOffice.OfficeApi.CustomXMLPart> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.CustomXMLPart item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Office, 12,14,15
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}