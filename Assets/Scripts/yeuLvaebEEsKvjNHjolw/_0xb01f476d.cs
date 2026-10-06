using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Everything this game does TO the scene template: reaching a panel body by
/// its SETTINGS index, clearing the bodies it rebuilds itself, emptying the
/// filler copy on the pages it never opens, and dressing the splash with an
/// abstract mark.
///
/// Panels are reached by index and never by name. Names do not survive
/// obfuscation, and the controller indexes its pool anyway. The controller's
/// own getter is private in this template, so the public Panels list is the
/// way in.
///
/// The loading bar is deliberately NOT touched from here: its colours live on
/// the prefab, so the bar is already themed before the first frame is drawn
/// and nothing has to run first for it to look right.
public static class _0xb01f476d
{
    public static Transform PanelBody(int _0xf4aa7bc8)
    {
        _0x09adb88e _0x0e50d732 = _0x09adb88e.Instance;
        if (_0x0e50d732 == null || _0x0e50d732.Panels == null)
        {
            return null;
        }

        if (_0xf4aa7bc8 < 0 || _0xf4aa7bc8 >= _0x0e50d732.Panels.Count)
        {
            return null;
        }

        _0x89b23978 _0x24e60f1b = _0x0e50d732.Panels[_0xf4aa7bc8];
        if (_0x24e60f1b == null || _0x24e60f1b.Content == null)
        {
            return null;
        }

        return _0x24e60f1b.Content.transform;
    }

    public static void ClearPanelBody(int _0xe9270fcc)
    {
        ClearPanelBody(_0xe9270fcc, null);
    }

    /// Switches off whatever the template put in a panel body so this game can
    /// build its own. Two branches are spared: anything holding a Pop, because
    /// those are addressed by index and have to stay reachable, and the branch
    /// handed in, which is the template's own scene-loading control the menu
    /// re-dresses rather than duplicates.
    ///
    /// The keep test is two-sided on purpose: a label the template parented
    /// directly under the body would otherwise make the body itself the
    /// victim and switch off the whole screen.
    public static void ClearPanelBody(int _0x62030d97, Transform _0x205461d3)
    {
        Transform _0xa286103a = PanelBody(_0x62030d97);
        if (_0xa286103a == null)
        {
            return;
        }

        for (int _0x61b4cd05 = _0xa286103a.childCount - 1; _0x61b4cd05 >= 0; _0x61b4cd05--)
        {
            Transform _0x30ee2f72 = _0xa286103a.GetChild(_0x61b4cd05);
            if (_0x30ee2f72 == null)
            {
                continue;
            }

            if (_0x30ee2f72.GetComponentInChildren<_0x44a03f11>(true) != null)
            {
                continue;
            }

            if (_0x205461d3 != null && (_0x30ee2f72 == _0x205461d3 || _0x205461d3.IsChildOf(_0x30ee2f72)))
            {
                continue;
            }

            _0x30ee2f72.gameObject.SetActive(false);
        }
    }

    /// Every teaching page the template declares. This game leaves the
    /// template tutorial switched off and explains its control on its own
    /// sheet plus a standing line in the run, so none of these is ever opened
    /// - but the template copy on them must not reach the build either
    /// (rule C.15).
    private static readonly int[] _0xe764fb6c =
    {
        _0x53431849._0xfa200dc8.TUTORIAL0,
        _0x53431849._0xfa200dc8.TUTORIAL1,
        _0x53431849._0xfa200dc8.TUTORIAL2,
        _0x53431849._0xfa200dc8.TUTORIAL3,
        _0x53431849._0xfa200dc8.TUTORIAL4,
        _0x53431849._0xfa200dc8.TUTORIAL5,
        _0x53431849._0xfa200dc8.TUTORIAL6,
    };
    /// Empties the filler strings from every template page this game does not
    /// dress itself. The page stays in the pool: the controller addresses
    /// panels by index, and a removed page breaks its navigation.
    public static void BlankUnusedPages()
    {
        for (int _0x29565e1c = 0; _0x29565e1c < _0xe764fb6c.Length; _0x29565e1c++)
        {
            Transform _0xa41d35c7 = PanelBody(_0xe764fb6c[_0x29565e1c]);
            if (_0xa41d35c7 == null)
            {
                continue;
            }

            TMP_Text[] _0xb63a689e = _0xa41d35c7.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x786a3a89 = 0; _0x786a3a89 < _0xb63a689e.Length; _0x786a3a89++)
            {
                if (_0xb63a689e[_0x786a3a89] != null)
                {
                    _0xb63a689e[_0x786a3a89].text = string.Empty;
                }
            }
        }
    }

    /// The splash: a dark veil over the hall, an abstract crown-and-crate mark
    /// ringed with harvest spokes, and one functional line. The branding here
    /// is colour and shape - nothing on this screen names the game.
    ///
    /// The mark goes in as the FIRST child of the splash body and the loading
    /// bar is pushed back to last, because the body holds exactly one child
    /// (the bar) and anything added after it would be drawn over it.
    public static void DressSplash(TMP_FontAsset _0x991cdec5, Sprite _0x4978105f, Sprite _0x9f78ef4d)
    {
        Transform _0x9abfebb4 = PanelBody(_0x53431849._0xfa200dc8.SPLASH);
        if (_0x9abfebb4 == null)
        {
            return;
        }

        Transform _0x4f719062 = _0x9abfebb4.childCount > 0 ? _0x9abfebb4.GetChild(_0x9abfebb4.childCount - 1) : null;
        RectTransform _0xdf9e02dc = _0xc7d755ab.Stretch(_0x9abfebb4, _0x06d6d251._0x0fc34138(new byte[10] { 177, 146, 142, 131, 145, 138, 175, 131, 144, 137 }, 226));
        _0xdf9e02dc.SetAsFirstSibling();
        Image _0x57dc28f3 = _0xdf9e02dc.gameObject.AddComponent<Image>();
        _0x57dc28f3.color = _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.88f);
        _0x57dc28f3.raycastTarget = false;
        RectTransform _0xfecdc723 = _0xc7d755ab.Node(_0xdf9e02dc, _0x06d6d251._0x0fc34138(new byte[11] { 121, 90, 70, 75, 89, 66, 105, 88, 79, 89, 94 }, 42), new Vector2(0.5f, 0.5f), new Vector2(0f, 300f), new Vector2(660f, 660f));
        for (int _0x7ceb2e02 = 0; _0x7ceb2e02 < 18; _0x7ceb2e02++)
        {
            float _0x3d37f170 = (360f / 18f) * _0x7ceb2e02;
            float _0x683f68b6 = _0x3d37f170 * Mathf.Deg2Rad;
            Image _0x9ec5e101 = _0xc7d755ab.Plate(_0xfecdc723, _0x06d6d251._0x0fc34138(new byte[11] { 51, 16, 12, 1, 19, 8, 51, 16, 15, 11, 5 }, 96), new Vector2(0.5f, 0.5f), new Vector2(Mathf.Sin(_0x683f68b6) * 276f, Mathf.Cos(_0x683f68b6) * 276f), new Vector2(44f, 14f), _0x9f78ef4d, _0xb0c2dde3.WithAlpha(_0x7ceb2e02 % 3 == 0 ? _0xb0c2dde3.Gold : _0xb0c2dde3.Lime, 0.78f));
            _0x9ec5e101.rectTransform.localRotation = Quaternion.Euler(0f, 0f, -_0x3d37f170);
        }

        _0xc7d755ab.Plate(_0xfecdc723, _0x06d6d251._0x0fc34138(new byte[10] { 108, 79, 83, 94, 76, 87, 119, 94, 83, 80 }, 63), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(440f, 440f), _0x9f78ef4d, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.DeepLift, 0.92f));
        _0xc7d755ab.Picture(_0xfecdc723, _0x06d6d251._0x0fc34138(new byte[12] { 43, 8, 20, 25, 11, 16, 61, 21, 26, 20, 29, 21 }, 120), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(330f, 330f), _0x4978105f, _0xb0c2dde3.Gold);
        _0xc7d755ab.Caption(_0xdf9e02dc, _0x06d6d251._0x0fc34138(new byte[10] { 147, 176, 172, 161, 179, 168, 140, 169, 174, 165 }, 192), new Vector2(0.5f, 0.5f), new Vector2(0f, -210f), new Vector2(880f, 90f), _0x06d6d251._0x0fc34138(new byte[19] { 134, 133, 139, 142, 131, 132, 141, 234, 158, 130, 143, 234, 130, 139, 152, 156, 143, 153, 158 }, 202), 42f, _0xb0c2dde3.Cream, TextAlignmentOptions.Center, _0x991cdec5);
        _0xc7d755ab.Plate(_0xdf9e02dc, _0x06d6d251._0x0fc34138(new byte[10] { 8, 43, 55, 58, 40, 51, 9, 46, 55, 62 }, 91), new Vector2(0.5f, 0.5f), new Vector2(0f, -288f), new Vector2(440f, 8f), _0x9f78ef4d, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Gold, 0.9f));
        if (_0x4f719062 != null)
        {
            _0x4f719062.SetAsLastSibling();
        }
    }
}

internal static class _0x06d6d251
{
    internal static string _0x0fc34138(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}