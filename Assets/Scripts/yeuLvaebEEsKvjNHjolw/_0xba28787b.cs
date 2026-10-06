using DG.Tweening;
using UnityEngine;

/// The service chute: the fourth way out of the shaft, and the only one that
/// punishes doing nothing. Anything the rooms did not take drops in here, and
/// the kitchen empties it one fruit at a time. Let it run over and the trip
/// is finished.
///
/// The glass is drawn ABOVE the fruit sorting order and the basin below it, so
/// the contents really do look like they are inside the tube.
public sealed class _0xba28787b : MonoBehaviour
{
    private void _0x45afb907()
    {
        if (this._0xe9d76966 == null)
        {
            return;
        }

        float _0x43e04660 = Mathf.Clamp01(this._0xd67e4189 / (float)Mathf.Max(1, this._0x3f7d2df1));
        float height = Mathf.Max(0.02f, this._0x3ad58518 * _0x43e04660 * 0.94f);
        Color _0x6668f117 = _0xb0c2dde3.Lime;
        if (_0x43e04660 >= 0.8f)
        {
            _0x6668f117 = _0xb0c2dde3.Coral;
        }
        else if (_0x43e04660 >= 0.5f)
        {
            _0x6668f117 = _0xb0c2dde3.Gold;
        }

        this._0xe9d76966.DOKill();
        this._0xe9d76966.size = new Vector2(this._0x5e2f5756 * 0.82f, height);
        this._0xe9d76966.transform.position = new Vector3(this.transform.position.x, this._0x4dea7772 + (height * 0.5f), 0f);
        this._0xe9d76966.DOColor(_0x6668f117, 0.25f);
    }

    /// Where a refused fruit should settle: the top of what is already in the
    /// tube, so the pile really does rise.
    public Vector3 _0x1d274143
    {
        get
        {
            float _0xeaea0c4d = Mathf.Clamp01(this._0xd67e4189 / (float)Mathf.Max(1, this._0x3f7d2df1));
            return new Vector3(this.transform.position.x, this._0x4dea7772 + (this._0x3ad58518 * _0xeaea0c4d * 0.9f) + (this._0x5e2f5756 * 0.2f), 0f);
        }
    }

    private float _0x4dea7772;
    private int _0x3f7d2df1 = 1;
    public int _0x4ec9e8ff
    {
        get
        {
            return this._0x3f7d2df1;
        }
    }

    private SpriteRenderer _0xc2a65300;
    private float _0x5e2f5756;
    private SpriteRenderer _0x8fc0d7ae;
    private SpriteRenderer _0xe9d76966;
    private float _0x3ad58518;
    public void _0xf3ef0b22(int _0xadcb45e3)
    {
        this._0xd67e4189 = Mathf.Max(0, _0xadcb45e3);
        this._0x45afb907();
    }

    public int _0x472f00b5
    {
        get
        {
            return this._0xd67e4189;
        }
    }

    private void OnDestroy()
    {
        this.transform.DOKill();
        if (this._0xe9d76966 != null)
        {
            this._0xe9d76966.DOKill();
        }
    }

    private int _0xd67e4189;
    public void _0x0d419761()
    {
        Transform _0x326abe28 = this.transform;
        _0x326abe28.DOKill(true);
        _0x326abe28.DOShakePosition(0.24f, new Vector3(0.05f, 0.02f, 0f), 14, 90f, false, true);
    }

    public void _0xde4b380e(SpriteRenderer _0x41926fab, SpriteRenderer _0x7b1708bb, SpriteRenderer _0x86c33cb0, float width, float height, float _0x9ccd4770, int _0xb2e75632)
    {
        this._0x8fc0d7ae = _0x41926fab;
        this._0xc2a65300 = _0x7b1708bb;
        this._0xe9d76966 = _0x86c33cb0;
        this._0x5e2f5756 = width;
        this._0x3ad58518 = height;
        this._0x4dea7772 = _0x9ccd4770;
        this._0x3f7d2df1 = Mathf.Max(1, _0xb2e75632);
        this._0xd67e4189 = 0;
        if (this._0x8fc0d7ae != null)
        {
            this._0x8fc0d7ae.size = new Vector2(width * 1.22f, width * 0.5f);
            this._0x8fc0d7ae.transform.localScale = Vector3.one;
        }

        if (this._0xc2a65300 != null)
        {
            this._0xc2a65300.size = new Vector2(width, height);
            this._0xc2a65300.transform.localScale = Vector3.one;
            this._0xc2a65300.color = _0xb0c2dde3.WithAlpha(Color.white, 0.75f);
        }

        if (this._0xe9d76966 != null)
        {
            this._0xe9d76966.size = new Vector2(width * 0.82f, 0.02f);
            this._0xe9d76966.transform.localScale = Vector3.one;
            this._0xe9d76966.color = _0xb0c2dde3.Lime;
        }

        this._0x45afb907();
    }
}