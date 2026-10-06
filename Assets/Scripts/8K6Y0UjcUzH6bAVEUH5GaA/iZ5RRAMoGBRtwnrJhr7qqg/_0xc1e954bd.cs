using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0xc1e954bd : MonoBehaviour
{
    private float _0xe09fb146;
    private AspectRatioFitter _0xe97240c8;
    private float _0xd06f310c = 1.5f;
    private TMP_Text _0x5072ef5c;
    private float _0x0b74f4b7 = 0.6f;
    private float _0x4e052a7a = 4;
    private void Update()
    {
        int _0x17bdf091 = 1;
        if (this._0x283f2eda.Count > 0)
        {
            string _0x46c13cbb = this._0x5072ef5c.text;
            foreach (string _0xd53c0740 in this._0x283f2eda)
                while (_0x46c13cbb.Contains(_0xd53c0740))
                    _0x46c13cbb = _0x46c13cbb.Replace(_0xd53c0740, "");
            _0x17bdf091 = _0x46c13cbb.Length;
        }
        else
        {
            _0x17bdf091 = this._0x5072ef5c.text.Length;
        }

        float _0x67bb5b7e = Mathf.Clamp(this._0xe09fb146 + this._0x0b74f4b7 * _0x17bdf091, this._0xd06f310c, this._0x4e052a7a);
        if (!Mathf.Approximately(this._0xe97240c8.aspectRatio, _0x67bb5b7e))
            this._0xe97240c8.aspectRatio = _0x67bb5b7e;
    }

    private List<string> _0x283f2eda = new();
}