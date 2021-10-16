using UnityEngine;

/// <summary>
/// センサーリストプラグイン
/// </summary>
public static class SensorListPlugin
{
    /// <summary>
    /// センサー名一覧を取得する
    /// </summary>
    /// <returns></returns>
    public static string[] GetSensorNames()
    {
#if !UNITY_EDITOR && UNITY_ANDROID
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject context = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaClass cls = new AndroidJavaClass("com.example.sensorlist.SensorList");
        string result = cls.CallStatic<string>("getSensorNames", context);
        return result.Split(',');
#else
        return new string[0];
#endif
    }

    /// <summary>
    /// センサータイプ一覧を取得する
    /// </summary>
    /// <returns></returns>
    public static string[] GetSensorTypes()
    {
#if !UNITY_EDITOR && UNITY_ANDROID
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject context = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaClass cls = new AndroidJavaClass("com.example.sensorlist.SensorList");
        string result = cls.CallStatic<string>("getSensorTypes", context);
        return result.Split(',');
#else
        return new string[0];
#endif
    }
}