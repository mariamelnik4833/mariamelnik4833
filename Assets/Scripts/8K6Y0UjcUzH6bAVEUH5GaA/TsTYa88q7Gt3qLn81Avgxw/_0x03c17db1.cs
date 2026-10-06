using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x03c17db1 : MonoBehaviour
{
    private static void ApplySafeAreaToAll()
    {
        for (int _0xdfc04bd2 = 0; _0xdfc04bd2 < _0x3a0e9f55.Count; _0xdfc04bd2++)
            _0x3a0e9f55[_0xdfc04bd2]._0xd2eecc52();
    }

    private Vector2 _0x486b9066;
    private void OnDestroy()
    {
        if (_0x3a0e9f55 != null && _0x3a0e9f55.Contains(this))
            _0x3a0e9f55.Remove(this);
    }

    private static void SafeAreaChanged()
    {
        _0x903d1c5f = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private RectTransform _0x57eb8e46;
    private Canvas _0xeba2e73f;
    private static Vector2 _0x2c99ea99 = Vector2.zero;
    private void Awake()
    {
        if (!_0x3a0e9f55.Contains(this))
            _0x3a0e9f55.Add(this);
        this._0xeba2e73f = this.GetComponent<Canvas>();
        this._0x0faa3dc7 = this.GetComponent<CanvasScaler>();
        if (this._0x0faa3dc7 != null)
            this._0x486b9066 = this._0x0faa3dc7.referenceResolution;
        this._0x1f4a0073 = this.GetComponent<RectTransform>();
        this._0x57eb8e46 = this.transform.Find(_0x38b625c4._0x242ea35f(new byte[8] { 142, 188, 187, 184, 156, 175, 184, 188 }, 221)) as RectTransform;
        if (!_0x71feb737)
        {
            _0x2b42c2ef = Screen.orientation;
            _0x2c99ea99.x = Screen.width;
            _0x2c99ea99.y = Screen.height;
            _0x903d1c5f = Screen.safeArea;
            _0x71feb737 = true;
        }

        this._0xd2eecc52();
    }

    private static void ResolutionChanged()
    {
        _0x2c99ea99.x = Screen.width;
        _0x2c99ea99.y = Screen.height;
        _0x903d1c5f = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xb0e1451b.Invoke();
    }

    private void _0xd2eecc52()
    {
        if (this._0x57eb8e46 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x77461922 = Screen.safeArea;
        Vector2 _0x75c3f451 = _0x77461922.position;
        Vector2 _0x15fa8f4c = _0x77461922.position + _0x77461922.size;
        _0x75c3f451.x /= screenWidth;
        _0x75c3f451.y /= screenHeight;
        _0x15fa8f4c.x /= screenWidth;
        _0x15fa8f4c.y /= screenHeight;
        this._0x57eb8e46.anchorMin = _0x75c3f451;
        this._0x57eb8e46.anchorMax = _0x15fa8f4c;
        this._0x57eb8e46.offsetMin = Vector2.zero;
        this._0x57eb8e46.offsetMax = Vector2.zero;
        if (this._0x0faa3dc7 == null)
            return;
        Vector2 _0x22e812dd = _0x15fa8f4c - _0x75c3f451;
        float _0x1bfd29a2 = 2f - _0x22e812dd.x;
        float _0x8051b1e2 = 2f - _0x22e812dd.y;
        this._0x0faa3dc7.referenceResolution = this._0x486b9066 * new Vector2(_0x1bfd29a2, _0x8051b1e2);
    }

    private static UnityEvent _0xb0e1451b = new();
    private static Rect _0x903d1c5f = Rect.zero;
    private RectTransform _0x1f4a0073;
    private static ScreenOrientation _0x2b42c2ef = ScreenOrientation.LandscapeLeft;
    private static readonly List<_0x03c17db1> _0x3a0e9f55 = new();
    private static void OrientationChanged()
    {
        _0x2b42c2ef = Screen.orientation;
        _0x2c99ea99.x = Screen.width;
        _0x2c99ea99.y = Screen.height;
        _0x903d1c5f = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xb0e1451b.Invoke();
    }

    private CanvasScaler _0x0faa3dc7;
    private static bool _0x71feb737;
    private void Start()
    {
    }

    private void Update()
    {
        if (_0x3a0e9f55.Count == 0 || _0x3a0e9f55[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x2b42c2ef)
            OrientationChanged();
        if (Screen.safeArea != _0x903d1c5f)
            SafeAreaChanged();
        if (Screen.width != _0x2c99ea99.x || Screen.height != _0x2c99ea99.y)
            ResolutionChanged();
    }
}

internal static class _0x38b625c4
{
    internal static string _0x242ea35f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}