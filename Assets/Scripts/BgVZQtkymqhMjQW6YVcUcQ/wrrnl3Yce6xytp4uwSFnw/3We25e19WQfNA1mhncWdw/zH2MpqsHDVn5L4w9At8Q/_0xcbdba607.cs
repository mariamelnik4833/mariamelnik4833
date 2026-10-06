using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xcbdba607 : MonoBehaviour
{
    public Button Button;
    public int LoadSceneId;
    public bool IsLoadCurrentScene;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x86c44cb0.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x86c44cb0.Instance.LoadSceneByIndex(this.LoadSceneId));
    }
}