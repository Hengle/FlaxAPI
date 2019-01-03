// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.

using System;
using System.Collections.Generic;
using FlaxEditor.CustomEditors.Editors;
using FlaxEngine;

namespace FlaxEditor.CustomEditors.Dedicated
{
    /// <summary>
    /// Custom editor for <see cref="FontReference"/>.
    /// </summary>
    /// <seealso cref="GenericEditor" />
    [CustomEditor(typeof(FontReference)), DefaultEditor]
    public class FontReferenceEditor : GenericEditor
    {
        /// <inheritdoc />
        protected override List<ItemInfo> GetItemsForType(Type type)
        {
            // Show properties
            return GetItemsForType(type, true, false);
        }
    }
}
