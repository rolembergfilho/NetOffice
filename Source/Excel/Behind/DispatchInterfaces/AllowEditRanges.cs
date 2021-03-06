﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// DispatchInterface AllowEditRanges 
	/// SupportByVersion Excel, 10,11,12,14,15,16
	/// </summary>	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838626.aspx </remarks>
	[SupportByVersion("Excel", 10,11,12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "_Default")]
	public class AllowEditRanges : COMObject, NetOffice.ExcelApi.AllowEditRanges
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Instance Type
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(AllowEditRanges);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public AllowEditRanges() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839256.aspx </remarks>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual Int32 Count
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public virtual NetOffice.ExcelApi.AllowEditRange this[object index]
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.AllowEditRange>(this, "_Default", typeof(NetOffice.ExcelApi.AllowEditRange), index);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff841109.aspx </remarks>
		/// <param name="title">string title</param>
		/// <param name="range">NetOffice.ExcelApi.Range range</param>
		/// <param name="password">optional object password</param>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.AllowEditRange Add(string title, NetOffice.ExcelApi.Range range, object password)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.AllowEditRange>(this, "Add", typeof(NetOffice.ExcelApi.AllowEditRange), title, range, password);
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff841109.aspx </remarks>
		/// <param name="title">string title</param>
		/// <param name="range">NetOffice.ExcelApi.Range range</param>
		[CustomMethod]
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.AllowEditRange Add(string title, NetOffice.ExcelApi.Range range)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.AllowEditRange>(this, "Add", typeof(NetOffice.ExcelApi.AllowEditRange), title, range);
		}

        #endregion

        #region IEnumerableProvider<NetOffice.ExcelApi.AddIn>

        ICOMObject IEnumerableProvider<NetOffice.ExcelApi.AllowEditRange>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.ExcelApi.AllowEditRange>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.ExcelApi.AllowEditRange>

        /// <summary>
        /// SupportByVersion Excel, 10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual IEnumerator<NetOffice.ExcelApi.AllowEditRange> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.AllowEditRange item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Excel, 10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 10,11,12,14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

