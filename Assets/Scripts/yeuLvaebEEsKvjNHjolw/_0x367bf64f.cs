/// What one trip through a hall is made of. Everything here comes out of the
/// generator's seed, so two attempts at the same hall ask for different sorts,
/// in different rooms, in different quantities, and in a different order
/// (rule C.11).
///
/// Public because a public component hands it around; a shared data type in an
/// internal class would make those signatures illegal.
public sealed class _0x367bf64f
{
    public int _0x50adeadf
    {
        get
        {
            int _0xd2241362 = 0;
            for (int _0x36d69226 = 0; _0x36d69226 < this.Quota.Length; _0x36d69226++)
            {
                _0xd2241362 += this.Quota[_0x36d69226];
            }

            return _0xd2241362;
        }
    }

    /// The release order. The arch walks this list and starts again at the top
    /// when it runs out, so a long trip never dries up.
    public int[] Releases = new int[0];
    /// How many of its sort each room needs before it closes its shutter.
    public int[] Quota = new int[_0x1d79b688.Rooms];
    public int Attempt;
    /// Which room, if any, is waiting for this sort right now.
    /// Returns -1 when nobody ordered it.
    public int _0x3a11187e(int _0xd96dc806)
    {
        for (int _0xace66438 = 0; _0xace66438 < this.WantedSort.Length; _0xace66438++)
        {
            if (this.WantedSort[_0xace66438] == _0xd96dc806)
            {
                return _0xace66438;
            }
        }

        return -1;
    }

    /// Which sort each of the three rooms is waiting for. Always distinct.
    public int[] WantedSort = new int[_0x1d79b688.Rooms];
    /// The fourth sort, the one nobody ordered.
    public int SpareSort;
    /// True only when twenty seeded attempts all failed their own check and
    /// the hard-wired layout had to stand in. It is a guarantee, not a game.
    public bool IsFallback;
    /// The seed this layout was grown from. Written to the log under B_LOGS so
    /// a reported run can be reproduced exactly.
    public int Seed;
    public int Hall;
}