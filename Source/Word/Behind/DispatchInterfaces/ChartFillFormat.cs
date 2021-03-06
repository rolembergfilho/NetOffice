﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.WordApi;

namespace NetOffice.WordApi.Behind
{
	/// <summary>
	/// DispatchInterface ChartFillFormat 
	/// SupportByVersion Word, 14,15,16
	/// </summary>
	[SupportByVersion("Word", 14,15,16)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class ChartFillFormat : COMObject, NetOffice.WordApi.ChartFillFormat
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
                    _type = typeof(ChartFillFormat);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public ChartFillFormat() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual NetOffice.WordApi.ChartColorFormat BackColor
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.ChartColorFormat>(this, "BackColor", typeof(NetOffice.WordApi.ChartColorFormat));
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual NetOffice.WordApi.ChartColorFormat ForeColor
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.ChartColorFormat>(this, "ForeColor", typeof(NetOffice.WordApi.ChartColorFormat));
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual NetOffice.OfficeApi.Enums.MsoGradientColorType GradientColorType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoGradientColorType>(this, "GradientColorType");
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual Single GradientDegree
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteSinglePropertyGet(this, "GradientDegree");
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual NetOffice.OfficeApi.Enums.MsoGradientStyle GradientStyle
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoGradientStyle>(this, "GradientStyle");
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual Int32 GradientVariant
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "GradientVariant");
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual NetOffice.OfficeApi.Enums.MsoPatternType Pattern
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoPatternType>(this, "Pattern");
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual NetOffice.OfficeApi.Enums.MsoPresetGradientType PresetGradientType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoPresetGradientType>(this, "PresetGradientType");
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual NetOffice.OfficeApi.Enums.MsoPresetTexture PresetTexture
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoPresetTexture>(this, "PresetTexture");
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual string TextureName
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "TextureName");
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual NetOffice.OfficeApi.Enums.MsoTextureType TextureType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoTextureType>(this, "TextureType");
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual NetOffice.OfficeApi.Enums.MsoFillType Type
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoFillType>(this, "Type");
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual NetOffice.OfficeApi.Enums.MsoTriState Visible
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoTriState>(this, "Visible");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "Visible", value);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Word", 14,15,16), ProxyResult]
		public virtual object Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Application");
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual Int32 Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Word", 14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// </summary>
		/// <param name="style">NetOffice.OfficeApi.Enums.MsoGradientStyle style</param>
		/// <param name="variant">Int32 variant</param>
		/// <param name="degree">Single degree</param>
		[SupportByVersion("Word", 14,15,16)]
		public virtual void OneColorGradient(NetOffice.OfficeApi.Enums.MsoGradientStyle style, Int32 variant, Single degree)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "OneColorGradient", style, variant, degree);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// </summary>
		/// <param name="style">NetOffice.OfficeApi.Enums.MsoGradientStyle style</param>
		/// <param name="variant">Int32 variant</param>
		[SupportByVersion("Word", 14,15,16)]
		public virtual void TwoColorGradient(NetOffice.OfficeApi.Enums.MsoGradientStyle style, Int32 variant)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "TwoColorGradient", style, variant);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// </summary>
		/// <param name="presetTexture">NetOffice.OfficeApi.Enums.MsoPresetTexture presetTexture</param>
		[SupportByVersion("Word", 14,15,16)]
		public virtual void PresetTextured(NetOffice.OfficeApi.Enums.MsoPresetTexture presetTexture)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "PresetTextured", presetTexture);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// </summary>
		[SupportByVersion("Word", 14,15,16)]
		public virtual void Solid()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Solid");
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// </summary>
		/// <param name="pattern">NetOffice.OfficeApi.Enums.MsoPatternType pattern</param>
		[SupportByVersion("Word", 14,15,16)]
		public virtual void Patterned(NetOffice.OfficeApi.Enums.MsoPatternType pattern)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Patterned", pattern);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// </summary>
		/// <param name="pictureFile">optional object pictureFile</param>
		/// <param name="pictureFormat">optional object pictureFormat</param>
		/// <param name="pictureStackUnit">optional object pictureStackUnit</param>
		/// <param name="picturePlacement">optional object picturePlacement</param>
		[SupportByVersion("Word", 14,15,16)]
		public virtual void UserPicture(object pictureFile, object pictureFormat, object pictureStackUnit, object picturePlacement)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "UserPicture", pictureFile, pictureFormat, pictureStackUnit, picturePlacement);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// </summary>
		[CustomMethod]
		[SupportByVersion("Word", 14,15,16)]
		public virtual void UserPicture()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "UserPicture");
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// </summary>
		/// <param name="pictureFile">optional object pictureFile</param>
		[CustomMethod]
		[SupportByVersion("Word", 14,15,16)]
		public virtual void UserPicture(object pictureFile)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "UserPicture", pictureFile);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// </summary>
		/// <param name="pictureFile">optional object pictureFile</param>
		/// <param name="pictureFormat">optional object pictureFormat</param>
		[CustomMethod]
		[SupportByVersion("Word", 14,15,16)]
		public virtual void UserPicture(object pictureFile, object pictureFormat)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "UserPicture", pictureFile, pictureFormat);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// </summary>
		/// <param name="pictureFile">optional object pictureFile</param>
		/// <param name="pictureFormat">optional object pictureFormat</param>
		/// <param name="pictureStackUnit">optional object pictureStackUnit</param>
		[CustomMethod]
		[SupportByVersion("Word", 14,15,16)]
		public virtual void UserPicture(object pictureFile, object pictureFormat, object pictureStackUnit)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "UserPicture", pictureFile, pictureFormat, pictureStackUnit);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// </summary>
		/// <param name="textureFile">string textureFile</param>
		[SupportByVersion("Word", 14,15,16)]
		public virtual void UserTextured(string textureFile)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "UserTextured", textureFile);
		}

		/// <summary>
		/// SupportByVersion Word 14, 15, 16
		/// </summary>
		/// <param name="style">NetOffice.OfficeApi.Enums.MsoGradientStyle style</param>
		/// <param name="variant">Int32 variant</param>
		/// <param name="presetGradientType">NetOffice.OfficeApi.Enums.MsoPresetGradientType presetGradientType</param>
		[SupportByVersion("Word", 14,15,16)]
		public virtual void PresetGradient(NetOffice.OfficeApi.Enums.MsoGradientStyle style, Int32 variant, NetOffice.OfficeApi.Enums.MsoPresetGradientType presetGradientType)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "PresetGradient", style, variant, presetGradientType);
		}

		#endregion

		#pragma warning restore
	}
}


