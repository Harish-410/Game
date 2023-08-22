using UnityEditor;

public class BuildScript
{
    static void BuildAndroid()
    {
        string[] scenes = { "Assets/Scenes/Game.unity" }; // Replace with your scene paths
        string outputPath = "D:/Game.apk"; // Replace with desired output path and file name

        BuildPipeline.BuildPlayer(scenes, outputPath, BuildTarget.Android, BuildOptions.None);
    }
}