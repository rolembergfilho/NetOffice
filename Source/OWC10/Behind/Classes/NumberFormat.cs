﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.OWC10Api.Behind
{
    /// <summary>
    /// CoClass NumberFormat 
    /// SupportByVersion OWC10, 1
    /// </summary>
    [SupportByVersion("OWC10", 1)]
    [EntityType(EntityType.IsCoClass)]
    public class NumberFormat : _NumberFormat, NetOffice.OWC10Api.NumberFormat
    {
        #pragma warning disable

        #region Fields

        private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
        private string _activeSinkId;
        private static Type _type;

        #endregion

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

        /// <summary>
        /// Type Cache
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(NumberFormat);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Stub Ctor, not intended to use
        /// </summary>		
        public NumberFormat() : base()
        {

        }

        #endregion

        #pragma warning restore
    }
}
