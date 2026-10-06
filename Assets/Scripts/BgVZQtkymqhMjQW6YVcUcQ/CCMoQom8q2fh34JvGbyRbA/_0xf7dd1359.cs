using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x53431849;

public class _0xf7dd1359 : MonoBehaviour
{
    public List<GameObject> GameObjectsToHide;
    public int CurrentPopIndex;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x44a03f11 _0xfcae4fed in this.Pops)
            if (_0xfcae4fed != null)
                _0xfcae4fed.gameObject.SetActive(true);
    }

    private void _0x08284678()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public float ScaleDuration = 0.4f;
    public _0x44a03f11 _0x8a941bbf(int _0xf978022f)
    {
        return this.Pops[_0xf978022f];
    }

    public void _0xc378a9f3()
    {
        this.LastPopIndexes.RemoveAll(_0x97738e8d => _0x97738e8d == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xeb69e208();
        else
            this._0x1fad8604(this.LastPopIndexes.Last());
    }

    private void _0x0fbf813a()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public void _0x1fad8604(int _0x9bb125f5)
    {
        this.CurrentPopIndex = _0x9bb125f5;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xcc61920a(true);
        this._0x08284678();
        this.Pops[_0x9bb125f5].Show();
        foreach (GameObject _0x45819395 in this.GameObjectsToHide)
            _0x45819395.SetActive(false);
    }

    public static _0xf7dd1359 Instance;
    public void _0xeb69e208()
    {
        this.LastPopIndexes.Clear();
        this._0xcc61920a();
        foreach (GameObject _0xee4935e9 in this.GameObjectsToHide)
            if (_0xee4935e9 != null)
                _0xee4935e9.SetActive(true);
        this._0x0fbf813a();
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public GameObject BlurBackground;
    public List<_0x44a03f11> Pops;
    private void _0xcc61920a(bool _0xb53691ab = false)
    {
        for (int _0xb54e42d6 = 0; _0xb54e42d6 < this.Pops.Count; ++_0xb54e42d6)
            if (this.Pops[_0xb54e42d6] != null && !(_0xb54e42d6 == this.CurrentPopIndex && _0xb53691ab))
                this.Pops[_0xb54e42d6]._0xd89565a8();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xf7dd1359>();
    }

    public List<int> LastPopIndexes = new();
}