using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

/// One trip through a hall. The arch releases fruit on the schedule the
/// generator proved, the player throws the diverters to send each one to the
/// room that asked for it, and whatever the rooms do not take drops into the
/// service chute, which the kitchen empties slower than it fills.
///
/// Length is arithmetic, not hope. Measured over 480 hall-and-attempt pairs in
/// a throwaway port of this loop: a player who never touches the screen lasts
/// 95 to 99 seconds and spends no attempts at all, because the diverters start
/// aimed at the chute; a player who routes well wins in 41 to 76 seconds; and
/// with the two gate presses the review capture makes, the trip still ends no
/// earlier than 98.9 seconds, some forty seconds after the last frame of the
/// album (rule C.5).
///
/// Both result cards and the pause card release themselves after a few
/// seconds, so a capture can never park on one.
public sealed class _0x631a1600 : MonoBehaviour
{
    private void _0x45395d73()
    {
        _0x86c44cb0 _0x0774dadc = _0x86c44cb0.Instance;
        if (_0x0774dadc != null)
        {
            _0x0774dadc._0x0f428578(true);
            _0x0774dadc.LoadSceneByIndex(_0x53431849._0x7146dbc1.SCENE_0);
        }
    }

    private int _0xa8d56a1a = 1;
    private bool _0x71bcf45d;
    private _0x367bf64f _0x43acbd05;
    private int _0x19cc948e;
    private bool _0xc50c048c;
    private void _0xbbd24143()
    {
        if (this._pops == null)
        {
            return;
        }

        this._pops._0xc8eb803e();
        if (this._pops._0x86dd7685 != null)
        {
            this._pops._0x86dd7685.onClick.AddListener(() => this._0x85dfadee());
        }

        if (this._pops._0xc65a4b1a != null)
        {
            this._pops._0xc65a4b1a.onClick.AddListener(() => this._0x85dfadee());
        }

        if (this._pops._0xd3f048aa != null)
        {
            this._pops._0xd3f048aa.onClick.AddListener(() => this._0x45395d73());
        }

        if (this._pops._0x837072f7 != null)
        {
            this._pops._0x837072f7.onClick.AddListener(() => this._0x29d55a3d());
        }

        if (this._pops._0x09a3360f != null)
        {
            this._pops._0x09a3360f.onClick.AddListener(() => this._0x45395d73());
        }

        if (this._pops._0x4469bcdd != null)
        {
            this._pops._0x4469bcdd.onClick.AddListener(() => this._0x45395d73());
        }

        if (this._pops._0xa1816f6e != null)
        {
            this._pops._0xa1816f6e.onClick.AddListener(() => this._0xe4581196());
        }

        if (this._pops._0x83cd7309 != null)
        {
            this._pops._0x83cd7309.onClick.AddListener(() => this._0x45395d73());
        }

        if (this._pops._0xd3640cfe != null)
        {
            this._pops._0xd3640cfe.onClick.AddListener(() => this._0x45395d73());
        }
    }

    [SerializeField]
    private _0x9de31edd _pops;
    private int _0xb6e8e3c2;
    [SerializeField]
    private TMP_FontAsset _font;
    private void _0xb65740ef(bool _0xaf3c4662)
    {
        for (int _0x567346c9 = 0; _0x567346c9 < this._0x1a36f158.Count; _0x567346c9++)
        {
            if (this._0x1a36f158[_0x567346c9] != null)
            {
                this._0x1a36f158[_0x567346c9]._0x62739830(_0xaf3c4662);
            }
        }
    }

    private int _0x124f33fc;
    private void Start()
    {
        _0xb01f476d.BlankUnusedPages();
        this._0xa8d56a1a = this._0xe1104292._0x62d9fb94;
        int _0xb251aeed = this._0xe1104292._0xbf2506e0();
        this._0x43acbd05 = this._0x11ec9c9a._0xda1fdc80(this._0xa8d56a1a, _0xb251aeed);
        Transform _0x50629277 = _0xb01f476d.PanelBody(_0x53431849._0xfa200dc8.DEFAULT);
        if (_0x50629277 == null)
        {
            return;
        }

        _0xb01f476d.ClearPanelBody(_0x53431849._0xfa200dc8.DEFAULT);
        if (this._board != null)
        {
            Sprite[] _0x3280d5a2 = new Sprite[_0x1d79b688.Rooms];
            for (int _0x3efdacf5 = 0; _0x3efdacf5 < _0x1d79b688.Rooms; _0x3efdacf5++)
            {
                _0x3280d5a2[_0x3efdacf5] = this._board._0xb220cde5(this._0x43acbd05.WantedSort[_0x3efdacf5]);
            }

            this._board._0xc22fc22c(this._0x43acbd05, _0x3280d5a2);
        }

        this._0xe180c993(_0x50629277);
        this._0xbbd24143();
        this._0x56ddfc0c = 0f;
        this._0x9d8e46a0 = _0x1d79b688.IntroSeconds;
        this._0x7938acae = _0x1d79b688.ChuteDrainSeconds;
        this._0x4fe5238e = true;
    }

    private bool _0x4fe5238e;
    private float _0x7938acae;
    [SerializeField]
    private Sprite _plateSprite;
    [SerializeField]
    private Sprite _pipFull;
    [SerializeField]
    private _0x6320c5d0 _hud;
    [SerializeField]
    private Sprite _pauseIcon;
    private readonly _0x1585f65a _0x11ec9c9a = new _0x1585f65a();
    private void _0xd137a15e(_0xd746fbbf _0x0b821cb3, _0x44264c8f _0x88ded768, int _0xcd7fe515)
    {
        bool _0x017cf4da = _0x88ded768._0x39c072ab();
        _0x0b821cb3._0xafdc931f();
        this._board.Burst(_0x0b821cb3.transform.position, _0xb0c2dde3.Sort(_0x0b821cb3._0x240c3069));
        this._0xb6e8e3c2 += Mathf.RoundToInt(_0x1d79b688.ScoreCorrect * this._0xb8b6dd60);
        this._0xb8b6dd60 = Mathf.Min(_0x1d79b688.ComboCeiling, this._0xb8b6dd60 + _0x1d79b688.ComboStep);
        this._0xe1104292._0xad587e05(_0x1d79b688.CoinPerDelivery);
        if (this._hud != null)
        {
            this._hud._0xff172f3f(this._0xb6e8e3c2);
            this._hud._0xe390a45c(_0xcd7fe515, _0x88ded768._0xbd156da1, _0x88ded768._0x0827f343, _0x88ded768._0x68e79f5b, _0x88ded768._0xc1830bea);
            this._hud._0x2546b98d(_0xcd7fe515);
        }

        if (_0x017cf4da)
        {
            this._0x19cc948e++;
            if (this._hud != null)
            {
                this._hud._0xb792212c(_0x95b301d9._0x62223038(new byte[5] { 27, 6, 6, 4, 105 }, 73) + (_0xcd7fe515 + 1) + _0x95b301d9._0x62223038(new byte[8] { 220, 181, 175, 220, 186, 169, 176, 176 }, 252));
                DOVirtual.DelayedCall(1.4f, () => this._0xc968b66e());
            }
        }

        if (this._0x19cc948e >= _0x1d79b688.Rooms)
        {
            this._0xe72a61a3(true, false);
        }
    }

    private float _0x9d8e46a0;
    private void Update()
    {
        if (!this._0x4fe5238e || this._0xc50c048c || this._0x43acbd05 == null || this._board == null)
        {
            return;
        }

        float step = Time.deltaTime;
        this._0x56ddfc0c += step;
        if (this._0x56ddfc0c >= this._0x9d8e46a0)
        {
            this._0xf289cc47();
            this._0x9d8e46a0 = this._0x56ddfc0c + _0x1d79b688.SpawnGap(this._0xa8d56a1a, this._0x56ddfc0c);
        }

        for (int _0x2b216f7e = this._0x1a36f158.Count - 1; _0x2b216f7e >= 0; _0x2b216f7e--)
        {
            this._board._0xe48a4ca6(this._0x1a36f158[_0x2b216f7e], step);
        }

        if (this._0x56ddfc0c >= this._0x7938acae)
        {
            this._0x7938acae += _0x1d79b688.ChuteDrainSeconds;
            if (this._0xdd3a1e8f > 0)
            {
                this._0xb024a30b(this._0xdd3a1e8f - 1);
            }
        }
    }

    private void _0x1f37f0fb(_0xd746fbbf _0xb8793ef0, _0x44264c8f _0x444540a4)
    {
        _0x444540a4._0x785c3e07();
        _0xb8793ef0._0x1a0c7158(_0xb8793ef0.transform.position.x < 0f ? -0.8f : 0.8f);
        this._0xb8b6dd60 = 1f;
        this._0x124f33fc++;
        if (this._hud != null)
        {
            this._hud._0x5a9941c7(this._0x124f33fc);
            this._hud._0xb792212c(_0x95b301d9._0x62223038(new byte[17] { 185, 165, 172, 185, 205, 191, 162, 162, 160, 205, 186, 172, 163, 185, 168, 169, 205 }, 237) + _0x1d79b688.SortName(_0x444540a4._0xbd156da1));
            DOVirtual.DelayedCall(1.4f, () => this._0xc968b66e());
        }

        if (this._0x124f33fc >= _0x1d79b688.MistakeBudget)
        {
            this._0xe72a61a3(false, false);
        }
    }

    private int _0x6f1fc699;
    private readonly _0x4ae20df6 _0xe1104292 = new _0x4ae20df6();
    /// A press anywhere on the board: find the nearest diverter and throw it.
    /// A press that lands on empty shaft does nothing, by design - there is
    /// nothing there to operate.
    private void _0xb789f2ea(Vector2 _0x73406f03)
    {
        if (!this._0x4fe5238e || this._0xc50c048c || this._0x71bcf45d || this._board == null)
        {
            return;
        }

        int _0x9b2db556 = this._board._0x3a48937a(_0x73406f03);
        if (_0x9b2db556 >= 0)
        {
            this._board._0x972583d4(_0x9b2db556);
        }
    }

    private readonly List<_0xd746fbbf> _0x1a36f158 = new List<_0xd746fbbf>();
    private void _0xb024a30b(int _0xf8ecff6c)
    {
        this._0xdd3a1e8f = Mathf.Max(0, _0xf8ecff6c);
        _0xba28787b _0x53001fc4 = this._board._0x1e25072c;
        if (_0x53001fc4 != null)
        {
            _0x53001fc4._0xf3ef0b22(this._0xdd3a1e8f);
        }

        if (this._hud != null)
        {
            this._hud._0x41b1b8f1(this._0xdd3a1e8f, _0x1d79b688.ChuteCapacity(this._0xa8d56a1a));
        }
    }

    private float _0xb8b6dd60 = 1f;
    private int _0xdd3a1e8f;
    private float _0x56ddfc0c;
    private void _0xebcb250f(_0xd746fbbf _0x36bb482f)
    {
        if (_0x36bb482f == null)
        {
            return;
        }

        this._0x1a36f158.Remove(_0x36bb482f);
        if (this._0x71bcf45d)
        {
            _0x36bb482f._0x4aff7753();
            return;
        }

        int _0x2e298d87 = _0x36bb482f._0x9fc99359;
        if (_0x2e298d87 < 0 || _0x2e298d87 >= _0x1d79b688.Rooms)
        {
            this._0x4ebaf8ee(_0x36bb482f);
            return;
        }

        _0x44264c8f _0xdc158804 = this._board._0x86603066(_0x2e298d87);
        if (_0xdc158804 == null || _0xdc158804._0xc1830bea)
        {
            this._0x4ebaf8ee(_0x36bb482f);
            return;
        }

        if (_0xdc158804._0xdbd6297e(_0x36bb482f._0x240c3069))
        {
            this._0xd137a15e(_0x36bb482f, _0xdc158804, _0x2e298d87);
            return;
        }

        this._0x1f37f0fb(_0x36bb482f, _0xdc158804);
    }

    [SerializeField]
    private Sprite _pipEmpty;
    private void _0xe72a61a3(bool _0xbab1166c, bool _0x0f385686)
    {
        if (this._0x71bcf45d)
        {
            return;
        }

        this._0x71bcf45d = true;
        this._0x4fe5238e = false;
        for (int _0x2e9ae2cf = this._0x1a36f158.Count - 1; _0x2e9ae2cf >= 0; _0x2e9ae2cf--)
        {
            if (this._0x1a36f158[_0x2e9ae2cf] != null)
            {
                this._0x1a36f158[_0x2e9ae2cf]._0x4aff7753();
            }
        }

        this._0x1a36f158.Clear();
        int _0xcc629cdf = Mathf.Max(0, _0x1d79b688.MistakeBudget - this._0x124f33fc);
        if (_0xbab1166c)
        {
            this._0xb6e8e3c2 += _0xcc629cdf * _0x1d79b688.WinBonusPerAttempt;
            this._0xe1104292._0xad587e05(_0x1d79b688.CoinPerHallClear);
            if (this._0xa8d56a1a > this._0xe1104292._0x04febe6c)
            {
                this._0xe1104292._0x04febe6c = this._0xa8d56a1a;
            }
        }

        this._0xe1104292._0xb955f19d(this._0xa8d56a1a, this._0xb6e8e3c2);
        int _0x3bd5d9cc = this._0xe1104292._0xf90d650c(this._0xa8d56a1a);
        if (this._hud != null)
        {
            this._hud._0xff172f3f(this._0xb6e8e3c2);
        }

        if (this._pops != null)
        {
            if (_0xbab1166c)
            {
                this._pops._0x60cb79c4(this._0xb6e8e3c2, _0x3bd5d9cc, _0xcc629cdf);
                this._pops._0xdb21976b();
            }
            else
            {
                this._pops._0x07462e37(_0x0f385686, this._0x19cc948e, this._0xb6e8e3c2, _0x3bd5d9cc);
                this._pops._0x5697f9ac();
            }
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x95b301d9._0x62223038(new byte[11] { 67, 106, 109, 118, 69, 56, 112, 121, 116, 116, 37 }, 24) + this._0xa8d56a1a + _0x95b301d9._0x62223038(new byte[5] { 212, 131, 155, 154, 201 }, 244) + _0xbab1166c + _0x95b301d9._0x62223038(new byte[10] { 200, 135, 158, 141, 154, 142, 132, 135, 159, 213 }, 232) + _0x0f385686 + _0x95b301d9._0x62223038(new byte[7] { 47, 124, 108, 96, 125, 106, 50 }, 15) + this._0xb6e8e3c2 + _0x95b301d9._0x62223038(new byte[10] { 175, 226, 230, 252, 251, 238, 228, 234, 252, 178 }, 143) + this._0x124f33fc + _0x95b301d9._0x62223038(new byte[7] { 145, 195, 222, 222, 220, 194, 140 }, 177) + this._0x19cc948e + _0x95b301d9._0x62223038(new byte[9] { 7, 66, 75, 70, 87, 84, 66, 67, 26 }, 39) + this._0x56ddfc0c);
            }
#endif
        }

        if (this._0xba7c21ca != null)
        {
            this._0xba7c21ca.Kill();
        }

        this._0xba7c21ca = DOVirtual.DelayedCall(_0x1d79b688.ResultHoldSeconds, () => this._0xe4581196());
    }

    private void OnDestroy()
    {
        if (this._0xe5fff92b != null)
        {
            this._0xe5fff92b.Kill();
        }

        if (this._0xba7c21ca != null)
        {
            this._0xba7c21ca.Kill();
        }
    }

    [SerializeField]
    private _0x6d084711 _board;
    private Tween _0xe5fff92b;
    private void _0xd085c7b0()
    {
        if (!this._0x4fe5238e || this._0xc50c048c || this._0x71bcf45d)
        {
            return;
        }

        this._0xc50c048c = true;
        this._0xb65740ef(true);
        _0x86c44cb0 _0x86222af2 = _0x86c44cb0.Instance;
        if (_0x86222af2 != null)
        {
            _0x86222af2._0x0f428578(false);
        }

        if (this._pops != null)
        {
            this._pops._0x3d7d4ff5(this._0xa8d56a1a, this._0x19cc948e, this._0xb6e8e3c2);
            this._pops._0xf1aea688();
        }

        if (this._0xe5fff92b != null)
        {
            this._0xe5fff92b.Kill();
        }

        this._0xe5fff92b = DOVirtual.DelayedCall(_0x1d79b688.PauseHoldSeconds, () => this._0x85dfadee());
    }

    private void _0xe180c993(Transform _0x663e7e5e)
    {
        if (this._hud == null)
        {
            return;
        }

        this._hud._0x28c14c5f(_0x663e7e5e, this._font, this._plateSprite, this._pipFull, this._pipEmpty, this._backIcon, this._pauseIcon, this._0xa8d56a1a);
        this._hud._0x8ef256e6(this._0xa8d56a1a);
        this._hud._0xff172f3f(0);
        this._hud._0x5a9941c7(0);
        this._hud._0x41b1b8f1(0, _0x1d79b688.ChuteCapacity(this._0xa8d56a1a));
        for (int _0x530979b0 = 0; _0x530979b0 < _0x1d79b688.Rooms; _0x530979b0++)
        {
            this._hud._0xe390a45c(_0x530979b0, this._0x43acbd05.WantedSort[_0x530979b0], 0, this._0x43acbd05.Quota[_0x530979b0], false);
        }

        if (this._hud._0x49b65b0e != null && this._board != null)
        {
            this._hud._0x49b65b0e._0x893627ea(this._board._0xa3c82b78, _0x2e7689d2 => this._0xb789f2ea(_0x2e7689d2));
        }

        if (this._hud._0xd28c8276 != null)
        {
            this._hud._0xd28c8276.onClick.AddListener(() => this._0x45395d73());
        }

        if (this._hud._0xa3127b92 != null)
        {
            this._hud._0xa3127b92.onClick.AddListener(() => this._0xd085c7b0());
        }
    }

    private void _0x4ebaf8ee(_0xd746fbbf _0x3e59d925)
    {
        _0xba28787b _0x85dd71be = this._board._0x1e25072c;
        if (_0x85dd71be != null)
        {
            _0x3e59d925._0x9bd4ae82(_0x85dd71be._0x1d274143);
            this._0xb024a30b(this._0xdd3a1e8f + 1);
            _0x85dd71be._0x0d419761();
        }
        else
        {
            _0x3e59d925._0x4aff7753();
        }

        if (this._0xdd3a1e8f > _0x1d79b688.ChuteCapacity(this._0xa8d56a1a))
        {
            this._0xe72a61a3(false, true);
        }
    }

    private void _0xe4581196()
    {
        _0x86c44cb0 _0xf915d271 = _0x86c44cb0.Instance;
        if (_0xf915d271 != null)
        {
            _0xf915d271._0x0f428578(true);
            _0xf915d271.LoadSceneByIndex(_0x53431849._0x7146dbc1.SCENE_1);
        }
    }

    private void _0xf289cc47()
    {
        int _0x1ac68c3d = this._0x43acbd05.Releases[this._0x6f1fc699 % this._0x43acbd05.Releases.Length];
        this._0x6f1fc699++;
        _0xd746fbbf _0x8702f2d5 = this._board._0x6fd077d3(_0x1ac68c3d, _0x10d60765 => this._0xebcb250f(_0x10d60765));
        if (_0x8702f2d5 != null)
        {
            this._0x1a36f158.Add(_0x8702f2d5);
        }
    }

    private void _0x85dfadee()
    {
        if (!this._0xc50c048c)
        {
            return;
        }

        if (this._0xe5fff92b != null)
        {
            this._0xe5fff92b.Kill();
            this._0xe5fff92b = null;
        }

        this._0xc50c048c = false;
        this._0xb65740ef(false);
        if (this._pops != null)
        {
            this._pops._0x8e7b6aad();
        }

        _0x86c44cb0 _0xaef31c12 = _0x86c44cb0.Instance;
        if (_0xaef31c12 != null)
        {
            _0xaef31c12._0x0f428578(true);
        }
    }

    private void _0x29d55a3d()
    {
        int _0x1675f87d = _0x1d79b688.WrapHall(this._0xa8d56a1a + 1);
        if (this._0xe1104292._0xe443c087(_0x1675f87d))
        {
            this._0xe1104292._0x62d9fb94 = _0x1675f87d;
        }

        this._0xe4581196();
    }

    private void _0xc968b66e()
    {
        if (this._hud != null)
        {
            this._hud._0xa57f47c1();
        }
    }

    [SerializeField]
    private Sprite _backIcon;
    private Tween _0xba7c21ca;
}

internal static class _0x95b301d9
{
    internal static string _0x62223038(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}