using UnityEngine;
using UnityEngine.UI;

public class _0x394c184b : MonoBehaviour
{
    public Button TutorialEndButton;
    public int EndTutorialPanelIndex = 1;
    public int NextTutorialPanelIndex;
    public Button NextTutorialButton;
    public bool IsTutorialEndPanel;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x09adb88e.Instance._0xa62f490f(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x86c44cb0.Instance._0x05c3da47());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x09adb88e.Instance._0xa62f490f(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x09adb88e.Instance._0xa62f490f(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x86c44cb0.Instance._0x05c3da47());
        }
    }
}