using System;
namespace AzParse;

public static class Resources
{
    public static string? ConvertResourceToFriendlyName(this string value)
    {
        return _resourceMap.Where(w => w.Key.Contains(value, StringComparison.InvariantCultureIgnoreCase))
            .Select(s => s.Value).FirstOrDefault();
    }

    private static Dictionary<string, string> _resourceMap = new()
    {
        // See: https://learn.microsoft.com/en-us/azure/azure-resource-manager/management/azure-services-resource-providers
        { "Microsoft.AAD", "Azure Active Directory Domain Services" },
        { "Microsoft.Addons", "Core" },
        { "Microsoft.App", "Azure Container App" },
        { "Microsoft.ADHybridHealthService", "Azure Active Directory" },
        { "Microsoft.Advisor", "Azure Advisor" },
        { "Microsoft.AlertsManagement", "Azure Monitor" },
        { "Microsoft.AnalysisServices", "Azure Analysis Services" },
        { "Microsoft.ApiManagement", "API Management" },
        { "Microsoft.AppConfiguration", "Azure App Configuration" },
        { "Microsoft.AppPlatform", "Azure Spring Apps" },
        { "Microsoft.Attestation", "Azure Attestation Service" },
        { "Microsoft.Authorization", "Azure Resource Manager" },
        { "Microsoft.Automation", "Azure Automation" },
        { "Microsoft.AutonomousSystems", "Autonomous Systems" },
        { "Microsoft.AVS", "Azure VMware Solution" },
        { "Microsoft.AzureActiveDirectory", "Azure Active Directory B2C" },
        { "Microsoft.AzureArcData", "Azure Arc-enabled Data Services" },
        { "Microsoft.AzureData", "Azure Data Registry" },
        { "Microsoft.AzureStack", "Core" },
        { "Microsoft.AzureStackHCI", "Azure Stack HCI" },
        { "Microsoft.Batch", "Azure Batch" },
        { "Microsoft.Billing", "Cost Management and Billing" },
        { "Microsoft.BingMaps", "Bing Maps" },
        { "Microsoft.Blockchain", "Azure Blockchain Service" },
        { "Microsoft.BlockchainTokens", "Azure Blockchain Tokens" },
        { "Microsoft.Blueprint", "Azure Blueprints" },
        { "Microsoft.BotService", "Azure Bot Service" },
        { "Microsoft.Cache", "Azure Cache for Redis" },
        { "Microsoft.Capacity", "Core" },
        { "Microsoft.Cdn", "Content Delivery Network" },
        { "Microsoft.CertificateRegistration", "App Service Certificates" },
        { "Microsoft.ChangeAnalysis", "Azure Monitor" },
        { "Microsoft.CognitiveServices", "Cognitive Services" },
        { "Microsoft.Compute/virtualMachines", "Virtual Machines" },
        { "Microsoft.Compute/virtualMachineScaleSets", "Virtual Machine Scale Set" },
        { "Microsoft.ContainerInstance", "Container Instances" },
        { "Microsoft.ContainerRegistry", "Container Registry" },
        { "Microsoft.ContainerService", "Azure Kubernetes Service" },
        { "Microsoft.CustomerLockbox", "Customer Lockbox for Microsoft Azure" },
        { "Microsoft.CustomProviders", "Azure Custom Providers" },
        { "Microsoft.DataBox", "Azure Data Box" },
        { "Microsoft.DataBoxEdge", "Azure Stack Edge" },
        { "Microsoft.Databricks", "Azure Databricks" },
        { "Microsoft.DataCatalog", "Data Catalog" },
        { "Microsoft.DataFactory", "Data Factory" },
        { "Microsoft.DataLakeAnalytics", "Data Lake Analytics" },
        { "Microsoft.DataLakeStore", "Azure Data Lake Storage Gen2" },
        { "Microsoft.DataMigration", "Azure Database Migration Service" },
        { "Microsoft.DataProtection", "Data Protection" },
        { "Microsoft.DataShare", "Azure Data Share" },
        { "Microsoft.DBforMariaDB", "Azure Database for MariaDB" },
        { "Microsoft.DBforMySQL", "Azure Database for MySQL" },
        { "Microsoft.DBforPostgreSQL", "Azure Database for PostgreSQL" },
        { "Microsoft.DesktopVirtualization", "Azure Virtual Desktop" },
        { "Microsoft.Devices/IotHubs", "Azure IoT Hub" },
        { "Microsoft.Devices/ProvisioningServices", "Azure IoT Hub Device Provisioning Service" },
        { "Microsoft.DeviceUpdate", "Device Update for IoT Hub" },
        { "Microsoft.DevOps", "Azure DevOps" }
    };
}