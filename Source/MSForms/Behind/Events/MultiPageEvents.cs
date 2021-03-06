﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;
using NetOffice.Attributes;
using NetOffice.Exceptions;

namespace NetOffice.MSFormsApi.Behind.EventContracts
{

	/// <summary>
	/// Default implementation of <see cref="NetOffice.MSFormsApi.EventContracts.MultiPageEvents"/>
	/// </summary>
    [InternalEntity(InternalEntityKind.SinkHelper)]
    [ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class MultiPageEvents_SinkHelper : SinkHelper, NetOffice.MSFormsApi.EventContracts.MultiPageEvents
	{
		#region Static
		
		/// <summary>
		/// Interface Id from MultiPageEvents
		/// </summary>
		public static readonly string Id = "7B020EC8-AF6C-11CE-9F46-00AA00574A4F";
		
		#endregion
	
		#region Ctor

		/// <summary>
		/// Creates an instance of the class
		/// </summary>
		/// <param name="eventClass"></param>
		/// <param name="connectPoint"></param>
		/// <exception cref="NetOfficeCOMException">Unexpected error</exception>
		public MultiPageEvents_SinkHelper(ICOMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			SetupEventBinding(connectPoint);
		}
		
		#endregion

		#region MultiPageEvents
		
		/// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="control"></param>
        public void AddControl([In] object index, [In, MarshalAs(UnmanagedType.IDispatch)] object control)
		{
            if (!Validate("AddControl"))
            {
                Invoker.ReleaseParamsArray(index, control);
                return;
            }

			Int32 newIndex = ToInt32(index);
			NetOffice.MSFormsApi.Control newControl = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.Control>(EventClass, control, typeof(NetOffice.MSFormsApi.Control));
			object[] paramsArray = new object[2];
			paramsArray[0] = newIndex;
			paramsArray[1] = newControl;
			EventBinding.RaiseCustomEvent("AddControl", ref paramsArray);
		}

		/// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="cancel"></param>
        /// <param name="control"></param>
        /// <param name="data"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="state"></param>
        /// <param name="effect"></param>
        /// <param name="shift"></param>
        public void BeforeDragOver([In] object index, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel, [In, MarshalAs(UnmanagedType.IDispatch)] object control, [In, MarshalAs(UnmanagedType.IDispatch)] object data, [In] object x, [In] object y, [In] object state, [In, MarshalAs(UnmanagedType.IDispatch)] object effect, [In] object shift)
        {
            if (!Validate("BeforeDragOver"))
            {
                Invoker.ReleaseParamsArray(index, cancel, control, data, x, y, state, effect, shift);
                return;
            }

			Int32 newIndex = Convert.ToInt32(index);
			NetOffice.MSFormsApi.ReturnBoolean newCancel = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnBoolean>(EventClass, cancel, typeof(NetOffice.MSFormsApi.ReturnBoolean));
			NetOffice.MSFormsApi.Control newControl = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.Control>(EventClass, control, typeof(NetOffice.MSFormsApi.Control));
			NetOffice.MSFormsApi.DataObject newData = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.DataObject>(EventClass, data, typeof(NetOffice.MSFormsApi.DataObject));
			Single newX = ToSingle(x);
			Single newY = ToSingle(y);
			NetOffice.MSFormsApi.Enums.fmDragState newState = (NetOffice.MSFormsApi.Enums.fmDragState)state;
			NetOffice.MSFormsApi.ReturnEffect newEffect = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnEffect>(EventClass, effect, typeof(NetOffice.MSFormsApi.ReturnEffect));
			Int16 newShift = ToInt16(shift);
			object[] paramsArray = new object[9];
			paramsArray[0] = newIndex;
			paramsArray[1] = newCancel;
			paramsArray[2] = newControl;
			paramsArray[3] = newData;
			paramsArray[4] = newX;
			paramsArray[5] = newY;
			paramsArray[6] = newState;
			paramsArray[7] = newEffect;
			paramsArray[8] = newShift;
			EventBinding.RaiseCustomEvent("BeforeDragOver", ref paramsArray);
		}

		/// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="cancel"></param>
        /// <param name="control"></param>
        /// <param name="action"></param>
        /// <param name="data"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="effect"></param>
        /// <param name="shift"></param>
        public void BeforeDropOrPaste([In] object index, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel, [In, MarshalAs(UnmanagedType.IDispatch)] object control, [In] object action, [In, MarshalAs(UnmanagedType.IDispatch)] object data, [In] object x, [In] object y, [In, MarshalAs(UnmanagedType.IDispatch)] object effect, [In] object shift)
        {
            if (!Validate("BeforeDropOrPaste"))
            {
                Invoker.ReleaseParamsArray(index, cancel, control, action, data, x, y, effect, shift);
                return;
            }

			Int32 newIndex = ToInt32(index);
			NetOffice.MSFormsApi.ReturnBoolean newCancel = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnBoolean>(EventClass, cancel, typeof(NetOffice.MSFormsApi.ReturnBoolean));
			NetOffice.MSFormsApi.Control newControl = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.Control>(EventClass, control, typeof(NetOffice.MSFormsApi.Control));
			NetOffice.MSFormsApi.Enums.fmAction newAction = (NetOffice.MSFormsApi.Enums.fmAction)action;
			NetOffice.MSFormsApi.DataObject newData = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.DataObject>(EventClass, data, typeof(NetOffice.MSFormsApi.DataObject));
			Single newX = ToSingle(x);
			Single newY = ToSingle(y);
			NetOffice.MSFormsApi.ReturnEffect newEffect = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnEffect>(EventClass, effect, typeof(NetOffice.MSFormsApi.ReturnEffect));
			Int16 newShift = ToInt16(shift);
			object[] paramsArray = new object[9];
			paramsArray[0] = newIndex;
			paramsArray[1] = newCancel;
			paramsArray[2] = newControl;
			paramsArray[3] = newAction;
			paramsArray[4] = newData;
			paramsArray[5] = newX;
			paramsArray[6] = newY;
			paramsArray[7] = newEffect;
			paramsArray[8] = newShift;
			EventBinding.RaiseCustomEvent("BeforeDropOrPaste", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		public void Change()
        {
            if (!Validate("Change"))
            {
                return;
            }

			object[] paramsArray = new object[0];
			EventBinding.RaiseCustomEvent("Change", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
        public void Click([In] object index)
		{
            if (!Validate("Click"))
            {
                return;
            }

			Int32 newIndex = ToInt32(index);
			object[] paramsArray = new object[1];
			paramsArray[0] = newIndex;
			EventBinding.RaiseCustomEvent("Click", ref paramsArray);
		}

		/// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="cancel"></param>
        public void DblClick([In] object index, [In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
		{
            if (!Validate("DblClick"))
            {
                Invoker.ReleaseParamsArray(index, cancel);
                return;
            }

			Int32 newIndex = Convert.ToInt32(index);
			NetOffice.MSFormsApi.ReturnBoolean newCancel = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnBoolean>(EventClass, cancel, typeof(NetOffice.MSFormsApi.ReturnBoolean));
			object[] paramsArray = new object[2];
			paramsArray[0] = newIndex;
			paramsArray[1] = newCancel;
			EventBinding.RaiseCustomEvent("DblClick", ref paramsArray);
		}

		/// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="number"></param>
        /// <param name="description"></param>
        /// <param name="sCode"></param>
        /// <param name="source"></param>
        /// <param name="helpFile"></param>
        /// <param name="helpContext"></param>
        /// <param name="cancelDisplay"></param>
        public void Error([In] object index, [In] object number, [In, MarshalAs(UnmanagedType.IDispatch)] object description, [In] object sCode, [In] object source, [In] object helpFile, [In] object helpContext, [In, MarshalAs(UnmanagedType.IDispatch)] object cancelDisplay)
        {
            if (!Validate("Error"))
            {
                Invoker.ReleaseParamsArray(index, number, description, sCode, source, helpFile, helpContext, cancelDisplay);
                return;
            }

			Int32 newIndex = ToInt32(index);
			Int16 newNumber = ToInt16(number);
			NetOffice.MSFormsApi.ReturnString newDescription = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnString>(EventClass, description, typeof(NetOffice.MSFormsApi.ReturnString));
			Int32 newSCode = ToInt32(sCode);
			string newSource = ToString(source);
			string newHelpFile = ToString(helpFile);
			Int32 newHelpContext = ToInt32(helpContext);
			NetOffice.MSFormsApi.ReturnBoolean newCancelDisplay = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnBoolean>(EventClass, cancelDisplay, typeof(NetOffice.MSFormsApi.ReturnBoolean));
			object[] paramsArray = new object[8];
			paramsArray[0] = newIndex;
			paramsArray[1] = newNumber;
			paramsArray[2] = newDescription;
			paramsArray[3] = newSCode;
			paramsArray[4] = newSource;
			paramsArray[5] = newHelpFile;
			paramsArray[6] = newHelpContext;
			paramsArray[7] = newCancelDisplay;
			EventBinding.RaiseCustomEvent("Error", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="keyCode"></param>
		/// <param name="shift"></param>
        public void KeyDown([In, MarshalAs(UnmanagedType.IDispatch)] object keyCode, [In] object shift)
        {
            if (!Validate("KeyDown"))
            {
                Invoker.ReleaseParamsArray(keyCode, shift);
                return;
            }

			NetOffice.MSFormsApi.ReturnInteger newKeyCode = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnInteger>(EventClass, keyCode, typeof(NetOffice.MSFormsApi.ReturnInteger));
			Int16 newShift = ToInt16(shift);
			object[] paramsArray = new object[2];
			paramsArray[0] = newKeyCode;
			paramsArray[1] = newShift;
			EventBinding.RaiseCustomEvent("KeyDown", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="keyAscii"></param>
        public void KeyPress([In, MarshalAs(UnmanagedType.IDispatch)] object keyAscii)
        {
            if (!Validate("KeyPress"))
            {
                Invoker.ReleaseParamsArray(keyAscii);
                return;
            }

			NetOffice.MSFormsApi.ReturnInteger newKeyAscii = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnInteger>(EventClass, keyAscii, typeof(NetOffice.MSFormsApi.ReturnInteger));
			object[] paramsArray = new object[1];
			paramsArray[0] = newKeyAscii;
			EventBinding.RaiseCustomEvent("KeyPress", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="keyCode"></param>
		/// <param name="shift"></param>
        public void KeyUp([In, MarshalAs(UnmanagedType.IDispatch)] object keyCode, [In] object shift)
        {
            if (!Validate("KeyUp"))
            {
                Invoker.ReleaseParamsArray(keyCode, shift);
                return;
            }

			NetOffice.MSFormsApi.ReturnInteger newKeyCode = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnInteger>(EventClass, keyCode, typeof(NetOffice.MSFormsApi.ReturnInteger));
			Int16 newShift = Convert.ToInt16(shift);
			object[] paramsArray = new object[2];
			paramsArray[0] = newKeyCode;
			paramsArray[1] = newShift;
			EventBinding.RaiseCustomEvent("KeyUp", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
        public void Layout([In] object index)
        {
            if (!Validate("Layout"))
            {
                Invoker.ReleaseParamsArray(index);
                return;
            }

			Int32 newIndex = ToInt32(index);
			object[] paramsArray = new object[1];
			paramsArray[0] = newIndex;
			EventBinding.RaiseCustomEvent("Layout", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
		/// <param name="button"></param>
		/// <param name="shift"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
        public void MouseDown([In] object index, [In] object button, [In] object shift, [In] object x, [In] object y)
        {
            if (!Validate("MouseDown"))
            {
                Invoker.ReleaseParamsArray(index, button, shift, x, y);
                return;
            }

			Int32 newIndex = ToInt32(index);
			Int16 newButton = ToInt16(button);
			Int16 newShift = ToInt16(shift);
			Single newX = ToSingle(x);
			Single newY = ToSingle(y);
			object[] paramsArray = new object[5];
			paramsArray[0] = newIndex;
			paramsArray[1] = newButton;
			paramsArray[2] = newShift;
			paramsArray[3] = newX;
			paramsArray[4] = newY;
			EventBinding.RaiseCustomEvent("MouseDown", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
		/// <param name="button"></param>
		/// <param name="shift"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
        public void MouseMove([In] object index, [In] object button, [In] object shift, [In] object x, [In] object y)
		{
            if (!Validate("MouseMove"))
            {
                Invoker.ReleaseParamsArray(index, button, shift, x, y);
                return;
            }

            Int32 newIndex = ToInt32(index);
			Int16 newButton = ToInt16(button);
			Int16 newShift = ToInt16(shift);
			Single newX = ToSingle(x);
			Single newY = ToSingle(y);
			object[] paramsArray = new object[5];
			paramsArray[0] = newIndex;
			paramsArray[1] = newButton;
			paramsArray[2] = newShift;
			paramsArray[3] = newX;
			paramsArray[4] = newY;
			EventBinding.RaiseCustomEvent("MouseMove", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
		/// <param name="button"></param>
		/// <param name="shift"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
        public void MouseUp([In] object index, [In] object button, [In] object shift, [In] object x, [In] object y)
		{
            if (!Validate("MouseUp"))
            {
                Invoker.ReleaseParamsArray(index, button, shift, x, y);
                return;
            }

            Int32 newIndex = ToInt32(index);
			Int16 newButton = ToInt16(button);
			Int16 newShift = ToInt16(shift);
			Single newX = ToSingle(x);
			Single newY = ToSingle(y);
			object[] paramsArray = new object[5];
			paramsArray[0] = newIndex;
			paramsArray[1] = newButton;
			paramsArray[2] = newShift;
			paramsArray[3] = newX;
			paramsArray[4] = newY;
			EventBinding.RaiseCustomEvent("MouseUp", ref paramsArray);
		}

		/// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="control"></param>
        public void RemoveControl([In] object index, [In, MarshalAs(UnmanagedType.IDispatch)] object control)
        {
            if (!Validate("RemoveControl"))
            {
                Invoker.ReleaseParamsArray(index, control);
                return;
            }

			Int32 newIndex = ToInt32(index);
			NetOffice.MSFormsApi.Control newControl = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.Control>(EventClass, control, typeof(NetOffice.MSFormsApi.Control));
			object[] paramsArray = new object[2];
			paramsArray[0] = newIndex;
			paramsArray[1] = newControl;
			EventBinding.RaiseCustomEvent("RemoveControl", ref paramsArray);
		}

		/// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="actionX"></param>
        /// <param name="actionY"></param>
        /// <param name="requestDx"></param>
        /// <param name="requestDy"></param>
        /// <param name="actualDx"></param>
        /// <param name="actualDy"></param>
        public void Scroll([In] object index, [In] object actionX, [In] object actionY, [In] object requestDx, [In] object requestDy, [In, MarshalAs(UnmanagedType.IDispatch)] object actualDx, [In, MarshalAs(UnmanagedType.IDispatch)] object actualDy)
        {
            if (!Validate("Scroll"))
            {
                Invoker.ReleaseParamsArray(index, actionX, actionY, requestDx, requestDy, actualDx, actualDy);
                return;
            }

			Int32 newIndex = Convert.ToInt32(index);
			NetOffice.MSFormsApi.Enums.fmScrollAction newActionX = (NetOffice.MSFormsApi.Enums.fmScrollAction)actionX;
			NetOffice.MSFormsApi.Enums.fmScrollAction newActionY = (NetOffice.MSFormsApi.Enums.fmScrollAction)actionY;
			Single newRequestDx = ToSingle(requestDx);
			Single newRequestDy = ToSingle(requestDy);
			NetOffice.MSFormsApi.ReturnSingle newActualDx = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnSingle>(EventClass, actualDx, typeof(NetOffice.MSFormsApi.ReturnSingle));
			NetOffice.MSFormsApi.ReturnSingle newActualDy = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnSingle>(EventClass, actualDy, typeof(NetOffice.MSFormsApi.ReturnSingle));
			object[] paramsArray = new object[7];
			paramsArray[0] = newIndex;
			paramsArray[1] = newActionX;
			paramsArray[2] = newActionY;
			paramsArray[3] = newRequestDx;
			paramsArray[4] = newRequestDy;
			paramsArray[5] = newActualDx;
			paramsArray[6] = newActualDy;
			EventBinding.RaiseCustomEvent("Scroll", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
		/// <param name="percent"></param>
        public void Zoom([In] object index, [In] [Out] ref object percent)
		{
            if (!Validate("Zoom"))
            {
                Invoker.ReleaseParamsArray(index, percent);
                return;
            }

			Int32 newIndex = ToInt32(index);
			object[] paramsArray = new object[2];
			paramsArray[0] = newIndex;
			paramsArray.SetValue(percent, 1);
			EventBinding.RaiseCustomEvent("Zoom", ref paramsArray);

            percent = ToInt32(paramsArray[1]);
		}

		#endregion
	}
	
}

