using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xf0aef9e7 : MonoBehaviour
{
    private void Update()
    {
        this._0xf457878a();
    }

    private Image _0x396c7fda;
    private void _0xf457878a()
    {
        if (this._0x396c7fda.canvasRenderer.GetColor() != this._0x459bd0de.canvasRenderer.GetColor())
            this._0x459bd0de.canvasRenderer.SetColor(this._0x396c7fda.canvasRenderer.GetColor());
    }

    private TMP_Text _0x459bd0de;
}