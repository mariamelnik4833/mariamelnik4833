using TMPro;
using UnityEngine;
using static _0x53431849;

public class _0x10f40c37 : MonoBehaviour
{
    public void _0x8610e81f()
    {
        this.MoneyCountText.text = _0xc5e03009._0xc95d7db8.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xed38904c;
            if (this.gameObject.TryGetComponent(out _0xed38904c))
                this.MoneyCountText = _0xed38904c;
        }

        this._0x8610e81f();
    }

    public TMP_Text MoneyCountText;
}