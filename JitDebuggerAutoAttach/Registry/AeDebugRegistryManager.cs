// AeDebugRegistryManager.cs
//
// Comments : 
// Date     : 2020/12/20
// Author   : Maciej ext Regulski
// <copyright file="AeDebugRegistryManager.cs" company="Carl Zeiss Microscopy GmbH">
//     Copyright (c) Carl Zeiss Microscopy GmbH. All rights reserved.
// </copyright>

namespace JitDebuggerAutoAttach.Registry
{
    using System;

    /// <summary>
    /// Class used to modify registry information.
    /// </summary>
    public class AeDebugRegistryManager
    {
        /// <summary>
        /// Sets to the registry chosen auto debug settings.
        /// </summary>
        /// <param name="regEntry">Poco that keeps auto debug registry information.</param>
        /// <returns>True upon success.</returns>
        public bool SetAeDebugEntry(AeDebugEntry regEntry)
        {
            bool success = false;
            if (regEntry == null)
            {
                throw new ArgumentNullException("Auto debug");
            }

            try
            {
                using (var rootKey = RegistryConsts.GetLocalMachine())
                {
                    var key = rootKey.OpenSubKey(RegistryConsts.AeDebugParentKey, true);
                    if (key == null)
                    {
                        key = rootKey.CreateSubKey(RegistryConsts.AeDebugParentKey, true);
                    }

                    key.SetValue("Auto", regEntry.Auto);
                    success = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Error setting auto debug entry. {0}", ex.Message));
            }

            return success;
        }

        /// <summary>
        /// Gets from the registry the information about current auto debug settings.
        /// </summary>
        /// <returns>True upon success.</returns>
        public AeDebugEntry GetAeDebugEntry()
        {
            AeDebugEntry regEntry = null;
            try
            {
                using (var rootKey = RegistryConsts.GetLocalMachine())
                using (var key = rootKey.OpenSubKey(RegistryConsts.AeDebugParentKey))
                {
                    if (key != null)
                    {
                        Int32? auto = key.GetValue("Auto") as Int32?;
                        if (auto.HasValue)
                        {
                            regEntry = new AeDebugEntry(auto.Value == 1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Error getting auto debug from registry. {0}", ex.Message));
            }

            return regEntry;
        }
    }
}
