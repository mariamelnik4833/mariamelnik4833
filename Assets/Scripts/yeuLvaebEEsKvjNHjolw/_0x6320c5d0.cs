using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The heads-up display for one trip, built out of this game's own objects
/// rather than hung on the template's placeholders (rule C.2).
///
/// It is deliberately two blocks pinned to the two edges of the screen, with
/// the whole middle left to the shaft: the top block ends about a quarter of
/// a world unit above the receiving arch and the bottom block starts about
/// four tenths below the room floor, so nothing in the display ever sits on
/// top of the board.
///
/// BACK and PAUSE are this game's own buttons. The template's pair in its own
/// top panel is left entirely alone - it is driven by the template's own
/// controller and switched off by the pipeline, so there is never a second
/// mismatched set of controls on screen.
public sealed class _0x6320c5d0 : MonoBehaviour
{
    private RectTransform _0x4c301b64;
    public void _0x5a9941c7(int _0x8bd930c1)
    {
        for (int _0x9e99cfb2 = 0; _0x9e99cfb2 < this._0xc9ad04b5.Length; _0x9e99cfb2++)
        {
            Image _0x3a9d58d8 = this._0xc9ad04b5[_0x9e99cfb2];
            if (_0x3a9d58d8 == null)
            {
                continue;
            }

            bool _0x86031038 = _0x9e99cfb2 < (_0x1d79b688.MistakeBudget - _0x8bd930c1);
            _0x3a9d58d8.sprite = _0x86031038 ? this._0x7a9148ea : this._0x44102733;
            _0x3a9d58d8.preserveAspect = true;
            _0x3a9d58d8.color = _0x86031038 ? _0xb0c2dde3.Lime : _0xb0c2dde3.Coral;
        }
    }

    private const float ChipHeight = 92f;
    public _0x1d0bfd1e _0x49b65b0e
    {
        get
        {
            return this._0xbf383e2d;
        }
    }

    private Button _0x88b6f651;
    public void _0x2546b98d(int _0x80d47bf7)
    {
        if (_0x80d47bf7 < 0 || _0x80d47bf7 >= _0x1d79b688.Rooms)
        {
            return;
        }

        RectTransform _0x0b399923 = this._0x57eb3547[_0x80d47bf7];
        if (_0x0b399923 != null)
        {
            _0x0b399923.DOKill(true);
            _0x0b399923.localScale = Vector3.one;
            _0x0b399923.DOPunchScale(Vector3.one * 0.12f, 0.26f, 8, 0.6f);
        }
    }

    private const float BottomPlateHeight = 300f;
    public void _0xb792212c(string _0xdd638878)
    {
        if (this._0xd0982dff == null)
        {
            return;
        }

        this._0xd0982dff.text = _0xdd638878;
        this._0xd0982dff.rectTransform.DOKill(true);
        this._0xd0982dff.rectTransform.localScale = Vector3.one;
        this._0xd0982dff.rectTransform.DOPunchScale(Vector3.one * 0.09f, 0.3f, 8, 0.6f);
    }

    private const float IconInset = 500f;
    private readonly Image[] _0xc9ad04b5 = new Image[_0x1d79b688.MistakeBudget];
    private const float IconSide = 104f;
    public void _0xe390a45c(int _0xd3dd782f, int _0x91f318c9, int _0x70b7a3a3, int _0x3b620429, bool _0xf7ab39a9)
    {
        if (_0xd3dd782f < 0 || _0xd3dd782f >= _0x1d79b688.Rooms)
        {
            return;
        }

        if (this._0x19e873b5[_0xd3dd782f] != null)
        {
            string _0xdb3aaa0f = _0x1d79b688.SortName(_0x91f318c9) + _0x20d176df._0xf9133570(new byte[1] { 214 }, 246) + _0x70b7a3a3 + _0x20d176df._0xf9133570(new byte[1] { 215 }, 248) + _0x3b620429;
            this._0x19e873b5[_0xd3dd782f].text = _0xf7ab39a9 ? (_0xdb3aaa0f + _0x20d176df._0xf9133570(new byte[3] { 219, 180, 176 }, 251)) : _0xdb3aaa0f;
            _0x7ffdfc32.ApplyOutline(this._0x19e873b5[_0xd3dd782f], _0xf7ab39a9 ? _0xb0c2dde3.Lime : _0xb0c2dde3.Cream);
        }

        if (this._0x1ba6ec67[_0xd3dd782f] != null)
        {
            this._0x1ba6ec67[_0xd3dd782f].DOKill();
            Color _0x093338c5 = _0xf7ab39a9 ? _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Lime, 0.35f) : _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Sort(_0x91f318c9), 0.32f);
            this._0x1ba6ec67[_0xd3dd782f].DOColor(_0x093338c5, 0.25f);
        }
    }

    public Button _0xa3127b92
    {
        get
        {
            return this._0x88b6f651;
        }
    }

    private const float PipPitch = 60f;
    private void BuildBottom(Transform _0xbe274767, TMP_FontAsset _0x67a7aff2, Sprite _0xefeb91fd)
    {
        RectTransform _0x1bca4ace = _0xc7d755ab.Node(_0xbe274767, _0x20d176df._0xf9133570(new byte[9] { 240, 205, 220, 250, 215, 204, 204, 215, 213 }, 184), new Vector2(0.5f, 0f), new Vector2(0f, (BottomPlateHeight * 0.5f) + 18f), new Vector2(PlateWidth, BottomPlateHeight));
        _0xc7d755ab.Plate(_0x1bca4ace, _0x20d176df._0xf9133570(new byte[11] { 121, 84, 79, 79, 84, 86, 107, 87, 90, 79, 94 }, 59), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(PlateWidth, BottomPlateHeight), _0xefeb91fd, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.86f));
        _0xc7d755ab.Plate(_0x1bca4ace, _0x20d176df._0xf9133570(new byte[10] { 252, 209, 202, 202, 209, 211, 251, 218, 217, 219 }, 190), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(PlateWidth - 16f, BottomPlateHeight - 16f), _0xefeb91fd, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Gold, 0.22f));
        for (int _0xf858c997 = 0; _0xf858c997 < _0x1d79b688.Rooms; _0xf858c997++)
        {
            float _0x3b8a5c26 = (_0xf858c997 - 1) * ChipPitch;
            RectTransform _0x9f1df4e4 = _0xc7d755ab.Node(_0x1bca4ace, _0x20d176df._0xf9133570(new byte[7] { 82, 111, 126, 89, 114, 115, 106 }, 26) + _0xf858c997, new Vector2(0.5f, 0.5f), new Vector2(_0x3b8a5c26, 84f), new Vector2(ChipWidth, ChipHeight));
            this._0x57eb3547[_0xf858c997] = _0x9f1df4e4;
            this._0x1ba6ec67[_0xf858c997] = _0xc7d755ab.Plate(_0x9f1df4e4, _0x20d176df._0xf9133570(new byte[8] { 41, 2, 3, 26, 40, 5, 14, 19 }, 106), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(ChipWidth, ChipHeight), _0xefeb91fd, _0xb0c2dde3.DeepLift);
            this._0x19e873b5[_0xf858c997] = _0xc7d755ab.Caption(_0x9f1df4e4, _0x20d176df._0xf9133570(new byte[9] { 159, 180, 181, 172, 144, 189, 190, 185, 176 }, 220), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(ChipWidth - 36f, ChipHeight - 24f), string.Empty, 38f, _0xb0c2dde3.Cream, TextAlignmentOptions.Center, _0x67a7aff2);
        }

        this._0xd9e775bb = _0xc7d755ab.Caption(_0x1bca4ace, _0x20d176df._0xf9133570(new byte[9] { 135, 186, 171, 157, 170, 187, 186, 189, 161 }, 207), new Vector2(0.5f, 0.5f), new Vector2(0f, -2f), new Vector2(700f, 56f), string.Empty, 34f, _0xb0c2dde3.Cream, TextAlignmentOptions.Center, _0x67a7aff2);
        // The control is a tap on the board itself, so it has to be spelled
        // out on screen and has to stay there (rule C.6).
        this._0xd0982dff = _0xc7d755ab.Caption(_0x1bca4ace, _0x20d176df._0xf9133570(new byte[7] { 120, 69, 84, 120, 89, 94, 68 }, 48), new Vector2(0.5f, 0.5f), new Vector2(0f, -74f), new Vector2(1100f, 64f), _0x20d176df._0xf9133570(new byte[26] { 174, 187, 170, 218, 187, 218, 189, 187, 174, 191, 218, 174, 181, 218, 188, 182, 179, 170, 218, 179, 174, 169, 218, 187, 168, 183 }, 250), 38f, _0xb0c2dde3.Gold, TextAlignmentOptions.Center, _0x67a7aff2);
    }

    private readonly Image[] _0x1ba6ec67 = new Image[_0x1d79b688.Rooms];
    private Sprite _0x44102733;
    private _0x1d0bfd1e _0xbf383e2d;
    public void _0xff172f3f(int _0x30bd2785)
    {
        if (this._0xad4728d1 != null)
        {
            this._0xad4728d1.text = _0x30bd2785.ToString();
        }

        if (this._0x4c301b64 != null)
        {
            this._0x4c301b64.DOKill(true);
            this._0x4c301b64.localScale = Vector3.one;
            this._0x4c301b64.DOPunchScale(Vector3.one * 0.10f, 0.26f, 8, 0.6f);
        }
    }

    private TextMeshProUGUI _0xd9e775bb;
    private const float ChipWidth = 356f;
    public void _0xa57f47c1()
    {
        if (this._0xd0982dff != null)
        {
            this._0xd0982dff.text = _0x20d176df._0xf9133570(new byte[26] { 132, 145, 128, 240, 145, 240, 151, 145, 132, 149, 240, 132, 159, 240, 150, 156, 153, 128, 240, 153, 132, 131, 240, 145, 130, 157 }, 208);
        }
    }

    private Button _0x75896f56;
    public void _0x28c14c5f(Transform _0x9678bf1f, TMP_FontAsset _0x5a24987c, Sprite _0x1571e650, Sprite _0x6d12dd08, Sprite _0xe5062801, Sprite _0xcc5ce403, Sprite _0xb9a8ddce, int _0xa0c678b0)
    {
        if (this._0xb5cbe9f5 || _0x9678bf1f == null)
        {
            return;
        }

        this._0xb5cbe9f5 = true;
        this._0x7a9148ea = _0x6d12dd08;
        this._0x44102733 = _0xe5062801;
        RectTransform _0x440e1a42 = _0xc7d755ab.Stretch(_0x9678bf1f, _0x20d176df._0xf9133570(new byte[6] { 80, 119, 108, 74, 119, 102 }, 2));
        // The board's press target goes in FIRST, so every control built after
        // it takes the raycast ahead of it.
        this._0xbf383e2d = _0xc7d755ab.TapSurface(_0x440e1a42, _0x20d176df._0xf9133570(new byte[10] { 227, 206, 192, 211, 197, 231, 200, 196, 205, 197 }, 161), 0.004f).gameObject.AddComponent<_0x1d0bfd1e>();
        this.BuildTop(_0x440e1a42, _0x5a24987c, _0x1571e650, _0xcc5ce403, _0xb9a8ddce, _0xa0c678b0);
        this.BuildBottom(_0x440e1a42, _0x5a24987c, _0x1571e650);
    }

    private const float ChipPitch = 376f;
    public void _0x41b1b8f1(int _0x5d28de7d, int _0xcfb3661f)
    {
        if (this._0xd9e775bb == null)
        {
            return;
        }

        this._0xd9e775bb.text = _0x20d176df._0xf9133570(new byte[13] { 17, 6, 23, 22, 17, 13, 99, 0, 11, 22, 23, 6, 99 }, 67) + _0x5d28de7d + _0x20d176df._0xf9133570(new byte[1] { 130 }, 173) + _0xcfb3661f;
        float _0x35e1de63 = _0xcfb3661f > 0 ? (_0x5d28de7d / (float)_0xcfb3661f) : 0f;
        Color _0xebb471ea = _0xb0c2dde3.Cream;
        if (_0x35e1de63 >= 0.8f)
        {
            _0xebb471ea = _0xb0c2dde3.Coral;
        }
        else if (_0x35e1de63 >= 0.5f)
        {
            _0xebb471ea = _0xb0c2dde3.Gold;
        }

        _0x7ffdfc32.ApplyOutline(this._0xd9e775bb, _0xebb471ea);
    }

    private const float PipSide = 48f;
    private TextMeshProUGUI _0xd0982dff;
    private const float PlateWidth = 1180f;
    private readonly RectTransform[] _0x57eb3547 = new RectTransform[_0x1d79b688.Rooms];
    private const float TopPlateHeight = 320f;
    private Sprite _0x7a9148ea;
    private void OnDestroy()
    {
        if (this._0x4c301b64 != null)
        {
            this._0x4c301b64.DOKill();
        }

        for (int _0x295ece04 = 0; _0x295ece04 < this._0x57eb3547.Length; _0x295ece04++)
        {
            if (this._0x57eb3547[_0x295ece04] != null)
            {
                this._0x57eb3547[_0x295ece04].DOKill();
            }

            if (this._0x1ba6ec67[_0x295ece04] != null)
            {
                this._0x1ba6ec67[_0x295ece04].DOKill();
            }
        }

        if (this._0xd0982dff != null)
        {
            this._0xd0982dff.rectTransform.DOKill();
        }
    }

    private readonly TextMeshProUGUI[] _0x19e873b5 = new TextMeshProUGUI[_0x1d79b688.Rooms];
    public void _0x8ef256e6(int _0x562b410e)
    {
        if (this._0xdc611c77 != null)
        {
            this._0xdc611c77.text = _0x20d176df._0xf9133570(new byte[5] { 188, 181, 184, 184, 212 }, 244) + _0x562b410e;
        }
    }

    private void BuildTop(Transform _0xf0fbb3eb, TMP_FontAsset _0x781dd139, Sprite _0x3e5b633e, Sprite _0xad12deca, Sprite _0xf2379bc1, int _0xea9917ce)
    {
        RectTransform _0xa13dd256 = _0xc7d755ab.Node(_0xf0fbb3eb, _0x20d176df._0xf9133570(new byte[6] { 105, 84, 69, 117, 78, 81 }, 33), new Vector2(0.5f, 1f), new Vector2(0f, -(TopPlateHeight * 0.5f) - 20f), new Vector2(PlateWidth, TopPlateHeight));
        _0xc7d755ab.Plate(_0xa13dd256, _0x20d176df._0xf9133570(new byte[8] { 43, 16, 15, 47, 19, 30, 11, 26 }, 127), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(PlateWidth, TopPlateHeight), _0x3e5b633e, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.86f));
        _0xc7d755ab.Plate(_0xa13dd256, _0x20d176df._0xf9133570(new byte[7] { 57, 2, 29, 40, 9, 10, 8 }, 109), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(PlateWidth - 16f, TopPlateHeight - 16f), _0x3e5b633e, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Gold, 0.22f));
        this._0x75896f56 = _0xc7d755ab.IconAction(_0xa13dd256, _0x20d176df._0xf9133570(new byte[7] { 15, 50, 35, 5, 38, 36, 44 }, 71), new Vector2(0.5f, 0.5f), new Vector2(-IconInset, 52f), IconSide, _0x3e5b633e, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.DeepLift, 0.98f), _0xad12deca, _0xb0c2dde3.Cream);
        this._0x88b6f651 = _0xc7d755ab.IconAction(_0xa13dd256, _0x20d176df._0xf9133570(new byte[8] { 55, 10, 27, 47, 30, 10, 12, 26 }, 127), new Vector2(0.5f, 0.5f), new Vector2(IconInset, 52f), IconSide, _0x3e5b633e, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.DeepLift, 0.98f), _0xf2379bc1, _0xb0c2dde3.Cream);
        this._0xdc611c77 = _0xc7d755ab.Caption(_0xa13dd256, _0x20d176df._0xf9133570(new byte[7] { 97, 92, 77, 97, 72, 69, 69 }, 41), new Vector2(0.5f, 0.5f), new Vector2(0f, 78f), new Vector2(560f, 64f), _0x20d176df._0xf9133570(new byte[5] { 114, 123, 118, 118, 26 }, 58) + _0xea9917ce, 46f, _0xb0c2dde3.Cream, TextAlignmentOptions.Center, _0x781dd139);
        // The score box is sized for the widest number it can ever hold, so the
        // layout does not move as the figure grows.
        this._0xad4728d1 = _0xc7d755ab.Caption(_0xa13dd256, _0x20d176df._0xf9133570(new byte[8] { 44, 17, 0, 55, 7, 11, 22, 1 }, 100), new Vector2(0.5f, 0.5f), new Vector2(0f, -8f), new Vector2(560f, 82f), _0x20d176df._0xf9133570(new byte[1] { 77 }, 125), 58f, _0xb0c2dde3.Gold, TextAlignmentOptions.Center, _0x781dd139);
        this._0x4c301b64 = this._0xad4728d1.rectTransform;
        RectTransform _0x7bb6c473 = _0xc7d755ab.Node(_0xa13dd256, _0x20d176df._0xf9133570(new byte[7] { 255, 194, 211, 231, 222, 199, 196 }, 183), new Vector2(0.5f, 0.5f), new Vector2(0f, -104f), new Vector2(PipPitch * _0x1d79b688.MistakeBudget, 60f));
        for (int _0x50857592 = 0; _0x50857592 < _0x1d79b688.MistakeBudget; _0x50857592++)
        {
            float _0xbd85335c = (_0x50857592 - ((_0x1d79b688.MistakeBudget - 1) * 0.5f)) * PipPitch;
            this._0xc9ad04b5[_0x50857592] = _0xc7d755ab.Picture(_0x7bb6c473, _0x20d176df._0xf9133570(new byte[6] { 63, 2, 19, 39, 30, 7 }, 119) + _0x50857592, new Vector2(0.5f, 0.5f), new Vector2(_0xbd85335c, 0f), new Vector2(PipSide, PipSide), this._0x7a9148ea, _0xb0c2dde3.Lime);
        }
    }

    private bool _0xb5cbe9f5;
    public Button _0xd28c8276
    {
        get
        {
            return this._0x75896f56;
        }
    }

    private TextMeshProUGUI _0xdc611c77;
    private TextMeshProUGUI _0xad4728d1;
}

internal static class _0x20d176df
{
    internal static string _0xf9133570(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}