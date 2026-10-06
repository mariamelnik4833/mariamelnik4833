using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Construction helpers for the UGUI both scenes assemble at run time. Every
/// number passed in is written in the canvas reference resolution
/// (1242 x 2688), so one set of coordinates reads the same on every device.
///
/// Inside a canvas the draw order IS the sibling order, so each helper adds
/// its fill FIRST and its glyph or caption afterwards: a background can never
/// cover its own label (rules C.13 and E.1).
public static class _0xc7d755ab
{
    public static void SetVisible(Component _0x8864505d, bool _0xdbd15e31)
    {
        if (_0x8864505d != null && _0x8864505d.gameObject.activeSelf != _0xdbd15e31)
        {
            _0x8864505d.gameObject.SetActive(_0xdbd15e31);
        }
    }

    public const float RefHeight = 2688f;
    /// A full-surface press target. A completely transparent Image is culled by
    /// the raycaster, so it keeps a trace of alpha and its mesh alive.
    public static Image TapSurface(Transform _0x4519535f, string _0x2dcc21ab, float _0x5f71de98)
    {
        RectTransform _0xfcc75315 = Stretch(_0x4519535f, _0x2dcc21ab);
        Image _0x25c89ea7 = _0xfcc75315.gameObject.AddComponent<Image>();
        _0x25c89ea7.color = new Color(0f, 0f, 0f, Mathf.Max(0.004f, _0x5f71de98));
        _0x25c89ea7.raycastTarget = true;
        _0x25c89ea7.canvasRenderer.cullTransparentMesh = false;
        return _0x25c89ea7;
    }

    /// Corner radius of a nine-sliced plate: a higher multiplier shrinks the
    /// drawn border and sharpens the corner. The floor is size aware, so the
    /// two borders of a small plate never meet in its middle and smear it.
    public static float SliceScale(Vector2 _0x13c7eef7)
    {
        float _0xe9595107 = Mathf.Max(1f, Mathf.Min(_0x13c7eef7.x, _0x13c7eef7.y));
        return Mathf.Max(1.6f, 240f / _0xe9595107);
    }

    /// A pressable surface. The fill is both the press target and the visible
    /// face, so the button's own colour tint actually shows; pointing the
    /// target graphic at a transparent hit layer gives no press feedback at all.
    public static Button Action(Transform _0x41761e76, string _0xd58828d9, Vector2 _0xc593c10c, Vector2 _0x629597b6, Vector2 _0x3f2c5e6c, Sprite _0x05ed8801, Color _0x0caa71ac, string _0xa499dc70, float _0x3cdefcd8, Color _0x97e0ebe8, TMP_FontAsset _0xb1d67a9c)
    {
        RectTransform _0xffbad68d = Node(_0x41761e76, _0xd58828d9, _0xc593c10c, _0x629597b6, _0x3f2c5e6c);
        Image _0x86463ebd = _0xffbad68d.gameObject.AddComponent<Image>();
        _0x86463ebd.sprite = _0x05ed8801;
        _0x86463ebd.type = _0x05ed8801 != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x86463ebd.pixelsPerUnitMultiplier = SliceScale(_0x3f2c5e6c);
        _0x86463ebd.color = _0x0caa71ac;
        _0x86463ebd.raycastTarget = true;
        _0x86463ebd.canvasRenderer.cullTransparentMesh = false;
        Button _0x8cbae399 = _0xffbad68d.gameObject.AddComponent<Button>();
        _0x8cbae399.targetGraphic = _0x86463ebd;
        ColorBlock _0x0b767a32 = _0x8cbae399.colors;
        _0x0b767a32.normalColor = Color.white;
        _0x0b767a32.highlightedColor = Color.white;
        _0x0b767a32.pressedColor = new Color(0.70f, 0.70f, 0.70f, 1f);
        _0x0b767a32.selectedColor = Color.white;
        _0x0b767a32.disabledColor = new Color(0.5f, 0.5f, 0.5f, 0.6f);
        _0x0b767a32.colorMultiplier = 1f;
        _0x0b767a32.fadeDuration = 0.08f;
        _0x8cbae399.colors = _0x0b767a32;
        if (!string.IsNullOrEmpty(_0xa499dc70))
        {
            Caption(_0xffbad68d, _0xd58828d9 + _0x86d99546._0xe52768cc(new byte[5] { 200, 227, 242, 239, 227 }, 151), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x3f2c5e6c.x - 48f, _0x3f2c5e6c.y - 28f), _0xa499dc70, _0x3cdefcd8, _0x97e0ebe8, TextAlignmentOptions.Center, _0xb1d67a9c);
        }

        return _0x8cbae399;
    }

    /// A rect stretched over its whole parent. A host made with
    /// new GameObject(...) starts 100x100, and every child would then resolve
    /// its anchors against 100x100 instead of the panel - so this runs
    /// immediately after parenting, never later.
    public static RectTransform Stretch(Transform _0x17722c16, string _0xe23a5475)
    {
        GameObject _0xf4a255a1 = new GameObject(_0xe23a5475, typeof(RectTransform));
        RectTransform _0x30e4b31b = _0xf4a255a1.GetComponent<RectTransform>();
        _0x30e4b31b.SetParent(_0x17722c16, false);
        _0x30e4b31b.anchorMin = Vector2.zero;
        _0x30e4b31b.anchorMax = Vector2.one;
        _0x30e4b31b.offsetMin = Vector2.zero;
        _0x30e4b31b.offsetMax = Vector2.zero;
        _0x30e4b31b.localScale = Vector3.one;
        return _0x30e4b31b;
    }

    /// A nine-sliced plate. Stretching is its whole purpose, so it keeps no
    /// aspect - that exemption is exactly what rule F.2a carves out for frames.
    public static Image Plate(Transform _0x70039fa5, string _0x7f9b8654, Vector2 _0xa22c2a1c, Vector2 _0xfcf6ab6b, Vector2 _0xaf74e7cb, Sprite _0x2098ee91, Color _0xeb8c9ef6)
    {
        RectTransform _0x8dd6ae56 = Node(_0x70039fa5, _0x7f9b8654, _0xa22c2a1c, _0xfcf6ab6b, _0xaf74e7cb);
        Image _0x27b28a1e = _0x8dd6ae56.gameObject.AddComponent<Image>();
        _0x27b28a1e.sprite = _0x2098ee91;
        _0x27b28a1e.type = _0x2098ee91 != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x27b28a1e.pixelsPerUnitMultiplier = SliceScale(_0xaf74e7cb);
        _0x27b28a1e.color = _0xeb8c9ef6;
        _0x27b28a1e.raycastTarget = false;
        return _0x27b28a1e;
    }

    public static TextMeshProUGUI Caption(Transform _0x063e0f95, string _0xad806a5d, Vector2 _0x463e71f0, Vector2 _0xe91f63df, Vector2 _0x8143d6e8, string _0x6376093e, float _0x7d3129b8, Color _0x1ca07390, TextAlignmentOptions _0x931f0b97, TMP_FontAsset _0x341e42ad)
    {
        RectTransform _0x0e12a769 = Node(_0x063e0f95, _0xad806a5d, _0x463e71f0, _0xe91f63df, _0x8143d6e8);
        TextMeshProUGUI _0x05cc67bc = _0x0e12a769.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x341e42ad != null)
        {
            _0x05cc67bc.font = _0x341e42ad;
        }

        _0x05cc67bc.text = _0x6376093e;
        _0x05cc67bc.alignment = _0x931f0b97;
        _0x05cc67bc.raycastTarget = false;
        _0x7ffdfc32.ApplyLayout(_0x05cc67bc, _0x7d3129b8);
        _0x7ffdfc32.ApplyOutline(_0x05cc67bc, _0x1ca07390);
        return _0x05cc67bc;
    }

    /// A square icon button. The glyph is added after the fill, so it draws on
    /// top of it, and it is sized as a fixed square so two icon buttons in a
    /// row can never come out different heights.
    public static Button IconAction(Transform _0xec8aae3c, string _0x882001d8, Vector2 _0xf9859885, Vector2 _0x0c3e8c17, float _0xeb20fbd4, Sprite _0x29bfb228, Color _0x6907b83d, Sprite _0xdc3730e6, Color _0x14ef983d)
    {
        Button _0x5dca7348 = Action(_0xec8aae3c, _0x882001d8, _0xf9859885, _0x0c3e8c17, new Vector2(_0xeb20fbd4, _0xeb20fbd4), _0x29bfb228, _0x6907b83d, string.Empty, _0x7ffdfc32.UiFontFloor, _0xb0c2dde3.Cream, null);
        Picture(_0x5dca7348.transform, _0x882001d8 + _0x86d99546._0xe52768cc(new byte[6] { 229, 221, 214, 195, 202, 210 }, 186), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xeb20fbd4 * 0.54f, _0xeb20fbd4 * 0.54f), _0xdc3730e6, _0x14ef983d);
        return _0x5dca7348;
    }

    public const float RefWidth = 1242f;
    /// A rect whose anchors collapse to one point, so its size is exactly what
    /// is written here and is never inherited from a stretching parent.
    public static RectTransform Node(Transform _0xecf44977, string _0x82e5fad3, Vector2 _0x6a1ae141, Vector2 _0x6b150cd5, Vector2 _0xbff35b57)
    {
        GameObject _0x94591f1b = new GameObject(_0x82e5fad3, typeof(RectTransform));
        RectTransform _0x25b5d976 = _0x94591f1b.GetComponent<RectTransform>();
        _0x25b5d976.SetParent(_0xecf44977, false);
        _0x25b5d976.anchorMin = _0x6a1ae141;
        _0x25b5d976.anchorMax = _0x6a1ae141;
        _0x25b5d976.pivot = new Vector2(0.5f, 0.5f);
        _0x25b5d976.anchoredPosition = _0x6b150cd5;
        _0x25b5d976.sizeDelta = _0xbff35b57;
        _0x25b5d976.localScale = Vector3.one;
        return _0x25b5d976;
    }

    /// A radial meter, used for the menu's harvest ring. Its rect is square and
    /// so is its sprite, so the aspect is kept rather than exempted: a filled
    /// image is a meter, not a frame, and has no business being stretched.
    public static Image Ring(Transform _0x00315837, string _0x2045859c, Vector2 _0xb6ed66c7, Vector2 _0xb77f2cbb, Vector2 _0xc4078cf0, Sprite _0x52f68f73, Color _0x0cfa08a4)
    {
        RectTransform _0xd5f7bdf0 = Node(_0x00315837, _0x2045859c, _0xb6ed66c7, _0xb77f2cbb, _0xc4078cf0);
        Image _0xd22edbe8 = _0xd5f7bdf0.gameObject.AddComponent<Image>();
        _0xd22edbe8.sprite = _0x52f68f73;
        _0xd22edbe8.preserveAspect = true;
        _0xd22edbe8.type = Image.Type.Filled;
        _0xd22edbe8.fillMethod = Image.FillMethod.Radial360;
        _0xd22edbe8.fillOrigin = 2;
        _0xd22edbe8.fillClockwise = true;
        _0xd22edbe8.fillAmount = 0f;
        _0xd22edbe8.color = _0x0cfa08a4;
        _0xd22edbe8.raycastTarget = false;
        return _0xd22edbe8;
    }

    /// Content art: the sprite keeps its own proportions whatever box it is
    /// handed, so a round fruit can never arrive as an egg (rule F.2a).
    public static Image Picture(Transform _0x003bb38c, string _0xe728c3c6, Vector2 _0xab693fbd, Vector2 _0x4cffb02e, Vector2 _0x45623e4f, Sprite _0xfc3c4738, Color _0x5f17d13a)
    {
        RectTransform _0xff08e2b6 = Node(_0x003bb38c, _0xe728c3c6, _0xab693fbd, _0x4cffb02e, _0x45623e4f);
        Image _0xdfd163c7 = _0xff08e2b6.gameObject.AddComponent<Image>();
        _0xdfd163c7.sprite = _0xfc3c4738;
        _0xdfd163c7.type = Image.Type.Simple;
        _0xdfd163c7.preserveAspect = true;
        _0xdfd163c7.color = _0x5f17d13a;
        _0xdfd163c7.raycastTarget = false;
        return _0xdfd163c7;
    }
}

internal static class _0x86d99546
{
    internal static string _0xe52768cc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}