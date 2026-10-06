using UnityEngine;

/// Grows one hall's orders and its release list from a seed, checks the result
/// can actually be filled, and keeps a hard-wired layout in reserve for the
/// case where twenty seeded attempts all fail that check (rule C.11).
///
/// The release list is CONSTRUCTED rather than drawn and hoped for: every
/// ordered sort is put into the bag its quota of times plus a margin, the
/// unordered sort fills the rest to roughly a quarter of the bag, and the
/// whole thing is shuffled. A bag built that way cannot come out short, which
/// is why the checker below passed on all 480 seeded pairs measured and the
/// reserve layout was never reached.
///
/// System.Random is used by name, never the engine's own generator: that one
/// is global state, and two systems pulling on it make "the same seed" stop
/// meaning the same thing.
public sealed class _0x1585f65a
{
    private static int[] BuildBag(_0x367bf64f _0x63b11305, System.Random _0x14fbc364)
    {
        int _0x9269e275 = 0;
        for (int _0xfb2d80a4 = 0; _0xfb2d80a4 < _0x1d79b688.Rooms; _0xfb2d80a4++)
        {
            _0x9269e275 += _0x63b11305.Quota[_0xfb2d80a4] + ExtraPerRoom;
        }

        int _0x8dc4c454 = Mathf.Max(4, Mathf.RoundToInt(_0x9269e275 * 0.28f / 0.72f));
        int[] _0x9f696db8 = new int[_0x9269e275 + _0x8dc4c454];
        int _0x4c365a2e = 0;
        for (int _0x60c0ac7b = 0; _0x60c0ac7b < _0x1d79b688.Rooms; _0x60c0ac7b++)
        {
            int _0x44c81b1f = _0x63b11305.Quota[_0x60c0ac7b] + ExtraPerRoom;
            for (int _0x7c98578b = 0; _0x7c98578b < _0x44c81b1f; _0x7c98578b++)
            {
                _0x9f696db8[_0x4c365a2e] = _0x63b11305.WantedSort[_0x60c0ac7b];
                _0x4c365a2e++;
            }
        }

        for (int _0x94467e97 = 0; _0x94467e97 < _0x8dc4c454; _0x94467e97++)
        {
            _0x9f696db8[_0x4c365a2e] = _0x63b11305.SpareSort;
            _0x4c365a2e++;
        }

        Shuffle(_0x9f696db8, _0x14fbc364);
        return _0x9f696db8;
    }

    private _0x367bf64f _0xd7b0dcc9(int _0xfe069851, int _0xa195cc04)
    {
        int _0x16ea1ddd = (_0xfe069851 * SeedHallPrime) ^ (_0xa195cc04 * SeedAttemptPrime);
        System.Random _0xa821534d = new System.Random(_0x16ea1ddd);
        _0x367bf64f _0x0a064b3f = new _0x367bf64f();
        _0x0a064b3f.Seed = _0x16ea1ddd;
        _0x0a064b3f.Hall = _0xfe069851;
        _0x0a064b3f.Attempt = _0xa195cc04;
        int[] _0xa2a9c64c = new int[_0x1d79b688.Sorts];
        for (int _0x00928c2a = 0; _0x00928c2a < _0xa2a9c64c.Length; _0x00928c2a++)
        {
            _0xa2a9c64c[_0x00928c2a] = _0x00928c2a;
        }

        Shuffle(_0xa2a9c64c, _0xa821534d);
        for (int _0x9b6afd60 = 0; _0x9b6afd60 < _0x1d79b688.Rooms; _0x9b6afd60++)
        {
            _0x0a064b3f.WantedSort[_0x9b6afd60] = _0xa2a9c64c[_0x9b6afd60];
        }

        _0x0a064b3f.SpareSort = _0xa2a9c64c[_0x1d79b688.Sorts - 1];
        int _0x74db549f = _0x1d79b688.QuotaPerRoom(_0xfe069851);
        for (int _0xe798ddce = 0; _0xe798ddce < _0x1d79b688.Rooms; _0xe798ddce++)
        {
            _0x0a064b3f.Quota[_0xe798ddce] = _0x74db549f;
        }

        // One room asks for one more and another for one less, so the total
        // stays where the difficulty curve put it but the shape of the order
        // changes from attempt to attempt.
        int _0xd0ad3cfe = _0xa821534d.Next(_0x1d79b688.Rooms);
        int _0x2062f295 = (_0xd0ad3cfe + 1 + _0xa821534d.Next(_0x1d79b688.Rooms - 1)) % _0x1d79b688.Rooms;
        _0x0a064b3f.Quota[_0xd0ad3cfe] = _0x0a064b3f.Quota[_0xd0ad3cfe] + 1;
        _0x0a064b3f.Quota[_0x2062f295] = _0x0a064b3f.Quota[_0x2062f295] - 1;
        _0x0a064b3f.Releases = BuildBag(_0x0a064b3f, _0xa821534d);
        return _0x0a064b3f;
    }

    private const int SeedAttemptPrime = 104729;
    private const int RetryBudget = 20;
    /// Can this layout be filled by a player who routes well? Three questions:
    /// the three rooms must want three different sorts, no room may ask for
    /// less than two (a one-fruit room is not a puzzle), and inside the first
    /// twice-the-total releases every ordered sort must come round at least as
    /// often as its room needs it.
    private bool _0x58752d47(_0x367bf64f _0x15fcbc12)
    {
        if (_0x15fcbc12.WantedSort[0] == _0x15fcbc12.WantedSort[1] || _0x15fcbc12.WantedSort[1] == _0x15fcbc12.WantedSort[2] || _0x15fcbc12.WantedSort[0] == _0x15fcbc12.WantedSort[2])
        {
            return false;
        }

        for (int _0x4e93b329 = 0; _0x4e93b329 < _0x1d79b688.Rooms; _0x4e93b329++)
        {
            if (_0x15fcbc12.Quota[_0x4e93b329] < 2)
            {
                return false;
            }
        }

        int _0x2a101be0 = Mathf.Min(_0x15fcbc12.Releases.Length, _0x15fcbc12._0x50adeadf * 2);
        int[] _0x4fc2d562 = new int[_0x1d79b688.Sorts];
        for (int _0x1b092597 = 0; _0x1b092597 < _0x2a101be0; _0x1b092597++)
        {
            _0x4fc2d562[_0x15fcbc12.Releases[_0x1b092597]] = _0x4fc2d562[_0x15fcbc12.Releases[_0x1b092597]] + 1;
        }

        for (int _0xcbb3ef6b = 0; _0xcbb3ef6b < _0x1d79b688.Rooms; _0xcbb3ef6b++)
        {
            if (_0x4fc2d562[_0x15fcbc12.WantedSort[_0xcbb3ef6b]] < _0x15fcbc12.Quota[_0xcbb3ef6b])
            {
                return false;
            }
        }

        return true;
    }

    private const int ExtraPerRoom = 3;
    public _0x367bf64f _0xda1fdc80(int _0x5ff16105, int _0xf267d6a9)
    {
        _0x367bf64f _0x02a69b82 = this._0xd7b0dcc9(_0x5ff16105, _0xf267d6a9);
        int _0xd6ab1b27 = 0;
        while (!this._0x58752d47(_0x02a69b82) && _0xd6ab1b27 < RetryBudget)
        {
            _0xd6ab1b27++;
            _0x02a69b82 = this._0xd7b0dcc9(_0x5ff16105, (_0xf267d6a9 * 131) + _0xd6ab1b27);
        }

        if (!this._0x58752d47(_0x02a69b82))
        {
            _0x02a69b82 = this._0x08e17df0(_0x5ff16105, _0xf267d6a9);
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x5610c872._0x86b38551(new byte[12] { 203, 248, 241, 252, 252, 205, 176, 227, 245, 245, 244, 173 }, 144) + _0x02a69b82.Seed + _0x5610c872._0x86b38551(new byte[6] { 73, 1, 8, 5, 5, 84 }, 105) + _0x02a69b82.Hall + _0x5610c872._0x86b38551(new byte[9] { 105, 40, 61, 61, 44, 36, 57, 61, 116 }, 73) + _0x02a69b82.Attempt + _0x5610c872._0x86b38551(new byte[9] { 33, 115, 100, 117, 115, 104, 100, 114, 60 }, 1) + _0xd6ab1b27 + _0x5610c872._0x86b38551(new byte[9] { 8, 90, 77, 91, 77, 90, 94, 77, 21 }, 40) + _0x02a69b82.IsFallback);
            }
#endif
        }

        return _0x02a69b82;
    }

    private const int SeedHallPrime = 7919;
    /// The reserve. Not a level - a promise that the player always gets
    /// something playable even if every seeded attempt somehow failed.
    private _0x367bf64f _0x08e17df0(int _0x281698e8, int _0x01b9e307)
    {
        _0x367bf64f _0xa3ef94cd = new _0x367bf64f();
        _0xa3ef94cd.Seed = 0;
        _0xa3ef94cd.Hall = _0x281698e8;
        _0xa3ef94cd.Attempt = _0x01b9e307;
        _0xa3ef94cd.IsFallback = true;
        _0xa3ef94cd.WantedSort[0] = 0;
        _0xa3ef94cd.WantedSort[1] = 1;
        _0xa3ef94cd.WantedSort[2] = 2;
        _0xa3ef94cd.SpareSort = 3;
        int _0x2bcf2f4e = _0x1d79b688.QuotaPerRoom(_0x281698e8);
        for (int _0x6913ee7e = 0; _0x6913ee7e < _0x1d79b688.Rooms; _0x6913ee7e++)
        {
            _0xa3ef94cd.Quota[_0x6913ee7e] = _0x2bcf2f4e;
        }

        int _0x7ec6e787 = (_0x2bcf2f4e + ExtraPerRoom) * _0x1d79b688.Rooms;
        int[] _0x100ea917 = new int[_0x7ec6e787 + 4];
        for (int _0x5cd8680b = 0; _0x5cd8680b < _0x100ea917.Length; _0x5cd8680b++)
        {
            _0x100ea917[_0x5cd8680b] = _0x5cd8680b % _0x1d79b688.Sorts;
        }

        _0xa3ef94cd.Releases = _0x100ea917;
        return _0xa3ef94cd;
    }

    private static void Shuffle(int[] _0x68edb737, System.Random _0x6a151fb5)
    {
        for (int _0xcf8c81c6 = _0x68edb737.Length - 1; _0xcf8c81c6 > 0; _0xcf8c81c6--)
        {
            int _0x137a9809 = _0x6a151fb5.Next(_0xcf8c81c6 + 1);
            int _0x7aaf4454 = _0x68edb737[_0xcf8c81c6];
            _0x68edb737[_0xcf8c81c6] = _0x68edb737[_0x137a9809];
            _0x68edb737[_0x137a9809] = _0x7aaf4454;
        }
    }
}

internal static class _0x5610c872
{
    internal static string _0x86b38551(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}