using UnityEngine;

/// The one palette every screen reads: splash, menu, the shaft, the result
/// cards and the world art. Keeping it in a single place is what stops the
/// menu and the run from drifting apart.
///
/// Fill colours and text colours are NOT interchangeable here. Every label is
/// drawn with a dark rim (see TextReadability), so a dark face sinks into its
/// own outline and turns into a smear. Deep, DeepLift and Grape are fills
/// only; GrapeText is the lightened stand-in for the rare moment that colour
/// has to be spelled out in words.
public static class _0xb0c2dde3
{
    /// #B99BE4 - the readable form of that colour, for when it must be written.
    public static readonly Color GrapeText = new Color(0.725f, 0.608f, 0.894f, 1f);
    /// #1E3D29 - the raised surface: card bodies, chips, the shaft wall.
    public static readonly Color DeepLift = new Color(0.118f, 0.239f, 0.161f, 1f);
    /// #173020 - the rim colour of every label and the darkest surface.
    public static readonly Color Deep = new Color(0.090f, 0.188f, 0.125f, 1f);
    /// #F5C451 - the palace trim: frames, numbers, the crown mark.
    public static readonly Color Gold = new Color(0.961f, 0.769f, 0.318f, 1f);
    public static Color WithAlpha(Color _0x8d8c0c1e, float _0x8ba2ef5b)
    {
        return new Color(_0x8d8c0c1e.r, _0x8d8c0c1e.g, _0x8d8c0c1e.b, _0x8ba2ef5b);
    }

    /// #8D67C7 - decoration and the plum hall. FILL ONLY: against the dark rim
    /// it measures about 4.2:1, under the 4.5:1 floor, so it is never a label.
    public static readonly Color Grape = new Color(0.553f, 0.404f, 0.780f, 1f);
    /// #FFF6E5 - the default text colour.
    public static readonly Color Cream = new Color(1f, 0.965f, 0.898f, 1f);
    /// The same four in a form that is safe to read as text against the dark rim.
    public static Color SortText(int _0xb166ab07)
    {
        int _0x29f2edc6 = ((_0xb166ab07 % 4) + 4) % 4;
        if (_0x29f2edc6 == 2)
        {
            return GrapeText;
        }

        return Sort(_0x29f2edc6);
    }

    /// The four harvest colours in the order the sorts are numbered:
    /// 0 apple, 1 lemon, 2 plum, 3 berry. Used for fills - gauges, hall trim,
    /// bursts - never for a label.
    public static Color Sort(int _0xd678dcd3)
    {
        int _0x02dd7ec4 = ((_0xd678dcd3 % 4) + 4) % 4;
        if (_0x02dd7ec4 == 0)
        {
            return Coral;
        }

        if (_0x02dd7ec4 == 1)
        {
            return Gold;
        }

        if (_0x02dd7ec4 == 2)
        {
            return Grape;
        }

        return Lime;
    }

    /// #BFD4C0 - secondary captions: present, but a step back from Cream.
    public static readonly Color Muted = new Color(0.749f, 0.831f, 0.753f, 1f);
    /// #EE6B55 - trouble: a spent attempt, an overfull service chute.
    public static readonly Color Coral = new Color(0.933f, 0.420f, 0.333f, 1f);
    /// #0C1A11 - the shadow under a card.
    public static readonly Color Shade = new Color(0.047f, 0.102f, 0.067f, 1f);
    /// #7CCB5B - the primary accent: the main action, a filled gauge, a hall
    /// that has taken what it asked for.
    public static readonly Color Lime = new Color(0.486f, 0.796f, 0.357f, 1f);
}