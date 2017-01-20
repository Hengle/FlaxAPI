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
		/// TODO Comment
		/// </summary>
		public sealed partial class ModelActor : Actor
		{
			/// <summary>
			/// Gets or sets model scale in lightmap parameter
			/// </summary>
			[UnmanagedCall]
			public float ScaleInLightmap
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetScaleInLightmap(unmanagedPtr); }
				set { Internal_SetScaleInLightmap(unmanagedPtr, ref value); }
#endif
			}

			/// <summary>
			/// Gets or sets model asset
			/// </summary>
			[UnmanagedCall]
			public Model Model
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetModel(unmanagedPtr); }
				set { Internal_SetModel(unmanagedPtr, ref value); }
#endif
			}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetScaleInLightmap(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetScaleInLightmap(IntPtr obj, ref float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Model Internal_GetModel(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetModel(IntPtr obj, ref Model val);
#endif
#endregion
	}
}

