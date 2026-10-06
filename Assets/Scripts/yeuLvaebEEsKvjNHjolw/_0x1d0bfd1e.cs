using UnityEngine;
using UnityEngine.EventSystems;

/// How the player reaches the gates.
///
/// The template's input helper cannot be used: in this template its instance
/// field and every one of its read methods are private, so the call the rules
/// suggest does not compile. A single full-surface UI graphic is the better
/// answer anyway - the pointer arrives in screen pixels, one conversion puts
/// it in world space, and the result is exact on any aspect without a single
/// correction for how the canvas happens to be letterboxed.
///
/// It is built as the FIRST child of the heads-up display, so every button
/// added afterwards wins the raycast over it and a press on PAUSE never
/// doubles as a press on the board behind it.
public sealed class _0x1d0bfd1e : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData _0x5455e265)
    {
        if (this._0x6cb911ea == null || _0x5455e265 == null)
        {
            return;
        }

        Camera _0xbc6aeafb = this._0xf0187fa2 != null ? this._0xf0187fa2 : Camera.main;
        if (_0xbc6aeafb == null)
        {
            return;
        }

        Vector3 _0xb49c5803 = _0xbc6aeafb.ScreenToWorldPoint(new Vector3(_0x5455e265.position.x, _0x5455e265.position.y, -_0xbc6aeafb.transform.position.z));
        this._0x6cb911ea.Invoke(new Vector2(_0xb49c5803.x, _0xb49c5803.y));
    }

    private System.Action<Vector2> _0x6cb911ea;
    public void _0x893627ea(Camera _0x0a29a8a2, System.Action<Vector2> _0x1290b3ec)
    {
        this._0xf0187fa2 = _0x0a29a8a2;
        this._0x6cb911ea = _0x1290b3ec;
    }

    private Camera _0xf0187fa2;
}