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
	#pragma warning disable
	///<summary>
	/// DispatchInterface IRibbonControl SupportByLibrary "Office", 12,14
	///</summary>
	[SupportByLibrary("Office", 12,14)]
	[ComImport, Guid("000C0395-0000-0000-C000-000000000046"), TypeLibType((short) 4160)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public interface IRibbonControl
	{
		#region Methods

		#endregion

		#region Properties

		[SupportByLibrary("Office", 12,14)]
		[DispId(1)]
		string Id{[return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(1)] get;}

		[SupportByLibrary("Office", 12,14)]
		[DispId(2)]
		COMObject Context{[return: MarshalAs(UnmanagedType.IDispatch)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(2)] get;}

		[SupportByLibrary("Office", 12,14)]
		[DispId(3)]
		string Tag{[return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(3)] get;}

		#endregion
	#pragma warning restore
	}
}