using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Owns the three cards a trip can raise. The template's own cards carry
/// another game's wording, a grey body, static labels for metrics this game
/// does not have, and a close button with no icon assigned - which Unity
/// draws as a plain white square. So every child of a card body is switched
/// off and this game builds its own inside it: a crest, a headline in the
/// language of the palace, two metric lines, two captioned actions and a real
/// close glyph taken from a serialized sprite (rule C.3).
///
/// Each button is built explicitly with its own caption, so a caption can
/// never land on the close cross the way an index-ordered pass would put it
/// there (rule C.17). The cross carries no words at all.
public sealed class _0x9de31edd : MonoBehaviour
{
    public void _0x60cb79c4(int _0x9693e5b2, int _0xacbdee69, int _0x0830c61e)
    {
        this._0x5810f08d(Win, _0x1c1aad96._0x65cd261e(new byte[11] { 123, 114, 127, 127, 19, 96, 118, 97, 101, 118, 119 }, 51), _0x1c1aad96._0x65cd261e(new byte[32] { 59, 40, 59, 44, 39, 94, 44, 49, 49, 51, 94, 54, 63, 45, 94, 41, 54, 63, 42, 94, 55, 42, 94, 63, 45, 53, 59, 58, 94, 56, 49, 44 }, 126), _0x1c1aad96._0x65cd261e(new byte[6] { 198, 214, 218, 199, 208, 181 }, 149) + _0x9693e5b2 + _0x1c1aad96._0x65cd261e(new byte[8] { 232, 229, 232, 138, 141, 155, 156, 232 }, 200) + _0xacbdee69, _0x1c1aad96._0x65cd261e(new byte[14] { 29, 20, 7, 3, 16, 6, 1, 117, 23, 26, 27, 0, 6, 117 }, 85) + (_0x0830c61e * _0x1d79b688.WinBonusPerAttempt));
    }

    public Button _0x4469bcdd
    {
        get
        {
            return this._0x3f431ef7[Win];
        }
    }

    private const int Lose = 1;
    private readonly Button[] _0x3f431ef7 = new Button[3];
    private bool _0xb328712f;
    private readonly Button[] _0xda7b5f6c = new Button[3];
    private readonly TextMeshProUGUI[] _0x10577447 = new TextMeshProUGUI[3];
    public void _0x3d7d4ff5(int _0xe490af2c, int _0xbbcf1414, int _0x10b61d7a)
    {
        this._0x5810f08d(Pause, _0x1c1aad96._0x65cd261e(new byte[11] { 96, 105, 100, 100, 8, 120, 105, 125, 123, 109, 108 }, 40), _0x1c1aad96._0x65cd261e(new byte[26] { 177, 164, 181, 197, 164, 197, 162, 164, 177, 160, 197, 177, 170, 197, 163, 169, 172, 181, 197, 172, 177, 182, 197, 164, 183, 168 }, 229), _0x1c1aad96._0x65cd261e(new byte[6] { 120, 104, 100, 121, 110, 11 }, 43) + _0x10b61d7a, _0x1c1aad96._0x65cd261e(new byte[5] { 60, 53, 56, 56, 84 }, 116) + _0xe490af2c + _0x1c1aad96._0x65cd261e(new byte[3] { 166, 171, 166 }, 134) + _0xbbcf1414 + _0x1c1aad96._0x65cd261e(new byte[4] { 180, 219, 210, 180 }, 148) + _0x1d79b688.Rooms + _0x1c1aad96._0x65cd261e(new byte[13] { 101, 23, 10, 10, 8, 22, 101, 3, 12, 9, 9, 0, 1 }, 69));
    }

    [SerializeField]
    private Sprite _plateSprite;
    public Button _0xd3f048aa
    {
        get
        {
            return this._0xda7b5f6c[Pause];
        }
    }

    private const float CardHeight = 1340f;
    private readonly TextMeshProUGUI[] _0x260f9ac9 = new TextMeshProUGUI[3];
    public Button _0xa1816f6e
    {
        get
        {
            return this._0x99720dd4[Lose];
        }
    }

    public Button _0x83cd7309
    {
        get
        {
            return this._0xda7b5f6c[Lose];
        }
    }

    private const float CardWidth = 1000f;
    public void _0xc8eb803e()
    {
        if (this._0xb328712f)
        {
            return;
        }

        _0xf7dd1359 _0xa2105c3c = _0xf7dd1359.Instance;
        if (_0xa2105c3c == null || _0xa2105c3c.Pops == null)
        {
            return;
        }

        _0x44a03f11 _0xf4a3d203 = _0xf7dd1359.Instance._0x8a941bbf(_0x53431849._0x0733d9ad.WIN);
        _0x44a03f11 _0x7dfa6910 = _0xf7dd1359.Instance._0x8a941bbf(_0x53431849._0x0733d9ad.LOSE);
        _0x44a03f11 _0x5bc9344e = _0xf7dd1359.Instance._0x8a941bbf(_0x53431849._0x0733d9ad.PAUSE);
        this._0x75f38226(_0xf4a3d203, Win, _0x1c1aad96._0x65cd261e(new byte[11] { 91, 82, 95, 95, 51, 64, 86, 65, 69, 86, 87 }, 19), _0xb0c2dde3.Lime, _0x1c1aad96._0x65cd261e(new byte[9] { 75, 64, 93, 81, 37, 77, 68, 73, 73 }, 5), _0x1c1aad96._0x65cd261e(new byte[4] { 1, 9, 2, 25 }, 76));
        this._0x75f38226(_0x7dfa6910, Lose, _0x1c1aad96._0x65cd261e(new byte[11] { 99, 106, 103, 103, 11, 104, 103, 100, 120, 110, 111 }, 43), _0xb0c2dde3.Coral, _0x1c1aad96._0x65cd261e(new byte[9] { 17, 23, 28, 101, 4, 2, 4, 12, 11 }, 69), _0x1c1aad96._0x65cd261e(new byte[4] { 225, 233, 226, 249 }, 172));
        this._0x75f38226(_0x5bc9344e, Pause, _0x1c1aad96._0x65cd261e(new byte[11] { 229, 236, 225, 225, 141, 253, 236, 248, 254, 232, 233 }, 173), _0xb0c2dde3.Gold, _0x1c1aad96._0x65cd261e(new byte[6] { 243, 228, 242, 244, 236, 228 }, 161), _0x1c1aad96._0x65cd261e(new byte[4] { 181, 189, 182, 173 }, 248));
        this._0xb328712f = true;
    }

    public void _0x8e7b6aad()
    {
        _0xf7dd1359 _0xafd0a195 = _0xf7dd1359.Instance;
        if (_0xafd0a195 != null)
        {
            _0xafd0a195._0xeb69e208();
        }
    }

    public Button _0x86dd7685
    {
        get
        {
            return this._0x99720dd4[Pause];
        }
    }

    private const int Win = 0;
    private readonly Button[] _0x99720dd4 = new Button[3];
    private void _0x5810f08d(int _0x79556bc9, string _0xd9dae4f9, string _0x7e7dd3d8, string _0x695c8c74, string _0xe822857f)
    {
        if (this._0x260f9ac9[_0x79556bc9] != null)
        {
            this._0x260f9ac9[_0x79556bc9].text = _0xd9dae4f9;
        }

        if (this._0x41803ab1[_0x79556bc9] != null)
        {
            this._0x41803ab1[_0x79556bc9].text = _0x7e7dd3d8;
        }

        if (this._0x10577447[_0x79556bc9] != null)
        {
            this._0x10577447[_0x79556bc9].text = _0x695c8c74;
        }

        if (this._0x7ae50d3f[_0x79556bc9] != null)
        {
            this._0x7ae50d3f[_0x79556bc9].text = _0xe822857f;
        }
    }

    public Button _0xc65a4b1a
    {
        get
        {
            return this._0x3f431ef7[Pause];
        }
    }

    private const int Pause = 2;
    [SerializeField]
    private TMP_FontAsset _font;
    public Button _0x09a3360f
    {
        get
        {
            return this._0xda7b5f6c[Win];
        }
    }

    private readonly TextMeshProUGUI[] _0x7ae50d3f = new TextMeshProUGUI[3];
    public void _0x5697f9ac()
    {
        _0x44a03f11 _0xc37fc7ab = _0xf7dd1359.Instance._0x8a941bbf(_0x53431849._0x0733d9ad.LOSE);
        if (_0xc37fc7ab == null)
        {
            return;
        }

        _0xf7dd1359.Instance._0x1fad8604(_0x53431849._0x0733d9ad.LOSE);
    }

    public void _0xdb21976b()
    {
        _0x44a03f11 _0x223c339d = _0xf7dd1359.Instance._0x8a941bbf(_0x53431849._0x0733d9ad.WIN);
        if (_0x223c339d == null)
        {
            return;
        }

        _0xf7dd1359.Instance._0x1fad8604(_0x53431849._0x0733d9ad.WIN);
    }

    [SerializeField]
    private Sprite _closeIcon;
    public Button _0xd3640cfe
    {
        get
        {
            return this._0x3f431ef7[Lose];
        }
    }

    [SerializeField]
    private Sprite _crownSprite;
    public Button _0x837072f7
    {
        get
        {
            return this._0x99720dd4[Win];
        }
    }

    private void _0x75f38226(_0x44a03f11 _0x4bd7c494, int _0x14e3a20a, string _0xaa44a424, Color _0x9762c64f, string _0x630554db, string _0xb1191bcd)
    {
        if (_0x4bd7c494 == null || _0x4bd7c494.Content == null)
        {
            return;
        }

        Transform _0xdf387769 = _0x4bd7c494.Content.transform;
        for (int _0x237d8024 = _0xdf387769.childCount - 1; _0x237d8024 >= 0; _0x237d8024--)
        {
            _0xdf387769.GetChild(_0x237d8024).gameObject.SetActive(false);
        }

        RectTransform _0x9771c5d0 = _0xc7d755ab.Stretch(_0xdf387769, _0x1c1aad96._0x65cd261e(new byte[8] { 233, 203, 216, 206, 226, 197, 217, 222 }, 170));
        Image _0x6332e3e8 = _0xc7d755ab.Plate(_0x9771c5d0, _0x1c1aad96._0x65cd261e(new byte[4] { 26, 56, 43, 61 }, 89), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(CardWidth, CardHeight), this._plateSprite, _0xb0c2dde3.Gold);
        Image _0x52d6e619 = _0xc7d755ab.Plate(_0x6332e3e8.transform, _0x1c1aad96._0x65cd261e(new byte[8] { 229, 199, 212, 194, 228, 201, 194, 223 }, 166), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(CardWidth - 32f, CardHeight - 32f), this._plateSprite, _0xb0c2dde3.DeepLift);
        _0xc7d755ab.Plate(_0x52d6e619.transform, _0x1c1aad96._0x65cd261e(new byte[8] { 106, 72, 91, 77, 126, 76, 69, 69 }, 41), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(CardWidth - 64f, CardHeight - 64f), this._plateSprite, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.96f));
        _0xc7d755ab.Picture(_0x6332e3e8.transform, _0x1c1aad96._0x65cd261e(new byte[9] { 199, 229, 246, 224, 199, 246, 225, 247, 240 }, 132), new Vector2(0.5f, 1f), new Vector2(0f, -240f), new Vector2(290f, 290f), this._crownSprite, _0xb0c2dde3.Gold);
        this._0x260f9ac9[_0x14e3a20a] = _0xc7d755ab.Caption(_0x6332e3e8.transform, _0x1c1aad96._0x65cd261e(new byte[13] { 213, 247, 228, 242, 194, 255, 226, 250, 243, 218, 255, 248, 243 }, 150), new Vector2(0.5f, 1f), new Vector2(0f, -500f), new Vector2(880f, 128f), _0xaa44a424, 70f, _0x9762c64f, TextAlignmentOptions.Center, this._font);
        this._0x41803ab1[_0x14e3a20a] = _0xc7d755ab.Caption(_0x6332e3e8.transform, _0x1c1aad96._0x65cd261e(new byte[12] { 95, 125, 110, 120, 94, 115, 120, 101, 72, 121, 100, 104 }, 28), new Vector2(0.5f, 1f), new Vector2(0f, -636f), new Vector2(880f, 96f), string.Empty, 40f, _0xb0c2dde3.Muted, TextAlignmentOptions.Center, this._font);
        // The template's own metric labels are left behind with the rest of
        // its card: these two carry this game's measures and are always filled.
        this._0x10577447[_0x14e3a20a] = _0xc7d755ab.Caption(_0x6332e3e8.transform, _0x1c1aad96._0x65cd261e(new byte[10] { 15, 45, 62, 40, 1, 41, 56, 62, 37, 47 }, 76), new Vector2(0.5f, 1f), new Vector2(0f, -772f), new Vector2(880f, 92f), string.Empty, 44f, _0xb0c2dde3.Gold, TextAlignmentOptions.Center, this._font);
        this._0x7ae50d3f[_0x14e3a20a] = _0xc7d755ab.Caption(_0x6332e3e8.transform, _0x1c1aad96._0x65cd261e(new byte[9] { 68, 102, 117, 99, 66, 127, 115, 117, 102 }, 7), new Vector2(0.5f, 1f), new Vector2(0f, -882f), new Vector2(880f, 88f), string.Empty, 40f, _0xb0c2dde3.Cream, TextAlignmentOptions.Center, this._font);
        this._0x99720dd4[_0x14e3a20a] = _0xc7d755ab.Action(_0x6332e3e8.transform, _0x1c1aad96._0x65cd261e(new byte[11] { 180, 150, 133, 147, 167, 133, 158, 154, 150, 133, 142 }, 247), new Vector2(0.5f, 0f), new Vector2(-240f, 150f), new Vector2(440f, 150f), this._plateSprite, _0xb0c2dde3.Lime, _0x630554db, 40f, _0xb0c2dde3.Deep, this._font);
        this._0xda7b5f6c[_0x14e3a20a] = _0xc7d755ab.Action(_0x6332e3e8.transform, _0x1c1aad96._0x65cd261e(new byte[13] { 240, 210, 193, 215, 224, 214, 208, 220, 221, 215, 210, 193, 202 }, 179), new Vector2(0.5f, 0f), new Vector2(240f, 150f), new Vector2(440f, 150f), this._plateSprite, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.DeepLift, 0.98f), _0xb1191bcd, 40f, _0xb0c2dde3.Gold, this._font);
        this._0x3f431ef7[_0x14e3a20a] = _0xc7d755ab.IconAction(_0x6332e3e8.transform, _0x1c1aad96._0x65cd261e(new byte[9] { 85, 119, 100, 114, 85, 122, 121, 101, 115 }, 22), new Vector2(1f, 1f), new Vector2(-84f, -84f), 100f, this._plateSprite, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.98f), this._closeIcon, _0xb0c2dde3.Gold);
        _0x6332e3e8.transform.localScale = Vector3.one;
    }

    public void _0x07462e37(bool _0x09303449, int _0x055b4e52, int _0x3e58f61c, int _0xf6c0bf97)
    {
        this._0x5810f08d(Lose, _0x09303449 ? _0x1c1aad96._0x65cd261e(new byte[17] { 21, 2, 19, 18, 21, 9, 103, 4, 15, 18, 19, 2, 103, 1, 18, 11, 11 }, 71) : _0x1c1aad96._0x65cd261e(new byte[17] { 81, 74, 74, 37, 72, 68, 75, 92, 37, 72, 76, 86, 81, 68, 78, 64, 86 }, 5), _0x055b4e52 + _0x1c1aad96._0x65cd261e(new byte[4] { 214, 185, 176, 214 }, 246) + _0x1d79b688.Rooms + _0x1c1aad96._0x65cd261e(new byte[13] { 230, 148, 137, 137, 139, 149, 230, 128, 143, 138, 138, 131, 130 }, 198), _0x1c1aad96._0x65cd261e(new byte[6] { 117, 101, 105, 116, 99, 6 }, 38) + _0x3e58f61c + _0x1c1aad96._0x65cd261e(new byte[8] { 170, 167, 170, 200, 207, 217, 222, 170 }, 138) + _0xf6c0bf97, _0x09303449 ? _0x1c1aad96._0x65cd261e(new byte[26] { 6, 26, 23, 114, 25, 27, 6, 17, 26, 23, 28, 114, 17, 19, 28, 28, 29, 6, 114, 25, 23, 23, 2, 114, 7, 2 }, 82) : _0x1c1aad96._0x65cd261e(new byte[31] { 22, 0, 21, 2, 9, 97, 21, 9, 4, 97, 0, 19, 12, 18, 97, 3, 4, 7, 14, 19, 4, 97, 21, 9, 4, 24, 97, 17, 0, 18, 18 }, 65));
    }

    public void _0xf1aea688()
    {
        _0x44a03f11 _0xc34034b3 = _0xf7dd1359.Instance._0x8a941bbf(_0x53431849._0x0733d9ad.PAUSE);
        if (_0xc34034b3 == null)
        {
            return;
        }

        _0xf7dd1359.Instance._0x1fad8604(_0x53431849._0x0733d9ad.PAUSE);
    }

    private readonly TextMeshProUGUI[] _0x41803ab1 = new TextMeshProUGUI[3];
}

internal static class _0x1c1aad96
{
    internal static string _0x65cd261e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}