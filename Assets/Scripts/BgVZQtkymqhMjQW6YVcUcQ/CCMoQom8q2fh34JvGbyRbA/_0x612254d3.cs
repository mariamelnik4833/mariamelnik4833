using UnityEngine;

public class _0x612254d3 : MonoBehaviour
{
    public bool IsOnlyWinGameEndEnabled;
    private void _0x33c95bf4()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsStoryEnabled;
    public bool IsSkipSplashEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x612254d3>();
            DontDestroyOnLoad(this.gameObject);
            this._0x33c95bf4();
        }
        else
        {
            this._0xb11c019c();
            Destroy(this.gameObject);
        }
    }

    public bool IsBestScoreEnabled;
    public bool IsTutorialEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsTimerEnabled;
    public static _0x612254d3 Instance;
    public bool IsCheckScoreEnabled;
    private void _0xb11c019c()
    {
    }

    public bool IsLevelSelectorEnabled;
}