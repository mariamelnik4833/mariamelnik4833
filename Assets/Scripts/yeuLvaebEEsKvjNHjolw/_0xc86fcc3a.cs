using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The menu. It dresses the splash, empties the template pages this game never
/// opens, and builds its own body inside the template's default panel: the
/// purse, a harvest ring that shows how much of the palace has been served,
/// the hall that is currently chosen, PLAY, and two optional sheets.
///
/// PLAY is the template's own scene-loading control, re-dressed rather than
/// duplicated. The face is added as a CHILD of that button, so the press
/// bubbles up to the component that already knows how to load the hall; this
/// director never loads a scene for PLAY itself, which would fire the load
/// twice. Its size is pinned in the scene file, not left to the template's
/// stretching anchors (rule G.3).
///
/// The purse is drawn here rather than through the template's coin counter:
/// this template's menu carries no coin container at all, so there is nothing
/// to re-use and a plate of our own reading the same stored value is the only
/// honest way to show it.
public sealed class _0xc86fcc3a : MonoBehaviour
{
    private const float PlayHeight = 168f;
    private void BuildSecondary(Transform _0x8a289c8a)
    {
        RectTransform _0x7b9e7e31 = _0xc7d755ab.Node(_0x8a289c8a, _0xfa4297c8._0x06d83e0b(new byte[12] { 203, 253, 251, 247, 246, 252, 249, 234, 225, 202, 247, 239 }, 152), new Vector2(0.5f, SecondaryRow), Vector2.zero, new Vector2(1140f, 150f));
        Button _0x9a0e4d79 = _0xc7d755ab.Action(_0x7b9e7e31, _0xfa4297c8._0x06d83e0b(new byte[11] { 79, 102, 107, 107, 116, 69, 114, 115, 115, 104, 105 }, 7), new Vector2(0.5f, 0.5f), new Vector2(-280f, 0f), new Vector2(520f, 124f), this._plateSprite, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.DeepLift, 0.96f), _0xfa4297c8._0x06d83e0b(new byte[5] { 111, 102, 107, 107, 116 }, 39), 44f, _0xb0c2dde3.Gold, this._font);
        _0x9a0e4d79.onClick.AddListener(() => this._0x4bcca7bb());
        Button _0x71f68c18 = _0xc7d755ab.Action(_0x7b9e7e31, _0xfa4297c8._0x06d83e0b(new byte[11] { 142, 169, 177, 146, 169, 132, 179, 178, 178, 169, 168 }, 198), new Vector2(0.5f, 0.5f), new Vector2(280f, 0f), new Vector2(520f, 124f), this._plateSprite, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.DeepLift, 0.96f), _0xfa4297c8._0x06d83e0b(new byte[11] { 132, 131, 155, 236, 152, 131, 236, 156, 128, 141, 149 }, 204), 42f, _0xb0c2dde3.Gold, this._font);
        _0x71f68c18.onClick.AddListener(() => this._0xbdc50f2b());
    }

    private TextMeshProUGUI _0x4cecb5a7;
    private RectTransform _0x209bdee4;
    [SerializeField]
    private Sprite _crownSprite;
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _starSprite;
    private void _0x4bcca7bb()
    {
        if (this._halls != null)
        {
            if (this._howTo != null)
            {
                this._howTo._0x7decdfc8();
            }

            this._halls._0x38d77286();
        }
    }

    private const float HallRow = 0.545f;
    [SerializeField]
    private Sprite _fruitApple;
    private void _0xa4c6088c()
    {
        int _0xa98216e5 = this._0xec3bd31a._0x62d9fb94;
        int _0xdafc8d44 = this._0xec3bd31a._0x04febe6c;
        if (this._0xf31cc233 != null)
        {
            this._0xf31cc233.text = this._0xec3bd31a._0x2d95bc07 + _0xfa4297c8._0x06d83e0b(new byte[6] { 230, 133, 137, 143, 136, 149 }, 198);
        }

        if (this._0x4cecb5a7 != null)
        {
            this._0x4cecb5a7.text = _0xdafc8d44 + _0xfa4297c8._0x06d83e0b(new byte[3] { 47, 32, 47 }, 15) + _0x1d79b688.Halls;
        }

        if (this._0x416ea105 != null)
        {
            this._0x416ea105.fillAmount = Mathf.Clamp01(_0xdafc8d44 / (float)_0x1d79b688.Halls);
        }

        if (this._0x71728135 != null)
        {
            this._0x71728135.text = _0xfa4297c8._0x06d83e0b(new byte[5] { 79, 70, 75, 75, 39 }, 7) + _0xa98216e5 + _0xfa4297c8._0x06d83e0b(new byte[3] { 97, 108, 97 }, 65) + (_0x1d79b688.QuotaPerRoom(_0xa98216e5) * _0x1d79b688.Rooms) + _0xfa4297c8._0x06d83e0b(new byte[7] { 234, 140, 152, 159, 131, 158, 153 }, 202);
        }

        if (this._0x4c297041 != null)
        {
            int _0xc2a16cc4 = this._0xec3bd31a._0xb5470f9f;
            this._0x4c297041.text = _0xc2a16cc4 > 0 ? (_0xfa4297c8._0x06d83e0b(new byte[10] { 57, 62, 40, 47, 91, 51, 58, 55, 55, 91 }, 123) + _0xc2a16cc4 + _0xfa4297c8._0x06d83e0b(new byte[3] { 230, 235, 230 }, 198) + this._0xec3bd31a._0xf90d650c(_0xc2a16cc4)) : _0xfa4297c8._0x06d83e0b(new byte[18] { 108, 109, 2, 106, 99, 110, 110, 2, 113, 103, 112, 116, 103, 102, 2, 123, 103, 118 }, 34);
        }
    }

    [SerializeField]
    private Sprite _fruitLemon;
    private void _0xbdc50f2b()
    {
        if (this._howTo != null)
        {
            if (this._halls != null)
            {
                this._halls._0x319da7c2();
            }

            this._howTo._0x04207357();
        }
    }

    private const float ObjectiveRow = 0.485f;
    private void BuildPurse(Transform _0x4d0e03cc)
    {
        this._0x209bdee4 = _0xc7d755ab.Node(_0x4d0e03cc, _0xfa4297c8._0x06d83e0b(new byte[9] { 29, 56, 63, 62, 40, 30, 33, 34, 57 }, 77), new Vector2(0.5f, PurseRow), Vector2.zero, new Vector2(460f, 118f));
        _0xc7d755ab.Plate(this._0x209bdee4, _0xfa4297c8._0x06d83e0b(new byte[10] { 66, 103, 96, 97, 119, 66, 126, 115, 102, 119 }, 18), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(460f, 118f), this._plateSprite, _0xb0c2dde3.Gold);
        _0xc7d755ab.Plate(this._0x209bdee4, _0xfa4297c8._0x06d83e0b(new byte[9] { 171, 142, 137, 136, 158, 172, 158, 151, 151 }, 251), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(432f, 92f), this._plateSprite, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.94f));
        this._0xf31cc233 = _0xc7d755ab.Caption(this._0x209bdee4, _0xfa4297c8._0x06d83e0b(new byte[10] { 168, 141, 138, 139, 157, 180, 153, 154, 157, 148 }, 248), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(400f, 80f), string.Empty, 44f, _0xb0c2dde3.Gold, TextAlignmentOptions.Center, this._font);
    }

    private const float PurseRow = 0.945f;
    private const float PlayWidth = 760f;
    /// Dresses the template's scene-loading control instead of adding a second
    /// one next to it. The face is a child of that button, so the press reaches
    /// the button itself and the hall loads exactly once.
    private void _0xd29b6868()
    {
        if (this._playSlot == null)
        {
            return;
        }

        RectTransform _0xd8a541aa = _0xc7d755ab.Stretch(this._playSlot.transform, _0xfa4297c8._0x06d83e0b(new byte[8] { 9, 53, 56, 32, 31, 56, 58, 60 }, 89));
        Image _0x881fcf1d = _0xd8a541aa.gameObject.AddComponent<Image>();
        _0x881fcf1d.sprite = this._plateSprite;
        _0x881fcf1d.type = Image.Type.Sliced;
        _0x881fcf1d.pixelsPerUnitMultiplier = _0xc7d755ab.SliceScale(new Vector2(PlayWidth, PlayHeight));
        _0x881fcf1d.color = _0xb0c2dde3.Gold;
        _0x881fcf1d.raycastTarget = true;
        _0x881fcf1d.canvasRenderer.cullTransparentMesh = false;
        _0xc7d755ab.Plate(_0xd8a541aa, _0xfa4297c8._0x06d83e0b(new byte[8] { 26, 38, 43, 51, 15, 46, 45, 47 }, 74), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(PlayWidth - 22f, PlayHeight - 22f), this._plateSprite, _0xb0c2dde3.Lime);
        _0xc7d755ab.Caption(_0xd8a541aa, _0xfa4297c8._0x06d83e0b(new byte[9] { 128, 188, 177, 169, 156, 177, 178, 181, 188 }, 208), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(PlayWidth - 90f, PlayHeight - 48f), _0xfa4297c8._0x06d83e0b(new byte[4] { 5, 25, 20, 12 }, 85), 62f, _0xb0c2dde3.Deep, TextAlignmentOptions.Center, this._font);
        _0xd8a541aa.DOScale(1.04f, 1.1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    [SerializeField]
    private Sprite _fruitBerry;
    private const float RingSize = 420f;
    [SerializeField]
    private _0xcbdba607 _playSlot;
    [SerializeField]
    private Sprite _closeIcon;
    private TextMeshProUGUI _0x4c297041;
    /// The hero: a ring that fills as halls are served, the crown-and-crate
    /// mark at its heart, and four harvest sorts drifting around it. Nothing
    /// here is pressable, so nothing here takes a ray.
    private void BuildRing(Transform _0x7c4f18d4)
    {
        RectTransform _0x4fb9ad83 = _0xc7d755ab.Node(_0x7c4f18d4, _0xfa4297c8._0x06d83e0b(new byte[4] { 116, 89, 78, 83 }, 60), new Vector2(0.5f, RingRow), Vector2.zero, new Vector2(1060f, 760f));
        _0xc7d755ab.Picture(_0x4fb9ad83, _0xfa4297c8._0x06d83e0b(new byte[9] { 125, 70, 65, 72, 123, 93, 78, 76, 68 }, 47), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(RingSize, RingSize), this._plateSprite, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.80f));
        this._0x416ea105 = _0xc7d755ab.Ring(_0x4fb9ad83, _0xfa4297c8._0x06d83e0b(new byte[8] { 10, 49, 54, 63, 30, 49, 52, 52 }, 88), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(RingSize, RingSize), this._plateSprite, _0xb0c2dde3.Lime);
        _0xc7d755ab.Picture(_0x4fb9ad83, _0xfa4297c8._0x06d83e0b(new byte[8] { 47, 20, 19, 26, 42, 24, 17, 17 }, 125), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(RingSize - 54f, RingSize - 54f), this._plateSprite, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.DeepLift, 0.98f));
        _0xc7d755ab.Picture(_0x4fb9ad83, _0xfa4297c8._0x06d83e0b(new byte[9] { 27, 32, 39, 46, 10, 59, 38, 62, 39 }, 73), new Vector2(0.5f, 0.5f), new Vector2(0f, 58f), new Vector2(186f, 186f), this._crownSprite, _0xb0c2dde3.Gold);
        this._0x4cecb5a7 = _0xc7d755ab.Caption(_0x4fb9ad83, _0xfa4297c8._0x06d83e0b(new byte[9] { 213, 238, 233, 224, 203, 230, 229, 226, 235 }, 135), new Vector2(0.5f, 0.5f), new Vector2(0f, -62f), new Vector2(300f, 92f), string.Empty, 64f, _0xb0c2dde3.Gold, TextAlignmentOptions.Center, this._font);
        _0xc7d755ab.Caption(_0x4fb9ad83, _0xfa4297c8._0x06d83e0b(new byte[11] { 48, 11, 12, 5, 33, 3, 18, 22, 11, 13, 12 }, 98), new Vector2(0.5f, 0.5f), new Vector2(0f, -136f), new Vector2(380f, 58f), _0xfa4297c8._0x06d83e0b(new byte[12] { 18, 27, 22, 22, 9, 122, 9, 31, 8, 12, 31, 30 }, 90), 32f, _0xb0c2dde3.Muted, TextAlignmentOptions.Center, this._font);
        Sprite[] _0xf411bf56 =
        {
            this._fruitApple,
            this._fruitLemon,
            this._fruitPlum,
            this._fruitBerry
        };
        float[] _0x7ed8baa3 =
        {
            -400f,
            400f,
            -330f,
            330f
        };
        float[] _0xa9196102 =
        {
            210f,
            210f,
            -190f,
            -190f
        };
        for (int _0x1f5e56d0 = 0; _0x1f5e56d0 < _0xf411bf56.Length; _0x1f5e56d0++)
        {
            Image _0x0685c5a1 = _0xc7d755ab.Picture(_0x4fb9ad83, _0xfa4297c8._0x06d83e0b(new byte[9] { 59, 22, 1, 28, 53, 1, 6, 26, 7 }, 115) + _0x1f5e56d0, new Vector2(0.5f, 0.5f), new Vector2(_0x7ed8baa3[_0x1f5e56d0], _0xa9196102[_0x1f5e56d0]), new Vector2(136f, 136f), _0xf411bf56[_0x1f5e56d0], Color.white);
            RectTransform _0x182d4023 = _0x0685c5a1.rectTransform;
            _0x182d4023.DOAnchorPosY(_0x182d4023.anchoredPosition.y + 18f, 2.4f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetDelay(_0x1f5e56d0 * 0.3f);
        }
    }

    private readonly _0x4ae20df6 _0xec3bd31a = new _0x4ae20df6();
    [SerializeField]
    private Sprite _fruitPlum;
    private TextMeshProUGUI _0x71728135;
    private void Start()
    {
        _0xb01f476d.BlankUnusedPages();
        _0xb01f476d.DressSplash(this._font, this._crownSprite, this._plateSprite);
        Transform _0xac28eb5d = _0xb01f476d.PanelBody(_0x53431849._0xfa200dc8.DEFAULT);
        if (_0xac28eb5d == null)
        {
            return;
        }

        Transform _0x3328c2d1 = this._playSlot != null ? this._playSlot.transform : null;
        _0xb01f476d.ClearPanelBody(_0x53431849._0xfa200dc8.DEFAULT, _0x3328c2d1);
        RectTransform _0xecbfc077 = _0xc7d755ab.Stretch(_0xac28eb5d, _0xfa4297c8._0x06d83e0b(new byte[8] { 98, 74, 65, 90, 109, 64, 75, 86 }, 47));
        this.BuildPurse(_0xecbfc077);
        this.BuildRing(_0xecbfc077);
        this._0x71728135 = _0xc7d755ab.Caption(_0xecbfc077, _0xfa4297c8._0x06d83e0b(new byte[8] { 243, 218, 215, 215, 247, 210, 213, 222 }, 187), new Vector2(0.5f, HallRow), Vector2.zero, new Vector2(1060f, 84f), string.Empty, 46f, _0xb0c2dde3.Gold, TextAlignmentOptions.Center, this._font);
        _0xc7d755ab.Caption(_0xecbfc077, _0xfa4297c8._0x06d83e0b(new byte[9] { 84, 121, 113, 126, 120, 111, 114, 109, 126 }, 27), new Vector2(0.5f, ObjectiveRow), Vector2.zero, new Vector2(1100f, 150f), _0xfa4297c8._0x06d83e0b(new byte[37] { 101, 121, 100, 98, 22, 98, 126, 115, 22, 126, 119, 100, 96, 115, 101, 98, 60, 127, 120, 98, 121, 22, 98, 126, 115, 22, 100, 127, 113, 126, 98, 22, 100, 121, 121, 123, 101 }, 54), 40f, _0xb0c2dde3.Cream, TextAlignmentOptions.Center, this._font);
        this._0xd29b6868();
        this.BuildSecondary(_0xecbfc077);
        this._0x4c297041 = _0xc7d755ab.Caption(_0xecbfc077, _0xfa4297c8._0x06d83e0b(new byte[10] { 219, 242, 242, 233, 248, 239, 209, 244, 243, 248 }, 157), new Vector2(0.5f, FooterRow), Vector2.zero, new Vector2(1060f, 76f), string.Empty, 36f, _0xb0c2dde3.Muted, TextAlignmentOptions.Center, this._font);
        if (this._howTo != null)
        {
            this._howTo._0x3ab3dcd0(_0xac28eb5d, this._font, this._plateSprite, this._closeIcon, this._fruitApple, this._fruitLemon, this._fruitPlum, () => this._0x4bcca7bb());
        }

        if (this._halls != null)
        {
            this._halls._0xb0143e10(_0xac28eb5d, this._font, this._plateSprite, this._closeIcon, this._starSprite, this._lockSprite, _0x159f376f => this._0x7e804a50(_0x159f376f), () => this._0xd3187d96());
        }

        this._0xa4c6088c();
    }

    [SerializeField]
    private _0x246bf86d _howTo;
    private const float RingRow = 0.735f;
    private void _0xa23781f8()
    {
        if (this._0xf31cc233 != null)
        {
            _0x7ffdfc32.ApplyOutline(this._0xf31cc233, _0xb0c2dde3.Gold);
        }
    }

    private const float SecondaryRow = 0.185f;
    /// A locked hall pulls the eye to the thing that unlocks it.
    private void _0xd3187d96()
    {
        if (this._0x209bdee4 == null || this._0xf31cc233 == null)
        {
            return;
        }

        this._0x209bdee4.DOKill(true);
        this._0x209bdee4.DOPunchScale(Vector3.one * 0.14f, 0.32f, 8, 0.6f);
        _0x7ffdfc32.ApplyOutline(this._0xf31cc233, _0xb0c2dde3.Coral);
        DOVirtual.DelayedCall(0.6f, () => this._0xa23781f8());
    }

    [SerializeField]
    private Sprite _plateSprite;
    [SerializeField]
    private _0x8fa521de _halls;
    private Image _0x416ea105;
    private void _0x7e804a50(int _0x8db4b8e7)
    {
        this._0xec3bd31a._0x62d9fb94 = _0x8db4b8e7;
        this._0xa4c6088c();
        _0x86c44cb0 _0xa9ee4e7f = _0x86c44cb0.Instance;
        if (_0xa9ee4e7f != null)
        {
            _0xa9ee4e7f.LoadSceneByIndex(_0x53431849._0x7146dbc1.SCENE_1);
        }
    }

    private TextMeshProUGUI _0xf31cc233;
    private const float FooterRow = 0.085f;
    [SerializeField]
    private Sprite _lockSprite;
}

internal static class _0xfa4297c8
{
    internal static string _0x06d83e0b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}