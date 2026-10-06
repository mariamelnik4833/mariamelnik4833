using DG.Tweening;
using UnityEngine;

/// One of the three rooms at the foot of the shaft: a stone doorway, a
/// nameplate, a shutter, the emblem of the sort it is waiting for, and a row
/// of pips that lights up as deliveries arrive.
///
/// Progress is shown with pips rather than a growing bar on purpose: a
/// nine-sliced bar whose width falls towards zero folds its own border into a
/// smear, while a pip is a fixed square that either is lit or is not.
///
/// Every size handed to Assemble is derived from the camera by the board, and
/// the pips are built to the exact number this room needs, so the row is
/// centred whatever the order asked for.
public sealed class _0x44264c8f : MonoBehaviour
{
    private SpriteRenderer _0x25149670;
    private int _0xda467419 = 1;
    private void OnDestroy()
    {
        this.transform.DOKill();
        if (this._0x2a1c0d86 != null)
        {
            this._0x2a1c0d86.DOKill();
        }

        if (this._0x0ce70558 != null)
        {
            this._0x0ce70558.DOKill();
        }

        if (this._0xa62a935e != null)
        {
            this._0xa62a935e.transform.DOKill();
        }

        if (this._0x25149670 != null)
        {
            this._0x25149670.transform.DOKill();
        }
    }

    public void _0x04e68ce3(SpriteRenderer _0xd08ced4d, SpriteRenderer _0xef1f280e, SpriteRenderer _0x1c2bc678, SpriteRenderer _0x0cd5201b, SpriteRenderer[] _0x011e64ef, Sprite _0xae3d5361, Sprite _0xdad53b11, Vector2 _0x3a5a9856, Vector2 _0x808a1c07, Vector2 _0x8eb8e2e7, float _0xf712b61f, float _0xa9468efb)
    {
        this._0x2a1c0d86 = _0xd08ced4d;
        this._0x0ce70558 = _0xef1f280e;
        this._0xa62a935e = _0x1c2bc678;
        this._0x25149670 = _0x0cd5201b;
        this._0xbb9891df = _0x011e64ef;
        this._0xe635c6b8 = _0xae3d5361;
        this._0x57ee9f68 = _0xdad53b11;
        if (this._0x2a1c0d86 != null)
        {
            this._0x2a1c0d86.size = _0x3a5a9856;
            this._0x2a1c0d86.transform.localScale = Vector3.one;
        }

        if (this._0x0ce70558 != null)
        {
            this._0x0ce70558.size = _0x808a1c07;
            this._0x0ce70558.transform.localScale = Vector3.one;
        }

        // The shutter waits out of sight low in the doorway and rises to seal
        // it when the room has what it asked for.
        if (this._0xa62a935e != null)
        {
            this._0xa62a935e.size = _0x8eb8e2e7;
            this._0xa62a935e.transform.localScale = Vector3.one;
            this._0xde447d64 = this._0xa62a935e.transform.localPosition;
            this._0xd76d6783 = this._0xde447d64 + new Vector3(0f, _0x3a5a9856.y * 0.36f, 0f);
            this._0xa62a935e.enabled = false;
        }

        if (this._0x25149670 != null)
        {
            this._0x25149670.size = new Vector2(_0xf712b61f, _0xf712b61f);
            this._0x25149670.transform.localScale = Vector3.one;
            this._0x1c6ea9a5 = this._0x25149670.transform.localScale;
        }

        for (int _0x260d56ac = 0; _0x260d56ac < this._0xbb9891df.Length; _0x260d56ac++)
        {
            if (this._0xbb9891df[_0x260d56ac] != null)
            {
                this._0xbb9891df[_0x260d56ac].size = new Vector2(_0xa9468efb, _0xa9468efb);
                this._0xbb9891df[_0x260d56ac].transform.localScale = Vector3.one;
            }
        }
    }

    private SpriteRenderer[] _0xbb9891df = new SpriteRenderer[0];
    private Sprite _0x57ee9f68;
    public bool _0xc1830bea
    {
        get
        {
            return this._0x8466338d;
        }
    }

    public int _0x68e79f5b
    {
        get
        {
            return this._0xda467419;
        }
    }

    private bool _0x8466338d;
    /// A fruit this room never asked for: the doorway shakes it off.
    public void _0x785c3e07()
    {
        Transform _0xec1d8df8 = this.transform;
        _0xec1d8df8.DOKill(true);
        _0xec1d8df8.DOShakePosition(0.30f, new Vector3(0.09f, 0.03f, 0f), 18, 90f, false, true);
        if (this._0x2a1c0d86 != null)
        {
            this._0x2a1c0d86.DOKill();
            this._0x2a1c0d86.color = _0xb0c2dde3.Coral;
            this._0x2a1c0d86.DOColor(Color.white, 0.4f);
        }
    }

    /// The rooms rise into place at the start of a trip, one after another, so
    /// the first gameplay frame already has something moving in it.
    public void _0x53892e4d(float _0xcdfc5348, float _0x2a2ae798)
    {
        Transform _0x7bfcdac7 = this.transform;
        Vector3 _0xe45859e4 = _0x7bfcdac7.position;
        _0x7bfcdac7.position = _0xe45859e4 - new Vector3(0f, _0x2a2ae798, 0f);
        _0x7bfcdac7.DOKill();
        _0x7bfcdac7.DOMoveY(_0xe45859e4.y, 0.38f).SetDelay(_0xcdfc5348).SetEase(Ease.OutBack);
    }

    /// Takes one fruit of the sort this room asked for. Returns true when that
    /// was the last one it needed.
    public bool _0x39c072ab()
    {
        if (this._0x8466338d)
        {
            return false;
        }

        this._0x990fa6b8++;
        this._0x62b33af0();
        if (this._0x25149670 != null)
        {
            Transform _0xc29b76c3 = this._0x25149670.transform;
            _0xc29b76c3.DOKill(true);
            _0xc29b76c3.localScale = this._0x1c6ea9a5;
            _0xc29b76c3.DOPunchScale(this._0x1c6ea9a5 * 0.2f, 0.26f, 8, 0.6f);
        }

        if (this._0x990fa6b8 >= this._0xda467419)
        {
            this._0x8466338d = true;
            this._0x07d66776();
            return true;
        }

        return false;
    }

    private int _0x438b2305;
    private Vector3 _0xde447d64;
    public bool _0xdbd6297e(int _0x49b82fe8)
    {
        return !this._0x8466338d && this._0x438b2305 == _0x49b82fe8;
    }

    private Vector3 _0x1c6ea9a5 = Vector3.one;
    private const float ShutterSeconds = 0.22f;
    private Sprite _0xe635c6b8;
    public int _0xbd156da1
    {
        get
        {
            return this._0x438b2305;
        }
    }

    private SpriteRenderer _0x2a1c0d86;
    private SpriteRenderer _0xa62a935e;
    private int _0x990fa6b8;
    private void _0x62b33af0()
    {
        for (int _0x3dc4a5c8 = 0; _0x3dc4a5c8 < this._0xbb9891df.Length; _0x3dc4a5c8++)
        {
            SpriteRenderer _0xcb4a106a = this._0xbb9891df[_0x3dc4a5c8];
            if (_0xcb4a106a == null)
            {
                continue;
            }

            bool _0xb9b02071 = _0x3dc4a5c8 < this._0x990fa6b8;
            _0xcb4a106a.sprite = _0xb9b02071 ? this._0x57ee9f68 : this._0xe635c6b8;
            _0xcb4a106a.color = _0xb9b02071 ? _0xb0c2dde3.Lime : _0xb0c2dde3.WithAlpha(_0xb0c2dde3.Cream, 0.45f);
        }
    }

    private void _0x07d66776()
    {
        if (this._0xa62a935e != null)
        {
            this._0xa62a935e.enabled = true;
            Transform _0xac4a96f8 = this._0xa62a935e.transform;
            _0xac4a96f8.DOKill();
            _0xac4a96f8.localPosition = this._0xde447d64;
            _0xac4a96f8.DOLocalMoveY(this._0xd76d6783.y, ShutterSeconds).SetEase(Ease.OutBack);
        }

        if (this._0x0ce70558 != null)
        {
            this._0x0ce70558.DOKill();
            this._0x0ce70558.DOColor(_0xb0c2dde3.Lime, 0.3f);
        }
    }

    private Vector3 _0xd76d6783;
    public void _0x316093db(int _0x785c1e4c, int _0x82a11485, Sprite _0x79f0b8b3, Color _0x6f849bf0)
    {
        this._0x438b2305 = _0x785c1e4c;
        this._0xda467419 = Mathf.Max(1, _0x82a11485);
        this._0x990fa6b8 = 0;
        this._0x8466338d = false;
        if (this._0x25149670 != null)
        {
            this._0x25149670.sprite = _0x79f0b8b3;
            this._0x25149670.color = Color.white;
        }

        if (this._0x0ce70558 != null)
        {
            this._0x0ce70558.color = _0x6f849bf0;
        }

        if (this._0xa62a935e != null)
        {
            this._0xa62a935e.transform.DOKill();
            this._0xa62a935e.transform.localPosition = this._0xde447d64;
            this._0xa62a935e.enabled = false;
            this._0xa62a935e.color = _0x6f849bf0;
        }

        this._0x62b33af0();
    }

    public int _0x0827f343
    {
        get
        {
            return this._0x990fa6b8;
        }
    }

    private SpriteRenderer _0x0ce70558;
}