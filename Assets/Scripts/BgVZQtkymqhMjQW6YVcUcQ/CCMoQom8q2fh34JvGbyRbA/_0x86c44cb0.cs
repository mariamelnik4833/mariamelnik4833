using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x53431849;

public class _0x86c44cb0 : MonoBehaviour
{
    public void _0x60f3b779()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    public int _0x3dfdd075 => SceneManager.GetActiveScene().buildIndex;

    public Transform Environment;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x86c44cb0>();
        this.RootGameObject = GameObject.FindWithTag(_0x1c156909._0x9c15cdf1(new byte[4] { 206, 243, 243, 232 }, 156));
        if (this._0x3dfdd075 == _0x7146dbc1.SCENE_0)
            this._0x0f428578(true);
        else
            this._0x0f428578(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x10f40c37>(true).ToList();
    }

    public void _0x0f428578(bool _0x32e207c1)
    {
        this._0xa5ca1bb0 = _0x32e207c1;
        this._0x3557fe9b(!this._0xa5ca1bb0);
        Physics2D.simulationMode = this._0xa5ca1bb0 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x71417f4a(this.EnvironmentWithTweensToToggle);
    }

    public void _0x05c3da47()
    {
        _0x0ec6a2ac._0x3b876ea8 = true;
    }

    private void _0x3c75df7a()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0x7146dbc1.SCENE_0);
    }

    private IEnumerator _0xa2a90bac(int _0x71b6eaf4)
    {
        _0x09adb88e.Instance._0xa62f490f(_0xfa200dc8.SPLASH);
        AsyncOperation _0x84b64bf3 = SceneManager.LoadSceneAsync(_0x71b6eaf4);
        while (!_0x84b64bf3.isDone)
            yield return null;
    }

    [HideInInspector]
    public List<_0x10f40c37> MoneyCountContainers = new();
    public static bool IsAfterLevelComplete;
    public bool _0xa5ca1bb0 { get; private set; }

    public void LoadSceneByIndex(int _0xa6542b19)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xa2a90bac(_0xa6542b19));
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private static void ExitGame()
    {
        Application.Quit();
    }

    public Button DeleteProgressDataButton;
    private void _0x71417f4a(Transform _0x4698d65e)
    {
        Transform[] _0xca70d1ee = _0x4698d65e.GetComponentsInChildren<Transform>();
        foreach (Transform _0x9ebb92a3 in _0xca70d1ee)
            if (_0x9ebb92a3 != null && DOTween.IsTweening(_0x9ebb92a3))
            {
                if (this._0xa5ca1bb0)
                    DOTween.Play(_0x9ebb92a3);
                else
                    DOTween.Pause(_0x9ebb92a3);
            }
    }

    private void Start()
    {
        if (this._0x3dfdd075 != _0x7146dbc1.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0x7146dbc1.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x0ec6a2ac._0x3b876ea8 = false;
            _0xf7dd1359.Instance._0xeb69e208();
            _0x09adb88e.Instance._0xa62f490f(_0xfa200dc8.TUTORIAL0);
        });
    }

    public static _0xe77d69ac _0x0ec6a2ac => _0xe77d69ac.ALL_SCENES_SETTING_SINGLETONS[Instance._0x3dfdd075];

    private IEnumerator _0x2d474f7b(string _0x350f4a5a)
    {
        _0x09adb88e.Instance._0xa62f490f(_0xfa200dc8.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0xb0fe927c = SceneManager.LoadSceneAsync(_0x350f4a5a);
        while (!_0xb0fe927c.isDone)
            yield return null;
    }

    private static _0xe77d69ac _0x317f8402 => _0xe77d69ac.ALL_SCENES_SETTING_SINGLETONS[0];

    public Button ShowResetTutorialButton;
    public Canvas MainCanvas;
    public static _0x86c44cb0 Instance;
    private void _0x3557fe9b(bool _0x448c5946)
    {
        Rigidbody2D[] _0x790095c0 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xe123d3bc in _0x790095c0)
            if (_0x448c5946)
                _0xe123d3bc.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xe123d3bc.constraints = RigidbodyConstraints2D.None;
    }

    public static bool IsAfterLevelFailed = false;
    public void _0x127cf751()
    {
        foreach (_0x10f40c37 _0x5d1c987b in this.MoneyCountContainers)
            _0x5d1c987b._0x8610e81f();
    }

    private static _0xe77d69ac GAME_INDEX_SETTINGS(int _0x3de9b337)
    {
        return _0xe77d69ac.ALL_SCENES_SETTING_SINGLETONS[_0x3de9b337];
    }

    private static void MakeGrid(List<RectTransform> _0xb4ff0a18, AspectRatioFitter _0xc10edd72, float _0x3bf4ccdb, int _0x94b04e34, int _0xf533a230)
    {
        _0xc10edd72.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0xc10edd72.aspectRatio = _0x3bf4ccdb;
        foreach (RectTransform _0xa89801c0 in _0xb4ff0a18)
        {
            int _0x08282c88 = _0xa89801c0.transform.GetSiblingIndex();
            _0xa89801c0.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x08282c88 % _0x94b04e34) * (1f / _0x94b04e34), (_0xf533a230 - (Mathf.FloorToInt((float)_0x08282c88 / _0x94b04e34) % _0xf533a230 + 1f)) * (1f / _0xf533a230));
            _0xa89801c0.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x08282c88 % _0x94b04e34 + 1f) * (1f / _0x94b04e34), (_0xf533a230 - Mathf.FloorToInt((float)_0x08282c88 / _0x94b04e34) % _0xf533a230) * (1f / _0xf533a230));
            _0xa89801c0.offsetMin = Vector2.zero;
            _0xa89801c0.offsetMax = Vector2.zero;
        }
    }

    public Transform EnvironmentWithTweensToToggle;
}

internal static class _0x1c156909
{
    internal static string _0x9c15cdf1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}