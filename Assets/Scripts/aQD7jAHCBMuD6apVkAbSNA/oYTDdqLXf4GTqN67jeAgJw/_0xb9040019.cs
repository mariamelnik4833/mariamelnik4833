using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xb9040019 : MonoBehaviour
{
    internal void _0x9f5678f6()
    {
        Rect _0xd781931b = Screen.safeArea;
        Vector2 _0xc0581a6a = new Vector2(Screen.width, Screen.height);
        if (_0xd781931b == lastSafe && _0xc0581a6a == lastSize)
            return;
        // Apply manual padding
        _0xd781931b.xMin += _0xbc252bcf;
        _0xd781931b.xMax -= _0x24b97027;
        _0xd781931b.yMin += _0x5248c690;
        _0xd781931b.yMax -= _0x7cca330b;
        // Convert Unity safe area -> native WebView frame
        Rect _0x4ec63b76 = new Rect(_0xd781931b.x, _0xc0581a6a.y - _0xd781931b.y - _0xd781931b.height, // Y flip for native coordinate system
 _0xd781931b.width, _0xd781931b.height);
        _0x21165c39.Frame = _0x4ec63b76;
        lastSafe = Screen.safeArea;
        lastSize = _0xc0581a6a;
    }

    private void Awake()
    {
        if (_0xc64e388f != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xc64e388f = gameObject.GetComponent<_0xb9040019>();
        DontDestroyOnLoad(gameObject);
        _0x459edd9d = _0xb49d32f8 = _0x6557de6f = "";
        _0x82b5e1b7 = "";
        _0x743a85ad = false;
    }

    private bool _0x0b464120(string _0x889320bd)
    {
        if (string.IsNullOrEmpty(_0x889320bd))
            return false;
        try
        {
            using (var _0x86de32d7 = new AndroidJavaClass(_0xe0d57b82._0x6813c1ab(new byte[30] { 179, 191, 189, 254, 165, 190, 185, 164, 169, 227, 180, 254, 160, 188, 177, 169, 181, 162, 254, 133, 190, 185, 164, 169, 128, 188, 177, 169, 181, 162 }, 208)))
            using (var _0x409e290e = _0x86de32d7.GetStatic<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[15] { 121, 111, 104, 104, 127, 116, 110, 91, 121, 110, 115, 108, 115, 110, 99 }, 26)))
            using (var _0xe7785615 = _0x409e290e.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[17] { 16, 18, 3, 39, 22, 20, 28, 22, 16, 18, 58, 22, 25, 22, 16, 18, 5 }, 119)))
            using (var _0x1f9564fc = _0xe7785615.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[25] { 148, 150, 135, 191, 146, 134, 157, 144, 155, 186, 157, 135, 150, 157, 135, 181, 156, 129, 163, 146, 144, 152, 146, 148, 150 }, 243), _0x889320bd))
            {
                if (_0x1f9564fc == null)
                    return false;
                WLog(_0xe0d57b82._0x6813c1ab(new byte[37] { 230, 205, 215, 202, 200, 192, 233, 204, 206, 192, 133, 201, 196, 208, 203, 198, 205, 133, 204, 203, 214, 209, 196, 201, 201, 192, 193, 133, 213, 196, 198, 206, 196, 194, 192, 159, 133 }, 165) + _0x889320bd);
                _0x1f9564fc.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[8] { 131, 134, 134, 164, 142, 131, 133, 145 }, 226), 0x10000000);
                _0x409e290e.Call(_0xe0d57b82._0x6813c1ab(new byte[13] { 87, 80, 69, 86, 80, 101, 71, 80, 77, 82, 77, 80, 93 }, 36), _0x1f9564fc);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private string _0xecf746fb = "";
    private string _0x2e2099ee;
    private string _0x97b08d00 = "";
    private bool _0xa9953aa3 = false;
    private bool TryOpenExternalLikeChrome(string _0x311c2e5b)
    {
        if (string.IsNullOrEmpty(_0x311c2e5b))
            return false;
        if (_0x311c2e5b.StartsWith(_0xe0d57b82._0x6813c1ab(new byte[9] { 196, 195, 217, 200, 195, 217, 151, 130, 130 }, 173), StringComparison.OrdinalIgnoreCase))
            return _0x2e7742f6(_0x311c2e5b);
        if (_0x6fddbc76(_0x311c2e5b))
            return _0x5081e008(_0x311c2e5b, null);
        if (!_0x311c2e5b.StartsWith(_0xe0d57b82._0x6813c1ab(new byte[7] { 88, 68, 68, 64, 10, 31, 31 }, 48), StringComparison.OrdinalIgnoreCase) && !_0x311c2e5b.StartsWith(_0xe0d57b82._0x6813c1ab(new byte[8] { 217, 197, 197, 193, 194, 139, 158, 158 }, 177), StringComparison.OrdinalIgnoreCase) && !_0x311c2e5b.StartsWith(_0xe0d57b82._0x6813c1ab(new byte[11] { 186, 185, 180, 174, 175, 225, 185, 183, 186, 181, 176 }, 219), StringComparison.OrdinalIgnoreCase))
        {
            return _0x329f33d8(_0x311c2e5b);
        }

        return false;
    }

    private static string ReadPushField(Dictionary<string, object> _0x914ffb32, string _0x3e5ae69f)
    {
        if (_0x914ffb32 == null || string.IsNullOrEmpty(_0x3e5ae69f))
            return string.Empty;
        if (_0x914ffb32.TryGetValue(_0xe0d57b82._0x6813c1ab(new byte[16] { 132, 133, 158, 131, 140, 131, 137, 139, 158, 131, 133, 132, 174, 139, 158, 139 }, 234), out var raw))
        {
            try
            {
                var _0x1f17905f = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x1f17905f != null && _0x1f17905f.TryGetValue(_0x3e5ae69f, out var nestedVal))
                {
                    var _0x445664f3 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x445664f3))
                        return _0x445664f3;
                }
            }
            catch
            {
            }
        }

        if (_0x914ffb32.TryGetValue(_0x3e5ae69f, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    internal bool IsHttpUrl(string _0xf820cc14)
    {
        if (string.IsNullOrEmpty(_0xf820cc14))
            return false;
        return _0xf820cc14.StartsWith(_0xe0d57b82._0x6813c1ab(new byte[7] { 119, 107, 107, 111, 37, 48, 48 }, 31), StringComparison.OrdinalIgnoreCase) || _0xf820cc14.StartsWith(_0xe0d57b82._0x6813c1ab(new byte[8] { 143, 147, 147, 151, 148, 221, 200, 200 }, 231), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0xb7fd8b99()
    {
        var _0x3f49d816 = _0x353d3058();
        if (_0x3f49d816 == null)
            return false;
        WLog(_0xe0d57b82._0x6813c1ab(new byte[31] { 53, 28, 15, 25, 10, 28, 15, 24, 93, 31, 28, 30, 22, 93, 80, 67, 93, 13, 18, 13, 8, 13, 93, 58, 18, 63, 28, 30, 22, 71, 93 }, 125) + _0x3f49d816.Id);
        _0x3f49d816.GoBack();
        return true;
    }

    private void _0x92d92e80()
    {
        _0x966a6c1c = true;
        if (_0x21165c39 != null)
            _0x21165c39.SetUserAgent(_0xc0fffb23());
    }

    // WS_SOURCE MONO
    public static _0xb9040019 _0xc64e388f { get; private set; }

    private string _0xd5687a72 = "";
    internal string _0x15ddf72a(string _0x9011e051)
    {
        int _0x92e490ed = _0x9011e051.IndexOf(_0xe0d57b82._0x6813c1ab(new byte[3] { 25, 20, 77 }, 112), StringComparison.OrdinalIgnoreCase);
        if (_0x92e490ed < 0)
            return null;
        string _0xcddebb36 = _0x9011e051.Substring(_0x92e490ed + 3);
        int _0xeb2e6b99 = _0xcddebb36.IndexOf('&');
        return _0xeb2e6b99 >= 0 ? _0xcddebb36.Substring(0, _0xeb2e6b99) : _0xcddebb36;
    }

    private bool _0x2e7742f6(string _0x956802e5)
    {
        try
        {
            using (var _0xaf594399 = new AndroidJavaClass(_0xe0d57b82._0x6813c1ab(new byte[30] { 142, 130, 128, 195, 152, 131, 132, 153, 148, 222, 137, 195, 157, 129, 140, 148, 136, 159, 195, 184, 131, 132, 153, 148, 189, 129, 140, 148, 136, 159 }, 237)))
            using (var _0x7060638a = _0xaf594399.GetStatic<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[15] { 216, 206, 201, 201, 222, 213, 207, 250, 216, 207, 210, 205, 210, 207, 194 }, 187)))
            using (var _0x2f99b94d = _0x7060638a.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[17] { 247, 245, 228, 192, 241, 243, 251, 241, 247, 245, 221, 241, 254, 241, 247, 245, 226 }, 144)))
            using (var _0xae033967 = new AndroidJavaClass(_0xe0d57b82._0x6813c1ab(new byte[22] { 79, 64, 74, 92, 65, 71, 74, 0, 77, 65, 64, 90, 75, 64, 90, 0, 103, 64, 90, 75, 64, 90 }, 46)))
            using (var _0xbe52daf9 = _0xae033967.CallStatic<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[8] { 238, 255, 236, 237, 251, 203, 236, 247 }, 158), _0x956802e5, 1))
            {
                string _0xd79d5890 = _0xbe52daf9.Call<string>(_0xe0d57b82._0x6813c1ab(new byte[14] { 199, 197, 212, 243, 212, 210, 201, 206, 199, 229, 216, 212, 210, 193 }, 160), _0xe0d57b82._0x6813c1ab(new byte[20] { 179, 163, 190, 166, 162, 180, 163, 142, 183, 176, 189, 189, 179, 176, 178, 186, 142, 164, 163, 189 }, 209));
                string _0x650a3d4b = _0xbe52daf9.Call<string>(_0xe0d57b82._0x6813c1ab(new byte[10] { 203, 201, 216, 252, 205, 207, 199, 205, 203, 201 }, 172));
                _0xbe52daf9.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[11] { 52, 49, 49, 22, 52, 33, 48, 50, 58, 39, 44 }, 85), _0xe0d57b82._0x6813c1ab(new byte[33] { 172, 163, 169, 191, 162, 164, 169, 227, 164, 163, 185, 168, 163, 185, 227, 174, 172, 185, 168, 170, 162, 191, 180, 227, 143, 159, 130, 154, 158, 140, 143, 129, 136 }, 205));
                _0xbe52daf9.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[11] { 28, 11, 3, 1, 24, 11, 43, 22, 26, 28, 15 }, 110), _0xe0d57b82._0x6813c1ab(new byte[20] { 187, 171, 182, 174, 170, 188, 171, 134, 191, 184, 181, 181, 187, 184, 186, 178, 134, 172, 171, 181 }, 217));
                if (_0xbe52daf9.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[15] { 56, 47, 57, 37, 38, 60, 47, 11, 41, 62, 35, 60, 35, 62, 51 }, 74), _0x2f99b94d) != null)
                {
                    WLog(_0xe0d57b82._0x6813c1ab(new byte[24] { 215, 252, 230, 251, 249, 241, 216, 253, 255, 241, 180, 251, 228, 241, 250, 180, 253, 250, 224, 241, 250, 224, 174, 180 }, 148) + _0x956802e5);
                    _0xbe52daf9.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[8] { 194, 199, 199, 229, 207, 194, 196, 208 }, 163), 0x10000000);
                    _0x7060638a.Call(_0xe0d57b82._0x6813c1ab(new byte[13] { 252, 251, 238, 253, 251, 206, 236, 251, 230, 249, 230, 251, 246 }, 143), _0xbe52daf9);
                    return true;
                }

                if (_0x0b464120(_0x650a3d4b))
                    return true;
                if (!string.IsNullOrEmpty(_0xd79d5890))
                {
                    WLog(_0xe0d57b82._0x6813c1ab(new byte[28] { 210, 249, 227, 254, 252, 244, 221, 248, 250, 244, 177, 248, 255, 229, 244, 255, 229, 177, 247, 240, 253, 253, 243, 240, 242, 250, 171, 177 }, 145) + _0xd79d5890);
                    if (_0x6fddbc76(_0xd79d5890))
                        return _0x5081e008(_0xd79d5890, _0x650a3d4b);
                    return _0x329f33d8(_0xd79d5890);
                }

                WLog(_0xe0d57b82._0x6813c1ab(new byte[30] { 58, 17, 11, 22, 20, 28, 53, 16, 18, 28, 89, 16, 23, 13, 28, 23, 13, 89, 23, 22, 89, 17, 24, 23, 29, 21, 28, 11, 67, 89 }, 121) + _0x956802e5);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xe0d57b82._0x6813c1ab(new byte[26] { 3, 40, 50, 47, 45, 37, 12, 41, 43, 37, 96, 41, 46, 52, 37, 46, 52, 96, 38, 33, 41, 44, 37, 36, 122, 96 }, 64) + e.Message);
            return true;
        }
    }

    private string _0x3adbf2d0()
    {
        string _0x63c6795b = _0xe0d57b82._0x6813c1ab(new byte[62] { 167, 164, 165, 162, 163, 160, 161, 174, 175, 172, 173, 170, 171, 168, 169, 182, 183, 180, 181, 178, 179, 176, 177, 190, 191, 188, 135, 132, 133, 130, 131, 128, 129, 142, 143, 140, 141, 138, 139, 136, 137, 150, 151, 148, 149, 146, 147, 144, 145, 158, 159, 156, 246, 247, 244, 245, 242, 243, 240, 241, 254, 255 }, 198);
        System.Random _0x1bc99f2d = new System.Random();
        int _0x3aca5f6b = _0x1bc99f2d.Next(8, 16);
        return new string (Enumerable.Repeat(_0x63c6795b, _0x3aca5f6b).Select(_0x0b288ebf => _0x0b288ebf[_0x1bc99f2d.Next(_0x0b288ebf.Length)]).ToArray());
    }

    private async Task _0x709482ba(string _0x2c616105)
    {
        if (_0xa9953aa3 || string.IsNullOrEmpty(_0x8b431dce) || string.IsNullOrEmpty(_0x2c616105) || _0xa4abc339)
            return;
        _0xa9953aa3 = true;
        try
        {
            JObject _0xd2454cdf = BuildRandomPayload(_0x2c616105, _0x8b431dce, _0x3a98ef0b());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x2c616105} payload: {_0xd2454cdf}");
                }
#endif
            }

            var _0x492c1ede = _0xb498a92f(_0xd2454cdf.ToString(), _0x8b431dce);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xe0d57b82._0x6813c1ab(new byte[4] { 91, 88, 86, 83 }, 55) + _0x8b431dce, _0x492c1ede } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[24] { 78, 65, 80, 70, 65, 72, 53, 89, 122, 116, 113, 53, 101, 116, 102, 102, 53, 112, 103, 103, 122, 103, 47, 53 }, 21) + e.Message);
#endif
            }
        }
    }

    private bool _0xa4abc339 = false;
    private string _0x29a92605()
    {
        try
        {
            using (var _0x2627b35a = new AndroidJavaClass(_0xe0d57b82._0x6813c1ab(new byte[30] { 140, 128, 130, 193, 154, 129, 134, 155, 150, 220, 139, 193, 159, 131, 142, 150, 138, 157, 193, 186, 129, 134, 155, 150, 191, 131, 142, 150, 138, 157 }, 239)))
            {
                var _0x1f086db2 = _0x2627b35a.GetStatic<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[15] { 45, 59, 60, 60, 43, 32, 58, 15, 45, 58, 39, 56, 39, 58, 55 }, 78));
                var _0xfd431a39 = _0x1f086db2.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[21] { 32, 34, 51, 6, 55, 55, 43, 46, 36, 38, 51, 46, 40, 41, 4, 40, 41, 51, 34, 63, 51 }, 71));
                using (var _0x06b7a274 = new AndroidJavaClass(_0xe0d57b82._0x6813c1ab(new byte[26] { 251, 244, 254, 232, 245, 243, 254, 180, 237, 255, 248, 241, 243, 238, 180, 205, 255, 248, 201, 255, 238, 238, 243, 244, 253, 233 }, 154)))
                {
                    return _0x06b7a274.CallStatic<string>(_0xe0d57b82._0x6813c1ab(new byte[19] { 235, 233, 248, 200, 233, 234, 237, 249, 224, 248, 217, 255, 233, 254, 205, 235, 233, 226, 248 }, 140), _0xfd431a39);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private void _0xf74f71c7(string _0x10608074)
    {
        Dictionary<string, object> _0x989f8aea;
        try
        {
            _0x989f8aea = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x10608074);
        }
        catch
        {
            return;
        }

        var _0x4a52189e = ReadPushField(_0x989f8aea, _0xe0d57b82._0x6813c1ab(new byte[3] { 93, 90, 68 }, 40));
        if (string.IsNullOrWhiteSpace(_0x4a52189e))
            return;
        _0x4a52189e = _0x4a52189e.Trim();
        if (!IsHttpUrl(_0x4a52189e))
            return;
        if (string.Equals(_0x4a52189e, _0x2e2099ee, StringComparison.Ordinal))
            return;
        _0x2e2099ee = _0x4a52189e;
        OpenUrlExternally(_0x4a52189e);
    }

    private string _0xa6af707a = "";
    internal bool _0x6fddbc76(string _0x07e81e27)
    {
        return _0x07e81e27.StartsWith(_0xe0d57b82._0x6813c1ab(new byte[9] { 84, 88, 75, 82, 92, 77, 3, 22, 22 }, 57), StringComparison.OrdinalIgnoreCase) || _0x07e81e27.StartsWith(_0xe0d57b82._0x6813c1ab(new byte[24] { 155, 135, 135, 131, 128, 201, 220, 220, 131, 159, 146, 138, 221, 148, 156, 156, 148, 159, 150, 221, 144, 156, 158, 220 }, 243), StringComparison.OrdinalIgnoreCase) || _0x07e81e27.StartsWith(_0xe0d57b82._0x6813c1ab(new byte[23] { 6, 26, 26, 30, 84, 65, 65, 30, 2, 15, 23, 64, 9, 1, 1, 9, 2, 11, 64, 13, 1, 3, 65 }, 110), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0x0ace5588 = false;
    private void _0x94250e1a()
    {
        WLog(_0xe0d57b82._0x6813c1ab(new byte[21] { 144, 185, 170, 188, 175, 185, 170, 189, 248, 186, 185, 187, 179, 248, 168, 170, 189, 171, 171, 189, 188 }, 216));
        if (Time.frameCount == _0xfb144216)
            return;
        _0xfb144216 = Time.frameCount;
        if (_0xeec80f76())
            return;
        _0xb06c9a82();
    }

    private Task _0xf0dee45e(IEnumerator _0x79907794)
    {
        var _0x7f135330 = new TaskCompletionSource<bool>();
        StartCoroutine(_0xe1dcccd9(_0x79907794, _0x7f135330));
        return _0x7f135330.Task;
    }

    private string _0x55d47229 = "";
    // WEB VIEW LOGIC END
    internal void _0x6ef45029()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xc589978b = new AndroidNotificationChannel
        {
            Id = _0xe0d57b82._0x6813c1ab(new byte[15] { 1, 0, 3, 4, 16, 9, 17, 58, 6, 13, 4, 11, 11, 0, 9 }, 101),
            Name = _0xe0d57b82._0x6813c1ab(new byte[15] { 72, 105, 106, 109, 121, 96, 120, 44, 79, 100, 109, 98, 98, 105, 96 }, 12),
            Importance = Importance.High,
            Description = _0xe0d57b82._0x6813c1ab(new byte[21] { 247, 213, 222, 213, 194, 209, 220, 144, 222, 223, 196, 217, 214, 217, 211, 209, 196, 217, 223, 222, 195 }, 176)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xc589978b);
        // Build notification
        var _0x29cb2d98 = new AndroidNotification
        {
            Title = _0xe8038565[UnityEngine.Random.Range(0, _0xe8038565.Length)],
            Text = _0xe0d57b82._0x6813c1ab(new byte[21] { 39, 20, 3, 70, 31, 9, 19, 70, 21, 19, 20, 3, 70, 18, 9, 70, 3, 30, 15, 18, 89 }, 102),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x29cb2d98, _0xe0d57b82._0x6813c1ab(new byte[15] { 138, 139, 136, 143, 155, 130, 154, 177, 141, 134, 143, 128, 128, 139, 130 }, 238));
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x21165c39 = null;
    private IEnumerator _0x4aac01b4()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[26] { 142, 129, 176, 166, 161, 136, 245, 156, 187, 188, 161, 188, 180, 185, 188, 175, 176, 135, 176, 179, 179, 176, 167, 176, 167, 245 }, 213));
            }
#endif
        }

        bool _0xa78c0092 = false;
        InstallReferrer.GetReferrer((_0x5bb1f4e8) =>
        {
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[24] { 45, 34, 19, 5, 2, 86, 36, 19, 16, 19, 4, 4, 19, 4, 43, 86, 17, 19, 2, 86, 148, 240, 228, 86 }, 118) + _0xecf746fb);
            if (_0x5bb1f4e8.IsSuccess)
            {
                _0xecf746fb = _0x5bb1f4e8.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[28] { 106, 101, 84, 66, 69, 17, 99, 84, 87, 84, 67, 67, 84, 67, 108, 17, 98, 68, 82, 82, 84, 66, 66, 17, 211, 183, 163, 17 }, 49) + _0xecf746fb);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[27] { 28, 19, 34, 52, 51, 103, 21, 34, 33, 34, 53, 53, 34, 53, 26, 103, 1, 38, 46, 43, 34, 35, 103, 165, 193, 213, 103 }, 71) + _0x5bb1f4e8);
#endif
                }

                _0xecf746fb = "";
            }

            _0x2e12ed0c = true;
        });
        StartCoroutine(_0xa56451d6(2f));
        yield return new WaitUntil(() => _0x2e12ed0c);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xecf746fb}");
#endif
        }

        bool _0x0554c3eb = _0xecf746fb.Contains(_0xe0d57b82._0x6813c1ab(new byte[6] { 173, 169, 166, 163, 174, 247 }, 202));
        _0xa78c0092 = _0x0554c3eb || _0xecf746fb.Contains(_0xe0d57b82._0x6813c1ab(new byte[18] { 255, 238, 238, 237, 176, 247, 240, 237, 234, 255, 249, 236, 255, 243, 176, 253, 241, 243 }, 158)) || _0xecf746fb.Contains(_0xe0d57b82._0x6813c1ab(new byte[17] { 183, 166, 166, 165, 248, 176, 183, 181, 179, 180, 185, 185, 189, 248, 181, 185, 187 }, 214));
        _0xb49d32f8 = _0x0554c3eb ? "" : (_0xa78c0092 ? "" : _0xb49d32f8);
        _0xb49d32f8 = _0xb49d32f8 ?? "";
        _0x6557de6f = _0x6557de6f ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0xb49d32f8}");
#endif
        }
    }

    private void _0xc338149d()
    {
        {
#if B_LOGS
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[22] { 47, 32, 17, 7, 0, 41, 84, 39, 0, 27, 6, 17, 48, 17, 2, 29, 23, 17, 61, 26, 18, 27 }, 116));
#endif
        }

        _0xebfa8c49 = SystemInfo.deviceModel;
        _0x391bcec7 = Application.version;
        _0x07643d27 = Application.installMode;
        _0x2b1203cd = Application.installerName;
        _0x55d47229 = Application.identifier;
        _0x867bd0d7 = _0xaef17ec1();
        _0x41190e43 = _0x29a92605();
        _0x981a0eb2 = SystemInfo.deviceUniqueIdentifier;
        _0x09e22361 = SystemInfo.graphicsDeviceName;
        _0x88ab39e9 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x391bcec7 = _0xe0d57b82._0x6813c1ab(new byte[5] { 126, 103, 126, 103, 126 }, 73);
                _0x07643d27 = ApplicationInstallMode.Store;
                _0x2b1203cd = _0xe0d57b82._0x6813c1ab(new byte[19] { 7, 11, 9, 74, 5, 10, 0, 22, 11, 13, 0, 74, 18, 1, 10, 0, 13, 10, 3 }, 100);
                _0x41190e43 = _0xe0d57b82._0x6813c1ab(new byte[8] { 255, 247, 234, 238, 227, 186, 239, 251 }, 154);
                _0x981a0eb2 = Guid.NewGuid().ToString().Replace(_0xe0d57b82._0x6813c1ab(new byte[1] { 35 }, 14), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[17] { 22, 25, 40, 62, 57, 16, 109, 41, 40, 59, 0, 34, 41, 40, 33, 119, 109 }, 77) + _0xebfa8c49);
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[19] { 1, 14, 63, 41, 46, 7, 122, 59, 42, 42, 12, 63, 40, 41, 51, 53, 52, 96, 122 }, 90) + _0x391bcec7);
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[20] { 254, 241, 192, 214, 209, 248, 133, 204, 203, 214, 209, 196, 201, 201, 232, 202, 193, 192, 159, 133 }, 165) + _0x07643d27);
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[23] { 252, 243, 194, 212, 211, 250, 135, 206, 201, 212, 211, 198, 203, 203, 194, 213, 244, 211, 200, 213, 194, 157, 135 }, 167) + _0x2b1203cd);
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[14] { 237, 226, 211, 197, 194, 235, 150, 215, 198, 198, 255, 210, 140, 150 }, 182) + _0x55d47229);
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[14] { 98, 109, 92, 74, 77, 100, 25, 88, 93, 79, 112, 93, 3, 25 }, 57) + _0x867bd0d7);
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[18] { 131, 140, 189, 171, 172, 133, 248, 173, 171, 189, 170, 153, 191, 189, 182, 172, 226, 248 }, 216) + _0x41190e43);
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[17] { 144, 159, 174, 184, 191, 150, 235, 184, 178, 184, 143, 174, 189, 130, 175, 241, 235 }, 203) + _0x981a0eb2);
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[12] { 25, 22, 39, 49, 54, 31, 98, 37, 50, 55, 120, 98 }, 66) + _0x09e22361);
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[12] { 190, 177, 128, 150, 145, 184, 197, 134, 149, 144, 223, 197 }, 229) + _0x88ab39e9);
#endif
        }
    }

    private async Task _0x3ce6112f()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xd5687a72 = _0xe0d57b82._0x6813c1ab(new byte[5] { 98, 101, 104, 119, 97 }, 4);
        _0xb53a2ec2 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x97b08d00 = DateTime.UtcNow.Ticks.ToString();
        _0x684b637c = "";
        JObject _0x48ab6ba0 = BuildRandomPayload(_0x55d47229, _0xe4da699c, _0x867bd0d7, _0x459edd9d, _0xecf746fb, _0xb49d32f8, _0x6557de6f, _0x41190e43, _0xa6af707a, _0x981a0eb2, _0xd5687a72, _0x684b637c, _0xebfa8c49, _0x391bcec7, _0x07643d27.ToString(), _0x2b1203cd, _0x97b08d00, _0xb53a2ec2, _0x8b431dce, _0x09e22361, _0x88ab39e9, _0x95b68b9f, _0x3a98ef0b());
        var _0x60f05884 = _0xb498a92f(_0x48ab6ba0.ToString(), _0x8b431dce);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x48ab6ba0}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xe0d57b82._0x6813c1ab(new byte[7] { 100, 117, 109, 120, 123, 117, 112 }, 20) + _0x8b431dce, _0x60f05884 } });
            await Task.Delay(500);
            string _0xc56fafeb = "";
            for (int _0x2437c288 = 0; _0x2437c288 < 20; _0x2437c288++)
            {
                if (await _0x212f4373(1, 1))
                {
                    await _0x709482ba(_0xe0d57b82._0x6813c1ab(new byte[7] { 200, 198, 197, 201, 193, 207, 206 }, 170));
                    _0x0f48b8f4();
                    return;
                }

                _0xc56fafeb = await _0x0e9a9f68(1, 500);
                if (!string.IsNullOrEmpty(_0xc56fafeb))
                    break;
            }

            _0x113f8d64(_0xc56fafeb);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[22] { 47, 32, 49, 39, 32, 41, 84, 51, 17, 26, 17, 6, 21, 24, 84, 17, 6, 6, 27, 6, 78, 84 }, 116) + e.Message);
#endif
            }

            _0x0f48b8f4();
        }
    }

    private static bool IsPrivacyItemTrue(Item _0xff542938)
    {
        if (_0xff542938.Key != _0xe0d57b82._0x6813c1ab(new byte[9] { 9, 19, 48, 18, 9, 22, 1, 3, 25 }, 96))
            return false;
        try
        {
            var _0xc2327c8c = _0xff542938.Value.GetAs<object>();
            return _0xc2327c8c switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    internal Vector2 lastSize = Vector2.zero;
    internal bool ContainsIgnoreCase(string _0x1ab4bd9b, string _0x959a9a0d)
    {
        if (string.IsNullOrEmpty(_0x1ab4bd9b) || string.IsNullOrEmpty(_0x959a9a0d))
            return false;
        return _0x1ab4bd9b.IndexOf(_0x959a9a0d, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal bool isApplicationPause = false;
    private string _0xfec67b3f()
    {
        return _0xe0d57b82._0x6813c1ab(new byte[12] { 72, 6, 21, 14, 3, 20, 9, 15, 14, 72, 73, 27 }, 96) + _0xe0d57b82._0x6813c1ab(new byte[8] { 227, 244, 231, 181, 224, 244, 168, 178 }, 149) + WindowsDesktopUserAgent + _0xe0d57b82._0x6813c1ab(new byte[2] { 82, 78 }, 117) + _0xe0d57b82._0x6813c1ab(new byte[30] { 72, 95, 76, 30, 78, 76, 81, 74, 81, 3, 112, 95, 72, 87, 89, 95, 74, 81, 76, 16, 78, 76, 81, 74, 81, 74, 71, 78, 91, 5 }, 62) + _0xe0d57b82._0x6813c1ab(new byte[121] { 133, 150, 141, 128, 151, 138, 140, 141, 195, 135, 134, 133, 203, 140, 129, 137, 207, 136, 134, 154, 207, 149, 130, 143, 202, 152, 151, 145, 154, 152, 172, 129, 137, 134, 128, 151, 205, 135, 134, 133, 138, 141, 134, 179, 145, 140, 147, 134, 145, 151, 154, 203, 140, 129, 137, 207, 136, 134, 154, 207, 152, 132, 134, 151, 217, 133, 150, 141, 128, 151, 138, 140, 141, 203, 202, 152, 145, 134, 151, 150, 145, 141, 195, 149, 130, 143, 216, 158, 207, 128, 140, 141, 133, 138, 132, 150, 145, 130, 129, 143, 134, 217, 151, 145, 150, 134, 158, 202, 216, 158, 128, 130, 151, 128, 139, 203, 134, 202, 152, 158, 158 }, 227) + _0xe0d57b82._0x6813c1ab(new byte[26] { 90, 91, 88, 22, 78, 76, 81, 74, 81, 18, 25, 75, 77, 91, 76, 127, 89, 91, 80, 74, 25, 18, 75, 95, 23, 5 }, 62) + _0xe0d57b82._0x6813c1ab(new byte[130] { 251, 250, 249, 183, 239, 237, 240, 235, 240, 179, 184, 254, 239, 239, 201, 250, 237, 236, 246, 240, 241, 184, 179, 184, 170, 177, 175, 191, 183, 200, 246, 241, 251, 240, 232, 236, 191, 209, 203, 191, 174, 175, 177, 175, 164, 191, 200, 246, 241, 169, 171, 164, 191, 231, 169, 171, 182, 191, 222, 239, 239, 243, 250, 200, 250, 253, 212, 246, 235, 176, 170, 172, 168, 177, 172, 169, 191, 183, 212, 215, 203, 210, 211, 179, 191, 243, 246, 244, 250, 191, 216, 250, 252, 244, 240, 182, 191, 220, 247, 237, 240, 242, 250, 176, 174, 173, 175, 177, 175, 177, 175, 177, 175, 191, 204, 254, 249, 254, 237, 246, 176, 170, 172, 168, 177, 172, 169, 184, 182, 164 }, 159) + _0xe0d57b82._0x6813c1ab(new byte[30] { 222, 223, 220, 146, 202, 200, 213, 206, 213, 150, 157, 202, 214, 219, 206, 220, 213, 200, 215, 157, 150, 157, 237, 211, 212, 137, 136, 157, 147, 129 }, 186) + _0xe0d57b82._0x6813c1ab(new byte[34] { 103, 102, 101, 43, 115, 113, 108, 119, 108, 47, 36, 117, 102, 109, 103, 108, 113, 36, 47, 36, 68, 108, 108, 100, 111, 102, 35, 74, 109, 96, 45, 36, 42, 56 }, 3) + _0xe0d57b82._0x6813c1ab(new byte[30] { 116, 117, 118, 56, 96, 98, 127, 100, 127, 60, 55, 125, 113, 104, 68, 127, 101, 115, 120, 64, 127, 121, 126, 100, 99, 55, 60, 32, 57, 43 }, 16) + _0xe0d57b82._0x6813c1ab(new byte[449] { 11, 13, 6, 4, 9, 30, 13, 95, 10, 30, 27, 66, 4, 29, 13, 30, 17, 27, 12, 69, 36, 4, 29, 13, 30, 17, 27, 69, 88, 60, 23, 13, 16, 18, 22, 10, 18, 88, 83, 9, 26, 13, 12, 22, 16, 17, 69, 88, 78, 77, 79, 88, 2, 83, 4, 29, 13, 30, 17, 27, 69, 88, 56, 16, 16, 24, 19, 26, 95, 60, 23, 13, 16, 18, 26, 88, 83, 9, 26, 13, 12, 22, 16, 17, 69, 88, 78, 77, 79, 88, 2, 83, 4, 29, 13, 30, 17, 27, 69, 88, 49, 16, 11, 66, 62, 64, 61, 13, 30, 17, 27, 88, 83, 9, 26, 13, 12, 22, 16, 17, 69, 88, 77, 75, 88, 2, 34, 83, 18, 16, 29, 22, 19, 26, 69, 25, 30, 19, 12, 26, 83, 15, 19, 30, 11, 25, 16, 13, 18, 69, 88, 40, 22, 17, 27, 16, 8, 12, 88, 83, 24, 26, 11, 55, 22, 24, 23, 58, 17, 11, 13, 16, 15, 6, 41, 30, 19, 10, 26, 12, 69, 25, 10, 17, 28, 11, 22, 16, 17, 87, 86, 4, 13, 26, 11, 10, 13, 17, 95, 47, 13, 16, 18, 22, 12, 26, 81, 13, 26, 12, 16, 19, 9, 26, 87, 4, 30, 13, 28, 23, 22, 11, 26, 28, 11, 10, 13, 26, 69, 88, 7, 71, 73, 88, 83, 29, 22, 11, 17, 26, 12, 12, 69, 88, 73, 75, 88, 83, 18, 16, 29, 22, 19, 26, 69, 25, 30, 19, 12, 26, 83, 18, 16, 27, 26, 19, 69, 88, 88, 83, 15, 19, 30, 11, 25, 16, 13, 18, 69, 88, 40, 22, 17, 27, 16, 8, 12, 88, 83, 15, 19, 30, 11, 25, 16, 13, 18, 41, 26, 13, 12, 22, 16, 17, 69, 88, 78, 74, 81, 79, 81, 79, 88, 83, 10, 30, 57, 10, 19, 19, 41, 26, 13, 12, 22, 16, 17, 69, 88, 78, 77, 79, 81, 79, 81, 79, 81, 79, 88, 2, 86, 68, 2, 2, 68, 48, 29, 21, 26, 28, 11, 81, 27, 26, 25, 22, 17, 26, 47, 13, 16, 15, 26, 13, 11, 6, 87, 15, 13, 16, 11, 16, 83, 88, 10, 12, 26, 13, 62, 24, 26, 17, 11, 59, 30, 11, 30, 88, 83, 4, 24, 26, 11, 69, 25, 10, 17, 28, 11, 22, 16, 17, 87, 86, 4, 13, 26, 11, 10, 13, 17, 95, 10, 30, 27, 68, 2, 83, 28, 16, 17, 25, 22, 24, 10, 13, 30, 29, 19, 26, 69, 11, 13, 10, 26, 2, 86, 68, 2, 28, 30, 11, 28, 23, 87, 26, 86, 4, 2 }, 127) + _0xe0d57b82._0x6813c1ab(new byte[112] { 8, 9, 10, 68, 31, 15, 30, 9, 9, 2, 64, 75, 27, 5, 8, 24, 4, 75, 64, 93, 85, 94, 92, 69, 87, 8, 9, 10, 68, 31, 15, 30, 9, 9, 2, 64, 75, 4, 9, 5, 11, 4, 24, 75, 64, 93, 92, 84, 92, 69, 87, 8, 9, 10, 68, 31, 15, 30, 9, 9, 2, 64, 75, 13, 26, 13, 5, 0, 59, 5, 8, 24, 4, 75, 64, 93, 85, 94, 92, 69, 87, 8, 9, 10, 68, 31, 15, 30, 9, 9, 2, 64, 75, 13, 26, 13, 5, 0, 36, 9, 5, 11, 4, 24, 75, 64, 93, 92, 88, 92, 69, 87 }, 108) + _0xe0d57b82._0x6813c1ab(new byte[45] { 1, 7, 12, 14, 2, 28, 27, 17, 26, 2, 91, 26, 27, 1, 26, 0, 22, 29, 6, 1, 20, 7, 1, 72, 0, 27, 17, 16, 19, 28, 27, 16, 17, 78, 8, 22, 20, 1, 22, 29, 93, 16, 92, 14, 8 }, 117) + _0xe0d57b82._0x6813c1ab(new byte[721] { 109, 107, 96, 98, 111, 120, 107, 57, 118, 107, 112, 126, 36, 110, 112, 119, 125, 118, 110, 55, 116, 120, 109, 122, 113, 84, 124, 125, 112, 120, 55, 123, 112, 119, 125, 49, 110, 112, 119, 125, 118, 110, 48, 34, 110, 112, 119, 125, 118, 110, 55, 116, 120, 109, 122, 113, 84, 124, 125, 112, 120, 36, 127, 108, 119, 122, 109, 112, 118, 119, 49, 104, 48, 98, 111, 120, 107, 57, 106, 36, 74, 109, 107, 112, 119, 126, 49, 104, 48, 55, 109, 118, 85, 118, 110, 124, 107, 90, 120, 106, 124, 49, 48, 34, 112, 127, 49, 106, 55, 112, 119, 125, 124, 97, 86, 127, 49, 62, 105, 118, 112, 119, 109, 124, 107, 35, 57, 122, 118, 120, 107, 106, 124, 62, 48, 39, 36, 41, 101, 101, 106, 55, 112, 119, 125, 124, 97, 86, 127, 49, 62, 113, 118, 111, 124, 107, 35, 57, 119, 118, 119, 124, 62, 48, 39, 36, 41, 101, 101, 106, 55, 112, 119, 125, 124, 97, 86, 127, 49, 62, 116, 120, 97, 52, 110, 112, 125, 109, 113, 62, 48, 39, 36, 41, 101, 101, 106, 55, 112, 119, 125, 124, 97, 86, 127, 49, 62, 116, 120, 97, 52, 125, 124, 111, 112, 122, 124, 52, 110, 112, 125, 109, 113, 62, 48, 39, 36, 41, 48, 107, 124, 109, 108, 107, 119, 57, 98, 116, 120, 109, 122, 113, 124, 106, 35, 127, 120, 117, 106, 124, 53, 116, 124, 125, 112, 120, 35, 104, 53, 118, 119, 122, 113, 120, 119, 126, 124, 35, 119, 108, 117, 117, 53, 120, 125, 125, 85, 112, 106, 109, 124, 119, 124, 107, 35, 127, 108, 119, 122, 109, 112, 118, 119, 49, 48, 98, 100, 53, 107, 124, 116, 118, 111, 124, 85, 112, 106, 109, 124, 119, 124, 107, 35, 127, 108, 119, 122, 109, 112, 118, 119, 49, 48, 98, 100, 53, 120, 125, 125, 92, 111, 124, 119, 109, 85, 112, 106, 109, 124, 119, 124, 107, 35, 127, 108, 119, 122, 109, 112, 118, 119, 49, 48, 98, 100, 53, 107, 124, 116, 118, 111, 124, 92, 111, 124, 119, 109, 85, 112, 106, 109, 124, 119, 124, 107, 35, 127, 108, 119, 122, 109, 112, 118, 119, 49, 48, 98, 100, 53, 125, 112, 106, 105, 120, 109, 122, 113, 92, 111, 124, 119, 109, 35, 127, 108, 119, 122, 109, 112, 118, 119, 49, 48, 98, 107, 124, 109, 108, 107, 119, 57, 127, 120, 117, 106, 124, 34, 100, 100, 34, 112, 127, 49, 106, 55, 112, 119, 125, 124, 97, 86, 127, 49, 62, 105, 118, 112, 119, 109, 124, 107, 35, 57, 127, 112, 119, 124, 62, 48, 39, 36, 41, 101, 101, 106, 55, 112, 119, 125, 124, 97, 86, 127, 49, 62, 113, 118, 111, 124, 107, 35, 57, 113, 118, 111, 124, 107, 62, 48, 39, 36, 41, 48, 107, 124, 109, 108, 107, 119, 57, 98, 116, 120, 109, 122, 113, 124, 106, 35, 109, 107, 108, 124, 53, 116, 124, 125, 112, 120, 35, 104, 53, 118, 119, 122, 113, 120, 119, 126, 124, 35, 119, 108, 117, 117, 53, 120, 125, 125, 85, 112, 106, 109, 124, 119, 124, 107, 35, 127, 108, 119, 122, 109, 112, 118, 119, 49, 48, 98, 100, 53, 107, 124, 116, 118, 111, 124, 85, 112, 106, 109, 124, 119, 124, 107, 35, 127, 108, 119, 122, 109, 112, 118, 119, 49, 48, 98, 100, 53, 120, 125, 125, 92, 111, 124, 119, 109, 85, 112, 106, 109, 124, 119, 124, 107, 35, 127, 108, 119, 122, 109, 112, 118, 119, 49, 48, 98, 100, 53, 107, 124, 116, 118, 111, 124, 92, 111, 124, 119, 109, 85, 112, 106, 109, 124, 119, 124, 107, 35, 127, 108, 119, 122, 109, 112, 118, 119, 49, 48, 98, 100, 53, 125, 112, 106, 105, 120, 109, 122, 113, 92, 111, 124, 119, 109, 35, 127, 108, 119, 122, 109, 112, 118, 119, 49, 48, 98, 107, 124, 109, 108, 107, 119, 57, 127, 120, 117, 106, 124, 34, 100, 100, 34, 107, 124, 109, 108, 107, 119, 57, 118, 107, 112, 126, 49, 104, 48, 34, 100, 34, 100, 122, 120, 109, 122, 113, 49, 124, 48, 98, 100 }, 25) + _0xe0d57b82._0x6813c1ab(new byte[5] { 164, 240, 241, 240, 226 }, 217);
    }

    public void _0x0f48b8f4()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[18] { 167, 168, 153, 143, 136, 161, 220, 176, 157, 137, 146, 159, 148, 220, 187, 157, 145, 153 }, 252));
#endif
        }

        _0xab64f467.Instance?._0xc09f38b5();
        _0x09adb88e.Instance._0xa62f490f(_0x53431849._0xfa200dc8.DEFAULT);
    }

    private bool _0x962821dd = false;
    private string _0x6557de6f { get; set; }

    private bool _0x5081e008(string _0x39d27062, string _0xa95d902b)
    {
        string _0xe96836d7 = _0x15ddf72a(_0x39d27062);
        if (string.IsNullOrEmpty(_0xe96836d7))
            _0xe96836d7 = _0xa95d902b;
        if (_0x0b464120(_0xe96836d7))
            return true;
        string _0x2477b768 = string.IsNullOrEmpty(_0xe96836d7) ? _0xe0d57b82._0x6813c1ab(new byte[29] { 95, 67, 67, 71, 68, 13, 24, 24, 71, 91, 86, 78, 25, 80, 88, 88, 80, 91, 82, 25, 84, 88, 90, 24, 68, 67, 88, 69, 82 }, 55) : _0xe0d57b82._0x6813c1ab(new byte[46] { 153, 133, 133, 129, 130, 203, 222, 222, 129, 157, 144, 136, 223, 150, 158, 158, 150, 157, 148, 223, 146, 158, 156, 222, 130, 133, 158, 131, 148, 222, 144, 129, 129, 130, 222, 149, 148, 133, 144, 152, 157, 130, 206, 152, 149, 204 }, 241) + _0xe96836d7;
        WLog(_0xe0d57b82._0x6813c1ab(new byte[35] { 89, 114, 104, 117, 119, 127, 86, 115, 113, 127, 58, 119, 123, 104, 113, 127, 110, 58, 124, 123, 118, 118, 120, 123, 121, 113, 58, 123, 105, 58, 109, 127, 120, 32, 58 }, 26) + _0x2477b768);
        return _0x329f33d8(_0x2477b768);
    }

    private bool _0x1f0716a0(int _0x4742f38e, string _0xf53e5505, string _0xa2f2e86d)
    {
        if (string.IsNullOrEmpty(_0xa2f2e86d))
            return false;
        if (!IsHttpUrl(_0xa2f2e86d))
            return true;
        if (string.IsNullOrEmpty(_0xf53e5505))
            return false;
        return _0xf53e5505.IndexOf(_0xe0d57b82._0x6813c1ab(new byte[20] { 175, 184, 184, 181, 169, 165, 164, 164, 175, 169, 190, 163, 165, 164, 181, 184, 175, 185, 175, 190 }, 234), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf53e5505.IndexOf(_0xe0d57b82._0x6813c1ab(new byte[22] { 223, 200, 200, 197, 217, 213, 212, 212, 223, 217, 206, 211, 213, 212, 197, 200, 223, 220, 207, 201, 223, 222 }, 154), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf53e5505.IndexOf(_0xe0d57b82._0x6813c1ab(new byte[21] { 130, 149, 149, 152, 132, 136, 137, 137, 130, 132, 147, 142, 136, 137, 152, 132, 139, 136, 148, 130, 131 }, 199), StringComparison.OrdinalIgnoreCase) >= 0 || _0xf53e5505.IndexOf(_0xe0d57b82._0x6813c1ab(new byte[22] { 119, 96, 96, 109, 103, 124, 121, 124, 125, 101, 124, 109, 103, 96, 126, 109, 97, 113, 122, 119, 127, 119 }, 50), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private readonly string[] _0xe8038565 = new string[]
    {
        _0xe0d57b82._0x6813c1ab(new byte[60] { 94, 49, 32, 30, 142, 250, 198, 203, 142, 220, 203, 203, 194, 221, 142, 207, 220, 203, 142, 198, 193, 218, 142, 220, 199, 201, 198, 218, 142, 192, 193, 217, 142, 76, 46, 61, 142, 202, 193, 192, 76, 46, 55, 218, 142, 195, 199, 221, 221, 142, 215, 193, 219, 220, 142, 221, 222, 199, 192, 143 }, 174),
        _0xe0d57b82._0x6813c1ab(new byte[52] { 33, 78, 92, 81, 241, 152, 165, 241, 178, 190, 164, 189, 181, 241, 179, 180, 241, 168, 190, 164, 163, 241, 189, 164, 178, 186, 168, 241, 188, 190, 188, 180, 191, 165, 241, 51, 81, 66, 241, 166, 185, 168, 241, 162, 165, 190, 161, 241, 191, 190, 166, 238 }, 209),
        _0xe0d57b82._0x6813c1ab(new byte[66] { 52, 76, 119, 57, 110, 89, 246, 148, 191, 177, 246, 161, 191, 184, 165, 246, 183, 164, 179, 246, 190, 191, 162, 162, 191, 184, 177, 246, 187, 185, 164, 179, 246, 185, 176, 162, 179, 184, 246, 162, 185, 178, 183, 175, 246, 52, 86, 69, 246, 165, 162, 183, 175, 246, 191, 184, 246, 162, 190, 179, 246, 177, 183, 187, 179, 248 }, 214),
        _0xe0d57b82._0x6813c1ab(new byte[54] { 105, 6, 12, 11, 185, 205, 241, 240, 234, 185, 240, 234, 185, 233, 235, 240, 244, 252, 185, 237, 240, 244, 252, 185, 123, 25, 10, 185, 237, 241, 252, 185, 251, 252, 234, 237, 185, 233, 245, 248, 224, 252, 235, 234, 185, 233, 245, 248, 224, 185, 247, 246, 238, 183 }, 153),
        _0xe0d57b82._0x6813c1ab(new byte[48] { 92, 51, 56, 9, 140, 245, 195, 217, 222, 140, 219, 197, 194, 194, 197, 194, 203, 140, 223, 216, 222, 201, 205, 199, 140, 207, 195, 217, 192, 200, 140, 206, 201, 140, 195, 194, 201, 140, 223, 220, 197, 194, 140, 205, 219, 205, 213, 130 }, 172),
        _0xe0d57b82._0x6813c1ab(new byte[65] { 30, 113, 116, 110, 206, 164, 143, 141, 133, 158, 129, 154, 157, 206, 143, 156, 139, 206, 131, 129, 156, 139, 206, 143, 141, 154, 135, 152, 139, 206, 154, 129, 128, 135, 137, 134, 154, 206, 12, 110, 125, 206, 157, 154, 143, 151, 206, 143, 128, 138, 206, 154, 156, 151, 206, 151, 129, 155, 156, 206, 130, 155, 141, 133, 192 }, 238),
        _0xe0d57b82._0x6813c1ab(new byte[55] { 130, 237, 252, 192, 82, 55, 4, 23, 0, 11, 82, 1, 2, 27, 28, 82, 17, 29, 7, 28, 6, 1, 82, 144, 242, 225, 82, 6, 26, 23, 82, 28, 23, 10, 6, 82, 29, 28, 23, 82, 17, 29, 7, 30, 22, 82, 16, 23, 82, 11, 29, 7, 0, 1, 92 }, 114),
        _0xe0d57b82._0x6813c1ab(new byte[63] { 255, 176, 141, 242, 165, 146, 61, 77, 113, 124, 100, 120, 111, 110, 61, 111, 116, 122, 117, 105, 61, 115, 114, 106, 61, 124, 111, 120, 61, 106, 116, 115, 115, 116, 115, 122, 61, 255, 157, 142, 61, 121, 114, 115, 255, 157, 132, 105, 61, 106, 124, 113, 118, 61, 124, 106, 124, 100, 61, 100, 120, 105, 51 }, 29),
        _0xe0d57b82._0x6813c1ab(new byte[51] { 108, 3, 19, 26, 188, 211, 242, 240, 229, 188, 232, 244, 243, 239, 249, 188, 235, 244, 243, 188, 239, 232, 253, 229, 188, 245, 242, 188, 232, 244, 249, 188, 251, 253, 241, 249, 188, 235, 245, 242, 188, 232, 244, 249, 188, 236, 238, 245, 230, 249, 178 }, 156),
        _0xe0d57b82._0x6813c1ab(new byte[64] { 181, 205, 246, 184, 239, 216, 119, 26, 56, 58, 50, 57, 35, 34, 58, 119, 62, 36, 119, 50, 33, 50, 37, 46, 35, 63, 62, 57, 48, 119, 181, 215, 196, 119, 60, 50, 50, 39, 119, 36, 39, 62, 57, 57, 62, 57, 48, 119, 49, 56, 37, 119, 46, 56, 34, 37, 119, 52, 63, 54, 57, 52, 50, 121 }, 87)
    };
    internal void Update()
    {
        if (_0x21165c39 == null)
            return;
        if (_0x6757d403())
            _0x94250e1a();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x9f5678f6();
        if (_0xe5928f7c && _0xf69eb13a != null)
            _0xf69eb13a.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private bool OpenUrlExternally(string _0x609fdf8e)
    {
        return _0x329f33d8(_0x609fdf8e);
    }

    private async Task<bool> _0xe9d44cbc()
    {
        {
#if B_LOGS
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[29] { 101, 106, 91, 77, 74, 99, 30, 119, 77, 110, 76, 87, 72, 95, 93, 71, 127, 80, 90, 109, 95, 72, 91, 90, 125, 86, 91, 93, 85 }, 62));
#endif
        }

        string _0x5b423563 = "";
        for (int _0xc86da390 = 0; _0xc86da390 < 2; _0xc86da390++)
        {
            if (await _0x212f4373(1, 100))
            {
                await _0x709482ba(_0xe0d57b82._0x6813c1ab(new byte[7] { 20, 26, 25, 21, 29, 19, 18 }, 118));
                _0x0f48b8f4();
                return true;
            }

            _0x5b423563 = await _0x0e9a9f68(1, 100);
            if (!string.IsNullOrEmpty(_0x5b423563))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x5b423563))
            {
                if (!string.IsNullOrEmpty(_0x04446fcc))
                {
                    _0x5b423563 = _0x6ef46a88(_0x5b423563, _0x04446fcc);
                    {
#if B_LOGS
                        Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[53] { 133, 138, 187, 173, 170, 131, 254, 157, 191, 189, 182, 187, 186, 254, 184, 183, 176, 191, 178, 139, 172, 178, 254, 169, 183, 170, 182, 254, 173, 187, 176, 186, 183, 186, 254, 60, 88, 76, 254, 173, 182, 177, 169, 254, 137, 187, 188, 136, 183, 187, 169, 228, 254 }, 222) + _0x5b423563);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[39] { 136, 135, 182, 160, 167, 142, 243, 144, 178, 176, 187, 182, 183, 243, 181, 186, 189, 178, 191, 134, 161, 191, 243, 49, 85, 65, 243, 160, 187, 188, 164, 243, 132, 182, 177, 133, 186, 182, 164 }, 211));
#endif
                    }
                }

                _0xa4abc339 = true;
                _0x97ab7ade(_0x5b423563);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[44] { 125, 114, 67, 85, 82, 123, 6, 99, 94, 69, 67, 86, 82, 79, 73, 72, 6, 81, 78, 79, 74, 67, 6, 69, 78, 67, 69, 77, 79, 72, 65, 6, 85, 71, 80, 67, 66, 6, 74, 79, 72, 77, 28, 6 }, 38) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private void _0x131151d8(string _0xf164de67)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[34] { 237, 226, 211, 197, 194, 235, 150, 240, 211, 194, 213, 222, 150, 243, 206, 194, 196, 215, 150, 230, 195, 197, 222, 150, 242, 215, 194, 215, 150, 228, 215, 193, 140, 150 }, 182) + _0xf164de67);
#endif
            }
        }

        var _0xbfab1cd2 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xf164de67);
        StartCoroutine(_0x6f450659(_0xbfab1cd2));
    }

    private void _0x97ab7ade(string _0x6bb44790)
    {
        _0xa3152ec6();
        StartCoroutine(_0xc5c3a31a(_0x6bb44790));
    }

    private string _0xe4da699c = "";
    private float _0xbf73744c = 0f;
    private int _0x2a433706 = 0;
    private string _0x3a98ef0b()
    {
        float _0x8e6f2f5e = Time.realtimeSinceStartup;
        if (_0x8e6f2f5e < 0f)
            _0x8e6f2f5e = 0f;
        int _0x192f0d50 = (int)(_0x8e6f2f5e * 1000f);
        int _0x7af606ee = _0x192f0d50 / 60000;
        int _0x97f8f3ae = (_0x192f0d50 / 1000) % 60;
        int _0x4ac2203a = _0x192f0d50 % 1000;
        return string.Format(_0xe0d57b82._0x6813c1ab(new byte[21] { 181, 254, 244, 254, 254, 179, 244, 181, 255, 244, 254, 254, 179, 244, 181, 252, 244, 254, 254, 254, 179 }, 206), _0x7af606ee, _0x97f8f3ae, _0x4ac2203a);
    }

    private string _0x867bd0d7 = "";
    private string _0x41190e43 = "";
    private async Task<bool> _0x96ae0ae7()
    {
        _0xab64f467.Instance?._0x7a9b64d0();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x6d905963) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[32] { 247, 248, 201, 223, 216, 241, 140, 249, 194, 197, 216, 213, 140, 252, 217, 223, 196, 140, 226, 195, 216, 197, 202, 197, 207, 205, 216, 197, 195, 194, 150, 140 }, 172) + string.Join(_0xe0d57b82._0x6813c1ab(new byte[1] { 151 }, 158), _0x6d905963));
                }
#endif
            }
        };
        try
        {
            _0x459edd9d = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[31] { 249, 246, 199, 209, 214, 255, 130, 228, 195, 203, 206, 199, 198, 130, 214, 205, 130, 197, 199, 214, 130, 210, 215, 209, 202, 130, 214, 205, 201, 199, 204 }, 162));
                }
#endif
            }

            _0x459edd9d = "";
        }

        _0x1ef25ce0 = !string.IsNullOrEmpty(_0x459edd9d);
        _0x95b68b9f = _0x3a98ef0b();
        {
#if B_LOGS
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[25] { 195, 204, 253, 235, 236, 197, 184, 205, 246, 241, 236, 225, 184, 200, 237, 235, 240, 184, 204, 247, 243, 253, 246, 162, 184 }, 152) + _0x459edd9d);
#endif
        }

        _0xab64f467.Instance?._0x7f027923();
        return false;
    }

    internal bool firstLoadShown = false;
    private string _0x2b1203cd = "";
    private void _0x221055cf(string _0x9153312f)
    {
        if (string.IsNullOrEmpty(_0x9153312f))
            return;
        if (TryOpenExternalLikeChrome(_0x9153312f))
            return;
        OpenUrlExternally(_0x9153312f);
    }

    internal Button _0xb1e2ea7c(string _0x1d35ae91, Transform _0xaceebd2c)
    {
        var _0x1c2ebd71 = new GameObject(_0x1d35ae91 + _0xe0d57b82._0x6813c1ab(new byte[3] { 117, 67, 89 }, 55), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x19a95f19 = _0x1c2ebd71.GetComponent<RectTransform>();
        _0x19a95f19.SetParent(_0xaceebd2c, false);
        var _0xd1b830e4 = _0x1c2ebd71.GetComponent<Image>();
        _0xd1b830e4.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x4da2d987 = _0x1c2ebd71.GetComponent<Button>();
        var _0x8aba24be = _0x4da2d987.colors;
        _0x8aba24be.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x8aba24be.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x4da2d987.colors = _0x8aba24be;
        var _0x0ceae964 = new GameObject(_0xe0d57b82._0x6813c1ab(new byte[4] { 159, 174, 179, 191 }, 203), typeof(RectTransform), typeof(Text));
        var _0x5e94c33a = _0x0ceae964.GetComponent<RectTransform>();
        _0x5e94c33a.SetParent(_0x1c2ebd71.transform, false);
        _0x5e94c33a.anchorMin = Vector2.zero;
        _0x5e94c33a.anchorMax = Vector2.one;
        _0x5e94c33a.offsetMin = _0x5e94c33a.offsetMax = Vector2.zero;
        var _0x9726ede2 = _0x0ceae964.GetComponent<Text>();
        _0x9726ede2.text = _0x1d35ae91;
        _0x9726ede2.alignment = TextAnchor.MiddleCenter;
        _0x9726ede2.color = Color.black;
        _0x9726ede2.font = Resources.GetBuiltinResource<Font>(_0xe0d57b82._0x6813c1ab(new byte[9] { 34, 17, 10, 2, 15, 77, 23, 23, 5 }, 99));
        _0x9726ede2.fontSize = 28;
        WLog(_0xe0d57b82._0x6813c1ab(new byte[14] { 241, 192, 215, 211, 198, 215, 240, 199, 198, 198, 221, 220, 146, 149 }, 178) + _0x1d35ae91 + _0xe0d57b82._0x6813c1ab(new byte[1] { 79 }, 104));
        return _0x4da2d987;
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x91b241fa)
    {
        if (_0x91b241fa == null || _0x91b241fa.Extra == null)
            return null;
        object _0xe37994bf;
        if (!_0x91b241fa.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xe37994bf))
            return null;
        return _0xe37994bf as string;
    }

    private static readonly string WindowsDesktopUserAgent = _0xe0d57b82._0x6813c1ab(new byte[111] { 165, 135, 146, 129, 132, 132, 137, 199, 221, 198, 216, 200, 192, 191, 129, 134, 140, 135, 159, 155, 200, 166, 188, 200, 217, 216, 198, 216, 211, 200, 191, 129, 134, 222, 220, 211, 200, 144, 222, 220, 193, 200, 169, 152, 152, 132, 141, 191, 141, 138, 163, 129, 156, 199, 221, 219, 223, 198, 219, 222, 200, 192, 163, 160, 188, 165, 164, 196, 200, 132, 129, 131, 141, 200, 175, 141, 139, 131, 135, 193, 200, 171, 128, 154, 135, 133, 141, 199, 217, 218, 216, 198, 216, 198, 216, 198, 216, 200, 187, 137, 142, 137, 154, 129, 199, 221, 219, 223, 198, 219, 222 }, 232);
    private bool _0xc4a0a58f()
    {
        _0x2320ffad.RemoveAll(_0x1190aa2f => _0x1190aa2f == null || !_0x1190aa2f.IsAlive);
        return _0x2320ffad.Count > 0;
    }

    private void _0x097dd575()
    {
        if (_0x32e206b1 != null)
            return;
        var _0xf30077f3 = _0xf9d90ea8();
        _0x32e206b1 = new GameObject(_0xe0d57b82._0x6813c1ab(new byte[14] { 155, 169, 174, 154, 165, 169, 187, 159, 188, 165, 162, 162, 169, 190 }, 204), typeof(RectTransform), typeof(Text));
        _0xf69eb13a = _0x32e206b1.GetComponent<RectTransform>();
        _0xf69eb13a.SetParent(_0xf30077f3.transform, false);
        _0xf69eb13a.anchorMin = new Vector2(0.5f, 0.5f);
        _0xf69eb13a.anchorMax = new Vector2(0.5f, 0.5f);
        _0xf69eb13a.pivot = new Vector2(0.5f, 0.5f);
        _0xf69eb13a.sizeDelta = new Vector2(600f, 600f);
        _0xf69eb13a.anchoredPosition = Vector2.zero;
        _0x22f3fd62 = _0x32e206b1.GetComponent<Text>();
        _0x22f3fd62.text = _0xe0d57b82._0x6813c1ab(new byte[1] { 13 }, 34);
        _0x22f3fd62.font = Resources.GetBuiltinResource<Font>(_0xe0d57b82._0x6813c1ab(new byte[17] { 220, 245, 247, 241, 243, 233, 194, 229, 254, 228, 249, 253, 245, 190, 228, 228, 246 }, 144));
        _0x22f3fd62.fontSize = 200;
        _0x22f3fd62.alignment = TextAnchor.MiddleCenter;
        _0x22f3fd62.color = Color.white;
        _0x22f3fd62.raycastTarget = false;
        _0x32e206b1.SetActive(false);
    }

    internal bool isApplicationFocus = false;
    private bool _0xbb969860 = false;
    private async Task _0xcb874c4a()
    {
        if (await _0x50d9c8e4())
            return;
        if (await _0x96ae0ae7())
            return;
        if (await _0xe9d44cbc())
            return;
        _0xc338149d();
        await _0xf0dee45e(_0x4aac01b4());
        _0xa6af707a = await _0x74dc7248();
        await _0x3ce6112f();
    }

    internal bool IsAboutBlank(string _0x2f7a9e4d)
    {
        if (string.IsNullOrEmpty(_0x2f7a9e4d))
            return false;
        return _0x2f7a9e4d.StartsWith(_0xe0d57b82._0x6813c1ab(new byte[11] { 233, 234, 231, 253, 252, 178, 234, 228, 233, 230, 227 }, 136), StringComparison.OrdinalIgnoreCase);
    }

    private GameObject _0x32e206b1;
    private IEnumerator _0x6f450659(Dictionary<string, object> _0x7c24f249)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[30] { 158, 145, 160, 182, 177, 152, 229, 131, 160, 177, 166, 173, 229, 128, 189, 177, 183, 164, 229, 149, 176, 182, 173, 229, 129, 164, 177, 164, 255, 229 }, 197) + string.Join(_0xe0d57b82._0x6813c1ab(new byte[1] { 145 }, 152), _0x7c24f249));
#endif
            }
        }

        string _0xa3214ab0 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x7c24f249 != null && _0x7c24f249.TryGetValue(_0xe0d57b82._0x6813c1ab(new byte[16] { 13, 12, 23, 10, 5, 10, 0, 2, 23, 10, 12, 13, 39, 2, 23, 2 }, 99), out var raw))
        {
            try
            {
                var _0x88513ecf = raw?.ToString();
                var _0xf8507322 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x88513ecf);
                if (_0xf8507322 != null && _0xf8507322.TryGetValue(_0xe0d57b82._0x6813c1ab(new byte[6] { 182, 160, 171, 161, 172, 161 }, 197), out var val))
                {
                    _0xa3214ab0 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0xe0d57b82._0x6813c1ab(new byte[30] { 55, 56, 9, 31, 24, 76, 60, 25, 31, 4, 49, 76, 38, 63, 35, 34, 76, 28, 13, 30, 31, 9, 76, 9, 30, 30, 3, 30, 86, 76 }, 108) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xa3214ab0) && _0x7c24f249 != null && _0x7c24f249.TryGetValue(_0xe0d57b82._0x6813c1ab(new byte[6] { 126, 104, 99, 105, 100, 105 }, 13), out var lab))
        {
            _0xa3214ab0 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[38] { 248, 247, 198, 208, 215, 131, 243, 214, 208, 203, 254, 131, 229, 198, 215, 192, 203, 198, 199, 131, 208, 198, 205, 199, 202, 199, 131, 197, 209, 204, 206, 131, 201, 208, 204, 205, 153, 131 }, 163) + _0xa3214ab0);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xa3214ab0))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[38] { 169, 166, 151, 129, 134, 210, 162, 135, 129, 154, 175, 210, 165, 147, 155, 134, 210, 134, 157, 210, 157, 130, 151, 156, 210, 133, 155, 134, 154, 210, 129, 151, 156, 150, 155, 150, 200, 210 }, 242) + _0xa3214ab0);
            }
#endif
        }

        _0x04446fcc = _0xa3214ab0;
        yield return new WaitUntil(() => _0x743a85ad);
        var _0x567c4b13 = _0x0e9a9f68(2, 100);
        yield return new WaitUntil(() => _0x567c4b13.IsCompleted);
        string _0x5ba74685 = _0x567c4b13.Result;
        if (!string.IsNullOrEmpty(_0x5ba74685))
        {
            string _0xde61bdf3 = _0x6ef46a88(_0x5ba74685, _0xa3214ab0);
            {
#if B_LOGS
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[33] { 144, 159, 174, 184, 191, 235, 155, 190, 184, 163, 150, 235, 153, 174, 167, 164, 170, 175, 235, 156, 174, 169, 157, 162, 174, 188, 235, 188, 162, 191, 163, 241, 235 }, 203) + _0xde61bdf3);
#endif
            }

            _0x21165c39.Load(_0xde61bdf3);
        }
    }

    private string _0xc0fffb23()
    {
        if (string.IsNullOrEmpty(_0x41190e43) && _0x21165c39 != null)
            _0x41190e43 = _0x21165c39.GetUserAgent();
        if (string.IsNullOrEmpty(_0x41190e43))
            return string.Empty;
        string _0x27462e45 = Regex.Replace(_0x41190e43, _0xe0d57b82._0x6813c1ab(new byte[11] { 204, 227, 186, 171, 204, 227, 186, 231, 230, 204, 242 }, 144), string.Empty);
        _0x27462e45 = Regex.Replace(_0x27462e45, _0xe0d57b82._0x6813c1ab(new byte[15] { 174, 129, 217, 176, 135, 155, 158, 150, 221, 169, 172, 201, 219, 175, 217 }, 242), string.Empty);
        _0x27462e45 = Regex.Replace(_0x27462e45, _0xe0d57b82._0x6813c1ab(new byte[15] { 180, 135, 144, 145, 139, 141, 140, 205, 214, 190, 204, 210, 190, 145, 200 }, 226), string.Empty);
        return Regex.Replace(_0x27462e45, _0xe0d57b82._0x6813c1ab(new byte[6] { 74, 101, 109, 36, 58, 107 }, 22), _0xe0d57b82._0x6813c1ab(new byte[1] { 24 }, 56)).Trim();
    }

    private void _0x55679858(UniWebView _0xbed981cd)
    {
        if (_0x962821dd)
            return;
        _0x962821dd = true;
        _0xbed981cd.AddUrlScheme(_0xe0d57b82._0x6813c1ab(new byte[2] { 214, 197 }, 162));
        _0xbed981cd.AddUrlScheme(_0xe0d57b82._0x6813c1ab(new byte[6] { 144, 151, 141, 156, 151, 141 }, 249));
        _0xbed981cd.AddUrlScheme(_0xe0d57b82._0x6813c1ab(new byte[6] { 68, 72, 91, 66, 76, 93 }, 41));
        _0xbed981cd.OnMessageReceived += (_0x7ea604d6, _0x8aeb3c5f) =>
        {
            if (TryOpenExternalLikeChrome(_0x8aeb3c5f.RawMessage))
            {
                _0xab32cecd(false);
                return;
            }
        };
        _0xbed981cd.RegisterShouldHandleRequest(_0x258492a7 =>
        {
            string _0xfdef84d8 = _0x258492a7 != null ? _0x258492a7.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xfdef84d8))
                return true;
            WLog(_0xe0d57b82._0x6813c1ab(new byte[21] { 65, 122, 125, 103, 126, 118, 90, 115, 124, 118, 126, 119, 64, 119, 99, 103, 119, 97, 102, 40, 50 }, 18) + _0xfdef84d8);
            if (TryOpenExternalLikeChrome(_0xfdef84d8))
            {
                _0xab32cecd(false);
                return false;
            }

            if (_0x258492a7 != null && _0x258492a7.IsMainFrame && IsGoogleAuthFlowUrl(_0xfdef84d8) && !_0x966a6c1c)
            {
                WLog(_0xe0d57b82._0x6813c1ab(new byte[62] { 118, 90, 82, 85, 27, 108, 94, 89, 109, 82, 94, 76, 27, 95, 94, 79, 94, 88, 79, 94, 95, 27, 124, 84, 84, 92, 87, 94, 27, 90, 78, 79, 83, 27, 110, 105, 119, 27, 22, 5, 27, 73, 94, 87, 84, 90, 95, 27, 76, 82, 79, 83, 27, 124, 84, 84, 92, 87, 94, 27, 110, 122 }, 59));
                _0x966a6c1c = true;
                _0xab32cecd(true);
                _0x21165c39.SetUserAgent(_0xc0fffb23());
                _0x21165c39.Load(_0xfdef84d8);
                return false;
            }

            return true;
        });
        _0xbed981cd.OnLoadingErrorReceived += (_0x7ea604d6, _0xb894a78a, _0x8aeb3c5f, _0x198854f9) =>
        {
            WLog(_0xe0d57b82._0x6813c1ab(new byte[25] { 6, 42, 34, 37, 107, 28, 46, 41, 29, 34, 46, 60, 107, 14, 57, 57, 36, 57, 113, 107, 40, 36, 47, 46, 118 }, 75) + _0xb894a78a + _0xe0d57b82._0x6813c1ab(new byte[9] { 31, 82, 90, 76, 76, 94, 88, 90, 2 }, 63) + _0x8aeb3c5f);
            string _0x181c22df = GetFailingUrl(_0x198854f9);
            if (string.IsNullOrEmpty(_0x181c22df) || IsAboutBlank(_0x181c22df))
                return;
            _ = _0x709482ba(_0xe0d57b82._0x6813c1ab(new byte[8] { 141, 140, 165, 159, 136, 136, 149, 136 }, 250));
            WLog(_0xe0d57b82._0x6813c1ab(new byte[45] { 104, 68, 76, 75, 5, 114, 64, 71, 115, 76, 64, 82, 5, 67, 68, 76, 73, 76, 75, 66, 5, 112, 119, 105, 5, 8, 27, 5, 74, 85, 64, 75, 5, 64, 93, 81, 64, 87, 75, 68, 73, 73, 92, 31, 5 }, 37) + _0x181c22df);
            StopCurrentFailedLoad(_0x7ea604d6);
            _0x221055cf(_0x181c22df);
        };
        _0xbed981cd.OnPageStarted += (_0x7ea604d6, _0xce1c087d) =>
        {
            _0x2a433706 = 0;
            if (_0x8f0659ed && IsAboutBlank(_0xce1c087d))
            {
                WLog(_0xe0d57b82._0x6813c1ab(new byte[27] { 200, 234, 253, 239, 249, 234, 245, 184, 249, 250, 247, 237, 236, 162, 250, 244, 249, 246, 243, 184, 235, 236, 249, 234, 236, 253, 252 }, 152));
                return;
            }

            WLog(_0xe0d57b82._0x6813c1ab(new byte[29] { 58, 22, 30, 25, 87, 32, 18, 21, 33, 30, 18, 0, 87, 56, 25, 39, 22, 16, 18, 36, 3, 22, 5, 3, 18, 19, 77, 87, 92 }, 119) + (Time.realtimeSinceStartup - _0xbf73744c).ToString(_0xe0d57b82._0x6813c1ab(new byte[5] { 54, 40, 54, 54, 54 }, 6)) + _0xe0d57b82._0x6813c1ab(new byte[2] { 7, 84 }, 116) + _0xce1c087d);
            if (TryOpenExternalLikeChrome(_0xce1c087d))
            {
                StopCurrentFailedLoad(_0x7ea604d6);
                return;
            }

            if (ContainsIgnoreCase(_0xce1c087d, _0xe0d57b82._0x6813c1ab(new byte[8] { 130, 143, 143, 135, 200, 135, 150, 150 }, 230)) || ContainsIgnoreCase(_0xce1c087d, _0xe0d57b82._0x6813c1ab(new byte[15] { 53, 36, 60, 107, 50, 44, 33, 34, 32, 49, 107, 39, 41, 42, 34 }, 69)) || _0xce1c087d.StartsWith(_0xe0d57b82._0x6813c1ab(new byte[25] { 110, 114, 114, 118, 117, 60, 41, 41, 100, 118, 97, 106, 105, 100, 103, 106, 96, 103, 112, 40, 106, 111, 112, 99, 41 }, 6), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x7ea604d6);
                OpenUrlExternally(_0xce1c087d);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xce1c087d))
            {
                _0xab32cecd(true);
                WLog(_0xe0d57b82._0x6813c1ab(new byte[41] { 226, 202, 202, 194, 201, 192, 133, 196, 208, 209, 205, 133, 195, 201, 202, 210, 133, 193, 192, 209, 192, 198, 209, 192, 193, 133, 136, 155, 133, 206, 192, 192, 213, 133, 211, 204, 214, 204, 199, 201, 192 }, 165));
                return;
            }

            _0x0ace5588 = true;
            _0xab32cecd(true);
            WLog(_0xe0d57b82._0x6813c1ab(new byte[43] { 174, 156, 155, 175, 144, 156, 142, 217, 149, 150, 152, 157, 144, 151, 158, 214, 139, 156, 157, 144, 139, 156, 154, 141, 144, 151, 158, 217, 212, 199, 217, 146, 156, 156, 137, 217, 143, 144, 138, 144, 155, 149, 156 }, 249));
        };
        _0xbed981cd.OnPageCommitted += (_0x7ea604d6, _0xce1c087d) =>
        {
            if (_0x8f0659ed && IsAboutBlank(_0xce1c087d))
                return;
            WLog(_0xe0d57b82._0x6813c1ab(new byte[31] { 65, 109, 101, 98, 44, 91, 105, 110, 90, 101, 105, 123, 44, 67, 98, 92, 109, 107, 105, 79, 99, 97, 97, 101, 120, 120, 105, 104, 54, 44, 39 }, 12) + (Time.realtimeSinceStartup - _0xbf73744c).ToString(_0xe0d57b82._0x6813c1ab(new byte[5] { 254, 224, 254, 254, 254 }, 206)) + _0xe0d57b82._0x6813c1ab(new byte[2] { 11, 88 }, 120) + _0xce1c087d);
            if (!firstLoadShown && IsHttpUrl(_0xce1c087d))
            {
                firstLoadShown = true;
                _0x0ace5588 = false;
                _0xab32cecd(false);
                _0x949b0884();
                _0x9f5678f6();
                _0x7ea604d6.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x709482ba(_0xe0d57b82._0x6813c1ab(new byte[9] { 170, 171, 130, 178, 173, 184, 179, 184, 185 }, 221));
                WLog(_0xe0d57b82._0x6813c1ab(new byte[39] { 54, 26, 18, 21, 91, 44, 30, 25, 45, 18, 30, 12, 91, 8, 19, 20, 12, 21, 91, 20, 21, 91, 24, 20, 22, 22, 18, 15, 15, 30, 31, 91, 24, 20, 21, 15, 30, 21, 15 }, 123));
            }
        };
        _0xbed981cd.OnPageProgressChanged += (_0x7ea604d6, _0x6da5cbf4) =>
        {
            if (_0x8f0659ed)
                return;
            if (!firstLoadShown && _0x6da5cbf4 >= 0.65f)
            {
                firstLoadShown = true;
                _0x0ace5588 = false;
                _0xab32cecd(false);
                _0x949b0884();
                _0x9f5678f6();
                _0x7ea604d6.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x709482ba(_0xe0d57b82._0x6813c1ab(new byte[9] { 120, 121, 80, 96, 127, 106, 97, 106, 107 }, 15));
                WLog(_0xe0d57b82._0x6813c1ab(new byte[32] { 244, 216, 208, 215, 153, 238, 220, 219, 239, 208, 220, 206, 153, 202, 209, 214, 206, 215, 153, 219, 192, 153, 201, 203, 214, 222, 203, 220, 202, 202, 131, 153 }, 185) + _0x6da5cbf4);
            }
        };
        _0xbed981cd.OnPageFinished += (_0x7ea604d6, _0xb894a78a, _0xce1c087d) =>
        {
            if (_0x8f0659ed && IsAboutBlank(_0xce1c087d))
            {
                _0x8f0659ed = false;
                WLog(_0xe0d57b82._0x6813c1ab(new byte[28] { 250, 216, 207, 221, 203, 216, 199, 138, 203, 200, 197, 223, 222, 144, 200, 198, 203, 196, 193, 138, 204, 195, 196, 195, 217, 194, 207, 206 }, 170));
                return;
            }

            WLog(_0xe0d57b82._0x6813c1ab(new byte[24] { 102, 74, 66, 69, 11, 124, 78, 73, 125, 66, 78, 92, 11, 109, 66, 69, 66, 88, 67, 78, 79, 17, 11, 0 }, 43) + (Time.realtimeSinceStartup - _0xbf73744c).ToString(_0xe0d57b82._0x6813c1ab(new byte[5] { 137, 151, 137, 137, 137 }, 185)) + _0xe0d57b82._0x6813c1ab(new byte[7] { 161, 242, 177, 189, 182, 183, 239 }, 210) + _0xb894a78a + _0xe0d57b82._0x6813c1ab(new byte[5] { 51, 102, 97, 127, 46 }, 19) + _0xce1c087d);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x0ace5588 = false;
                _0xab32cecd(false);
                _0x949b0884();
                _0x9f5678f6();
                _0x7ea604d6.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x709482ba(_0xe0d57b82._0x6813c1ab(new byte[9] { 210, 211, 250, 202, 213, 192, 203, 192, 193 }, 165));
                WLog(_0xe0d57b82._0x6813c1ab(new byte[33] { 25, 53, 61, 58, 116, 3, 49, 54, 2, 61, 49, 35, 116, 50, 61, 38, 39, 32, 116, 56, 59, 53, 48, 116, 55, 59, 57, 36, 56, 49, 32, 49, 48 }, 84));
            }
            else if (_0x0ace5588)
            {
                _0x0ace5588 = false;
                _0xab32cecd(false);
                _0x7ea604d6.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0xe0d57b82._0x6813c1ab(new byte[40] { 251, 215, 223, 216, 150, 225, 211, 212, 224, 223, 211, 193, 150, 229, 222, 217, 193, 150, 215, 208, 194, 211, 196, 150, 218, 217, 215, 210, 223, 216, 209, 150, 208, 223, 216, 223, 197, 222, 211, 210 }, 182));
            }
            else
            {
                _0xab32cecd(false);
            }

            if (_0x966a6c1c && !IsGoogleAuthFlowUrl(_0xce1c087d) && !IsGoogleAuthFlowUrl(_0xce1c087d))
            {
                WLog(_0xe0d57b82._0x6813c1ab(new byte[48] { 107, 67, 67, 75, 64, 73, 12, 77, 89, 88, 68, 12, 95, 73, 73, 65, 95, 12, 74, 69, 66, 69, 95, 68, 73, 72, 12, 1, 18, 12, 94, 73, 95, 88, 67, 94, 73, 12, 72, 73, 74, 77, 89, 64, 88, 12, 121, 109 }, 44));
                _0x966a6c1c = false;
                _0x21165c39.SetUserAgent("");
            }
        };
        _0xbed981cd.OnShouldClose += _0x7ea604d6 =>
        {
            WLog(_0xe0d57b82._0x6813c1ab(new byte[41] { 74, 69, 116, 98, 101, 76, 49, 92, 112, 120, 127, 49, 70, 116, 115, 71, 120, 116, 102, 49, 94, 127, 66, 121, 126, 100, 125, 117, 82, 125, 126, 98, 116, 49, 120, 127, 103, 126, 122, 116, 117 }, 17));
            _0x94250e1a();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0xbed981cd.SetPopupPageEventEnabled(true);
        bool _0x67c93cb5 = false;
        bool _0x9d7aebf2 = false;
        _0xbed981cd.OnMultipleWindowOpened += (_0x7ea604d6, _0x3417f643) =>
        {
            _0x7ea604d6.ScrollTo(0, 0, false);
            WLog(_0xe0d57b82._0x6813c1ab(new byte[43] { 54, 57, 8, 30, 25, 48, 77, 32, 12, 4, 3, 77, 58, 8, 15, 59, 4, 8, 26, 77, 32, 24, 1, 25, 4, 29, 1, 8, 58, 4, 3, 9, 2, 26, 77, 34, 29, 8, 3, 8, 9, 87, 77 }, 109) + _0x3417f643);
            var _0xc4c0446f = _0xbed981cd.GetPopupWindow(_0x3417f643);
            if (_0xc4c0446f == null)
                return;
            _0x2320ffad.Add(_0xc4c0446f);
            Debug.Log($"[Test] Popup ID: {_0xc4c0446f.Id}");
            _0xc4c0446f.OnPageStarted += (_0x36040d5a, _0xce1c087d) =>
            {
                WLog(_0xe0d57b82._0x6813c1ab(new byte[36] { 228, 235, 218, 204, 203, 226, 159, 239, 208, 207, 202, 207, 159, 232, 218, 221, 233, 214, 218, 200, 159, 240, 209, 239, 222, 216, 218, 236, 203, 222, 205, 203, 218, 219, 133, 159 }, 191) + _0xce1c087d);
                _0x2a433706 = 0;
                if (string.IsNullOrEmpty(_0xce1c087d) || IsAboutBlank(_0xce1c087d))
                    return;
                if (IsGoogleAuthFlowUrl(_0xce1c087d))
                {
                    WLog(_0xe0d57b82._0x6813c1ab(new byte[57] { 224, 239, 222, 200, 207, 230, 155, 235, 212, 203, 206, 203, 155, 252, 212, 212, 220, 215, 222, 155, 218, 206, 207, 211, 155, 221, 215, 212, 204, 155, 150, 133, 155, 200, 203, 212, 212, 221, 155, 252, 212, 212, 220, 215, 222, 155, 248, 211, 201, 212, 214, 222, 155, 238, 250, 129, 155 }, 187) + _0xce1c087d);
                    _0x67c93cb5 = false;
                    _0x92d92e80();
                    if (_0x36040d5a != null && _0x36040d5a.IsAlive)
                        _0x36040d5a.EvaluateJavaScript(_0x5b65b8a2());
                    return;
                }

                if (_0x21165c39 == null)
                    return;
                if (!_0x67c93cb5)
                {
                    _0x67c93cb5 = true;
                    _0x21165c39.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0xe0d57b82._0x6813c1ab(new byte[39] { 190, 177, 128, 150, 145, 184, 197, 181, 138, 149, 144, 149, 197, 132, 149, 149, 137, 156, 197, 178, 140, 139, 129, 138, 146, 150, 197, 129, 128, 150, 142, 145, 138, 149, 197, 176, 164, 223, 197 }, 229) + _0xce1c087d);
                }

                if (_0x36040d5a != null && _0x36040d5a.IsAlive)
                    _0x36040d5a.EvaluateJavaScript(_0xfec67b3f());
                if (!_0x9d7aebf2 && _0x36040d5a != null && _0x36040d5a.IsAlive && IsHttpUrl(_0xce1c087d))
                {
                    _0x9d7aebf2 = true;
                }
            };
            _0xc4c0446f.OnPageFinished += (_0x36040d5a, _0x198854f9) =>
            {
                string _0xb5cca7a4 = _0x198854f9 != null ? _0x198854f9.data : string.Empty;
                WLog(_0xe0d57b82._0x6813c1ab(new byte[35] { 29, 18, 35, 53, 50, 27, 102, 22, 41, 54, 51, 54, 102, 17, 35, 36, 16, 47, 35, 49, 102, 0, 47, 40, 47, 53, 46, 35, 34, 124, 102, 51, 52, 42, 123 }, 70) + _0xb5cca7a4);
                if (_0x36040d5a == null || !_0x36040d5a.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xb5cca7a4))
                {
                    _0x92d92e80();
                    _0x36040d5a.EvaluateJavaScript(_0x5b65b8a2());
                    return;
                }

                if (!_0x67c93cb5)
                    return;
                _0x36040d5a.EvaluateJavaScript(_0xfec67b3f());
            };
        };
        _0xbed981cd.OnMultipleWindowClosed += (_0x7ea604d6, _0x3417f643) =>
        {
            _0x2320ffad.RemoveAll(_0x1190aa2f => _0x1190aa2f == null || _0x1190aa2f.Id == _0x3417f643 || !_0x1190aa2f.IsAlive);
            _0xab32cecd(false);
            if (_0x2320ffad.Count == 0 && _0x21165c39 != null)
            {
                _0x67c93cb5 = false;
                _0x9d7aebf2 = false;
                _0x4a02c3fc();
            }

            WLog(_0xe0d57b82._0x6813c1ab(new byte[43] { 18, 29, 44, 58, 61, 20, 105, 4, 40, 32, 39, 105, 30, 44, 43, 31, 32, 44, 62, 105, 4, 60, 37, 61, 32, 57, 37, 44, 30, 32, 39, 45, 38, 62, 105, 10, 37, 38, 58, 44, 45, 115, 105 }, 73) + _0x3417f643);
        };
        _0xbed981cd.RegisterOnRequestMediaCapturePermission(_0x258492a7 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x0f48b8f4();
    }

    private string _0x09e22361 = "";
    private IEnumerator _0xa56451d6(float _0x68a5f3a4)
    {
        yield return new WaitForSeconds(_0x68a5f3a4);
        if (!_0x2e12ed0c)
        {
            _0x2e12ed0c = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xecf746fb}");
                }
#endif
            }
        }
    }

    // PART 3
    private string _0xaef17ec1()
    {
        try
        {
            var _0xb967c857 = new AndroidJavaClass(_0xe0d57b82._0x6813c1ab(new byte[30] { 170, 166, 164, 231, 188, 167, 160, 189, 176, 250, 173, 231, 185, 165, 168, 176, 172, 187, 231, 156, 167, 160, 189, 176, 153, 165, 168, 176, 172, 187 }, 201));
            var _0x1c52ed42 = _0xb967c857.GetStatic<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[15] { 16, 6, 1, 1, 22, 29, 7, 50, 16, 7, 26, 5, 26, 7, 10 }, 115));
            var _0x99c36a10 = new AndroidJavaClass(_0xe0d57b82._0x6813c1ab(new byte[57] { 169, 165, 167, 228, 173, 165, 165, 173, 166, 175, 228, 171, 164, 174, 184, 165, 163, 174, 228, 173, 167, 185, 228, 171, 174, 185, 228, 163, 174, 175, 164, 190, 163, 172, 163, 175, 184, 228, 139, 174, 188, 175, 184, 190, 163, 185, 163, 164, 173, 131, 174, 137, 166, 163, 175, 164, 190 }, 202));
            var _0x1dc15961 = _0x99c36a10.CallStatic<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[20] { 41, 43, 58, 15, 42, 56, 43, 60, 58, 39, 61, 39, 32, 41, 7, 42, 7, 32, 40, 33 }, 78), _0x1c52ed42);
            var _0x83649a2f = _0x1dc15961.Call<string>(_0xe0d57b82._0x6813c1ab(new byte[5] { 1, 3, 18, 47, 2 }, 102));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x83649a2f}");
#endif
            }

            return string.IsNullOrEmpty(_0x83649a2f) ? "" : _0x83649a2f;
        }
        catch
        {
            return "";
        }
    }

    private bool _0x966a6c1c = false;
    private string _0x88ab39e9 = "";
    private Canvas _0xf9d90ea8()
    {
        if (_0x4b4b9590 != null)
            return _0x4b4b9590;
        var _0x25c363cc = gameObject.GetComponentInChildren<Canvas>();
        if (_0x25c363cc == null)
        {
            var _0xacb7d3a5 = new GameObject(_0xe0d57b82._0x6813c1ab(new byte[6] { 219, 249, 246, 238, 249, 235 }, 152), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x25c363cc = _0xacb7d3a5.GetComponent<Canvas>();
            _0x25c363cc.transform.SetParent(transform, false);
            _0x25c363cc.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x4b4b9590 = _0x25c363cc;
        return _0x4b4b9590;
    }

    private string _0x95b68b9f = "";
    private string _0x391bcec7 = "";
    private IEnumerator _0xc5c3a31a(string _0xe253fa52)
    {
        if (_0x21165c39 != null && _0x743a85ad)
            yield break;
        _0x21165c39 = gameObject.AddComponent<UniWebView>();
        _0x5056acbb(_0x21165c39);
        _0x55679858(_0x21165c39);
        _0x21165c39.BackgroundColor = Color.clear;
        var _0xeeaca262 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x9f5678f6();
        yield return new WaitForEndOfFrame();
        _0x743a85ad = true;
        _0x097dd575();
        _0xab32cecd(true);
        _0x8f0659ed = false;
        _0x966a6c1c = false;
        _0x2320ffad.Clear();
        _0xfb144216 = -1;
        firstLoadShown = false;
        _0x0ace5588 = false;
        _0xbb969860 = false;
        _0x21165c39.SetUserAgent("");
        _0xbf73744c = Time.realtimeSinceStartup;
        _0x21165c39.Stop();
        _0x21165c39.Load(_0xe253fa52);
        _0x21165c39.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0xe0d57b82._0x6813c1ab(new byte[25] { 241, 221, 213, 210, 156, 235, 217, 222, 234, 213, 217, 203, 156, 245, 210, 213, 200, 213, 221, 208, 156, 239, 212, 211, 203 }, 188));
    }

    private Action _0x4e6c0786;
    private string _0x5b65b8a2()
    {
        string _0xace68496 = _0xc0fffb23();
        if (string.IsNullOrEmpty(_0xace68496))
            return _0xe0d57b82._0x6813c1ab(new byte[7] { 216, 193, 199, 202, 142, 158, 149 }, 174);
        string _0x93e2f693 = _0xace68496.Replace(_0xe0d57b82._0x6813c1ab(new byte[1] { 153 }, 197), _0xe0d57b82._0x6813c1ab(new byte[2] { 181, 181 }, 233)).Replace(_0xe0d57b82._0x6813c1ab(new byte[1] { 208 }, 247), _0xe0d57b82._0x6813c1ab(new byte[2] { 138, 241 }, 214));
        var _0x0ca305fa = Regex.Match(_0xace68496, _0xe0d57b82._0x6813c1ab(new byte[12] { 4, 47, 53, 40, 42, 34, 104, 111, 27, 35, 108, 110 }, 71));
        string _0x6bef2c4c = _0x0ca305fa.Success ? _0x0ca305fa.Groups[1].Value : _0xe0d57b82._0x6813c1ab(new byte[3] { 143, 140, 142 }, 190);
        return _0xe0d57b82._0x6813c1ab(new byte[12] { 235, 165, 182, 173, 160, 183, 170, 172, 173, 235, 234, 184 }, 195) + _0xe0d57b82._0x6813c1ab(new byte[8] { 9, 30, 13, 95, 10, 30, 66, 88 }, 127) + _0x93e2f693 + _0xe0d57b82._0x6813c1ab(new byte[2] { 60, 32 }, 27) + _0xe0d57b82._0x6813c1ab(new byte[30] { 46, 57, 42, 120, 40, 42, 55, 44, 55, 101, 22, 57, 46, 49, 63, 57, 44, 55, 42, 118, 40, 42, 55, 44, 55, 44, 33, 40, 61, 99 }, 88) + _0xe0d57b82._0x6813c1ab(new byte[121] { 246, 229, 254, 243, 228, 249, 255, 254, 176, 244, 245, 246, 184, 255, 242, 250, 188, 251, 245, 233, 188, 230, 241, 252, 185, 235, 228, 226, 233, 235, 223, 242, 250, 245, 243, 228, 190, 244, 245, 246, 249, 254, 245, 192, 226, 255, 224, 245, 226, 228, 233, 184, 255, 242, 250, 188, 251, 245, 233, 188, 235, 247, 245, 228, 170, 246, 229, 254, 243, 228, 249, 255, 254, 184, 185, 235, 226, 245, 228, 229, 226, 254, 176, 230, 241, 252, 171, 237, 188, 243, 255, 254, 246, 249, 247, 229, 226, 241, 242, 252, 245, 170, 228, 226, 229, 245, 237, 185, 171, 237, 243, 241, 228, 243, 248, 184, 245, 185, 235, 237, 237 }, 144) + _0xe0d57b82._0x6813c1ab(new byte[26] { 68, 69, 70, 8, 80, 82, 79, 84, 79, 12, 7, 85, 83, 69, 82, 97, 71, 69, 78, 84, 7, 12, 85, 65, 9, 27 }, 32) + _0xe0d57b82._0x6813c1ab(new byte[52] { 224, 225, 226, 172, 244, 246, 235, 240, 235, 168, 163, 229, 244, 244, 210, 225, 246, 247, 237, 235, 234, 163, 168, 241, 229, 170, 246, 225, 244, 232, 229, 231, 225, 172, 171, 218, 201, 235, 254, 237, 232, 232, 229, 216, 171, 171, 168, 163, 163, 173, 173, 191 }, 132) + _0xe0d57b82._0x6813c1ab(new byte[37] { 77, 76, 79, 1, 89, 91, 70, 93, 70, 5, 14, 89, 69, 72, 93, 79, 70, 91, 68, 14, 5, 14, 101, 64, 71, 92, 81, 9, 72, 91, 68, 95, 17, 69, 14, 0, 18 }, 41) + _0xe0d57b82._0x6813c1ab(new byte[34] { 119, 118, 117, 59, 99, 97, 124, 103, 124, 63, 52, 101, 118, 125, 119, 124, 97, 52, 63, 52, 84, 124, 124, 116, 127, 118, 51, 90, 125, 112, 61, 52, 58, 40 }, 19) + _0xe0d57b82._0x6813c1ab(new byte[30] { 149, 148, 151, 217, 129, 131, 158, 133, 158, 221, 214, 156, 144, 137, 165, 158, 132, 146, 153, 161, 158, 152, 159, 133, 130, 214, 221, 196, 216, 202 }, 241) + _0xe0d57b82._0x6813c1ab(new byte[48] { 80, 86, 93, 95, 82, 69, 86, 4, 81, 69, 64, 25, 95, 70, 86, 69, 74, 64, 87, 30, 127, 95, 70, 86, 69, 74, 64, 30, 3, 103, 76, 86, 75, 73, 77, 81, 73, 3, 8, 82, 65, 86, 87, 77, 75, 74, 30, 3 }, 36) + _0x6bef2c4c + _0xe0d57b82._0x6813c1ab(new byte[35] { 104, 50, 99, 52, 45, 61, 46, 33, 43, 117, 104, 8, 32, 32, 40, 35, 42, 111, 12, 39, 61, 32, 34, 42, 104, 99, 57, 42, 61, 60, 38, 32, 33, 117, 104 }, 79) + _0x6bef2c4c + _0xe0d57b82._0x6813c1ab(new byte[238] { 111, 53, 100, 51, 42, 58, 41, 38, 44, 114, 111, 6, 39, 60, 117, 9, 119, 10, 58, 41, 38, 44, 111, 100, 62, 45, 58, 59, 33, 39, 38, 114, 111, 122, 124, 111, 53, 21, 100, 37, 39, 42, 33, 36, 45, 114, 60, 58, 61, 45, 100, 56, 36, 41, 60, 46, 39, 58, 37, 114, 111, 9, 38, 44, 58, 39, 33, 44, 111, 100, 47, 45, 60, 0, 33, 47, 32, 13, 38, 60, 58, 39, 56, 49, 30, 41, 36, 61, 45, 59, 114, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51, 58, 45, 60, 61, 58, 38, 104, 24, 58, 39, 37, 33, 59, 45, 102, 58, 45, 59, 39, 36, 62, 45, 96, 51, 41, 58, 43, 32, 33, 60, 45, 43, 60, 61, 58, 45, 114, 111, 41, 58, 37, 111, 100, 42, 33, 60, 38, 45, 59, 59, 114, 111, 126, 124, 111, 100, 37, 39, 42, 33, 36, 45, 114, 60, 58, 61, 45, 100, 37, 39, 44, 45, 36, 114, 111, 111, 100, 56, 36, 41, 60, 46, 39, 58, 37, 114, 111, 9, 38, 44, 58, 39, 33, 44, 111, 100, 56, 36, 41, 60, 46, 39, 58, 37, 30, 45, 58, 59, 33, 39, 38, 114, 111, 121, 124, 102, 120, 102, 120, 111, 100, 61, 41, 14, 61, 36, 36, 30, 45, 58, 59, 33, 39, 38, 114, 111 }, 72) + _0x6bef2c4c + _0xe0d57b82._0x6813c1ab(new byte[117] { 251, 229, 251, 229, 251, 229, 242, 168, 252, 238, 168, 168, 238, 154, 183, 191, 176, 182, 161, 251, 177, 176, 179, 188, 187, 176, 133, 167, 186, 165, 176, 167, 161, 172, 253, 165, 167, 186, 161, 186, 249, 242, 160, 166, 176, 167, 148, 178, 176, 187, 161, 145, 180, 161, 180, 242, 249, 174, 178, 176, 161, 239, 179, 160, 187, 182, 161, 188, 186, 187, 253, 252, 174, 167, 176, 161, 160, 167, 187, 245, 160, 180, 177, 238, 168, 249, 182, 186, 187, 179, 188, 178, 160, 167, 180, 183, 185, 176, 239, 161, 167, 160, 176, 168, 252, 238, 168, 182, 180, 161, 182, 189, 253, 176, 252, 174, 168 }, 213) + _0xe0d57b82._0x6813c1ab(new byte[5] { 171, 255, 254, 255, 237 }, 214);
    }

    private string _0x8b431dce = "";
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0xb498a92f(string _0x829d8b79, string _0x6aa9f158)
    {
        try
        {
            using var _0x418335fd = Aes.Create();
            _0x418335fd.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x6aa9f158));
            _0x418335fd.GenerateIV();
            using var _0xd9ded734 = new MemoryStream();
            _0xd9ded734.Write(_0x418335fd.IV, 0, _0x418335fd.IV.Length);
            using (var _0xc19a69cc = new CryptoStream(_0xd9ded734, _0x418335fd.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xb378cdd3 = Encoding.UTF8.GetBytes(_0x829d8b79);
                _0xc19a69cc.Write(_0xb378cdd3, 0, _0xb378cdd3.Length);
                _0xc19a69cc.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xd9ded734.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private async Task<string> _0x0e9a9f68(int _0xc59287ed = 5, int _0x8e82ef11 = 500)
    {
        try
        {
            List<EntityData> _0xa2184919 = new List<EntityData>();
            int _0xdeebc616 = 0;
            do
            {
                _0xa2184919 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xe0d57b82._0x6813c1ab(new byte[8] { 54, 42, 39, 63, 35, 52, 15, 34 }, 70), _0x8b431dce, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x8b431dce }), new QueryOptions())).ToList();
                await Task.Delay(_0x8e82ef11);
            }
            while (_0xa2184919.Count == 0 && _0xdeebc616++ < _0xc59287ed);
            {
#if B_LOGS
                {
                    Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[33] { 178, 189, 140, 154, 157, 180, 201, 186, 136, 159, 140, 141, 201, 165, 128, 135, 130, 201, 184, 156, 140, 155, 144, 201, 155, 140, 154, 156, 133, 157, 154, 211, 201 }, 233) + JsonConvert.SerializeObject(_0xa2184919, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[39] { 79, 64, 113, 103, 96, 73, 52, 71, 117, 98, 113, 112, 52, 88, 125, 122, 127, 52, 69, 97, 113, 102, 109, 52, 102, 113, 103, 97, 120, 96, 103, 52, 119, 123, 97, 122, 96, 46, 52 }, 20) + _0xa2184919.Count);
                }
#endif
            }

            var _0x75665102 = _0xa2184919.SelectMany(_0xb098971a => _0xb098971a.Data).FirstOrDefault(_0x519188ee => _0x519188ee.Key == _0x8b431dce)?.Value.GetAs<string>() ?? string.Empty;
            _0x75665102 = Decrypt(_0x75665102, _0x8b431dce);
            {
#if B_LOGS
                {
                    Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[24] { 158, 145, 160, 182, 177, 152, 229, 137, 170, 164, 161, 229, 182, 164, 179, 160, 161, 229, 169, 172, 171, 174, 255, 229 }, 197) + _0x75665102);
                }
#endif
            }

            return _0x75665102;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[39] { 222, 209, 224, 246, 241, 216, 165, 194, 224, 241, 165, 234, 247, 165, 245, 228, 247, 246, 224, 165, 246, 228, 243, 224, 225, 165, 233, 236, 235, 238, 165, 227, 228, 236, 233, 224, 225, 191, 165 }, 133) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private void OnApplicationFocus(bool _0x48c2c314)
    {
        isApplicationFocus = _0x48c2c314;
        if (_0x48c2c314 && _0x743a85ad)
        {
            _0xa3152ec6();
        }
    }

    private void StopCurrentFailedLoad(UniWebView _0x0f967999)
    {
        _0xab32cecd(false);
        if (_0x0f967999 == null)
            return;
        _0x0f967999.Stop();
        if (_0x0f967999.CanGoBack)
            _0x0f967999.GoBack();
    }

    private void OnApplicationPause(bool _0x977209f0)
    {
        isApplicationPause = _0x977209f0;
    }

    private Text _0x22f3fd62;
    private void _0x949b0884()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    internal Rect lastSafe = Rect.zero;
    private RectTransform _0xf69eb13a;
    private bool _0xe5928f7c = false;
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x74dc7248()
    {
        var _0x3d75a235 = _0xe0d57b82._0x6813c1ab(new byte[40] { 198, 218, 218, 222, 221, 148, 129, 129, 217, 217, 217, 128, 205, 194, 193, 219, 202, 200, 194, 207, 220, 203, 128, 205, 193, 195, 129, 205, 202, 192, 131, 205, 201, 199, 129, 218, 220, 207, 205, 203 }, 174);
        using (UnityWebRequest _0x6dbfc37f = UnityWebRequest.Get(_0x3d75a235))
        {
            await _0x6dbfc37f.SendWebRequest();
            string[] _0xc1478802 = _0x6dbfc37f.downloadHandler.text.Split('\n');
            foreach (string _0xe17ac0b3 in _0xc1478802)
            {
                if (_0xe17ac0b3.StartsWith(_0xe0d57b82._0x6813c1ab(new byte[3] { 2, 27, 86 }, 107)))
                {
                    string _0xaa04aea9 = _0xe17ac0b3.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xaa04aea9} from {_0x3d75a235}");
                        }
#endif
                    }

                    return _0xaa04aea9;
                }
            }
        }

        return "";
    }

    private string _0x6ef46a88(string _0x1225e589, string _0xd6c8c80a)
    {
        if (string.IsNullOrEmpty(_0xd6c8c80a))
            return _0x1225e589;
        if (_0x1225e589.Contains(_0xe0d57b82._0x6813c1ab(new byte[1] { 144 }, 175)))
            return _0x1225e589 + _0xe0d57b82._0x6813c1ab(new byte[8] { 153, 204, 218, 209, 219, 214, 219, 130 }, 191) + UnityWebRequest.EscapeURL(_0xd6c8c80a);
        else
            return _0x1225e589 + _0xe0d57b82._0x6813c1ab(new byte[8] { 108, 32, 54, 61, 55, 58, 55, 110 }, 83) + UnityWebRequest.EscapeURL(_0xd6c8c80a);
    }

    // MAIN FLOW
    private bool _0x2e12ed0c { get; set; }

    private string _0xb53a2ec2 = "";
    private Canvas _0x4b4b9590;
    private void _0x113f8d64(string _0x456736db)
    {
        bool _0xe8338ee4 = !string.IsNullOrEmpty(_0x456736db);
        if (_0xe8338ee4)
        {
            {
#if B_LOGS
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[13] { 72, 71, 118, 96, 103, 78, 51, 64, 123, 124, 100, 41, 51 }, 19) + _0x456736db);
#endif
            }

            _0x97ab7ade(_0x456736db);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[39] { 53, 58, 11, 29, 26, 51, 78, 40, 15, 2, 2, 12, 15, 13, 5, 78, 140, 232, 252, 78, 41, 15, 3, 11, 78, 70, 0, 1, 78, 8, 7, 0, 15, 2, 78, 59, 60, 34, 71 }, 110));
#endif
            }

            _0x0f48b8f4();
            return;
        }
    }

    private ApplicationInstallMode _0x07643d27 = ApplicationInstallMode.Unknown;
    private void _0xa3152ec6()
    {
        using (var _0xa35a153e = new AndroidJavaClass(_0xe0d57b82._0x6813c1ab(new byte[30] { 111, 99, 97, 34, 121, 98, 101, 120, 117, 63, 104, 34, 124, 96, 109, 117, 105, 126, 34, 89, 98, 101, 120, 117, 92, 96, 109, 117, 105, 126 }, 12)))
        using (var _0x42b76a01 = _0xa35a153e.GetStatic<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[15] { 109, 123, 124, 124, 107, 96, 122, 79, 109, 122, 103, 120, 103, 122, 119 }, 14)))
        using (var _0x16b0d2e8 = _0x42b76a01.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[9] { 79, 77, 92, 97, 70, 92, 77, 70, 92 }, 40)))
        {
            if (_0x16b0d2e8 == null)
                return;
            using (var _0xf036850b = _0x16b0d2e8.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[9] { 202, 200, 217, 232, 213, 217, 223, 204, 222 }, 173)))
            {
                if (_0xf036850b == null)
                    return;
                using (var _0xa87b4781 = new AndroidJavaObject(_0xe0d57b82._0x6813c1ab(new byte[19] { 19, 14, 27, 82, 22, 15, 19, 18, 82, 54, 47, 51, 50, 51, 30, 22, 25, 31, 8 }, 124)))
                using (var _0x14eba7e9 = _0xf036850b.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[6] { 4, 10, 22, 60, 10, 27 }, 111)))
                using (var _0xe9d6b612 = _0x14eba7e9.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[8] { 4, 25, 8, 31, 12, 25, 2, 31 }, 109)))
                {
                    while (_0xe9d6b612.Call<bool>(_0xe0d57b82._0x6813c1ab(new byte[7] { 37, 44, 62, 3, 40, 53, 57 }, 77)))
                    {
                        string _0x065ab7d9 = _0xe9d6b612.Call<string>(_0xe0d57b82._0x6813c1ab(new byte[4] { 131, 136, 149, 153 }, 237));
                        using (var _0xca78ef73 = _0xf036850b.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[3] { 194, 192, 209 }, 165), _0x065ab7d9))
                        {
                            _0xa87b4781.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[3] { 19, 22, 23 }, 99), _0x065ab7d9, _0xca78ef73);
                        }
                    }

                    string _0x7383db71 = _0xa87b4781.Call<string>(_0xe0d57b82._0x6813c1ab(new byte[8] { 34, 57, 5, 34, 36, 63, 56, 49 }, 86));
                    if (!string.IsNullOrEmpty(_0x7383db71))
                    {
                        _0xf74f71c7(_0x7383db71);
                        _0x131151d8(_0x7383db71);
                    }
                }
            }
        }
    }

    private int _0x7cca330b = 5, _0x5248c690 = 5, _0xbc252bcf = 5, _0x24b97027 = 5;
    private async Task<bool> _0x212f4373(int _0x4c473bf0 = 5, int _0x92ad23fa = 500)
    {
        List<EntityData> _0x6b545121 = new List<EntityData>();
        int _0x3648737b = 0;
        do
        {
            try
            {
                _0x6b545121 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xe0d57b82._0x6813c1ab(new byte[8] { 87, 75, 70, 94, 66, 85, 110, 67 }, 39), _0x8b431dce, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xe0d57b82._0x6813c1ab(new byte[9] { 173, 183, 148, 182, 173, 178, 165, 167, 189 }, 196) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[32] { 250, 245, 196, 210, 213, 252, 129, 208, 212, 196, 211, 216, 224, 210, 216, 207, 194, 243, 196, 210, 212, 205, 213, 210, 129, 196, 211, 211, 206, 211, 155, 129 }, 161) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x92ad23fa);
        }
        while (_0x6b545121.Count == 0 && _0x3648737b++ < _0x4c473bf0);
        {
#if B_LOGS
            {
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[32] { 59, 52, 5, 19, 20, 61, 64, 41, 19, 48, 18, 9, 22, 1, 3, 25, 64, 49, 21, 5, 18, 25, 64, 18, 5, 19, 21, 12, 20, 19, 90, 64 }, 96) + JsonConvert.SerializeObject(_0x6b545121, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[38] { 140, 131, 178, 164, 163, 138, 247, 158, 164, 135, 165, 190, 161, 182, 180, 174, 247, 134, 162, 178, 165, 174, 247, 165, 178, 164, 162, 187, 163, 164, 247, 180, 184, 162, 185, 163, 237, 247 }, 215) + _0x6b545121.Count);
            }
#endif
        }

        bool _0xe17e90ff = true;
        if (_0x6b545121.Count == 0)
        {
            _0xe17e90ff = false;
        }
        else
        {
            _0xe17e90ff = _0x6b545121.Any(_0xb098971a => _0xb098971a.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[25] { 112, 127, 78, 88, 95, 118, 11, 98, 88, 123, 89, 66, 93, 74, 72, 82, 11, 89, 78, 88, 94, 71, 95, 17, 11 }, 43) + _0xe17e90ff);
            }
#endif
        }

        return _0xe17e90ff;
    }

    private JObject BuildRandomPayload(params string[] _0xff08568f)
    {
        JObject _0xf2bea44b = new JObject();
        foreach (var _0x93f4a678 in _0xff08568f)
        {
            string _0x8f4fce70 = _0x3adbf2d0();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x8f4fce70} val={_0x93f4a678}");
#endif
            }

            _0xf2bea44b.Add(_0x8f4fce70, _0x93f4a678 == null ? "" : _0x93f4a678);
        }

        return _0xf2bea44b;
    }

    private AndroidJavaObject _0x560768d5 { get; set; }

    private IEnumerator _0xe1dcccd9(IEnumerator _0x04123cd3, TaskCompletionSource<bool> _0x53cc046e)
    {
        yield return _0x04123cd3;
        _0x53cc046e.SetResult(true);
    }

    internal bool isDestroyedForce = false;
    private void _0x5056acbb(UniWebView _0xce13770e)
    {
        _0xce13770e.BackgroundColor = Color.clear;
        _0xce13770e.SetSupportMultipleWindows(true, true);
        _0xce13770e.SetBackButtonEnabled(false);
        _0x21165c39.SetUserAgent(_0xc0fffb23());
    }

    private bool _0xeec80f76()
    {
        if (_0xb7fd8b99())
            return true;
        if (_0x21165c39 != null && _0x21165c39.CanGoBack)
        {
            WLog(_0xe0d57b82._0x6813c1ab(new byte[36] { 95, 118, 101, 115, 96, 118, 101, 114, 55, 117, 118, 116, 124, 55, 58, 41, 55, 122, 118, 126, 121, 55, 64, 114, 117, 65, 126, 114, 96, 55, 80, 120, 85, 118, 116, 124 }, 23));
            _0x21165c39.GoBack();
            return true;
        }

        return false;
    }

    private async Task<bool> _0x50d9c8e4()
    {
        {
#if B_LOGS
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[37] { 11, 4, 53, 35, 36, 13, 112, 3, 57, 55, 62, 25, 62, 5, 62, 57, 36, 41, 3, 53, 34, 38, 57, 51, 53, 35, 17, 62, 63, 62, 41, 61, 63, 37, 35, 60, 41 }, 80));
#endif
        }

        try
        {
            var _0xa78170f5 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0xa78170f5);
            {
#if B_LOGS
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[32] { 190, 177, 128, 150, 145, 184, 197, 176, 139, 140, 145, 156, 182, 128, 151, 147, 140, 134, 128, 150, 197, 172, 139, 140, 145, 140, 132, 137, 140, 159, 128, 129 }, 229));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[20] { 130, 147, 133, 130, 246, 131, 184, 191, 162, 175, 133, 179, 164, 160, 191, 181, 179, 165, 236, 246 }, 214) + ex.Message);
#endif
            }

            _0xc64e388f?._0x0f48b8f4();
            return true;
        }

        bool _0xc6aaea00 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xc6aaea00 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[37] { 219, 212, 229, 243, 244, 221, 160, 211, 233, 231, 238, 173, 233, 238, 160, 193, 238, 239, 238, 249, 237, 239, 245, 243, 174, 160, 208, 236, 225, 249, 229, 242, 160, 201, 196, 186, 160 }, 128) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x8b431dce = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[25] { 85, 68, 82, 85, 33, 82, 104, 102, 111, 44, 104, 111, 33, 64, 116, 117, 105, 33, 68, 83, 83, 78, 83, 59, 33 }, 1) + ex.Message);
#endif
                }

                _0xc64e388f?._0x0f48b8f4();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[28] { 183, 166, 176, 183, 195, 176, 138, 132, 141, 206, 138, 141, 195, 177, 134, 146, 150, 134, 144, 151, 195, 166, 177, 177, 172, 177, 217, 195 }, 227) + ex.Message);
#endif
                }

                _0xc64e388f?._0x0f48b8f4();
                return true;
            }
        }
        while (!_0xc6aaea00);
        return false;
    }

    private async void Start()
    {
        await _0xcb874c4a();
    }

    private string _0x459edd9d = "";
    private string Decrypt(string _0x9bd3a95e, string _0xe5a96358)
    {
        try
        {
            var _0x006825b4 = Convert.FromBase64String(_0x9bd3a95e);
            using var _0xd62a81ba = Aes.Create();
            _0xd62a81ba.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xe5a96358));
            var _0x44dc3a3e = new byte[16];
            Buffer.BlockCopy(_0x006825b4, 0, _0x44dc3a3e, 0, 16);
            _0xd62a81ba.IV = _0x44dc3a3e;
            using var _0x657b9cf1 = new MemoryStream(_0x006825b4, 16, _0x006825b4.Length - 16);
            using var _0x78161fbe = new CryptoStream(_0x657b9cf1, _0xd62a81ba.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xa3dd14f5 = new StreamReader(_0x78161fbe, Encoding.UTF8);
            return _0xa3dd14f5.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0xebfa8c49 = "";
    public void _0xdc474f80()
    {
        if (_0x743a85ad)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[33] { 73, 70, 119, 97, 102, 79, 50, 70, 123, 127, 119, 96, 50, 125, 103, 102, 50, 63, 44, 50, 127, 125, 100, 119, 50, 102, 125, 50, 97, 113, 119, 124, 119 }, 18));
            }
#endif
        }

        _0x0f48b8f4();
    }

    private void _0x4a02c3fc()
    {
        if (_0x21165c39 == null)
            return;
        if (_0x966a6c1c)
            _0x21165c39.SetUserAgent(_0xc0fffb23());
        else
            _0x21165c39.SetUserAgent("");
    }

    private bool _0x8f0659ed = false;
    private IEnumerator _0x708908ff()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    private bool _0x6757d403()
    {
        var _0x8bec1d39 = Keyboard.current;
        return _0x8bec1d39 != null && _0x8bec1d39.escapeKey.wasPressedThisFrame;
    }

    private string _0xb49d32f8 { get; set; }

    private string _0x981a0eb2 = "";
    private int _0xfb144216 = -1;
    private readonly List<UniWebViewPopup> _0x2320ffad = new List<UniWebViewPopup>();
    private UniWebViewPopup _0x353d3058()
    {
        for (int _0x195d4918 = _0x2320ffad.Count - 1; _0x195d4918 >= 0; _0x195d4918--)
        {
            var _0x22a4261f = _0x2320ffad[_0x195d4918];
            if (_0x22a4261f != null && _0x22a4261f.IsAlive)
                return _0x22a4261f;
            _0x2320ffad.RemoveAt(_0x195d4918);
        }

        return null;
    }

    // WEB VIEW LOGIC
    public bool _0x743a85ad { get; set; }

    private void _0xb06c9a82()
    {
        if (_0xbb969860)
        {
            WLog(_0xe0d57b82._0x6813c1ab(new byte[18] { 132, 185, 168, 181, 225, 160, 173, 179, 164, 160, 165, 184, 225, 178, 169, 174, 182, 175 }, 193));
            return;
        }

        _0xab32cecd(false);
        WLog(_0xe0d57b82._0x6813c1ab(new byte[46] { 92, 112, 120, 127, 49, 70, 116, 115, 71, 120, 116, 102, 49, 65, 100, 98, 121, 49, 95, 126, 101, 120, 119, 120, 114, 112, 101, 120, 126, 127, 49, 57, 121, 112, 99, 117, 102, 112, 99, 116, 49, 115, 112, 114, 122, 56 }, 17));
        ++_0x2a433706;
        _0x6ef45029();
        if (_0x2a433706 <= 1)
            return;
        if (_0xc4a0a58f())
        {
            WLog(_0xe0d57b82._0x6813c1ab(new byte[37] { 29, 32, 49, 44, 120, 43, 51, 49, 40, 40, 61, 60, 120, 117, 102, 120, 40, 55, 40, 45, 40, 43, 120, 43, 44, 49, 52, 52, 120, 55, 40, 61, 54, 61, 60, 98, 120 }, 88) + _0x2320ffad.Count);
            return;
        }

        Application.Quit();
    }

    private string _0x82b5e1b7 = "";
    private bool _0x329f33d8(string _0x67be1d79)
    {
        try
        {
            using (var _0x16053c2b = new AndroidJavaClass(_0xe0d57b82._0x6813c1ab(new byte[30] { 173, 161, 163, 224, 187, 160, 167, 186, 183, 253, 170, 224, 190, 162, 175, 183, 171, 188, 224, 155, 160, 167, 186, 183, 158, 162, 175, 183, 171, 188 }, 206)))
            using (var _0xd25e33aa = _0x16053c2b.GetStatic<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[15] { 56, 46, 41, 41, 62, 53, 47, 26, 56, 47, 50, 45, 50, 47, 34 }, 91)))
            using (var _0xb74a9b34 = new AndroidJavaClass(_0xe0d57b82._0x6813c1ab(new byte[15] { 100, 107, 97, 119, 106, 108, 97, 43, 107, 96, 113, 43, 80, 119, 108 }, 5)))
            using (var _0x29b84ddc = _0xb74a9b34.CallStatic<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[5] { 14, 31, 12, 13, 27 }, 126), _0x67be1d79))
            using (var _0x29ead330 = new AndroidJavaObject(_0xe0d57b82._0x6813c1ab(new byte[22] { 209, 222, 212, 194, 223, 217, 212, 158, 211, 223, 222, 196, 213, 222, 196, 158, 249, 222, 196, 213, 222, 196 }, 176), _0xe0d57b82._0x6813c1ab(new byte[26] { 24, 23, 29, 11, 22, 16, 29, 87, 16, 23, 13, 28, 23, 13, 87, 24, 26, 13, 16, 22, 23, 87, 47, 48, 60, 46 }, 121), _0x29b84ddc))
            {
                WLog(_0xe0d57b82._0x6813c1ab(new byte[26] { 95, 116, 110, 115, 113, 121, 80, 117, 119, 121, 60, 115, 108, 121, 114, 60, 121, 100, 104, 121, 110, 114, 125, 112, 38, 60 }, 28) + _0x67be1d79);
                _0x29ead330.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[11] { 136, 141, 141, 170, 136, 157, 140, 142, 134, 155, 144 }, 233), _0xe0d57b82._0x6813c1ab(new byte[33] { 36, 43, 33, 55, 42, 44, 33, 107, 44, 43, 49, 32, 43, 49, 107, 38, 36, 49, 32, 34, 42, 55, 60, 107, 7, 23, 10, 18, 22, 4, 7, 9, 0 }, 69));
                _0x29ead330.Call<AndroidJavaObject>(_0xe0d57b82._0x6813c1ab(new byte[8] { 198, 195, 195, 225, 203, 198, 192, 212 }, 167), 0x10000000);
                _0xd25e33aa.Call(_0xe0d57b82._0x6813c1ab(new byte[13] { 173, 170, 191, 172, 170, 159, 189, 170, 183, 168, 183, 170, 167 }, 222), _0x29ead330);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xe0d57b82._0x6813c1ab(new byte[28] { 153, 178, 168, 181, 183, 191, 150, 179, 177, 191, 250, 191, 162, 174, 191, 168, 180, 187, 182, 250, 188, 187, 179, 182, 191, 190, 224, 250 }, 218) + e.Message);
            Application.OpenURL(_0x67be1d79);
            return true;
        }
    }

    private string _0x04446fcc;
    private IEnumerator RequestAndroidPermissionIfNeeded(string _0x85c4342e)
    {
        if (Permission.HasUserAuthorizedPermission(_0x85c4342e))
            yield break;
        bool _0x823dc6e2 = false;
        var _0xe21d27a9 = new PermissionCallbacks();
        _0xe21d27a9.PermissionGranted += _0x16b0fbb1 => _0x823dc6e2 = true;
        _0xe21d27a9.PermissionDenied += _0x16b0fbb1 => _0x823dc6e2 = true;
        Permission.RequestUserPermission(_0x85c4342e, _0xe21d27a9);
        yield return new WaitUntil(() => _0x823dc6e2);
    }

    private void WLog(string _0xc5a493a8)
    {
#if B_LOGS
        {
            Debug.Log(_0xe0d57b82._0x6813c1ab(new byte[7] { 210, 221, 236, 250, 253, 212, 169 }, 137) + _0xc5a493a8);
        }
#endif
    }

    private bool _0x1ef25ce0 = false;
    private string _0x684b637c = "";
    internal bool IsGoogleAuthFlowUrl(string _0xbca5d014)
    {
        if (string.IsNullOrEmpty(_0xbca5d014))
            return false;
        return _0xbca5d014.IndexOf(_0xe0d57b82._0x6813c1ab(new byte[19] { 134, 132, 132, 136, 146, 137, 147, 148, 201, 128, 136, 136, 128, 139, 130, 201, 132, 136, 138 }, 231), StringComparison.OrdinalIgnoreCase) >= 0 || _0xbca5d014.IndexOf(_0xe0d57b82._0x6813c1ab(new byte[16] { 254, 252, 252, 240, 234, 241, 235, 236, 177, 248, 240, 240, 248, 243, 250, 177 }, 159), StringComparison.OrdinalIgnoreCase) >= 0 || _0xbca5d014.IndexOf(_0xe0d57b82._0x6813c1ab(new byte[21] { 225, 233, 233, 225, 234, 227, 243, 245, 227, 244, 229, 233, 232, 242, 227, 232, 242, 168, 229, 233, 235 }, 134), StringComparison.OrdinalIgnoreCase) >= 0 || _0xbca5d014.IndexOf(_0xe0d57b82._0x6813c1ab(new byte[11] { 218, 206, 201, 220, 201, 212, 222, 147, 222, 210, 208 }, 189), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private void _0xab32cecd(bool _0x846b51e9)
    {
        _0x097dd575();
        _0x32e206b1.SetActive(_0x846b51e9);
        _0xe5928f7c = _0x846b51e9;
        if (_0x846b51e9)
        {
            _0x32e206b1.transform.SetAsLastSibling();
            if (_0xf69eb13a != null)
                _0xf69eb13a.localRotation = Quaternion.identity;
        }
    }
}

internal static class _0xe0d57b82
{
    internal static string _0x6813c1ab(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}