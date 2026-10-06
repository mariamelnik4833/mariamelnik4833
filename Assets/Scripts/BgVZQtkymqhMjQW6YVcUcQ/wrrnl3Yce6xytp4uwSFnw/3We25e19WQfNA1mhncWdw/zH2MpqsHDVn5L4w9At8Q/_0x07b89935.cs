using UnityEngine;
using UnityEngine.UI;

public class _0x07b89935 : MonoBehaviour
{
    public Button Button;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x86c44cb0.Instance._0x0f428578(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}