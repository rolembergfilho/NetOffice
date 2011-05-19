//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi
{
	///<summary>
	/// DispatchInterface Fields SupportByLibrary "ADODB", 2.1,2.5
	///</summary>
	[SupportByLibrary("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Fields : Fields20 ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Fields(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Fields(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Fields(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Fields()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 2.1 2.5 
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 2.5 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("ADODB", 2.5)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ADODBApi.Field this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.ADODBApi.Field newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi.Field;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 2.1 2.5 
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Refresh()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Refresh", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 2.1 2.5 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">NetOffice.ADODBApi.Enums.DataTypeEnum Type</param>
		/// <param name="DefinedSize">Int32 DefinedSize</param>
		/// <param name="Attrib">NetOffice.ADODBApi.Enums.FieldAttributeEnum Attrib</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Append(string name, NetOffice.ADODBApi.Enums.DataTypeEnum type, Int32 definedSize, NetOffice.ADODBApi.Enums.FieldAttributeEnum attrib)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, definedSize, attrib);
			Invoker.Method(this, "Append", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 2.5 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">NetOffice.ADODBApi.Enums.DataTypeEnum Type</param>
		/// <param name="DefinedSize">Int32 DefinedSize</param>
		/// <param name="Attrib">NetOffice.ADODBApi.Enums.FieldAttributeEnum Attrib</param>
		/// <param name="FieldValue">optional object FieldValue</param>
		[SupportByLibrary("ADODB", 2.5)]
		public void Append(string name, NetOffice.ADODBApi.Enums.DataTypeEnum type, Int32 definedSize, NetOffice.ADODBApi.Enums.FieldAttributeEnum attrib, object fieldValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, definedSize, attrib, fieldValue);
			Invoker.Method(this, "Append", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 2.1 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("ADODB", 2.1)]
		public void Delete(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 2.5 
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public void Update()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 2.5 
		/// </summary>
		/// <param name="ResyncValues">NetOffice.ADODBApi.Enums.ResyncEnum ResyncValues</param>
		[SupportByLibrary("ADODB", 2.5)]
		public void Resync(NetOffice.ADODBApi.Enums.ResyncEnum resyncValues)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(resyncValues);
			Invoker.Method(this, "Resync", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 2.5 
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public void CancelUpdate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CancelUpdate", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("ADODB", 2.1,2.5)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}