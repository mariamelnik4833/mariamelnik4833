using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xfe069ad9 : MonoBehaviour
{
    private int _0xe90a0c92 => this.CustomTargetScore + _0x86c44cb0._0x0ec6a2ac._0xf4b85fde * 10;

    public List<TMP_Text> TimerText = new();
    private void _0x4120b79c()
    {
        if (this.ScoreCurrent >= this._0xe90a0c92)
            this._0xc1fceb8e();
        else
            this._0x589976b4();
    }

    public int CustomTargetScore = 10;
    private IEnumerator _0x65e6c619()
    {
        this._0x4ab4435b();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x86c44cb0.Instance._0x3dfdd075 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x86c44cb0.Instance._0xa5ca1bb0)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x4ab4435b();
            }
        }

        if (!this.IsGameEnd)
            this._0x589976b4();
    }

    [HideInInspector]
    public int TimeLeft;
    private static _0xfe069ad9 _0xdb054b8c;
    private int _0x3ed1aa8f => this.CustomTimeInitial + _0x86c44cb0._0x0ec6a2ac._0xf4b85fde * 10;

    public int CustomTimeInitial = 30;
    [HideInInspector]
    public bool IsGameEnd;
    private void _0xaeee1c9c()
    {
        this.IsGameEnd = true;
        _0x86c44cb0.IsAfterLevelComplete = true;
    }

    public List<TMP_Text> LevelNumberText = new();
    private int _0x91ed05a9 => this.ScoreCurrent;

    public List<TMP_Text> SubtitleText = new();
    public List<Button> PauseButtons = new();
    public void _0x39fda2dc(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x01032449();
            this._0x143eda67();
        }
    }

    [HideInInspector]
    public int CurrentGameIndex;
    public void _0xc1fceb8e()
    {
        if (!this.IsGameEnd)
        {
            this._0xaeee1c9c();
            _0x86c44cb0.IsAfterLevelComplete = true;
            _0x86c44cb0.IsAfterLevelFailed = false;
            _0x44a03f11 _0x938625df = _0xf7dd1359.Instance._0x8a941bbf(_0x53431849._0x0733d9ad.WIN).GetComponent<_0x44a03f11>();
            if (_0x612254d3.Instance.IsCheckScoreEnabled)
                _0x938625df.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xe90a0c92}";
            else
                _0x938625df.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x612254d3.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x53431849._0xc5e03009._0xc95d7db8)
                    _0x53431849._0xc5e03009._0xc95d7db8 = this.ScoreCurrent;
                _0x938625df.ContentAdditionalText.text = $"{_0x53431849._0xc5e03009._0xc95d7db8}";
            }
            else
            {
                _0x938625df.ContentAdditionalText.text = $"{this._0x91ed05a9}";
                _0x53431849._0xc5e03009._0xc95d7db8 += this._0x91ed05a9;
            }

            if (_0x612254d3.Instance.IsLevelIncrementOnWin)
                ++_0x86c44cb0._0x0ec6a2ac._0xf4b85fde;
            _0xf7dd1359.Instance._0x1fad8604(_0x53431849._0x0733d9ad.WIN);
        }
    }

    [HideInInspector]
    public int ScoreCurrent;
    private void _0x143eda67()
    {
        if (this.ScoreCurrent > _0x86c44cb0._0x0ec6a2ac._0x5a4063e1)
            _0x86c44cb0._0x0ec6a2ac._0x5a4063e1 = this.ScoreCurrent;
        if (_0x612254d3.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xe90a0c92)
                this._0xc1fceb8e();
    }

    private void _0x01032449()
    {
        if (_0x612254d3.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x14a544be => _0x14a544be.text = $"{this.ScoreCurrent}/{this._0xe90a0c92}");
        else
            this.ScoreText.ForEach(_0x14a544be => _0x14a544be.text = $"{this.ScoreCurrent}");
    }

    private void _0x4ab4435b()
    {
        this.TimerText.ForEach(_0x14a544be => _0x14a544be.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x8fd208a6._0xe06ef9ad(new byte[6] { 130, 130, 179, 213, 156, 156 }, 239)));
    }

    public List<TMP_Text> ScoreText = new();
    public void _0x589976b4()
    {
        if (_0x612254d3.Instance.IsOnlyWinGameEndEnabled)
            this._0xc1fceb8e();
        if (!this.IsGameEnd)
        {
            this._0xaeee1c9c();
            _0x86c44cb0.IsAfterLevelComplete = false;
            _0x86c44cb0.IsAfterLevelFailed = true;
            _0x44a03f11 _0x25c7a152 = _0xf7dd1359.Instance._0x8a941bbf(_0x53431849._0x0733d9ad.LOSE).GetComponent<_0x44a03f11>();
            if (_0x612254d3.Instance.IsCheckScoreEnabled)
                _0x25c7a152.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xe90a0c92}";
            else
                _0x25c7a152.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x25c7a152.ContentAdditionalText.text = $"{0}";
            _0x53431849._0xc5e03009._0xc95d7db8 += 0;
            _0xf7dd1359.Instance._0x1fad8604(_0x53431849._0x0733d9ad.LOSE);
        }
    }

    public void _0x88ded14c()
    {
        _0x86c44cb0.Instance._0x0f428578(true);
        _0x86c44cb0.Instance.LoadSceneByIndex(_0x53431849._0x7146dbc1.SCENE_0);
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x3ed1aa8f;
        this.CurrentGameIndex = _0x86c44cb0.Instance._0x3dfdd075;
        foreach (Button _0x76724d2b in this.HomeButtons)
            _0x76724d2b.onClick.AddListener(() =>
            {
                this._0x88ded14c();
            });
        foreach (Button _0x194def41 in this.PauseButtons)
            _0x194def41.onClick.AddListener(() =>
            {
                _0x86c44cb0.Instance._0x0f428578(false);
                _0xf7dd1359.Instance._0x1fad8604(_0x53431849._0x0733d9ad.PAUSE);
            });
        this._0x01032449();
        this.LevelNumberText.ForEach(_0x14a544be => _0x14a544be.text = $"LVL {_0x86c44cb0._0x0ec6a2ac._0xf4b85fde + 1}");
        if (_0x612254d3.Instance.IsTimerEnabled)
        {
            this._0x4ab4435b();
            this.StartCoroutine(this._0x65e6c619());
        }
    }

    private void Awake()
    {
        _0xdb054b8c = this.gameObject.GetComponent<_0xfe069ad9>();
    }

    public List<Button> HomeButtons = new();
}

internal static class _0x8fd208a6
{
    internal static string _0xe06ef9ad(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}