using System;

internal class StartupHook
{
    public static void Initialize()
    {
        AppDomain.CurrentDomain.AssemblyResolve += FabActUtilStartupHook.AssemblyResolver.LoadAssemblyFromLocalAppPath;
    }
}
