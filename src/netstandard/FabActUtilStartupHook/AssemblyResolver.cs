using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FabActUtilStartupHook
{
    internal class AssemblyResolver
    {
        internal static Assembly LoadAssemblyFromLocalAppPath(object sender, ResolveEventArgs args)
        {
            var assemblyName = new AssemblyName(args.Name).Name;
            if (KnownDlls.Contains(assemblyName))
            {
                var assemblyToLoad = assemblyName + ".dll";
                var assemblyPath = Path.Combine(directoryPath, assemblyToLoad);
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

        // we should only load the DLLs that we know about and not anything else
        private static readonly string[] KnownDlls =
        {
            "System.Fabric",
            "System.Fabric.Management.ServiceModel",
            "System.Fabric.Strings",
            "StartupServicesModel"
        };

        private static string directoryPath = Directory.GetParent(Assembly.GetEntryAssembly().Location).ToString();
    }
}
