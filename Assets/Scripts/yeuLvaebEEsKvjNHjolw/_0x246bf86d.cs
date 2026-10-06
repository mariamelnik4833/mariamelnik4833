using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The HOW TO PLAY sheet: three steps with a picture each, over a dimmed menu.
///
/// It is a sheet rather than a page of its own because a screen you must pass
/// through is a dead end for a review capture - PLAY always goes straight into
/// the hall, and this is one optional tap away. The dim surround is itself a
/// close control, so a press that misses the corner glyph still closes it and
/// cannot leave the sheet sitting over PLAY; a timer closes it in any case.
///
/// Each step keeps its picture and its words in two horizontal bands that
/// never overlap, so the text cannot run under the illustration (rule C.25).
public sealed class _0x246bf86d : MonoBehaviour
{
    private void _0x1ef00810()
    {
        this._0x7decdfc8();
        if (this._0x48cc7233 != null)
        {
            this._0x48cc7233.Invoke();
        }
    }

    public bool _0xdebacfd5
    {
        get
        {
            return this._0xc817e02a != null && this._0xc817e02a.gameObject.activeSelf;
        }
    }

    private const float GutterCentre = -364f;
    private const float TextLeft = -200f;
    public void _0x04207357()
    {
        if (this._0xc817e02a == null)
        {
            return;
        }

        this._0xc817e02a.gameObject.SetActive(true);
        this._0xc817e02a.SetAsLastSibling();
        if (this._0x1ca7ae87 != null)
        {
            this._0x1ca7ae87.alpha = 0f;
            DOTween.Kill(this._0x1ca7ae87);
            this._0x1ca7ae87.DOFade(1f, 0.18f);
        }

        this._0xd21d9961();
    }

    private Tween _0xf1ab4227;
    private CanvasGroup _0x1ca7ae87;
    private const float GutterWidth = 240f;
    private RectTransform _0xc817e02a;
    private const float CardWidth = 1120f;
    /// One teaching row. The picture lives alone in the left band and the two
    /// lines live alone in the right one; the text starts 44 reference pixels
    /// clear of the picture band, well past the 24 the rule asks for, and the
    /// band itself stays inside the row plate rather than hanging over its edge.
    private void Step(Transform _0x62b48fa1, int _0x6d1fdf30, Sprite _0x7b9bb72a, string _0xb5ff8f46, string _0xf7eec72c, TMP_FontAsset _0x3a49c0f4, Sprite _0x621ab2a9)
    {
        float _0x9a3ca420 = 430f - (_0x6d1fdf30 * RowPitch);
        RectTransform _0x4590c0e9 = _0xc7d755ab.Node(_0x62b48fa1, _0xf095e433._0x1d120669(new byte[9] { 235, 204, 212, 247, 204, 240, 215, 198, 211 }, 163) + _0x6d1fdf30, new Vector2(0.5f, 0.5f), new Vector2(0f, _0x9a3ca420), new Vector2(1000f, 330f));
        _0xc7d755ab.Plate(_0x4590c0e9, _0xf095e433._0x1d120669(new byte[9] { 142, 169, 184, 173, 141, 177, 188, 169, 184 }, 221), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1000f, 310f), _0x621ab2a9, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.DeepLift, 0.92f));
        _0xc7d755ab.Plate(_0x4590c0e9, _0xf095e433._0x1d120669(new byte[8] { 82, 117, 100, 113, 86, 100, 109, 109 }, 1), new Vector2(0.5f, 0.5f), new Vector2(GutterCentre, 0f), new Vector2(GutterWidth + 24f, GutterWidth + 24f), _0x621ab2a9, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.9f));
        _0xc7d755ab.Picture(_0x4590c0e9, _0xf095e433._0x1d120669(new byte[7] { 151, 176, 161, 180, 133, 182, 176 }, 196), new Vector2(0.5f, 0.5f), new Vector2(GutterCentre, 0f), new Vector2(GutterWidth, GutterWidth), _0x7b9bb72a, Color.white);
        float _0x362ac284 = TextLeft + (TextWidth * 0.5f);
        _0xc7d755ab.Caption(_0x4590c0e9, _0xf095e433._0x1d120669(new byte[9] { 125, 90, 75, 94, 122, 71, 90, 66, 75 }, 46), new Vector2(0.5f, 0.5f), new Vector2(_0x362ac284, 58f), new Vector2(TextWidth, 80f), _0xb5ff8f46, 46f, _0xb0c2dde3.Gold, TextAlignmentOptions.Left, _0x3a49c0f4);
        _0xc7d755ab.Caption(_0x4590c0e9, _0xf095e433._0x1d120669(new byte[8] { 126, 89, 72, 93, 111, 66, 73, 84 }, 45), new Vector2(0.5f, 0.5f), new Vector2(_0x362ac284, -34f), new Vector2(TextWidth, 76f), _0xf7eec72c, 38f, _0xb0c2dde3.Cream, TextAlignmentOptions.Left, _0x3a49c0f4);
    }

    private const float TextWidth = 650f;
    private const float CardHeight = 1960f;
    private const float RowPitch = 370f;
    public void _0x7decdfc8()
    {
        if (this._0xf1ab4227 != null)
        {
            this._0xf1ab4227.Kill();
            this._0xf1ab4227 = null;
        }

        if (this._0xc817e02a != null)
        {
            this._0xc817e02a.gameObject.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        if (this._0xf1ab4227 != null)
        {
            this._0xf1ab4227.Kill();
        }
    }

    /// Set by the menu so the footer can hand the player straight to the hall
    /// board: one tap, one new screen, no detour back through the menu.
    private System.Action _0x48cc7233;
    private bool _0xfbea0728;
    public void _0x3ab3dcd0(Transform _0xf5444370, TMP_FontAsset _0xf5db5efa, Sprite _0xd25b521d, Sprite _0x2ff4aaa8, Sprite _0x3e166089, Sprite _0x6054442f, Sprite _0x4af50e47, System.Action _0xdfcddeff)
    {
        if (this._0xfbea0728 || _0xf5444370 == null)
        {
            return;
        }

        this._0xfbea0728 = true;
        this._0x48cc7233 = _0xdfcddeff;
        this._0xc817e02a = _0xc7d755ab.Stretch(_0xf5444370, _0xf095e433._0x1d120669(new byte[10] { 239, 200, 208, 243, 200, 244, 207, 194, 194, 211 }, 167));
        this._0x1ca7ae87 = this._0xc817e02a.gameObject.AddComponent<CanvasGroup>();
        // The shade closes the sheet: a press anywhere outside the card is a
        // deliberate way out, and it cannot be missed.
        Image _0x5f2263d7 = this._0xc817e02a.gameObject.AddComponent<Image>();
        _0x5f2263d7.color = _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.86f);
        _0x5f2263d7.raycastTarget = true;
        _0x5f2263d7.canvasRenderer.cullTransparentMesh = false;
        Button _0x46df6737 = this._0xc817e02a.gameObject.AddComponent<Button>();
        _0x46df6737.transition = Selectable.Transition.None;
        _0x46df6737.targetGraphic = _0x5f2263d7;
        _0x46df6737.onClick.AddListener(() => this._0x7decdfc8());
        Image _0x699a5d20 = _0xc7d755ab.Plate(this._0xc817e02a, _0xf095e433._0x1d120669(new byte[9] { 101, 66, 90, 121, 66, 110, 76, 95, 73 }, 45), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(CardWidth, CardHeight), _0xd25b521d, _0xb0c2dde3.Gold);
        _0x699a5d20.raycastTarget = true;
        _0x699a5d20.canvasRenderer.cullTransparentMesh = false;
        _0xc7d755ab.Plate(_0x699a5d20.transform, _0xf095e433._0x1d120669(new byte[9] { 164, 131, 155, 184, 131, 174, 131, 136, 149 }, 236), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(CardWidth - 24f, CardHeight - 24f), _0xd25b521d, _0xb0c2dde3.DeepLift);
        _0xc7d755ab.Plate(_0x699a5d20.transform, _0xf095e433._0x1d120669(new byte[9] { 100, 67, 91, 120, 67, 123, 73, 64, 64 }, 44), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(CardWidth - 56f, CardHeight - 56f), _0xd25b521d, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.94f));
        _0xc7d755ab.Caption(_0x699a5d20.transform, _0xf095e433._0x1d120669(new byte[10] { 237, 202, 210, 241, 202, 241, 204, 209, 201, 192 }, 165), new Vector2(0.5f, 0.5f), new Vector2(0f, 830f), new Vector2(760f, 110f), _0xf095e433._0x1d120669(new byte[11] { 29, 26, 2, 117, 1, 26, 117, 5, 25, 20, 12 }, 85), 68f, _0xb0c2dde3.Gold, TextAlignmentOptions.Center, _0xf5db5efa);
        this.Step(_0x699a5d20.transform, 0, _0x3e166089, _0xf095e433._0x1d120669(new byte[16] { 128, 148, 147, 143, 146, 230, 128, 135, 138, 138, 149, 230, 130, 137, 145, 136 }, 198), _0xf095e433._0x1d120669(new byte[16] { 162, 190, 179, 214, 166, 183, 186, 183, 181, 179, 214, 165, 190, 183, 176, 162 }, 246), _0xf5db5efa, _0xd25b521d);
        this.Step(_0x699a5d20.transform, 1, _0x6054442f, _0xf095e433._0x1d120669(new byte[10] { 47, 58, 43, 91, 58, 91, 60, 58, 47, 62 }, 123), _0xf095e433._0x1d120669(new byte[15] { 2, 25, 118, 16, 26, 31, 6, 118, 31, 2, 5, 118, 23, 4, 27 }, 86), _0xf5db5efa, _0xd25b521d);
        this.Step(_0x699a5d20.transform, 2, _0x4af50e47, _0xf095e433._0x1d120669(new byte[14] { 112, 127, 122, 122, 22, 115, 119, 117, 126, 22, 100, 121, 121, 123 }, 54), _0xf095e433._0x1d120669(new byte[18] { 15, 17, 12, 16, 120, 17, 12, 11, 120, 23, 15, 22, 120, 30, 10, 13, 17, 12 }, 88), _0xf5db5efa, _0xd25b521d);
        Button _0x2420d353 = _0xc7d755ab.Action(_0x699a5d20.transform, _0xf095e433._0x1d120669(new byte[10] { 132, 163, 187, 152, 163, 132, 173, 160, 160, 191 }, 204), new Vector2(0.5f, 0.5f), new Vector2(0f, -830f), new Vector2(700f, 140f), _0xd25b521d, _0xb0c2dde3.Lime, _0xf095e433._0x1d120669(new byte[5] { 155, 146, 159, 159, 128 }, 211), 48f, _0xb0c2dde3.Deep, _0xf5db5efa);
        _0x2420d353.onClick.AddListener(() => this._0x1ef00810());
        Button _0xa08dca3b = _0xc7d755ab.IconAction(_0x699a5d20.transform, _0xf095e433._0x1d120669(new byte[10] { 214, 241, 233, 202, 241, 221, 242, 241, 237, 251 }, 158), new Vector2(0.5f, 0.5f), new Vector2(470f, 830f), 104f, _0xd25b521d, _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Deep, 0.96f), _0x2ff4aaa8, _0xb0c2dde3.Gold);
        _0xa08dca3b.onClick.AddListener(() => this._0x7decdfc8());
        this._0xc817e02a.gameObject.SetActive(false);
    }

    private const float AutoCloseSeconds = 16f;
    /// A sheet nobody dismisses must dismiss itself, or a capture run that
    /// misses the close control photographs it for the rest of the album.
    private void _0xd21d9961()
    {
        if (this._0xf1ab4227 != null)
        {
            this._0xf1ab4227.Kill();
        }

        this._0xf1ab4227 = DOVirtual.DelayedCall(AutoCloseSeconds, () => this._0x7decdfc8());
    }
}

internal static class _0xf095e433
{
    internal static string _0x1d120669(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}