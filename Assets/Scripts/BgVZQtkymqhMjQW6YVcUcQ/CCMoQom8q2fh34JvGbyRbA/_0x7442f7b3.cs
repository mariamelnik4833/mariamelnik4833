using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x7442f7b3 : MonoBehaviour
{
    private bool _0x67e5dfd6(Touch? _0xa60d7e0a, Bounds _0xd51a2ed1, TouchPhase _0x5e476297)
    {
        if (!_0x86c44cb0.Instance._0xa5ca1bb0)
        {
            _0xa60d7e0a = null;
            return false;
        }

        if (_0xa60d7e0a != null)
            if (_0xa60d7e0a.Value.phase == _0x5e476297)
            {
                Vector3 _0xfe0db66d = Camera.main.ScreenToWorldPoint(_0xa60d7e0a.Value.screenPosition);
                Vector3 _0xf7afc5de = new(_0xfe0db66d.x, _0xfe0db66d.y, _0xd51a2ed1.center.z);
                if (_0xd51a2ed1.Contains(_0xf7afc5de) && this._0x90fb3387(_0xa60d7e0a.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0x2fe75f27(Bounds _0x280d75f2, TouchPhase _0x17c2324d)
    {
        if (!_0x86c44cb0.Instance._0xa5ca1bb0)
            return null;
        foreach (Touch _0xe6132fc3 in Touch.activeTouches)
            if (_0xe6132fc3.phase == _0x17c2324d)
            {
                Vector3 _0x8761adbb = Camera.main.ScreenToWorldPoint(_0xe6132fc3.screenPosition);
                Vector3 _0xdfaa7c15 = new(_0x8761adbb.x, _0x8761adbb.y, _0x280d75f2.center.z);
                if (_0x280d75f2.Contains(_0xdfaa7c15) && this._0x90fb3387(_0xe6132fc3))
                    return _0xe6132fc3;
            }

        return null;
    }

    private void _0x248f92b3(Touch? _0x359a51a2)
    {
        if (!_0x86c44cb0.Instance._0xa5ca1bb0)
        {
            _0x359a51a2 = null;
            return;
        }

        int _0x72846b92 = _0x359a51a2.Value.touchId;
        _0x359a51a2 = Touch.activeTouches.FirstOrDefault(_0x8c54c8fa => _0x8c54c8fa.touchId == _0x72846b92);
        if (!this._0x90fb3387(_0x359a51a2.Value))
            _0x359a51a2 = null;
    }

    private Touch? _0x76b2ef29(Bounds _0x594878de)
    {
        if (!_0x86c44cb0.Instance._0xa5ca1bb0)
            return null;
        foreach (Touch _0x5709971e in Touch.activeTouches)
            if (_0x5709971e.ended)
            {
                Vector3 _0x6aed230a = Camera.main.ScreenToWorldPoint(_0x5709971e.screenPosition);
                Vector3 _0xd665e302 = new(_0x6aed230a.x, _0x6aed230a.y, _0x594878de.center.z);
                if (_0x594878de.Contains(_0xd665e302) && this._0x90fb3387(_0x5709971e))
                    return _0x5709971e;
            }

        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private static _0x7442f7b3 _0x06beb9e6;
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x06beb9e6 = this.gameObject.GetComponent<_0x7442f7b3>();
    }

    private Touch? _0x06e38d1d()
    {
        if (!_0x86c44cb0.Instance._0xa5ca1bb0)
            return null;
        foreach (Touch _0x1cf30f8c in Touch.activeTouches)
            if (_0x1cf30f8c.ended)
                if (this._0x90fb3387(_0x1cf30f8c))
                    return _0x1cf30f8c;
        return null;
    }

    private Touch? _0xd66a4cd0(Bounds _0xa6fa5159)
    {
        if (!_0x86c44cb0.Instance._0xa5ca1bb0)
            return null;
        foreach (Touch _0xd86cbd1b in Touch.activeTouches)
            if (!_0xd86cbd1b.ended)
            {
                Vector3 _0x334bc3ab = Camera.main.ScreenToWorldPoint(_0xd86cbd1b.screenPosition);
                Vector3 _0x085ea023 = new(_0x334bc3ab.x, _0x334bc3ab.y, _0xa6fa5159.center.z);
                if (_0xa6fa5159.Contains(_0x085ea023) && this._0x90fb3387(_0xd86cbd1b))
                    return _0xd86cbd1b;
            }

        return null;
    }

    private Touch? _0x24a96783()
    {
        if (!_0x86c44cb0.Instance._0xa5ca1bb0)
            return null;
        foreach (Touch _0x969d7dc6 in Touch.activeTouches)
            if (!_0x969d7dc6.ended)
                if (this._0x90fb3387(_0x969d7dc6))
                    return _0x969d7dc6;
        return null;
    }

    private bool _0x90fb3387(Touch? _0xb75f6627)
    {
        if (!_0xb75f6627.HasValue)
            return false;
        Vector3 _0x62236400 = Camera.main.ScreenToWorldPoint(_0xb75f6627.Value.screenPosition);
        Vector3 _0x50166004 = _0x62236400;
        _0x50166004.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x50166004))
            return true;
        _0xb75f6627 = null;
        return false;
    }
}