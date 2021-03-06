﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OWC10Api;

namespace NetOffice.OWC10Api.Behind
{
	/// <summary>
	/// DispatchInterface PivotResultDataAxis 
	/// SupportByVersion OWC10, 1
	/// </summary>
	[SupportByVersion("OWC10", 1)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class PivotResultDataAxis : PivotResultAxis, NetOffice.OWC10Api.PivotResultDataAxis
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
                    _type = typeof(PivotResultDataAxis);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public PivotResultDataAxis() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public virtual NetOffice.OWC10Api.PivotDataAxis SourceDataAxis
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OWC10Api.PivotDataAxis>(this, "SourceDataAxis", typeof(NetOffice.OWC10Api.PivotDataAxis));
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public virtual NetOffice.OWC10Api.PivotFields Fields
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OWC10Api.PivotFields>(this, "Fields", typeof(NetOffice.OWC10Api.PivotFields));
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public virtual NetOffice.OWC10Api.PivotTotals Totals
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OWC10Api.PivotTotals>(this, "Totals", typeof(NetOffice.OWC10Api.PivotTotals));
			}
		}

		#endregion

		#region Methods

		#endregion

		#pragma warning restore
	}
}


