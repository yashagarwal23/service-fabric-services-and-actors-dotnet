// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace FabActUtilStartupHook
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    internal class AssemblyResolver
    {
        // we should only load the DLLs that we know about and not anything else
        private static readonly string[] KnownDlls =
        {
            "System.Fabric",
            "System.Fabric.Strings",
            "System.Fabric.Management.ServiceModel"
        };

        private static string fabActUtilTempDirectoryPath = Directory.GetParent(Assembly.GetEntryAssembly().Location).ToString();

        internal static Assembly LoadAssemblyFromLocalAppPath(object sender, ResolveEventArgs args)
        {
            var assemblyName = new AssemblyName(args.Name).Name;
            if (KnownDlls.Contains(assemblyName))
            {
                var assemblyToLoad = assemblyName + ".dll";
                var assemblyPath = Path.Combine(fabActUtilTempDirectoryPath, assemblyToLoad);
                if (File.Exists(assemblyPath))
                {
                    try
                    {
                        Console.WriteLine("FabActUtilStartupHook resolved path : " + assemblyPath);
                        var assembly = Assembly.LoadFile(assemblyPath);
                        return assembly;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
                else
                {
                    Console.Error.WriteLine($"Cannot find file \"{assemblyPath}\"");
                }
            }

            return null;
        }
    }
}
