using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x020b2e67 : MonoBehaviour
{
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x9cd91d89;
    private const float MinRatio = 4.5f;
    private readonly List<TMP_Text> _0x3ba692d2 = new List<TMP_Text>();
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x7fd21230)
    {
        return 0.2126f * Linear(_0x7fd21230.r) + 0.7152f * Linear(_0x7fd21230.g) + 0.0722f * Linear(_0x7fd21230.b);
    }

    private readonly HashSet<TMP_Text> _0x957e8a1a = new HashSet<TMP_Text>();
    private const float TargetRatio = 7f;
    private void LateUpdate()
    {
        if (this._0x957e8a1a.Count == 0)
            return;
        this._0x3ba692d2.Clear();
        this._0x3ba692d2.AddRange(this._0x957e8a1a);
        this._0x957e8a1a.Clear();
        for (int _0x49a094f3 = 0; _0x49a094f3 < this._0x3ba692d2.Count; _0x49a094f3++)
            Fix(this._0x3ba692d2[_0x49a094f3]);
    }

    private const float MinOutlineWidth = 0.01f;
    private static _0x020b2e67 _0xfd09c0aa;
    private void OnDisable()
    {
        if (this._0x9cd91d89 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x9cd91d89);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x80060b2a(Object _0x4c461096)
    {
        TMP_Text _0x216aecf7 = _0x4c461096 as TMP_Text;
        if (_0x216aecf7 != null)
            this._0x957e8a1a.Add(_0x216aecf7);
    }

    private static float Linear(float _0x2924753a)
    {
        _0x2924753a = Mathf.Clamp01(_0x2924753a);
        return _0x2924753a <= 0.03928f ? _0x2924753a / 12.92f : Mathf.Pow((_0x2924753a + 0.055f) / 1.055f, 2.4f);
    }

    private void OnEnable()
    {
        if (this._0x9cd91d89 == null)
            this._0x9cd91d89 = _0x84d607b5 => this._0x80060b2a(_0x84d607b5);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x9cd91d89);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xfd09c0aa != null)
            return;
        GameObject _0x588bd55e = new GameObject(_0x21edc0a9._0xe39ba5a4(new byte[16] { 80, 105, 116, 71, 107, 106, 112, 118, 101, 119, 112, 67, 113, 101, 118, 96 }, 4));
        _0x588bd55e.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x588bd55e);
        _0xfd09c0aa = _0x588bd55e.AddComponent<_0x020b2e67>();
    }

    private static void Fix(TMP_Text _0x04eb6a13)
    {
        if (_0x04eb6a13 == null || !_0x04eb6a13.isActiveAndEnabled)
            return;
        Material _0xf81cb862 = _0x04eb6a13.fontSharedMaterial;
        if (_0xf81cb862 == null || !_0xf81cb862.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xf81cb862.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xf81cb862.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x52d8aa15 = _0x04eb6a13.color;
        if (_0x52d8aa15.a <= 0f)
            return;
        Color _0xb3b0acaa = _0xf81cb862.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x52d8aa15, _0xb3b0acaa) >= MinRatio)
            return;
        Color _0x7af6c792 = Luminance(_0xb3b0acaa) < 0.5f ? Color.white : Color.black;
        Color _0xac5f5c65;
        if (Ratio(_0x7af6c792, _0xb3b0acaa) < TargetRatio)
        {
            _0xac5f5c65 = _0x7af6c792;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xc2510020 = 0f;
            float _0xe1ae8a2e = 1f;
            for (int _0x80da3af7 = 0; _0x80da3af7 < 20; _0x80da3af7++)
            {
                float _0x2678fca8 = (_0xc2510020 + _0xe1ae8a2e) * 0.5f;
                if (Ratio(Color.Lerp(_0x52d8aa15, _0x7af6c792, _0x2678fca8), _0xb3b0acaa) >= TargetRatio)
                    _0xe1ae8a2e = _0x2678fca8;
                else
                    _0xc2510020 = _0x2678fca8;
            }

            _0xac5f5c65 = Color.Lerp(_0x52d8aa15, _0x7af6c792, _0xe1ae8a2e);
        }

        _0xac5f5c65.a = _0x52d8aa15.a;
        _0x04eb6a13.color = _0xac5f5c65;
    }

    private static float Ratio(Color _0x310d85bc, Color _0xc78424aa)
    {
        float _0x1b025a5f = Luminance(_0x310d85bc);
        float _0x772414a7 = Luminance(_0xc78424aa);
        return (Mathf.Max(_0x1b025a5f, _0x772414a7) + 0.05f) / (Mathf.Min(_0x1b025a5f, _0x772414a7) + 0.05f);
    }
}

internal static class _0x21edc0a9
{
    internal static string _0xe39ba5a4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}