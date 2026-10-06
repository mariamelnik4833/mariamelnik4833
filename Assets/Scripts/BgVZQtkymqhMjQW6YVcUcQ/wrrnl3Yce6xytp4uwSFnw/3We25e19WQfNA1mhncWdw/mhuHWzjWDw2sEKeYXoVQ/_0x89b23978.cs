using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x89b23978 : MonoBehaviour
{
    public void _0x5832e80f()
    {
        this._0x9a50baee();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x09adb88e.Instance._0x46599954(_0x09adb88e.Instance.CurrentPanelIndex);
    }

    private bool _0x768bda51 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public GameObject OuterBackground;
    private void _0xe3844e56()
    {
        if (this.OuterBackground != null)
        {
            Image _0x1379cf16 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x1379cf16, true);
            _0x1379cf16.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public bool IsScaledDownOnAwake = true;
    public GameObject Content;
    public TMP_Text MainText;
    private void _0x9a50baee()
    {
        if (this.OuterBackground != null)
        {
            Image _0x144c9b39 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x144c9b39, true);
            _0x144c9b39.DOFade(1f, 0f);
        }
    }

    public void _0xe70339f1()
    {
        this._0x09a5bca4();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public void Show()
    {
        this._0x017fddf4();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x09adb88e.Instance._0x46599954(_0x09adb88e.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0x017fddf4()
    {
        if (this.OuterBackground != null)
        {
            Image _0x7a2e9cb2 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x7a2e9cb2, true);
            _0x7a2e9cb2.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xe3844e56();
    }

    private void _0x09a5bca4()
    {
        if (this.OuterBackground != null)
        {
            Image _0x3052139a = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x3052139a, true);
            _0x3052139a.DOFade(0f, this.ScaleDuration);
        }
    }

    public Ease Ease = Ease.OutSine;
    public float ScaleDuration = 0.4f;
    public TMP_Text HeaderText;
}