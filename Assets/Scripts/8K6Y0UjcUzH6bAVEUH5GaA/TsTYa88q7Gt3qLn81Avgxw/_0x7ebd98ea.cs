using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x7ebd98ea : MonoBehaviour
{
    private void Awake()
    {
        if (!_0x64de8fa8.Contains(this))
            _0x64de8fa8.Add(this);
        this._0x65b8f488 = this.GetComponent<Canvas>();
        this._0xdd5b9993 = this.GetComponent<RectTransform>();
        this._0x868996bb = this.transform.Find(_0x2e1da763._0x5442b391(new byte[8] { 247, 197, 194, 193, 229, 214, 193, 197 }, 164)) as RectTransform;
        if (!_0xd569a709)
        {
            _0x170b8e59 = Screen.orientation;
            _0x17d73ee4.x = Screen.width;
            _0x17d73ee4.y = Screen.height;
            _0xd1576ca8 = Screen.safeArea;
            _0xd569a709 = true;
        }

        this._0xca66205c();
    }

    private RectTransform _0xdd5b9993;
    private static Rect _0xd1576ca8 = Rect.zero;
    private void Update()
    {
        if (_0x64de8fa8[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x170b8e59)
            OrientationChanged();
        if (Screen.safeArea != _0xd1576ca8)
            SafeAreaChanged();
        if (Screen.width != _0x17d73ee4.x || Screen.height != _0x17d73ee4.y)
            ResolutionChanged();
    }

    private static void SafeAreaChanged()
    {
        _0xd1576ca8 = Screen.safeArea;
        for (int _0x3cd81788 = 0; _0x3cd81788 < _0x64de8fa8.Count; _0x3cd81788++)
            _0x64de8fa8[_0x3cd81788]._0xca66205c();
    }

    private static UnityEvent _0x64607d34 = new();
    private static void OrientationChanged()
    {
        _0x170b8e59 = Screen.orientation;
        _0x17d73ee4.x = Screen.width;
        _0x17d73ee4.y = Screen.height;
        _0x64607d34.Invoke();
    }

    private static readonly List<_0x7ebd98ea> _0x64de8fa8 = new();
    private static bool _0xd569a709;
    private RectTransform _0x868996bb;
    private static ScreenOrientation _0x170b8e59 = ScreenOrientation.LandscapeLeft;
    private static Vector2 _0x17d73ee4 = Vector2.zero;
    private Canvas _0x65b8f488;
    private static void ResolutionChanged()
    {
        _0x17d73ee4.x = Screen.width;
        _0x17d73ee4.y = Screen.height;
        _0x64607d34.Invoke();
    }

    private void _0xca66205c()
    {
        if (this._0x868996bb == null)
            return;
        Rect _0xeb605082 = Screen.safeArea;
        Vector2 _0xa56af310 = _0xeb605082.position;
        Vector2 _0x79e1b387 = _0xeb605082.position + _0xeb605082.size;
        _0xa56af310.x /= this._0x65b8f488.pixelRect.width;
        _0xa56af310.y /= this._0x65b8f488.pixelRect.height;
        _0x79e1b387.x /= this._0x65b8f488.pixelRect.width;
        _0x79e1b387.y /= this._0x65b8f488.pixelRect.height;
        this._0x868996bb.anchorMin = _0xa56af310;
        this._0x868996bb.anchorMax = _0x79e1b387;
    }

    private void OnDestroy()
    {
        if (_0x64de8fa8 != null && _0x64de8fa8.Contains(this))
            _0x64de8fa8.Remove(this);
    }
}

internal static class _0x2e1da763
{
    internal static string _0x5442b391(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}