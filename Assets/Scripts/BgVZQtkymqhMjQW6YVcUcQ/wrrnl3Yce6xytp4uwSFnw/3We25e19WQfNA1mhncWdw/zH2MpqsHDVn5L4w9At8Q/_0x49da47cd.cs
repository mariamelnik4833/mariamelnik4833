using UnityEngine;
using UnityEngine.UI;

public class _0x49da47cd : MonoBehaviour
{
    private void Start()
    {
        if (this._0x1228c278)
            this._0x98aacb24.onClick.AddListener(() => _0x09adb88e.Instance._0xcf5f9304());
        else
            this._0x98aacb24.onClick.AddListener(() => _0x09adb88e.Instance._0xa62f490f(this._0x786272db));
    }

    private void Awake()
    {
        if (this._0x98aacb24 == null)
            if (!this.TryGetComponent(out this._0x98aacb24))
                this._0x98aacb24 = this.GetComponentInChildren<Button>();
    }

    private bool _0x1228c278;
    private Button _0x98aacb24;
    private int _0x786272db;
}