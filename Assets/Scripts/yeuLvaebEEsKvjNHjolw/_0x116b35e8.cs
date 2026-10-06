using DG.Tweening;
using UnityEngine;

/// One diverter in the shaft: a pivot cap with an arm across it. The arm
/// decides which of the two ways below the gate a fruit takes, and a tap
/// throws it to the other side.
///
/// The arm sprite is drawn facing RIGHT, which is declared in the art
/// manifest, so pointing it left is an explicit mirror rather than an
/// accident of whichever way the model happened to draw it (rule C.8).
///
/// Sizes come from the board, which derives them from the camera: nothing
/// here is a hand-picked literal (rule C.0).
public sealed class _0x116b35e8 : MonoBehaviour
{
    private bool _0x3a166066;
    private void OnDestroy()
    {
        if (this._0x8203c2bc != null)
        {
            this._0x8203c2bc.transform.DOKill();
            this._0x8203c2bc.DOKill();
        }

        if (this._0xba2772c2 != null)
        {
            this._0xba2772c2.transform.DOKill();
        }
    }

    public void _0x8b46f432(SpriteRenderer _0x2e0898df, SpriteRenderer _0x15c52275, float _0x488b799c, Vector2 _0xa8e5fe80, bool _0x6687aa52)
    {
        this._0x8203c2bc = _0x2e0898df;
        this._0xba2772c2 = _0x15c52275;
        if (this._0x8203c2bc != null)
        {
            this._0x8203c2bc.size = new Vector2(_0x488b799c, _0x488b799c);
            this._0x8203c2bc.transform.localPosition = Vector3.zero;
            this._0x8203c2bc.transform.localScale = Vector3.one;
            this._0xdabb4a86 = this._0x8203c2bc.transform.localScale;
        }

        if (this._0xba2772c2 != null)
        {
            this._0xba2772c2.size = _0xa8e5fe80;
            this._0xba2772c2.transform.localPosition = Vector3.zero;
            this._0xba2772c2.transform.localScale = Vector3.one;
        }

        this._0x3a166066 = _0x6687aa52;
        this._0x2810b14d(true);
    }

    /// True when the arm sends fruit to the RIGHT of this gate.
    public bool _0xe6420377
    {
        get
        {
            return this._0x3a166066;
        }
    }

    private Vector3 _0xdabb4a86 = Vector3.one;
    public void _0xee8b439e(bool _0x76864a43, bool _0xef8ffc31)
    {
        if (this._0x3a166066 == _0x76864a43 && !_0xef8ffc31)
        {
            return;
        }

        this._0x3a166066 = _0x76864a43;
        this._0x2810b14d(_0xef8ffc31);
    }

    public void _0x4026b2cf(Color _0xc44d1812)
    {
        if (this._0x8203c2bc != null)
        {
            this._0x8203c2bc.DOKill();
            this._0x8203c2bc.color = _0xc44d1812;
            this._0x8203c2bc.DOColor(Color.white, 0.4f);
        }
    }

    private const float ArmAngle = 32f;
    public Vector2 _0xc429b10b
    {
        get
        {
            return this.transform.position;
        }
    }

    private SpriteRenderer _0x8203c2bc;
    /// Throws the arm the other way. Returns the side it now points at so the
    /// caller can log or react without reading state back.
    public bool _0xe147320f()
    {
        this._0x3a166066 = !this._0x3a166066;
        this._0x2810b14d(false);
        if (this._0x8203c2bc != null)
        {
            Transform _0xe9b15242 = this._0x8203c2bc.transform;
            _0xe9b15242.DOKill(true);
            _0xe9b15242.localScale = this._0xdabb4a86;
            _0xe9b15242.DOPunchScale(this._0xdabb4a86 * 0.14f, 0.22f, 8, 0.6f);
        }

        return this._0x3a166066;
    }

    private void _0x2810b14d(bool _0xbf36c483)
    {
        if (this._0xba2772c2 == null)
        {
            return;
        }

        Transform _0x20a7335e = this._0xba2772c2.transform;
        _0x20a7335e.DOKill();
        this._0xba2772c2.flipX = !this._0x3a166066;
        float _0xd2e04dcb = this._0x3a166066 ? -ArmAngle : ArmAngle;
        if (_0xbf36c483)
        {
            _0x20a7335e.localRotation = Quaternion.Euler(0f, 0f, _0xd2e04dcb);
            return;
        }

        _0x20a7335e.DOLocalRotate(new Vector3(0f, 0f, _0xd2e04dcb), ThrowSeconds, RotateMode.Fast).SetEase(Ease.OutBack);
    }

    private SpriteRenderer _0xba2772c2;
    private const float ThrowSeconds = 0.18f;
}