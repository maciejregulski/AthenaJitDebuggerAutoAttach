// ComboItem.cs
//
// Comments : 
// Date     : 2020/12/20
// Author   : Maciej ext Regulski
// <copyright file="ComboItem.cs" company="Carl Zeiss Microscopy GmbH">
//     Copyright (c) Carl Zeiss Microscopy GmbH. All rights reserved.
// </copyright>

namespace JitDebuggerAutoAttach
{
    /// <summary>
    /// This class is a data model for combo box in main form.
    /// </summary>
    public class ComboItem
    {
        /// <summary>
        /// Gets or sets a proper display name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets process image name stored in the registry.
        /// </summary>
        public string Process { get; set; }

        /// <summary>
        /// Used to display default name in the list.
        /// </summary>
        /// <returns>Display name.</returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
