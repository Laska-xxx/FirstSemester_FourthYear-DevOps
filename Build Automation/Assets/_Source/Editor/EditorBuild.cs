using UnityEditor;
using UnityEngine;

public static class EditorBuild
{
    [MenuItem("Build/Pc")]
    public static void BuildPC()
    {
        BuildPipeline.BuildPlayer(
            EditorBuildSettings.scenes, 
            "Builds/Windows/Game.exe", 
            BuildTarget.StandaloneWindows64, 
            BuildOptions.None);
    }

    [MenuItem("Build/Android")]
    public static void BuildAndroid()
    {
        BuildPipeline.BuildPlayer(
           EditorBuildSettings.scenes,
           "Builds/Android/Game.apk",
           BuildTarget.Android,
           BuildOptions.None);
    }

    [MenuItem("Build/All")]
    public static void BuildAll()
    {
        Debug.Log("-----Starting Build All");

        BuildPC();
        BuildAndroid();

        Debug.Log("-----Finished Build All");
    }
}
