using UnityEngine;

/// <summary>
/// �Z���T�[���X�g�v���O�C��
/// </summary>
public static class SensorListPlugin
{
    /// <summary>
    /// �Z���T�[���ꗗ���擾����
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
    /// �Z���T�[�^�C�v�ꗗ���擾����
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