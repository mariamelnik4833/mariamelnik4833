using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x44a03f11 : MonoBehaviour
{
    public TMP_Text ContentMainText;
    private void _0x9e04948e()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public GameObject Content;
    public TMP_Text ContentHeaderText;
    private void Start()
    {
    // Content.SetActive(false);
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x9e04948e();
    }

    public static void HideAllPops()
    {
        _0xf7dd1359.Instance._0xeb69e208();
    }

    public void _0xd89565a8()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public bool IsOnlyYScale;
    public Ease ease = Ease.OutSine;
    public float scaleDuration = 0.4f;
    private bool _0x5a0d7303 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public Image ContentImage;
    public TMP_Text ContentAdditionalText;
    public bool IsScaledDownOnAwake = true;
}