using System;
namespace AzParse;

public static class Resources
{
    public static string ToFriendlyName(this string value)
    {
        return Resources.ResourceMap.TryGetValue(value, out var displayName) ? displayName : value;
    }

    public static Dictionary<string, string> ResourceMap = new()
	{
		{ "Microsoft.Compute/virtualMachines", "Virtual Machine" }
	};
}