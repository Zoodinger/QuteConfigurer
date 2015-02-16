using System.IO;

namespace Qute
{
    class QuteData
    {
        public QuteResolver.UEProject UEProject { get; set; }
        public QuteResolver.Kit Kit { get; set; }

        public string UEPath { get; set; }

        public string GetBuildCmd() {
            return Path.Combine(UEPath, UEProject.Engine, @"Engine\Build\BatchFiles\Build.bat");
        }

        public string GetCleanCmd() {
            return Path.Combine(UEPath, UEProject.Engine, @"Engine\Build\BatchFiles\Clean.bat");
        }

        public string GetEngineExe() {
            return Path.Combine(UEPath, UEProject.Engine, @"Engine\Binaries\Win64\UE4Editor.exe");
        }

        public string GetGenerateCmd() {
            //Aparently, in some older versions the batch file had a different name.
            var path1 = Path.Combine(UEPath, UEProject.Engine, @"Engine\Build\BatchFiles\GenerateProjectFiles.bat");
            var path2 = Path.Combine(UEPath, UEProject.Engine, @"Engine\Build\BatchFiles\RocketGenerateProjectFiles.bat");
            return File.Exists(path1) ? path1 : path2;
        }

        public string GetProjectFilesDir() {
            return Path.Combine(Path.GetDirectoryName(UEProject.Path), @"Intermediate\ProjectFiles");
        }

        public void ValidateEUPaths() {
            if (!File.Exists(GetEngineExe())) {
                throw new QuteException("UE4Editor.exe was not found. Make sure that you set Unreal Engine path correctly.");
            }
            if (!File.Exists(GetBuildCmd())) {
                throw new QuteException("Build.bat was not found. Make sure that you set Unreal Engine path correctly.");
            }
            if (!File.Exists(GetCleanCmd())) {
                throw new QuteException("Clean.bat was not found. Make sure that you set Unreal Engine path correctly.");
            }
            if (!File.Exists(GetGenerateCmd())) {
                throw new QuteException("RocketGenerateProjectFiles.bat was not found. Make sure that you set Unreal Engine path correctly.");
            }
        }
    }
}
