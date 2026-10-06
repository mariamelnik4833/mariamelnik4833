using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x53431849;

public class _0x09adb88e : MonoBehaviour
{
    private _0x89b23978 _0x39409d02(int _0x2a81682f)
    {
        return this.Panels[_0x2a81682f];
    }

    public void _0x46599954(int _0x0da8d021)
    {
        if (_0x0da8d021 == _0xfa200dc8.SPLASH && _0x86c44cb0.Instance._0x3dfdd075 != _0x7146dbc1.SCENE_0)
            _0xab64f467.Instance._0x3421e090();
        if (_0x86c44cb0.Instance._0x3dfdd075 != _0x7146dbc1.SCENE_0)
        {
            if (_0x0da8d021 == _0xfa200dc8.SPLASH || _0x0da8d021 == _0xfa200dc8.TUTORIAL0)
                _0x86c44cb0.Instance._0x0f428578(false);
            else if (_0x0da8d021 == _0xfa200dc8.DEFAULT)
                _0x86c44cb0.Instance._0x0f428578(true);
        }
    }

    private void _0x887be341(int _0x054bfe67)
    {
        if (_0x054bfe67 == _0xfa200dc8.SPLASH)
            _0xab64f467.Instance._0x530b1a51();
        if (_0x86c44cb0.Instance._0x3dfdd075 == _0x7146dbc1.SCENE_0)
        {
        }
    }

    private void _0x4d85b19b(int _0x4fc927d4)
    {
        this.LastPanelIndexes.Add(_0x4fc927d4);
        this.CurrentPanelIndex = _0x4fc927d4;
        for (int _0x64fc15b3 = 0; _0x64fc15b3 < this.Panels.Count; _0x64fc15b3++)
            if (_0x64fc15b3 != _0x4fc927d4 && this.Panels[_0x64fc15b3] != null)
                this.Panels[_0x64fc15b3]._0xe70339f1();
    }

    private void _0x4b29036b()
    {
        this._0x9f368bc2(_0xfa200dc8.SPLASH);
        if (_0x86c44cb0.Instance._0x3dfdd075 == _0x7146dbc1.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0xab64f467.Instance.DefaultAnimationTime);
        }
    }

    public List<_0x89b23978> Panels;
    private void Start()
    {
        this._0x4b29036b();
    }

    public float ScaleDuration = 0.4f;
    public float StaticBlurMaterialInitialValue;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0x3773f5ef(int _0x990ecba5)
    {
        this.LastPanelIndexes.Add(_0x990ecba5);
        this.CurrentPanelIndex = _0x990ecba5;
        for (int _0x0a865d58 = 0; _0x0a865d58 < this.Panels.Count; _0x0a865d58++)
            if (_0x0a865d58 != _0x990ecba5 && this.Panels[_0x0a865d58] != null)
                this.Panels[_0x0a865d58]._0xe70339f1();
    }

    public bool IsShowSplashOnStart = true;
    private void _0x9f368bc2(int _0x5dab8208)
    {
        this._0x4d85b19b(_0x5dab8208);
        this._0x887be341(_0x5dab8208);
        this.CurrentPanelIndex = _0x5dab8208;
        this.Panels[_0x5dab8208]._0x5832e80f();
    }

    public int CurrentPanelIndex;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x09adb88e>();
    }

    public void _0xcf5f9304()
    {
        this.LastPanelIndexes.RemoveAll(_0x97738e8d => _0x97738e8d == this.CurrentPanelIndex);
        int _0x07eccf48 = this.LastPanelIndexes.Last();
        this._0x887be341(_0x07eccf48);
        this._0x3773f5ef(_0x07eccf48);
        this.CurrentPanelIndex = _0x07eccf48;
        this.Panels[_0x07eccf48].Show();
    }

    public void _0xa62f490f(int _0xb98b61d1)
    {
        this._0x4d85b19b(_0xb98b61d1);
        this._0x887be341(_0xb98b61d1);
        this.CurrentPanelIndex = _0xb98b61d1;
        this.Panels[_0xb98b61d1].Show();
    }

    private void SwitchSplash()
    {
        if (_0x612254d3.Instance.IsTutorialEnabled && !_0x86c44cb0._0x0ec6a2ac._0x3b876ea8)
            this._0xa62f490f(_0xfa200dc8.TUTORIAL0);
        else
            this._0xa62f490f(_0xfa200dc8.DEFAULT);
    }

    public static _0x09adb88e Instance;
}