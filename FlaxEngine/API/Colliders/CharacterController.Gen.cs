// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// Physical objects that allows to easily do player movement constrained by collisions without having to deal with a rigidbody.
    /// </summary>
    [Serializable]
    public sealed partial class CharacterController : Collider
    {
        /// <summary>
        /// Creates new <see cref="CharacterController"/> object.
        /// </summary>
        private CharacterController() : base()
        {
        }

        /// <summary>
        /// Creates new instance of <see cref="CharacterController"/> object.
        /// </summary>
        /// <returns>Created object.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static CharacterController New()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_Create(typeof(CharacterController)) as CharacterController;
#endif
        }

        /// <summary>
        /// Gets or sets the radius of the character capsule, measured in the object's local space.
        /// </summary>
        /// <remarks>
        /// The character capsule radius will be scaled by the actor's world scale.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(100), EditorDisplay("Collider"), Tooltip("Radius of the character capsule, measured in the object's local space")]
        public float Radius
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetRadius(unmanagedPtr); }
            set { Internal_SetRadius(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the height of the character, measured in the object's local space.
        /// </summary>
        /// <remarks>
        /// The character height will be scaled by the actor's world scale.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(110), EditorDisplay("Collider"), Tooltip("Height of the character, measured in the object's local space")]
        public float Height
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetHeight(unmanagedPtr); }
            set { Internal_SetHeight(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the slope limit (in degrees).
        /// </summary>
        /// <remarks>
        /// Limits the collider to only climb slopes that are less steep (in degrees) than the indicated value.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(210), Limit(0, 100), EditorDisplay("Character Controller"), Tooltip("Limits the collider to only climb slopes that are less steep (in degrees) than the indicated value")]
        public float SlopeLimit
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetSlopeLimit(unmanagedPtr); }
            set { Internal_SetSlopeLimit(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the step height.
        /// </summary>
        /// <remarks>
        /// The character will step up a stair only if it is closer to the ground than the indicated value. This should not be greater than the Character Controller's height or it will generate an error.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(220), Limit(0), EditorDisplay("Character Controller"), Tooltip("The character will step up a stair only if it is closer to the ground than the indicated value.")]
        public float StepOffset
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetStepOffset(unmanagedPtr); }
            set { Internal_SetStepOffset(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the minimum move distance of the character controller.
        /// </summary>
        /// <remarks>
        /// The minimum travelled distance to consider. If travelled distance is smaller, the character doesn't move. This is used to stop the recursive motion algorithm when remaining distance to travel is small.
        /// </remarks>
        [UnmanagedCall]
        [EditorOrder(230), Limit(0, 1000), EditorDisplay("Character Controller"), Tooltip("The minimum travelled distance to consider.If travelled distance is smaller, the character doesn't move.")]
        public float MinMoveDistance
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetMinMoveDistance(unmanagedPtr); }
            set { Internal_SetMinMoveDistance(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets the current linear velocity of the Character Controller.
        /// </summary>
        /// <remarks>
        /// This allows tracking how fast the character is actually moving, for instance when it is stuck at a wall this value will be the near zero vector.
        /// </remarks>
        [UnmanagedCall]
        [HideInEditor]
        public Vector3 Velocity
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { Vector3 resultAsRef; Internal_GetVelocity(unmanagedPtr, out resultAsRef); return resultAsRef; }
#endif
        }

        /// <summary>
        /// Gets the current collision flags.
        /// </summary>
        /// <remarks>
        /// Tells which parts of the character capsule collided with the environment during the last move call. It can be used to trigger various character animations.
        /// </remarks>
        [UnmanagedCall]
        [HideInEditor]
        public CollisionFlags Flags
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetFlags(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Moves the character with the given speed.
        /// </summary>
        /// <remarks>
        /// Velocity along the y-axis is ignored and the gravity is automatically applied. It will slide along colliders. Result collision flags is the summary of collisions that occurred during the Move.
        /// </remarks>
        /// <param name="speed">The speed (in cm/s).</param>
        /// <returns>The collision flags. It can be used to trigger various character animations.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public CollisionFlags SimpleMove(Vector3 speed)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_SimpleMove(unmanagedPtr, ref speed);
#endif
        }

        /// <summary>
        /// Moves the character with the given speed.
        /// </summary>
        /// <remarks>
        /// Velocity along the y-axis is ignored and the gravity is automatically applied. It will slide along colliders. Result collision flags is the summary of collisions that occurred during the Move.
        /// </remarks>
        /// <param name="speed">The displacement vector (in cm).</param>
        /// <returns>The collision flags. It can be used to trigger various character animations.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public CollisionFlags Move(Vector3 speed)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_Move(unmanagedPtr, ref speed);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetRadius(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetRadius(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetHeight(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetHeight(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetSlopeLimit(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetSlopeLimit(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetStepOffset(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetStepOffset(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetMinMoveDistance(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetMinMoveDistance(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetVelocity(IntPtr obj, out Vector3 resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern CollisionFlags Internal_GetFlags(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern CollisionFlags Internal_SimpleMove(IntPtr obj, ref Vector3 speed);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern CollisionFlags Internal_Move(IntPtr obj, ref Vector3 speed);
#endif

        #endregion
    }
}
