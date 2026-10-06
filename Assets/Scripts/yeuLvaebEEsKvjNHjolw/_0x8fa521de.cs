using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The hall board: eight halls on two columns, each with its stars, its order
/// size and its best score. Tapping an open hall picks it and goes straight
/// in; tapping a locked one says so in three visible ways at once.
///
/// Like the teaching sheet this is an overlay over the menu rather than a
/// screen of its own, and its dim surround is a close control, so it can
/// never end up parked over PLAY.
///
/// Each card keeps its indicator column and its words in two horizontal bands
/// that never share space: the stars sit in a 64 wide gutter centred at -194
/// from the card centre, and the text column starts at -116, which is 46
/// reference pixels clear of the gutter's right edge (rule C.25 asks 24).
public sealed class _0x8fa521de : MonoBehaviour
{
    private const float TileHeight = 290f;
    private const float RowPitch = 320f;
    private void _0x52836aea(int _0x7acfafd5)
    {
        if (this._0x848f4803._0xe443c087(_0x7acfafd5))
        {
            this._0x848f4803._0x62d9fb94 = _0x7acfafd5;
            this._0x319da7c2();
            if (this._0xc86dbdf7 != null)
            {
                this._0xc86dbdf7.Invoke(_0x7acfafd5);
            }

            return;
        }

        this._0x3483800a(_0x7acfafd5);
    }

    private const float AutoCloseSeconds = 16f;
    private const float CardHeight = 2120f;
    private readonly Image[] _0x05b8f7ae = new Image[_0x1d79b688.Halls];
    public void _0x319da7c2()
    {
        if (this._0xc63214eb != null)
        {
            this._0xc63214eb.Kill();
            this._0xc63214eb = null;
        }

        if (this._0x44de6729 != null)
        {
            this._0x44de6729.gameObject.SetActive(false);
        }
    }

    private const float TileWidth = 540f;
    /// Three thresholds against the best a hall can give: half, seven tenths
    /// and nine tenths of a perfect trip.
    private int _0x3127dd05(int _0x8734d92a, int _0xcd167787)
    {
        if (_0xcd167787 <= 0)
        {
            return 0;
        }

        float _0x85f9d884 = (_0x1d79b688.QuotaPerRoom(_0x8734d92a) * _0x1d79b688.Rooms * _0x1d79b688.ScoreCorrect * 2f) + (_0x1d79b688.WinBonusPerAttempt * _0x1d79b688.MistakeBudget);
        float _0xc1ae3352 = _0xcd167787 / Mathf.Max(1f, _0x85f9d884);
        if (_0xc1ae3352 >= 0.90f)
        {
            return 3;
        }

        if (_0xc1ae3352 >= 0.72f)
        {
            return 2;
        }

        if (_0xc1ae3352 >= 0.50f)
        {
            return 1;
        }

        return 0;
    }

    private void OnDestroy()
    {
        if (this._0xc63214eb != null)
        {
            this._0xc63214eb.Kill();
        }
    }

    private const float CardWidth = 1160f;
    private const float RowTop = 500f;
    public bool _0x25241d36
    {
        get
        {
            return this._0x44de6729 != null && this._0x44de6729.gameObject.activeSelf;
        }
    }

    /// A locked hall has to say so where the player is looking, not only in
    /// words: the tile shakes, its padlock takes a knock and the purse plate
    /// in the menu flashes (rule C.7).
    private void _0x3483800a(int _0x99269d12)
    {
        int _0x39af9fa8 = Mathf.Clamp(_0x99269d12 - 1, 0, _0x1d79b688.Halls - 1);
        RectTransform _0x1fcd5236 = this._0xa0b3a789[_0x39af9fa8];
        if (_0x1fcd5236 != null)
        {
            _0x1fcd5236.DOKill(true);
            _0x1fcd5236.DOShakePosition(0.28f, TileWidth * 0.012f, 18, 90f, false, true);
        }

        Image _0xcd485c3d = this._0x4877532d[_0x39af9fa8];
        if (_0xcd485c3d != null)
        {
            _0xcd485c3d.rectTransform.DOKill(true);
            _0xcd485c3d.rectTransform.DOPunchScale(Vector3.one * 0.22f, 0.3f, 8, 0.6f);
        }

        if (this._0x96cbdf11 != null)
        {
            this._0x96cbdf11.Invoke();
        }

        this._0xb73720b3();
    }

    private readonly _0x4ae20df6 _0x848f4803 = new _0x4ae20df6();
    private readonly RectTransform[] _0xa0b3a789 = new RectTransform[_0x1d79b688.Halls];
    private readonly Image[] _0x6a49854f = new Image[_0x1d79b688.Halls];
    private readonly Image[] _0x4877532d = new Image[_0x1d79b688.Halls];
    private readonly Image[][] _0xf7ffa8dc = new Image[_0x1d79b688.Halls][];
    private CanvasGroup _0xb4f97737;
    private const float TextWidth = 358f;
    private void _0xb73720b3()
    {
        if (this._0xc63214eb != null)
        {
            this._0xc63214eb.Kill();
        }

        this._0xc63214eb = DOVirtual.DelayedCall(AutoCloseSeconds, () => this._0x319da7c2());
    }

    public void _0xb0143e10(Transform _0xccb2876e, TMP_FontAsset _0xc4d8c990, Sprite _0x25697c5e, Sprite _0x108d7c9c, Sprite _0xf01c95ea, Sprite _0x3738cfab, System.Action<int> _0x0ac81139, System.Action _0x08b292f9)
    {
        if (this._0xd0ef3dd8 || _0xccb2876e == null)
        {
            return;
        }

        this._0xd0ef3dd8 = true;
        this._0xc86dbdf7 = _0x0ac81139;
        this._0x96cbdf11 = _0x08b292f9;
        this._0x44de6729 = _0xc7d755ab.Stretch(_0xccb2876e, _0xf851b27f._0x5af75132(new byte[9] { 105, 64, 77, 77, 114, 73, 68, 68, 85 }, 33));
        this._0xb4f97737 = this._0x44de6729.gameObject.AddComponent<CanvasGroup>();
        Image _0x5c251716 = this._0x44de6729.gameObject.AddComponent<Image>();
        _0x5c251716.color = _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.88f);
        _0x5c251716.raycastTarget = true;
        _0x5c251716.canvasRenderer.cullTransparentMesh = false;
        Button _0x15fa37ab = this._0x44de6729.gameObject.AddComponent<Button>();
        _0x15fa37ab.transition = Selectable.Transition.None;
        _0x15fa37ab.targetGraphic = _0x5c251716;
        _0x15fa37ab.onClick.AddListener(() => this._0x319da7c2());
        Image _0x06779b47 = _0xc7d755ab.Plate(this._0x44de6729, _0xf851b27f._0x5af75132(new byte[8] { 10, 35, 46, 46, 1, 35, 48, 38 }, 66), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(CardWidth, CardHeight), _0x25697c5e, _0xb0c2dde3.Gold);
        _0x06779b47.raycastTarget = true;
        _0x06779b47.canvasRenderer.cullTransparentMesh = false;
        _0xc7d755ab.Plate(_0x06779b47.transform, _0xf851b27f._0x5af75132(new byte[12] { 208, 249, 244, 244, 219, 249, 234, 252, 218, 247, 252, 225 }, 152), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(CardWidth - 24f, CardHeight - 24f), _0x25697c5e, _0xb0c2dde3.DeepLift);
        _0xc7d755ab.Plate(_0x06779b47.transform, _0xf851b27f._0x5af75132(new byte[12] { 71, 110, 99, 99, 76, 110, 125, 107, 88, 106, 99, 99 }, 15), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(CardWidth - 56f, CardHeight - 56f), _0x25697c5e, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.94f));
        _0xc7d755ab.Caption(_0x06779b47.transform, _0xf851b27f._0x5af75132(new byte[13] { 0, 41, 36, 36, 11, 41, 58, 44, 28, 33, 60, 36, 45 }, 72), new Vector2(0.5f, 0.5f), new Vector2(0f, 910f), new Vector2(760f, 112f), _0xf851b27f._0x5af75132(new byte[13] { 20, 31, 24, 24, 4, 18, 119, 22, 119, 31, 22, 27, 27 }, 87), 68f, _0xb0c2dde3.Gold, TextAlignmentOptions.Center, _0xc4d8c990);
        for (int _0x715a45bb = 0; _0x715a45bb < _0x1d79b688.Halls; _0x715a45bb++)
        {
            this.Tile(_0x06779b47.transform, _0x715a45bb, _0xc4d8c990, _0x25697c5e, _0xf01c95ea, _0x3738cfab);
        }

        _0xc7d755ab.Caption(_0x06779b47.transform, _0xf851b27f._0x5af75132(new byte[12] { 104, 65, 76, 76, 99, 65, 82, 68, 104, 73, 78, 84 }, 32), new Vector2(0.5f, 0.5f), new Vector2(0f, -820f), new Vector2(940f, 150f), _0xf851b27f._0x5af75132(new byte[48] { 217, 208, 221, 221, 177, 222, 223, 212, 177, 216, 194, 177, 208, 221, 198, 208, 200, 194, 177, 222, 193, 212, 223, 155, 215, 216, 221, 221, 177, 217, 208, 221, 221, 194, 177, 197, 222, 177, 212, 208, 195, 223, 177, 210, 222, 216, 223, 194 }, 145), 36f, _0xb0c2dde3.Cream, TextAlignmentOptions.Center, _0xc4d8c990);
        Button _0x13e97d43 = _0xc7d755ab.IconAction(_0x06779b47.transform, _0xf851b27f._0x5af75132(new byte[13] { 15, 38, 43, 43, 4, 38, 53, 35, 4, 43, 40, 52, 34 }, 71), new Vector2(0.5f, 0.5f), new Vector2(490f, 910f), 104f, _0x25697c5e, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.96f), _0x108d7c9c, _0xb0c2dde3.Gold);
        _0x13e97d43.onClick.AddListener(() => this._0x319da7c2());
        this._0x44de6729.gameObject.SetActive(false);
    }

    private System.Action<int> _0xc86dbdf7;
    private const float GutterCentre = -194f;
    private readonly TextMeshProUGUI[] _0x6664369a = new TextMeshProUGUI[_0x1d79b688.Halls];
    private void Tile(Transform _0x3f15c203, int _0x79bc4293, TMP_FontAsset _0x1489b0c5, Sprite _0x3d394bdb, Sprite _0xcde4485d, Sprite _0xbcc53908)
    {
        int _0x331c051c = _0x79bc4293 + 1;
        float _0xe5c79096 = ((_0x79bc4293 % 2) == 0) ? -ColumnOffset : ColumnOffset;
        float _0x4aa0ff93 = RowTop - ((_0x79bc4293 / 2) * RowPitch);
        Button _0x8389e0b4 = _0xc7d755ab.Action(_0x3f15c203, _0xf851b27f._0x5af75132(new byte[8] { 36, 13, 0, 0, 56, 5, 0, 9 }, 108) + _0x331c051c, new Vector2(0.5f, 0.5f), new Vector2(_0xe5c79096, _0x4aa0ff93), new Vector2(TileWidth, TileHeight), _0x3d394bdb, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Gold, 0f), string.Empty, _0x7ffdfc32.UiFontFloor, _0xb0c2dde3.Cream, null);
        this._0xa0b3a789[_0x79bc4293] = _0x8389e0b4.GetComponent<RectTransform>();
        this._0x6a49854f[_0x79bc4293] = _0x8389e0b4.GetComponent<Image>();
        this._0x05b8f7ae[_0x79bc4293] = _0xc7d755ab.Plate(_0x8389e0b4.transform, _0xf851b27f._0x5af75132(new byte[8] { 15, 50, 55, 62, 25, 52, 63, 34 }, 91), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(TileWidth - 20f, TileHeight - 20f), _0x3d394bdb, _0xb0c2dde3.DeepLift);
        // indicator gutter: three stars, or a padlock when the hall is shut
        Image[] _0x740b3c40 = new Image[_0x1d79b688.Rooms];
        for (int _0x6b0868f4 = 0; _0x6b0868f4 < _0x1d79b688.Rooms; _0x6b0868f4++)
        {
            _0x740b3c40[_0x6b0868f4] = _0xc7d755ab.Picture(_0x8389e0b4.transform, _0xf851b27f._0x5af75132(new byte[8] { 188, 129, 132, 141, 187, 156, 137, 154 }, 232) + _0x6b0868f4, new Vector2(0.5f, 0.5f), new Vector2(GutterCentre, 66f - (_0x6b0868f4 * 66f)), new Vector2(52f, 52f), _0xcde4485d, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.55f));
        }

        this._0xf7ffa8dc[_0x79bc4293] = _0x740b3c40;
        this._0x4877532d[_0x79bc4293] = _0xc7d755ab.Picture(_0x8389e0b4.transform, _0xf851b27f._0x5af75132(new byte[8] { 102, 91, 94, 87, 126, 93, 81, 89 }, 50), new Vector2(0.5f, 0.5f), new Vector2(GutterCentre, 0f), new Vector2(84f, 84f), _0xbcc53908, _0xb0c2dde3.Gold);
        float _0xc0b39a3e = TextLeft + (TextWidth * 0.5f);
        _0xc7d755ab.Caption(_0x8389e0b4.transform, _0xf851b27f._0x5af75132(new byte[8] { 66, 127, 122, 115, 88, 119, 123, 115 }, 22), new Vector2(0.5f, 0.5f), new Vector2(_0xc0b39a3e, 80f), new Vector2(TextWidth, 64f), _0xf851b27f._0x5af75132(new byte[5] { 230, 239, 226, 226, 142 }, 174) + _0x331c051c, 44f, _0xb0c2dde3.Cream, TextAlignmentOptions.Left, _0x1489b0c5);
        _0xc7d755ab.Caption(_0x8389e0b4.transform, _0xf851b27f._0x5af75132(new byte[8] { 219, 230, 227, 234, 200, 224, 238, 227 }, 143), new Vector2(0.5f, 0.5f), new Vector2(_0xc0b39a3e, 8f), new Vector2(TextWidth, 56f), (_0x1d79b688.QuotaPerRoom(_0x331c051c) * _0x1d79b688.Rooms) + _0xf851b27f._0x5af75132(new byte[17] { 254, 152, 140, 139, 151, 138, 141, 254, 243, 254, 237, 254, 140, 145, 145, 147, 141 }, 222), 34f, _0xb0c2dde3.Muted, TextAlignmentOptions.Left, _0x1489b0c5);
        this._0x6664369a[_0x79bc4293] = _0xc7d755ab.Caption(_0x8389e0b4.transform, _0xf851b27f._0x5af75132(new byte[8] { 107, 86, 83, 90, 125, 90, 76, 75 }, 63), new Vector2(0.5f, 0.5f), new Vector2(_0xc0b39a3e, -66f), new Vector2(TextWidth, 56f), string.Empty, 34f, _0xb0c2dde3.Gold, TextAlignmentOptions.Left, _0x1489b0c5);
        _0x8389e0b4.onClick.AddListener(() => this._0x52836aea(_0x331c051c));
    }

    private const float GutterHalf = 32f;
    public void _0x38d77286()
    {
        if (this._0x44de6729 == null)
        {
            return;
        }

        this._0xf34e9a6a();
        this._0x44de6729.gameObject.SetActive(true);
        this._0x44de6729.SetAsLastSibling();
        if (this._0xb4f97737 != null)
        {
            this._0xb4f97737.alpha = 0f;
            DOTween.Kill(this._0xb4f97737);
            this._0xb4f97737.DOFade(1f, 0.18f);
        }

        this._0xb73720b3();
    }

    private System.Action _0x96cbdf11;
    private Tween _0xc63214eb;
    private bool _0xd0ef3dd8;
    private const float TextLeft = -116f;
    /// Paints every tile from the store. A hall opens the moment the purse
    /// passes its price - there is no buying step and no shop to visit, so
    /// the board can never show the player a dead end.
    private void _0xf34e9a6a()
    {
        int _0xee67f247 = this._0x848f4803._0x62d9fb94;
        for (int _0xbe15773e = 0; _0xbe15773e < _0x1d79b688.Halls; _0xbe15773e++)
        {
            int _0xc3fd8b4f = _0xbe15773e + 1;
            bool _0xd2ef0fd3 = this._0x848f4803._0xe443c087(_0xc3fd8b4f);
            int _0xbe335b1a = this._0x848f4803._0xf90d650c(_0xc3fd8b4f);
            if (this._0x6a49854f[_0xbe15773e] != null)
            {
                this._0x6a49854f[_0xbe15773e].color = _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Gold, _0xc3fd8b4f == _0xee67f247 ? 1f : 0f);
            }

            if (this._0x05b8f7ae[_0xbe15773e] != null)
            {
                this._0x05b8f7ae[_0xbe15773e].color = _0xd2ef0fd3 ? _0xb0c2dde3.DeepLift : _0xb0c2dde3.WithAlpha(_0xb0c2dde3.DeepLift, 0.55f);
            }

            _0xc7d755ab.SetVisible(this._0x4877532d[_0xbe15773e], !_0xd2ef0fd3);
            Image[] _0x7ce60041 = this._0xf7ffa8dc[_0xbe15773e];
            for (int _0xa0bf41bc = 0; _0xa0bf41bc < _0x7ce60041.Length; _0xa0bf41bc++)
            {
                _0xc7d755ab.SetVisible(_0x7ce60041[_0xa0bf41bc], _0xd2ef0fd3);
                if (_0x7ce60041[_0xa0bf41bc] != null)
                {
                    _0x7ce60041[_0xa0bf41bc].color = _0xa0bf41bc < this._0x3127dd05(_0xc3fd8b4f, _0xbe335b1a) ? _0xb0c2dde3.Gold : _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.55f);
                }
            }

            if (this._0x6664369a[_0xbe15773e] != null)
            {
                if (!_0xd2ef0fd3)
                {
                    this._0x6664369a[_0xbe15773e].text = _0x1d79b688.UnlockCost(_0xc3fd8b4f - 1) + _0xf851b27f._0x5af75132(new byte[14] { 0, 99, 111, 105, 110, 115, 0, 116, 111, 0, 111, 112, 101, 110 }, 32);
                    _0x7ffdfc32.ApplyOutline(this._0x6664369a[_0xbe15773e], _0xb0c2dde3.Coral);
                }
                else if (_0xbe335b1a > 0)
                {
                    this._0x6664369a[_0xbe15773e].text = _0xf851b27f._0x5af75132(new byte[5] { 31, 24, 14, 9, 125 }, 93) + _0xbe335b1a;
                    _0x7ffdfc32.ApplyOutline(this._0x6664369a[_0xbe15773e], _0xb0c2dde3.Gold);
                }
                else
                {
                    this._0x6664369a[_0xbe15773e].text = _0xf851b27f._0x5af75132(new byte[14] { 123, 122, 97, 21, 102, 112, 103, 99, 112, 113, 21, 108, 112, 97 }, 53);
                    _0x7ffdfc32.ApplyOutline(this._0x6664369a[_0xbe15773e], _0xb0c2dde3.Muted);
                }
            }
        }
    }

    private const float ColumnOffset = 290f;
    private RectTransform _0x44de6729;
}

internal static class _0xf851b27f
{
    internal static string _0x5af75132(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}