using Eproduction.Integrated.Assistant.Start.Core;
using Eproduction.Integrated.Assistant.Start.Core.Section;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System;

namespace Eproduction.Integrated.Assistant.Start.Worker {
    public static class IntelligentDeployWorker {
        /// <summary>
        /// 获取自动部署版本列表
        /// </summary>
        public static IList<DeployVersionContext> GetDeployVersionList() {
            IList<DeployVersionContext> deployVersions = new List<DeployVersionContext>();
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var section = (IntelligentDeployContextSection)configuration.GetSection("intelligentDeploySection");
            var versionCollection = section.DeploySettings.Collection;
            if (versionCollection.Count > 0) {
                foreach (var item in versionCollection) {
                    deployVersions.Add(new DeployVersionContext() {
                        Name = item.Name,
                        EnvrionmentPath = item.EnvrionmentPath,
                        ExportPath = item.ExportPath,
                        TypeKey = item.TypeKey,
                        E10Version = item.E10Version,
                        IsSelected = item.IsSelected,
                        TargetType = item.TargetType,
                        DeployToClient = item.DeployToClient,
                        DeployToServer = item.DeployToServer,
                        DeployToWebServer = item.DeployToWebServer,
                        DeployZhCHTResources = item.DeployZhCHTResources,
                        DeployEnUSResources = item.DeployEnUSResources,
                        KillEprocess = item.KillEprocess,
                        KillClientProcess = item.KillClientProcess,
                        AutoDeploy = item.AutoDeploy,
                        ServerParamsType = item.ServerParamsType,
                        ServerParams = item.ServerParams,
                        ClientParamsType = item.ClientParamsType,
                        ClientParams = item.ClientParams,
                        ApplyciBeenPutInStorage = item.ApplyciBeenPutInStorage,
                        ExcludeProgramInfo = item.ExcludeProgramInfo,
                        BeforeDeployementKillEprocess = item.BeforeDeployementKillEprocess,
                        ApplyciDocs = item.ApplyciDocs,
                    });
                }
            }
            return deployVersions;
        }
        /// <summary>
        /// 创建自动部署版本信息
        /// </summary>
        /// <param name="context"></param>
        public static void CreateDeployVersion(DeployVersionContext context) {
            if (context != null) {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var intelligentDeploySection = (IntelligentDeployContextSection)configuration.GetSection("intelligentDeploySection");
                var elements = intelligentDeploySection.DeploySettings;

                string prefix = "Version ";
                int maxIndexer = 0;
                var versions = elements.Collection.Where(_ => _ != null && _.Name.StartsWith(prefix) && _.Name.Remove(0, prefix.Length).Trim().ToArray().All(__ => Char.IsNumber(__)));
                if (versions.Count() > 0) {
                    maxIndexer = versions.Max(_ => Convert.ToInt32(_.Name.Remove(0, prefix.Length).Trim()));
                }
                context.Name = prefix + (maxIndexer + 1);

                elements.Add(new DeployeVersionSettingElement() {
                    Name = context.Name,
                    EnvrionmentPath = context.EnvrionmentPath,
                    ExportPath = context.ExportPath,
                    TypeKey = context.TypeKey,
                    E10Version = context.E10Version,
                    IsSelected = context.IsSelected,
                    TargetType = context.TargetType,
                    DeployToClient = context.DeployToClient,
                    DeployToServer = context.DeployToServer,
                    DeployToWebServer = context.DeployToWebServer,
                    DeployZhCHTResources = context.DeployZhCHTResources,
                    DeployEnUSResources = context.DeployEnUSResources,
                    KillEprocess = context.KillEprocess,
                    KillClientProcess = context.KillClientProcess,
                    AutoDeploy = context.AutoDeploy,
                    ServerParamsType = context.ServerParamsType,
                    ServerParams = context.ServerParams,
                    ClientParamsType = context.ClientParamsType,
                    ClientParams = context.ClientParams,
                    ApplyciBeenPutInStorage = context.ApplyciBeenPutInStorage,
                    ExcludeProgramInfo = context.ExcludeProgramInfo,
                    BeforeDeployementKillEprocess = context.BeforeDeployementKillEprocess,
                    ApplyciDocs = context.ApplyciDocs,
                });

                configuration.Save();
            }
        }
        /// <summary>
        /// 保存版本信息更改设置
        /// </summary>
        /// <param name="context"></param>
        /// <param name="oldVersionName"></param>
        public static void SaveDeployVersion(DeployVersionContext context, string oldVersionName) {
            if (context != null) {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var intelligentDeploySection = (IntelligentDeployContextSection)configuration.GetSection("intelligentDeploySection");
                var element = intelligentDeploySection.DeploySettings[oldVersionName];
                if (element != null) {
                    element.Name = context.Name;
                    configuration.Save();
                }
            }
        }
        /// <summary>
        /// 删除版本信息
        /// </summary>
        /// <param name="context"></param>
        public static void DeleteDeployVersion(DeployVersionContext context) {
            if (context != null) {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var intelligentDeploySection = (IntelligentDeployContextSection)configuration.GetSection("intelligentDeploySection");
                intelligentDeploySection.DeploySettings.Remove(context.Name);
                var firstElement = intelligentDeploySection.DeploySettings.Collection.FirstOrDefault();
                if (firstElement != null) {
                    firstElement.IsSelected = true;
                }
                configuration.Save();
            }
        }
        /// <summary>
        /// 判断版本名称是否已存在
        /// </summary>
        /// <param name="context"></param>
        /// <param name="versionName"></param>
        /// <returns></returns>
        public static bool IsExistsVersionName(DeployVersionContext context, string versionName) {
            bool exists = false;
            if (!string.IsNullOrEmpty(versionName) && context.Name != versionName) {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var intelligentDeploySection = (IntelligentDeployContextSection)configuration.GetSection("intelligentDeploySection");
                exists = intelligentDeploySection.DeploySettings.Collection.Any(_ => _.Name == versionName);
            }
            return exists;
        }
    }
}
