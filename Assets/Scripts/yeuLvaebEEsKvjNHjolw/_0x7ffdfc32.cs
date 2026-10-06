using TMPro;
using UnityEngine;

/// Outline and layout discipline for every label this game builds in code.
///
/// The shared font material carries ONE outline colour for the whole app, so a
/// label whose face is close to that colour reads as a blob. Touching
/// fontMaterial makes a per-label instance, which lets each label pick a rim
/// against its own face while the shared asset stays exactly as it shipped
/// (rules C.10 and C.14).
///
/// Word wrap is off and every break is an explicit escape in the string:
/// automatic wrapping produces a different number of lines per device and the
/// layout under it moves. Autosize is always on with its floor at the
/// readability minimum - that floor is the size that really ships, because a
/// line that does not fit is shrunk to exactly it (rule C.12).
public static class _0x7ffdfc32
{
    public static void ApplyOutline(TMP_Text _0x153dd2e7, Color _0x062eee69)
    {
        if (_0x153dd2e7 == null)
        {
            return;
        }

        _0x153dd2e7.color = _0x062eee69;
        float _0xb0bfb5db = (0.299f * _0x062eee69.r) + (0.587f * _0x062eee69.g) + (0.114f * _0x062eee69.b);
        Color _0x8ca9b3a3 = _0xb0bfb5db < 0.5f ? _0xb0c2dde3.Cream : _0xb0c2dde3.Deep;
        Material _0xdb8bd721 = _0x153dd2e7.fontMaterial;
        if (_0xdb8bd721 == null)
        {
            return;
        }

        _0xdb8bd721.EnableKeyword(ShaderUtilities.Keyword_Outline);
        _0xdb8bd721.SetColor(ShaderUtilities.ID_OutlineColor, _0x8ca9b3a3);
        _0xdb8bd721.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.22f);
        _0xdb8bd721.SetFloat(ShaderUtilities.ID_FaceDilate, 0.18f);
    }

    public static void ApplyLayout(TMP_Text _0xadf19cd3, float _0x3fc9ad15)
    {
        if (_0xadf19cd3 == null)
        {
            return;
        }

        _0xadf19cd3.textWrappingMode = TextWrappingModes.NoWrap;
        _0xadf19cd3.overflowMode = TextOverflowModes.Overflow;
        _0xadf19cd3.enableAutoSizing = true;
        _0xadf19cd3.fontSizeMin = UiFontFloor;
        _0xadf19cd3.fontSizeMax = Mathf.Max(UiFontFloor, _0x3fc9ad15);
        _0xadf19cd3.fontSize = Mathf.Max(UiFontFloor, _0x3fc9ad15);
    }

    /// Readability floor in canvas reference pixels, one notch above the
    /// 24 px minimum so a long line still lands clear of it.
    public const float UiFontFloor = 30f;
}