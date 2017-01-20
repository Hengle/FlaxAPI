//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{

		/// <summary>
		/// Base class every script derives from
		/// </summary>
		public abstract partial class Script : Object
		{
			/// <summary>
			/// Enable/disable script updates
			/// </summary>
			[UnmanagedCall]
			public bool Enabled
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetEnabled(unmanagedPtr); }
				set { Internal_SetEnabled(unmanagedPtr, ref value); }
#endif
			}

			/// <summary>
			/// Gets actor owning that script
			/// </summary>
			[UnmanagedCall]
			public Actor Actor
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetActor(unmanagedPtr); }
#endif
			}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_GetEnabled(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetEnabled(IntPtr obj, ref bool val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Actor Internal_GetActor(IntPtr obj);
#endif
#endregion
	}
}

