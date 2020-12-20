// RegistryConsts.cs
//
// Comments : 
// Date     : 2020/12/20
// Author   : Maciej ext Regulski
// <copyright file="RegistryConsts.cs" company="Carl Zeiss Microscopy GmbH">
//     Copyright (c) Carl Zeiss Microscopy GmbH. All rights reserved.
// </copyright>

namespace JitDebuggerAutoAttach.Registry
{
    /// <summary>
    /// Keeps information about registry base keys used in this assembly.
    /// </summary>
    public class RegistryConsts
    {
        /// <summary>
        /// Base registry key path.
        /// </summary>
        public const string ProcessDebugParentKey = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options";

        /// <summary>
        /// Base registry key path.
        /// </summary>
        public const string AeDebugParentKey = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AeDebug";

        /// <summary>
        /// Avoids WoW64 registry redirection.
        /// </summary>
        /// <returns>Registry key.</returns>
        public static Microsoft.Win32.RegistryKey GetLocalMachine()
        {
            return Microsoft.Win32.RegistryKey.OpenBaseKey(
                Microsoft.Win32.RegistryHive.LocalMachine,
                Microsoft.Win32.RegistryView.Registry64);
        }
    }
}
