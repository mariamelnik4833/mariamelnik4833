using DG.Tweening;
using UnityEngine;

/// One fruit on its way down the shaft.
///
/// The fall is driven in Update at a speed the board worked out from the
/// camera, not by a tween: the routing has to be exact and predictable, and a
/// tween that is paused, killed or retimed takes the timing with it.
///
/// The route is read, not pushed: as the fruit passes each gate row it asks
/// that gate which way it is pointing. Throwing a gate therefore changes the
/// path of every fruit still above it and of none below it, which is the
/// whole feel of the game.
public sealed class _0xd746fbbf : MonoBehaviour
{
    private void OnDestroy()
    {
        this.transform.DOKill();
        if (this._0x9bb4ca8a != null)
        {
            this._0x9bb4ca8a.DOKill();
        }
    }

    private float _0x3b9e24ac;
    private float _0xb4a79f02;
    private float _0x81519005;
    private float _0x4a6e1db5;
    private SpriteRenderer _0x9bb4ca8a;
    public int _0x240c3069
    {
        get
        {
            return this._0xfc40d7cd;
        }
    }

    private float _0xdafdad54;
    /// Taken by a room that wanted it: a short swell, then gone.
    public void _0xafdc931f()
    {
        this.transform.DOKill();
        this.transform.localScale = this._0x836f16a1;
        Sequence _0xf15e567d = DOTween.Sequence();
        _0xf15e567d.Append(this.transform.DOScale(this._0x836f16a1 * 1.25f, 0.12f));
        _0xf15e567d.Append(this.transform.DOScale(Vector3.zero, 0.16f).SetEase(Ease.InBack));
        _0xf15e567d.OnComplete(() => this._0x3080bf8d());
    }

    private System.Action<_0xd746fbbf> _0x3c09d56f;
    /// Swallowed by the service chute: it sinks into the tube.
    public void _0x9bd4ae82(Vector3 _0x862fda39)
    {
        this.transform.DOKill();
        this.transform.DOMove(_0x862fda39, 0.26f).SetEase(Ease.OutQuad).OnComplete(() => this._0x3080bf8d());
    }

    /// The gates are handed in rather than looked up: a serialized chain beats
    /// any search, and obfuscation cannot break it.
    public void _0x670cac30(float step, _0x116b35e8 _0x308e486a, _0x116b35e8 _0xacf2c0a7, _0x116b35e8 _0x37822af3)
    {
        if (this._0xc47cacae || this._0x51a1335f)
        {
            return;
        }

        Vector3 _0x818c3578 = this.transform.position;
        _0x818c3578.y -= this._0x4a6e1db5 * step;
        if (this._0x030ffe03 < 0 && _0x818c3578.y <= this._0xdafdad54 && _0x308e486a != null)
        {
            this._0x030ffe03 = _0x308e486a._0xe6420377 ? 1 : 0;
            this._0xebb0060f = this._0x030ffe03 == 1 ? this._0xb4a79f02 : -this._0xb4a79f02;
        }

        if (this._0x030ffe03 >= 0 && this._0x2ae0d74e < 0 && _0x818c3578.y <= this._0x3b9e24ac)
        {
            _0x116b35e8 _0x694d9ff7 = this._0x030ffe03 == 1 ? _0x37822af3 : _0xacf2c0a7;
            bool _0xb0c87aed = _0x694d9ff7 != null && _0x694d9ff7._0xe6420377;
            this._0x2ae0d74e = (this._0x030ffe03 * 2) + (_0xb0c87aed ? 1 : 0);
            float _0x52d6fd93 = this._0xb4a79f02 * 0.5f;
            this._0xebb0060f = (this._0x030ffe03 == 1 ? this._0xb4a79f02 : -this._0xb4a79f02) + (_0xb0c87aed ? _0x52d6fd93 : -_0x52d6fd93);
        }

        _0x818c3578.x = Mathf.MoveTowards(_0x818c3578.x, this._0xebb0060f, this._0x81519005 * step);
        this.transform.position = _0x818c3578;
        if (_0x818c3578.y <= this._0xb3acd42f)
        {
            this._0xc47cacae = true;
            if (this._0x2ae0d74e < 0)
            {
                this._0x2ae0d74e = 3;
            }

            if (this._0x3c09d56f != null)
            {
                this._0x3c09d56f.Invoke(this);
            }
        }
    }

    private int _0x2ae0d74e = -1;
    public void _0x62739830(bool _0xc40d572a)
    {
        this._0x51a1335f = _0xc40d572a;
    }

    private float _0xebb0060f;
    private int _0x030ffe03 = -1;
    private Vector3 _0x836f16a1 = Vector3.one;
    private void _0x3080bf8d()
    {
        if (this != null && this.gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }

    /// Which of the four ways out this fruit has committed to: rooms 0, 1, 2
    /// and the service chute as 3. Valid once it has passed the lower row.
    public int _0x9fc99359
    {
        get
        {
            return this._0x2ae0d74e;
        }
    }

    /// Refused: it drops out of the shaft sideways.
    public void _0x1a0c7158(float _0xe31b0b21)
    {
        this.transform.DOKill();
        if (this._0x9bb4ca8a != null)
        {
            this._0x9bb4ca8a.DOKill();
            this._0x9bb4ca8a.DOFade(0f, 0.34f);
        }

        this.transform.DOMove(this.transform.position + new Vector3(_0xe31b0b21, -0.5f, 0f), 0.34f).SetEase(Ease.InQuad).OnComplete(() => this._0x3080bf8d());
    }

    public void _0x60b7c167(SpriteRenderer _0xe677b9f0, int _0xe8d13a16, float _0xdc1f89fa, float _0xa1e68284, float _0x7b88b21d, float _0x2e307455, float _0x9f29a09d, float _0x16645215, float _0x9432c346, System.Action<_0xd746fbbf> _0x4c7409e0)
    {
        this._0x9bb4ca8a = _0xe677b9f0;
        this._0xfc40d7cd = _0xe8d13a16;
        this._0x4a6e1db5 = _0xa1e68284;
        this._0x81519005 = _0x7b88b21d;
        this._0xdafdad54 = _0x2e307455;
        this._0x3b9e24ac = _0x9f29a09d;
        this._0xb3acd42f = _0x16645215;
        this._0xb4a79f02 = _0x9432c346;
        this._0x3c09d56f = _0x4c7409e0;
        this._0xebb0060f = 0f;
        if (this._0x9bb4ca8a != null)
        {
            this._0x9bb4ca8a.size = new Vector2(_0xdc1f89fa, _0xdc1f89fa);
            this._0x9bb4ca8a.transform.localScale = Vector3.one;
        }

        this._0x836f16a1 = this.transform.localScale;
    }

    private float _0xb3acd42f;
    private bool _0x51a1335f;
    public void _0x4aff7753()
    {
        this.transform.DOKill();
        if (this._0x9bb4ca8a != null)
        {
            this._0x9bb4ca8a.DOKill();
        }

        this._0x3080bf8d();
    }

    private bool _0xc47cacae;
    private int _0xfc40d7cd;
}