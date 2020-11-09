using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace DistantPointExe.Localization
{
    public static class DistantPointExeLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DistantPointExeConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DistantPointExeLocalizationConfigurer).GetAssembly(),
                        "DistantPointExe.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
