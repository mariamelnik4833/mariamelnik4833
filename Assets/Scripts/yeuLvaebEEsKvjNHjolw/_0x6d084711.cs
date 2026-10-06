using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// The palace shaft itself: the receiving arch at the top, two guide rails,
/// three diverters arranged as a little tree, the three rooms at the bottom
/// and the service chute beside them.
///
/// Nothing here is a literal. The camera gives the half height and the aspect;
/// every position and every size is a fraction of those, so the same code
/// lays the board out correctly on any phone (rule C.0). Content sprites are
/// drawn SQUARE and let their own artwork decide what shape they look - a
/// round fruit can never arrive as an egg that way. Only the pieces that are
/// genuinely nine-sliced (rails, doorways, shutters, the glass tube) are given
/// a rectangle (rule F.2a).
///
/// The routing tree has two levels and four ways out: rooms 0, 1 and 2, and
/// the service chute as the fourth. The diverters start aimed at that chute,
/// which is why a player who never touches the screen posts nothing to a room
/// and therefore spends no attempts (rule C.5).
public sealed class _0x6d084711 : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _burstPrefab;
    private float _0xe6397ea7;
    private const float LateralSeconds = 0.45f;
    private void _0xe8e59952(_0x367bf64f _0xdb5a0e23)
    {
        float width = this._0x77e1df05 * ChuteWidthFraction;
        float height = this._0xcc88bb85 - this._0xad817d9e;
        float _0x34461ae1 = (this._0xcc88bb85 + this._0xad817d9e) * 0.5f;
        GameObject _0xd1423bc7 = new GameObject(_0xf2ffe843._0xf951717d(new byte[12] { 49, 7, 16, 20, 11, 1, 7, 33, 10, 23, 22, 7 }, 98));
        _0xd1423bc7.transform.SetParent(this.transform, false);
        _0xd1423bc7.transform.position = new Vector3(this._0x9e19da3a(3), _0x34461ae1, 0f);
        SpriteRenderer _0xbccde885 = this.Place(this._chuteBodyPrefab, _0xd1423bc7.transform, new Vector3(0f, height * -0.5f, 0f));
        SpriteRenderer _0xfee8c180 = this.Place(this._chuteLevelPrefab, _0xd1423bc7.transform, Vector3.zero);
        SpriteRenderer _0xf80535c8 = this.Place(this._chuteGlassPrefab, _0xd1423bc7.transform, Vector3.zero);
        _0xba28787b _0x4f846b10 = _0xd1423bc7.AddComponent<_0xba28787b>();
        _0x4f846b10._0xde4b380e(_0xbccde885, _0xf80535c8, _0xfee8c180, width, height, this._0xad817d9e, _0x1d79b688.ChuteCapacity(_0xdb5a0e23.Hall));
        this._0xd36f91e0 = _0x4f846b10;
    }

    private readonly List<SpriteRenderer> _0xe61b7dee = new List<SpriteRenderer>();
    private const float RailWidth = 0.10f;
    [SerializeField]
    private SpriteRenderer _shellPrefab;
    [SerializeField]
    private SpriteRenderer _hubPrefab;
    private const float PlateHeightFraction = 0.22f;
    private float _0x77e1df05 = 1f;
    public bool _0x3c3645c2
    {
        get
        {
            return this._0x8fbf11d6;
        }
    }

    [SerializeField]
    private SpriteRenderer _archPrefab;
    public Sprite _0xb220cde5(int _0x824a1baa)
    {
        int _0x1b9725aa = ((_0x824a1baa % _0x1d79b688.Sorts) + _0x1d79b688.Sorts) % _0x1d79b688.Sorts;
        if (_0x1b9725aa == 0)
        {
            return this._fruitApple;
        }

        if (_0x1b9725aa == 1)
        {
            return this._fruitLemon;
        }

        if (_0x1b9725aa == 2)
        {
            return this._fruitPlum;
        }

        return this._fruitBerry;
    }

    public void _0xc22fc22c(_0x367bf64f _0xc040f761, Sprite[] _0xc92ffc90)
    {
        if (this._0x8fbf11d6 || _0xc040f761 == null)
        {
            return;
        }

        this._0x8fbf11d6 = true;
        this._0x96855f2e = Camera.main;
        this._0xb0acd0d7 = this._0x96855f2e != null ? this._0x96855f2e.orthographicSize : 5f;
        this._0x0bb66e36 = this._0xb0acd0d7 * (this._0x96855f2e != null ? this._0x96855f2e.aspect : 0.4615f);
        float _0x99b979a4 = this._0x0bb66e36 * _0x1d79b688.BandFraction;
        this._0x77e1df05 = (2f * _0x99b979a4) / 4f;
        this._0xe6397ea7 = this._0xb0acd0d7 * _0x1d79b688.ArchFraction;
        this._0xed91db88 = this._0xb0acd0d7 * _0x1d79b688.UpperGateFraction;
        this._0xf9880135 = this._0xb0acd0d7 * _0x1d79b688.LowerGateFraction;
        this._0xcc88bb85 = this._0xb0acd0d7 * _0x1d79b688.MouthFraction;
        this._0xad817d9e = this._0xb0acd0d7 * _0x1d79b688.FloorFraction;
        this._0x185cfcdf(_0x99b979a4);
        this._0xbde0d0c6();
        this._0xd8c373e8(_0xc040f761, _0xc92ffc90);
        this._0xe8e59952(_0xc040f761);
        this._0x89e05025();
    }

    [SerializeField]
    private SpriteRenderer _shutterPrefab;
    [SerializeField]
    private SpriteRenderer _railPrefab;
    private const float ChuteWidthFraction = 0.64f;
    private const float ShellFraction = 0.90f;
    [SerializeField]
    private Sprite _pipFull;
    /// Three diverters: one on the centre line and two below it, one under
    /// each branch. All three start aimed to the right, which walks a fruit
    /// to the fourth leaf - the service chute.
    private void _0xbde0d0c6()
    {
        float[] _0x164ed51d =
        {
            0f,
            -this._0x77e1df05,
            this._0x77e1df05
        };
        float[] _0x7850a8e3 =
        {
            this._0xed91db88,
            this._0xf9880135,
            this._0xf9880135
        };
        float _0xe316a7b2 = this._0x77e1df05 * HubFraction;
        float _0xfd20956f = this._0x77e1df05 * ArmFraction;
        for (int _0x275905d3 = 0; _0x275905d3 < this._0xbbb2ab40.Length; _0x275905d3++)
        {
            GameObject _0x4192f19c = new GameObject(_0xf2ffe843._0xf951717d(new byte[4] { 182, 144, 133, 148 }, 241) + _0x275905d3);
            _0x4192f19c.transform.SetParent(this.transform, false);
            _0x4192f19c.transform.position = new Vector3(_0x164ed51d[_0x275905d3], _0x7850a8e3[_0x275905d3], 0f);
            SpriteRenderer _0xb3c59054 = this._hubPrefab != null ? Instantiate(this._hubPrefab, _0x4192f19c.transform) : null;
            SpriteRenderer _0x5c89ebfb = this._armPrefab != null ? Instantiate(this._armPrefab, _0x4192f19c.transform) : null;
            _0x116b35e8 _0xcf7eeec1 = _0x4192f19c.AddComponent<_0x116b35e8>();
            _0xcf7eeec1._0x8b46f432(_0xb3c59054, _0x5c89ebfb, _0xe316a7b2, new Vector2(_0xfd20956f, _0xfd20956f), true);
            this._0xbbb2ab40[_0x275905d3] = _0xcf7eeec1;
        }
    }

    private Camera _0x96855f2e;
    public float _0xeca32c7e
    {
        get
        {
            return this._0x77e1df05;
        }
    }

    public _0xba28787b _0x1e25072c
    {
        get
        {
            return this._0xd36f91e0;
        }
    }

    private const float EmblemFraction = 0.40f;
    private const float PipPitchFraction = 0.155f;
    private const float HubFraction = 0.34f;
    public bool _0x972583d4(int _0x14943da6)
    {
        if (_0x14943da6 < 0 || _0x14943da6 >= this._0xbbb2ab40.Length || this._0xbbb2ab40[_0x14943da6] == null)
        {
            return false;
        }

        this._0xbbb2ab40[_0x14943da6]._0xe147320f();
        this._0xbbb2ab40[_0x14943da6]._0x4026b2cf(_0xb0c2dde3.Gold);
        return true;
    }

    private float _0xb0acd0d7 = 5f;
    private void OnDestroy()
    {
        for (int _0x9e49d2fe = 0; _0x9e49d2fe < this._0xe61b7dee.Count; _0x9e49d2fe++)
        {
            if (this._0xe61b7dee[_0x9e49d2fe] != null)
            {
                this._0xe61b7dee[_0x9e49d2fe].DOKill();
                this._0xe61b7dee[_0x9e49d2fe].transform.DOKill();
            }
        }
    }

    private float _0xf9880135;
    private const float FruitFraction = 0.52f;
    private const float ArchSideFraction = 1.15f;
    public void _0xe48a4ca6(_0xd746fbbf _0x5eb91ec4, float _0xa3e92afa)
    {
        if (_0x5eb91ec4 != null)
        {
            _0x5eb91ec4._0x670cac30(_0xa3e92afa, this._0xbbb2ab40[0], this._0xbbb2ab40[1], this._0xbbb2ab40[2]);
        }
    }

    [SerializeField]
    private SpriteRenderer _armPrefab;
    private int _0xbe22ec26;
    private bool _0x8fbf11d6;
    [SerializeField]
    private Sprite _pipEmpty;
    private float _0xad817d9e;
    private void _0x89e05025()
    {
        if (this._burstPrefab == null)
        {
            return;
        }

        float _0x581e6dd7 = this._0x77e1df05 * BurstFraction;
        for (int _0x2dc440df = 0; _0x2dc440df < BurstPool; _0x2dc440df++)
        {
            SpriteRenderer _0xad489d9e = Instantiate(this._burstPrefab, this.transform);
            _0xad489d9e.size = new Vector2(_0x581e6dd7, _0x581e6dd7);
            _0xad489d9e.transform.localScale = Vector3.one;
            _0xad489d9e.enabled = false;
            this._0xe61b7dee.Add(_0xad489d9e);
        }
    }

    private SpriteRenderer Place(SpriteRenderer _0x66aed259, Transform _0x04a4d9bf, Vector3 _0xbbb29651)
    {
        if (_0x66aed259 == null)
        {
            return null;
        }

        SpriteRenderer _0x47015461 = Instantiate(_0x66aed259, _0x04a4d9bf);
        _0x47015461.transform.localPosition = _0xbbb29651;
        _0x47015461.transform.localScale = Vector3.one;
        return _0x47015461;
    }

    private _0xba28787b _0xd36f91e0;
    public Camera _0xa3c82b78
    {
        get
        {
            return this._0x96855f2e;
        }
    }

    private readonly _0x44264c8f[] _0xe1e25696 = new _0x44264c8f[_0x1d79b688.Rooms];
    /// Releases one fruit from the arch. The caller owns the fall: this just
    /// hands back a router already wired to the board's geometry.
    public _0xd746fbbf _0x6fd077d3(int _0xa1862c7d, System.Action<_0xd746fbbf> _0x82b89a3a)
    {
        if (this._fruitPrefab == null)
        {
            return null;
        }

        SpriteRenderer _0xf70b000f = Instantiate(this._fruitPrefab, this.transform);
        _0xf70b000f.sprite = this._0xb220cde5(_0xa1862c7d);
        _0xf70b000f.transform.position = new Vector3(0f, this._0xe6397ea7 - (this._0x77e1df05 * 0.3f), 0f);
        _0xd746fbbf _0x2247978a = _0xf70b000f.gameObject.AddComponent<_0xd746fbbf>();
        float _0xebaaed2d = (this._0xe6397ea7 - (this._0x77e1df05 * 0.3f)) - this._0xcc88bb85;
        _0x2247978a._0x60b7c167(_0xf70b000f, _0xa1862c7d, this._0x77e1df05 * FruitFraction, _0xebaaed2d / _0x1d79b688.FallSeconds, this._0x77e1df05 / LateralSeconds, this._0xed91db88, this._0xf9880135, this._0xcc88bb85, this._0x77e1df05, _0x82b89a3a);
        return _0x2247978a;
    }

    private const float PlateWidthFraction = 0.84f;
    public _0x44264c8f _0x86603066(int _0x60417b62)
    {
        if (_0x60417b62 < 0 || _0x60417b62 >= this._0xe1e25696.Length)
        {
            return null;
        }

        return this._0xe1e25696[_0x60417b62];
    }

    [SerializeField]
    private SpriteRenderer _namePlatePrefab;
    private const int BurstPool = 4;
    [SerializeField]
    private SpriteRenderer _pipPrefab;
    /// Finds the diverter nearest a world point, within reach. Returns -1 when
    /// the player pressed empty shaft.
    public int _0x3a48937a(Vector2 _0xfb761040)
    {
        int _0x17b56939 = -1;
        float _0x8f93a26e = _0x1d79b688.GateTapRadius;
        for (int _0xf7141c6c = 0; _0xf7141c6c < this._0xbbb2ab40.Length; _0xf7141c6c++)
        {
            if (this._0xbbb2ab40[_0xf7141c6c] == null)
            {
                continue;
            }

            float _0x0a4f00e4 = Vector2.Distance(_0xfb761040, this._0xbbb2ab40[_0xf7141c6c]._0xc429b10b);
            if (_0x0a4f00e4 < _0x8f93a26e)
            {
                _0x8f93a26e = _0x0a4f00e4;
                _0x17b56939 = _0xf7141c6c;
            }
        }

        return _0x17b56939;
    }

    [SerializeField]
    private SpriteRenderer _chuteBodyPrefab;
    private const float BurstFraction = 0.70f;
    [SerializeField]
    private Sprite _fruitApple;
    private readonly _0x116b35e8[] _0xbbb2ab40 = new _0x116b35e8[3];
    private float _0xcc88bb85;
    private float _0x0bb66e36 = 2.3077f;
    [SerializeField]
    private SpriteRenderer _chuteGlassPrefab;
    private const float PipFraction = 0.13f;
    private void _0x185cfcdf(float _0xe4dc6018)
    {
        float _0x3ed720ca = this._0x77e1df05 * ArchSideFraction;
        if (this._archPrefab != null)
        {
            SpriteRenderer _0x2cfe03fc = Instantiate(this._archPrefab, this.transform);
            _0x2cfe03fc.size = new Vector2(_0x3ed720ca, _0x3ed720ca);
            _0x2cfe03fc.transform.localScale = Vector3.one;
            _0x2cfe03fc.transform.position = new Vector3(0f, this._0xe6397ea7, 0f);
        }

        if (this._railPrefab == null)
        {
            return;
        }

        float _0x0991b3ca = this._0xe6397ea7 + RailHeadroom;
        float _0x4cc57642 = _0x0991b3ca - this._0xcc88bb85;
        float _0x2cf35cba = (_0x0991b3ca + this._0xcc88bb85) * 0.5f;
        for (int _0x553e6b93 = 0; _0x553e6b93 < 2; _0x553e6b93++)
        {
            SpriteRenderer _0xdb561a7a = Instantiate(this._railPrefab, this.transform);
            _0xdb561a7a.size = new Vector2(RailWidth, _0x4cc57642);
            _0xdb561a7a.transform.localScale = Vector3.one;
            _0xdb561a7a.transform.position = new Vector3(_0x553e6b93 == 0 ? -_0xe4dc6018 : _0xe4dc6018, _0x2cf35cba, 0f);
            _0xdb561a7a.color = _0xb0c2dde3.WithAlpha(Color.white, 0.9f);
        }
    }

    private float _0xed91db88;
    [SerializeField]
    private SpriteRenderer _emblemPrefab;
    private void _0x37c6cc2b(SpriteRenderer _0xa7969369)
    {
        if (_0xa7969369 != null)
        {
            _0xa7969369.enabled = false;
            _0xa7969369.color = Color.white;
        }
    }

    [SerializeField]
    private Sprite _fruitBerry;
    private void _0xd8c373e8(_0x367bf64f _0xf0ff2bfb, Sprite[] _0xbadd7ff2)
    {
        float _0xb8093687 = this._0x77e1df05 * ShellFraction;
        float _0x151bdc7c = this._0xcc88bb85 - this._0xad817d9e;
        float _0x99465a2b = (this._0xcc88bb85 + this._0xad817d9e) * 0.5f;
        Vector2 _0x96be9748 = new Vector2(this._0x77e1df05 * PlateWidthFraction, this._0x77e1df05 * PlateHeightFraction);
        float _0x2319cef2 = this._0x77e1df05 * EmblemFraction;
        float _0x11773d79 = this._0x77e1df05 * PipFraction;
        float _0xecf7437b = this._0x77e1df05 * PipPitchFraction;
        for (int _0xff975583 = 0; _0xff975583 < _0x1d79b688.Rooms; _0xff975583++)
        {
            GameObject _0xa2354795 = new GameObject(_0xf2ffe843._0xf951717d(new byte[4] { 40, 21, 21, 23 }, 122) + _0xff975583);
            _0xa2354795.transform.SetParent(this.transform, false);
            _0xa2354795.transform.position = new Vector3(this._0x9e19da3a(_0xff975583), _0x99465a2b, 0f);
            SpriteRenderer _0x4cfec515 = this.Place(this._shellPrefab, _0xa2354795.transform, Vector3.zero);
            SpriteRenderer _0x8ca727e9 = this.Place(this._namePlatePrefab, _0xa2354795.transform, new Vector3(0f, _0x151bdc7c * 0.34f, 0f));
            SpriteRenderer _0x5047d176 = this.Place(this._shutterPrefab, _0xa2354795.transform, new Vector3(0f, _0x151bdc7c * -0.02f, 0f));
            SpriteRenderer _0x3e6b5bff = this.Place(this._emblemPrefab, _0xa2354795.transform, new Vector3(0f, _0x151bdc7c * 0.02f, 0f));
            int _0xc4c2e383 = Mathf.Max(1, _0xf0ff2bfb.Quota[_0xff975583]);
            SpriteRenderer[] _0x7d825abe = new SpriteRenderer[_0xc4c2e383];
            for (int _0xd39deb1e = 0; _0xd39deb1e < _0xc4c2e383; _0xd39deb1e++)
            {
                float _0xd2488f97 = (_0xd39deb1e - ((_0xc4c2e383 - 1) * 0.5f)) * _0xecf7437b;
                _0x7d825abe[_0xd39deb1e] = this.Place(this._pipPrefab, _0xa2354795.transform, new Vector3(_0xd2488f97, _0x151bdc7c * -0.34f, 0f));
            }

            _0x44264c8f _0x7547555c = _0xa2354795.AddComponent<_0x44264c8f>();
            _0x7547555c._0x04e68ce3(_0x4cfec515, _0x8ca727e9, _0x5047d176, _0x3e6b5bff, _0x7d825abe, this._pipEmpty, this._pipFull, new Vector2(_0xb8093687, _0x151bdc7c), _0x96be9748, _0x96be9748, _0x2319cef2, _0x11773d79);
            int _0x1a993db2 = _0xf0ff2bfb.WantedSort[_0xff975583];
            Sprite _0xb36bbaba = _0xbadd7ff2 != null && _0xff975583 < _0xbadd7ff2.Length ? _0xbadd7ff2[_0xff975583] : this._0xb220cde5(_0x1a993db2);
            _0x7547555c._0x316093db(_0x1a993db2, _0xc4c2e383, _0xb36bbaba, _0xb0c2dde3.Sort(_0x1a993db2));
            _0x7547555c._0x53892e4d(_0xff975583 * 0.08f, _0x151bdc7c * 0.6f);
            this._0xe1e25696[_0xff975583] = _0x7547555c;
        }
    }

    [SerializeField]
    private SpriteRenderer _chuteLevelPrefab;
    [SerializeField]
    private SpriteRenderer _fruitPrefab;
    private const float RailHeadroom = 0.45f;
    [SerializeField]
    private Sprite _fruitPlum;
    public void Burst(Vector3 _0xf4038a8d, Color _0xa9f6de32)
    {
        if (this._0xe61b7dee.Count == 0)
        {
            return;
        }

        SpriteRenderer _0xcd3caad5 = this._0xe61b7dee[this._0xbe22ec26 % this._0xe61b7dee.Count];
        this._0xbe22ec26++;
        if (_0xcd3caad5 == null)
        {
            return;
        }

        _0xcd3caad5.transform.DOKill();
        _0xcd3caad5.DOKill();
        _0xcd3caad5.enabled = true;
        _0xcd3caad5.transform.position = _0xf4038a8d;
        _0xcd3caad5.transform.localScale = Vector3.one * 0.5f;
        _0xcd3caad5.color = _0xa9f6de32;
        _0xcd3caad5.transform.DOScale(1.25f, 0.34f).SetEase(Ease.OutQuad);
        _0xcd3caad5.DOFade(0f, 0.34f).OnComplete(() => this._0x37c6cc2b(_0xcd3caad5));
    }

    [SerializeField]
    private Sprite _fruitLemon;
    /// The x of one of the four ways out, measured from the camera: two leaves
    /// each side of the centre line, half a pitch apart from their branch.
    public float _0x9e19da3a(int _0x2cd904ab)
    {
        int _0xcf78c0e9 = Mathf.Clamp(_0x2cd904ab, 0, 3);
        return (_0xcf78c0e9 - 1.5f) * this._0x77e1df05;
    }

    private const float ArmFraction = 0.95f;
}

internal static class _0xf2ffe843
{
    internal static string _0xf951717d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}