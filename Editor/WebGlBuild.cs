using UnityEditor;
using System.IO;

public class WebGlBuild
{
    [MenuItem("Game Build Menu/Dual Build")]
    public static void BuildGame()
    { 
        const string dualBuildPath = "WebGLBuilds"; 
        const string desktopBuildName = "WebGL_Build";
        const string mobileBuildName = "WebGL_Mobile";

        var desktopPath = Path.Combine(dualBuildPath, desktopBuildName);
        var mobilePath  = Path.Combine(dualBuildPath, mobileBuildName);
        string[] scenes = {"Assets/Game/Scenes/LoadScene.unity","Assets/Game/Scenes/SampleScene.unity"};

        DirectoryCleaner.ClearDirectory(dualBuildPath);

        EditorUserBuildSettings.webGLBuildSubtarget = WebGLTextureSubtarget.DXT;
        BuildPipeline.BuildPlayer(scenes, desktopPath, BuildTarget.WebGL, BuildOptions.Development); 

        EditorUserBuildSettings.webGLBuildSubtarget = WebGLTextureSubtarget.ASTC;
        BuildPipeline.BuildPlayer(scenes,  mobilePath, BuildTarget.WebGL, BuildOptions.Development); 

        FileUtil.CopyFileOrDirectory(Path.Combine(mobilePath, "Build", mobileBuildName + ".data"), Path.Combine(desktopPath, "Build", mobileBuildName + ".data"));
    }  
}