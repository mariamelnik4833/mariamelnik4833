using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xab64f467 : MonoBehaviour
{
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x53431849._0x7146dbc1.SCENE_0 && !_0xdb35e481)
        {
            this._0x4b4424f8();
        }
        else
        {
            this._0x3421e090();
        }
    }

    public void _0x3421e090()
    {
        this._0x530b1a51();
        bool _0x59b7698f = _0xdb35e481;
        this._0xc0a623fc = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x072bb5a3 => this.AnimationSlider.value = _0x072bb5a3, _0x59b7698f ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xdb35e481 = !_0xdb35e481;
    }

    public GameObject Content;
    public Slider AnimationSlider;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xab64f467>();
    }

    private static bool _0xdb35e481 = false;
    public void _0x7a9b64d0()
    {
        this._0xc0a623fc?.Pause();
    }

    public void _0x7f027923()
    {
        this._0xc0a623fc?.Play();
    }

    private void _0x4b4424f8()
    {
        this.AnimationSlider.value = 0.05f;
        _0xdb35e481 = !_0xdb35e481;
        this._0xc0a623fc = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x072bb5a3 => this.AnimationSlider.value = _0x072bb5a3, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xb9040019._0xc64e388f?._0xdc474f80();
        });
    }

    public float FirstAnimationTime = 10.0f;
    private Sequence _0xc0a623fc;
    public GameObject Background;
    public static _0xab64f467 Instance;
    public void _0x530b1a51()
    {
        this._0xc0a623fc?.Kill();
        this.AnimationSlider.value = _0xdb35e481 ? this.SecondPassSliderValue : 0.05f;
    }

    public float DefaultAnimationTime = 0.4f;
    public float SecondPassSliderValue = 0.5f;
    public void _0xc09f38b5()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xc0a623fc?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xdb35e481 = false;
    }

    public GameObject Error;
}