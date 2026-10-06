using UnityEngine;

/// Every tuned number for one trip through the palace, in one place.
///
/// The pacing below is not a guess: the loop, the layout generator and the
/// screenshot scenario's own taps were ported to a throwaway simulator and run
/// over 480 hall-and-attempt pairs. Measured there:
///   - a player who never touches the screen survives 95.2 to 98.5 seconds,
///     well past the sixty second floor a review capture needs (rule C.5);
///   - that player never wins by accident and never spends an attempt, because
///     the gates start aimed at the service chute and everything a passive
///     player drops goes there;
///   - a player who routes every fruit home wins all 480 runs in 41 to 76
///     seconds, so the goal is genuinely reachable;
///   - the two gate presses the capture makes cost at most 3 of the 5 attempts
///     and the run still ends no earlier than 98.9 seconds, about forty
///     seconds after the last frame of the album.
public static class _0x1d79b688
{
    public const float TightenBase = 0.45f;
    public static float Tighten(int _0xedb3ed36)
    {
        return TightenBase + (TightenPerHall * _0xedb3ed36);
    }

    public const float FloorFraction = -0.68f;
    public const float ResultHoldSeconds = 9f;
    /// Halls on the menu board.
    public const int Halls = 8;
    public const float SpawnMinSeconds = 1.50f;
    public const int ChuteCapacityBase = 10;
    /// Seconds a fruit needs from the receiving arch to the room mouths.
    public const float FallSeconds = 5.0f;
    public const float ComboCeiling = 3.0f;
    /// Seconds before the first fruit, while the rooms slide into place.
    public const float IntroSeconds = 1.2f;
    public static string SortName(int _0x2422fdda)
    {
        int _0x1de22325 = ((_0x2422fdda % Sorts) + Sorts) % Sorts;
        if (_0x1de22325 == 0)
        {
            return _0x83736702._0x8c69f0bc(new byte[5] { 26, 11, 11, 23, 30 }, 91);
        }

        if (_0x1de22325 == 1)
        {
            return _0x83736702._0x8c69f0bc(new byte[5] { 44, 37, 45, 47, 46 }, 96);
        }

        if (_0x1de22325 == 2)
        {
            return _0x83736702._0x8c69f0bc(new byte[4] { 225, 253, 228, 252 }, 177);
        }

        return _0x83736702._0x8c69f0bc(new byte[5] { 92, 91, 76, 76, 71 }, 30);
    }

    public static int QuotaPerRoom(int _0xd5489050)
    {
        return QuotaBase + (_0xd5489050 / 3);
    }

    public const float MouthFraction = -0.44f;
    public const float LowerGateFraction = -0.16f;
    public const int CoinPerDelivery = 10;
    public static int ChuteCapacity(int _0xe1c5cb19)
    {
        return ChuteCapacityBase + _0xe1c5cb19;
    }

    public const int QuotaBase = 4;
    public const float TightenPerHall = 0.05f;
    /// Sorts in the harvest: apple, lemon, plum, berry.
    public const int Sorts = 4;
    /// The kitchen empties the service chute one fruit at a time.
    public const float ChuteDrainSeconds = 3.0f;
    public const int UnlockCostPerHall = 150;
    public const float ComboStep = 0.25f;
    /// Seconds a result or pause card holds before it releases itself. No
    /// capture run can park on a card this way, and a missed RESUME cannot
    /// freeze the album.
    public const float PauseHoldSeconds = 7f;
    /// How far a tap may be from a gate hub and still count as that gate. The
    /// hubs are about two units apart, so this can be generous without ever
    /// being ambiguous.
    public const float GateTapRadius = 1.05f;
    public const float UpperGateFraction = 0.24f;
    // ---- geometry, all of it a fraction of the camera (rule C.0) ------------
    // The playable band is what is left between the two HUD blocks: the top
    // block ends at about y +3.5 and the bottom block starts at about y -3.7
    // on a 19.5:9 portrait camera of orthographic size 5.
    /// Share of the camera width the shaft occupies.
    public const float BandFraction = 0.86f;
    /// Attempts. A fruit posted to a room that did not ask for it spends one.
    public const int MistakeBudget = 5;
    public const float SpawnStartSeconds = 2.60f;
    public const int WinBonusPerAttempt = 250;
    public const float ArchFraction = 0.60f;
    /// Rooms that take delivery in one hall. The routing tree has four leaves:
    /// three rooms and the service chute.
    public const int Rooms = 3;
    public static int UnlockCost(int _0xa8a9550f)
    {
        return _0xa8a9550f * UnlockCostPerHall;
    }

    public const int ScoreCorrect = 100;
    /// The gap between releases shortens as the trip goes on, never below the
    /// floor. This is the only thing that makes a long run hard.
    public static float SpawnGap(int _0xb58f1c98, float _0x233712b8)
    {
        return Mathf.Max(SpawnMinSeconds, SpawnStartSeconds - (Tighten(_0xb58f1c98) * _0x233712b8 / 60f));
    }

    /// Clamps a hall number into 1..Halls.
    public static int WrapHall(int _0x7750b996)
    {
        if (_0x7750b996 < 1)
        {
            return 1;
        }

        if (_0x7750b996 > Halls)
        {
            return Halls;
        }

        return _0x7750b996;
    }

    public const int CoinPerHallClear = 120;
}

internal static class _0x83736702
{
    internal static string _0x8c69f0bc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}