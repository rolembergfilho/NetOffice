﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
    /// <summary>
    /// Interface IDownBars 
    /// SupportByVersion Excel, 9,10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsInterface)]
    public class IDownBars : COMObject, NetOffice.ExcelApi.IDownBars
    {
        #pragma warning disable

        #region Type Information

        /// <summary>        /// Instance Type
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
                    _type = typeof(IDownBars);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IDownBars() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Application Application
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string Name
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Name");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Border Border
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Border>(this, "Border", typeof(NetOffice.ExcelApi.Border));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Interior Interior
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Interior>(this, "Interior", typeof(NetOffice.ExcelApi.Interior));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.ChartFillFormat Fill
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ChartFillFormat>(this, "Fill", typeof(NetOffice.ExcelApi.ChartFillFormat));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.ChartFormat Format
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ChartFormat>(this, "Format", typeof(NetOffice.ExcelApi.ChartFormat));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object Select()
        {
            return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "Select");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object Delete()
        {
            return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "Delete");
        }

        #endregion

        #pragma warning restore
    }
}

