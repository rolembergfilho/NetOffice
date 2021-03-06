﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;

namespace NetOffice.WordApi
{
	/// <summary>
	/// DispatchInterface BuildingBlocks 
	/// SupportByVersion Word, 12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837526.aspx </remarks>
	[SupportByVersion("Word", 12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Custom), HasIndexProperty(IndexInvoke.Method, "Item")]
	[TypeId("C6D50987-25D7-408A-BFF2-90BF86A24E93")]
	public interface BuildingBlocks : ICOMObject, IEnumerableProvider<NetOffice.WordApi.BuildingBlock>
	{
		#region Properties

		/// <summary>
		/// SupportByVersion Word 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff191875.aspx </remarks>
		[SupportByVersion("Word", 12,14,15,16)]
		NetOffice.WordApi.Application Application { get; }

		/// <summary>
		/// SupportByVersion Word 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194560.aspx </remarks>
		[SupportByVersion("Word", 12,14,15,16)]
		Int32 Creator { get; }

		/// <summary>
		/// SupportByVersion Word 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837685.aspx </remarks>
		[SupportByVersion("Word", 12,14,15,16), ProxyResult]
		object Parent { get; }

		/// <summary>
		/// SupportByVersion Word 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194693.aspx </remarks>
		[SupportByVersion("Word", 12,14,15,16)]
		Int32 Count { get; }

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 12, 14, 15, 16
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Word", 12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		NetOffice.WordApi.BuildingBlock this[object index] { get; }

		/// <summary>
		/// SupportByVersion Word 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192232.aspx </remarks>
		/// <param name="name">string name</param>
		/// <param name="range">NetOffice.WordApi.Range range</param>
		/// <param name="description">optional object description</param>
		/// <param name="insertOptions">optional NetOffice.WordApi.Enums.WdDocPartInsertOptions InsertOptions = 0</param>
		[SupportByVersion("Word", 12,14,15,16)]
		NetOffice.WordApi.BuildingBlock Add(string name, NetOffice.WordApi.Range range, object description, object insertOptions);

		/// <summary>
		/// SupportByVersion Word 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192232.aspx </remarks>
		/// <param name="name">string name</param>
		/// <param name="range">NetOffice.WordApi.Range range</param>
		[CustomMethod]
		[SupportByVersion("Word", 12,14,15,16)]
		NetOffice.WordApi.BuildingBlock Add(string name, NetOffice.WordApi.Range range);

		/// <summary>
		/// SupportByVersion Word 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192232.aspx </remarks>
		/// <param name="name">string name</param>
		/// <param name="range">NetOffice.WordApi.Range range</param>
		/// <param name="description">optional object description</param>
		[CustomMethod]
		[SupportByVersion("Word", 12,14,15,16)]
		NetOffice.WordApi.BuildingBlock Add(string name, NetOffice.WordApi.Range range, object description);

		#endregion
	}
}
