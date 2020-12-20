// ProcessRegistryManager.cs
//
// Comments : 
// Date     : 2020/12/20
// Author   : Maciej ext Regulski
// <copyright file="ProcessRegistryManager.cs" company="Carl Zeiss Microscopy GmbH">
//     Copyright (c) Carl Zeiss Microscopy GmbH. All rights reserved.
// </copyright>

namespace JitDebuggerAutoAttach.Registry
{
    using System;

    /// <summary>
    /// Class used to modify registry information.
    /// </summary>
    public class ProcessRegistryManager
    {
        /// <summary>
        /// Writes process entry to the registry.
        /// </summary>
        /// <param name="regEntry">Poco that keeps process registry information.</param>
        /// <returns>True upon success.</returns>
        public bool AddProcessEntry(ProcessEntry regEntry)
        {
            bool success = false;
            if (regEntry == null || string.IsNullOrEmpty(regEntry.ProcessName))
            {
                throw new ArgumentException("Empty process name");
            }

            try
            {
                var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(RegistryConsts.ProcessDebugParentKey, true);
                if (key != null)
                {
                    var subKey = key.CreateSubKey(regEntry.ProcessName);
                    if (subKey != null)
                    {
                        subKey.SetValue("Debugger", regEntry.DebuggerPath);
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Error creating process entry. {0}", ex.Message));
            }

            return success;
        }

        /// <summary>
        /// Removes process entry from the registry.
        /// </summary>
        /// <param name="regEntry">Poco that keeps process registry information.</param>
        /// <returns>True upon success.</returns>
        public bool RemoveProcessEntry(ProcessEntry regEntry)
        {
            bool success = false;
            if (regEntry == null || string.IsNullOrEmpty(regEntry.ProcessName))
            {
                throw new ArgumentException("Empty process name");
            }

            try
            {
                var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(RegistryConsts.ProcessDebugParentKey, true);
                if (key != null)
                {
                    key.DeleteSubKey(regEntry.ProcessName);
                    success = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Error removing process entry. {0}", ex.Message));
            }

            return success;
        }
    }
}
