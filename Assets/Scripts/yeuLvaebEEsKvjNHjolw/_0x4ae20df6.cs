using UnityEngine;

/// The handful of values that outlive a single trip: which hall the player
/// chose, how many halls they have finished, the best score each hall has
/// seen, and the attempt counter the layout seed is grown from.
///
/// Keys are literal strings on purpose. A persisted identifier must survive
/// renaming, so nameof is exactly the wrong tool for it.
public sealed class _0x4ae20df6
{
    private static readonly string ClearedKey = _0xd926f76d._0x2e446354(new byte[10] { 140, 154, 181, 137, 134, 143, 139, 152, 143, 142 }, 234);
    private static readonly string BestPrefix = _0xd926f76d._0x2e446354(new byte[8] { 200, 222, 241, 204, 203, 221, 218, 241 }, 174);
    /// The purse is the template's own value, so the counter in the game scene
    /// and the plate in the menu can never disagree.
    public int _0x2d95bc07
    {
        get
        {
            return _0x53431849._0xc5e03009._0xc95d7db8;
        }
    }

    /// Hall one is always open. Every later hall opens once the purse has been
    /// filled past its price - there is no shop and no buying step, the lock
    /// simply comes off.
    public bool _0xe443c087(int _0x9b5cb2f9)
    {
        int _0xd78915aa = _0x1d79b688.WrapHall(_0x9b5cb2f9);
        if (_0xd78915aa <= 1)
        {
            return true;
        }

        return this._0x2d95bc07 >= _0x1d79b688.UnlockCost(_0xd78915aa - 1);
    }

    public int _0x62d9fb94
    {
        get
        {
            return _0x1d79b688.WrapHall(PlayerPrefs.GetInt(SelectedKey, 1));
        }

        set
        {
            PlayerPrefs.SetInt(SelectedKey, _0x1d79b688.WrapHall(value));
            PlayerPrefs.Save();
        }
    }

    public void _0xb955f19d(int _0x343760e5, int _0x89c17b9f)
    {
        int _0x832f325d = _0x1d79b688.WrapHall(_0x343760e5);
        if (_0x89c17b9f > this._0xf90d650c(_0x832f325d))
        {
            PlayerPrefs.SetInt(BestPrefix + _0x832f325d, _0x89c17b9f);
            PlayerPrefs.Save();
        }
    }

    private static readonly string AttemptKey = _0xd926f76d._0x2e446354(new byte[10] { 217, 207, 224, 222, 203, 203, 218, 210, 207, 203 }, 191);
    /// The highest hall number the player has finished. Hall 1 is always open;
    /// the rest open with coins.
    public int _0x04febe6c
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(ClearedKey, 0), 0, _0x1d79b688.Halls);
        }

        set
        {
            PlayerPrefs.SetInt(ClearedKey, Mathf.Clamp(value, 0, _0x1d79b688.Halls));
            PlayerPrefs.Save();
        }
    }

    public void _0xad587e05(int _0x901538be)
    {
        if (_0x901538be != 0)
        {
            _0x53431849._0xc5e03009._0xc95d7db8 = _0x53431849._0xc5e03009._0xc95d7db8 + _0x901538be;
        }
    }

    public int _0xf90d650c(int _0xf13794e7)
    {
        return PlayerPrefs.GetInt(BestPrefix + _0x1d79b688.WrapHall(_0xf13794e7), 0);
    }

    private static readonly string SelectedKey = _0xd926f76d._0x2e446354(new byte[11] { 48, 38, 9, 37, 51, 58, 9, 62, 55, 58, 58 }, 86);
    public int _0xb5470f9f
    {
        get
        {
            int _0xa065845a = 0;
            for (int _0x8d4c6421 = 1; _0x8d4c6421 <= _0x1d79b688.Halls; _0x8d4c6421++)
            {
                if (this._0xf90d650c(_0x8d4c6421) > 0)
                {
                    _0xa065845a = _0x8d4c6421;
                }
            }

            return _0xa065845a;
        }
    }

    /// A fresh attempt number for the next trip. Two trips through the same
    /// hall never share a seed, so the orders never sit the same way twice.
    public int _0xbf2506e0()
    {
        int _0xe3b64571 = PlayerPrefs.GetInt(AttemptKey, 0) + 1;
        PlayerPrefs.SetInt(AttemptKey, _0xe3b64571);
        PlayerPrefs.Save();
        return _0xe3b64571;
    }
}

internal static class _0xd926f76d
{
    internal static string _0x2e446354(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}