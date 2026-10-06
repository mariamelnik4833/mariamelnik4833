using UnityEngine;
using UnityEngine.UI;

public class _0xa1e0913d : MonoBehaviour
{
    public int PopToShowIndex;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsHideAllPops;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xf7dd1359.Instance._0xc378a9f3();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xf7dd1359.Instance._0xeb69e208());
        else
            this.Button.onClick.AddListener(() => _0xf7dd1359.Instance._0x1fad8604(this.PopToShowIndex));
    }

    public bool IsShowLastPop;
}