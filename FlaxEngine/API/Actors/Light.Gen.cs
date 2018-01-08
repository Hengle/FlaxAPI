////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2018 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////
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
	/// Base class for all light types.
	/// </summary>
	[Serializable]
	public abstract partial class Light : Actor
	{
		/// <summary>
		/// Gets or sets value indicating if visual element affects the world.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(-50), EditorDisplay("General"), Tooltip("True if visual element affects the world")]
		public bool AffectsWorld
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetAffectsWorld(unmanagedPtr); }
			set { Internal_SetAffectsWorld(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets the light emission color.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(20), EditorDisplay("Light"), Tooltip("Light emission color")]
		public Color Color
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { Color resultAsRef; Internal_GetColor(unmanagedPtr, out resultAsRef); return resultAsRef; }
			set { Internal_SetColor(unmanagedPtr, ref value); }
#endif
		}

		/// <summary>
		/// Gets or sets light brightness parameter.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(30), EditorDisplay("Light"), Tooltip("Light brighness value"), Limit(0.0f, 100000000.0f, 0.1f)]
		public float Brightness
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetBrightness(unmanagedPtr); }
			set { Internal_SetBrightness(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets the factor that controls how much this light will contribute to the Volumetric Fog. When set to 0, there is no contribution.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(110), Limit(0, 10, 0.01f), EditorDisplay("Volumetric Fog", "Scattering Intensity"), Tooltip("Controls how much this light will contribute to the Volumetric Fog. When set to 0, there is no contribution.")]
		public float VolumetricScatteringIntensity
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetVolumetricScatteringIntensity(unmanagedPtr); }
			set { Internal_SetVolumetricScatteringIntensity(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Toggles whether or not to cast a volumetric shadow for lights contributing to Volumetric Fog
		/// </summary>
		/// <remarks>
		/// Also shadows casting by this light should be enabled in order to make it cast volumetric fog shadow.
		/// </remarks>
		[UnmanagedCall]
		[EditorOrder(120), EditorDisplay("Volumetric Fog", "Cast Shadow"), Tooltip("Toggles whether or not to cast a volumetric shadow for lights contributing to Volumetric Fog. Also shadows casting by this light should be enabled in order to make it cast volumetric fog shadow.")]
		public bool CastVolumetricShadow
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetCastVolumetricShadow(unmanagedPtr); }
			set { Internal_SetCastVolumetricShadow(unmanagedPtr, value); }
#endif
		}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_GetAffectsWorld(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetAffectsWorld(IntPtr obj, bool val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_GetColor(IntPtr obj, out Color resultAsRef);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetColor(IntPtr obj, ref Color val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetBrightness(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetBrightness(IntPtr obj, float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetVolumetricScatteringIntensity(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetVolumetricScatteringIntensity(IntPtr obj, float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_GetCastVolumetricShadow(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetCastVolumetricShadow(IntPtr obj, bool val);
#endif
#endregion
	}
}

