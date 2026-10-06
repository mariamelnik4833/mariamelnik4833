using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x9198d0cd : MonoBehaviour
{
    //public bool executeInUpdate;
    private float _0x22b8dfbe { get; set; }

    private _0x585884cf _0x9ff11227 = _0x585884cf.Portrait;
    private Vector3 _0x4563dcb9 { get; set; }
    private float _0xd462f668 { get; set; }
    private Vector3 _0x9016a8fa { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x1a531d40;
        Matrix4x4 _0x3cf354b8 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xef004b38.orthographic)
        {
            float _0x96ce19b9 = this._0xef004b38.farClipPlane - this._0xef004b38.nearClipPlane;
            float _0x571b03c7 = (this._0xef004b38.farClipPlane + this._0xef004b38.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x571b03c7), new Vector3(this._0xef004b38.orthographicSize * 2 * this._0xef004b38.aspect, this._0xef004b38.orthographicSize * 2, _0x96ce19b9));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xef004b38.fieldOfView, this._0xef004b38.farClipPlane, this._0xef004b38.nearClipPlane, this._0xef004b38.aspect);
        }

        Gizmos.matrix = _0x3cf354b8;
    }

    private Vector3 _0xcf4eb7ac { get; set; }

    private static _0x9198d0cd _0x2586dff8;
    private Color _0x1a531d40 = Color.white;
    private Vector3 _0xd2c29e25 { get; set; }

    private void Awake()
    {
        this._0xef004b38 = this.GetComponent<Camera>();
        _0x2586dff8 = this;
        this._0x64989baf();
    }

    private Vector3 _0xe9d06450 { get; set; }

    private float _0xab6b270c = 1;
    private Vector3 _0x195da514 { get; set; }
    private Vector3 _0x7fce1e07 { get; set; }

    public enum _0x585884cf
    {
        Landscape,
        Portrait
    }

    private new Camera _0xef004b38;
    private Vector3 _0xa3573b52 { get; set; }

    private void _0x64989baf()
    {
        float _0xbba7df1f, _0xfb92e866, _0x65cbca8a, _0xa16a4e87;
        if (this._0x9ff11227 == _0x585884cf.Landscape)
            this._0xef004b38.orthographicSize = 1f / this._0xef004b38.aspect * this._0xab6b270c / 2f;
        else
            this._0xef004b38.orthographicSize = this._0xab6b270c / 2f;
        this._0xd462f668 = 2f * this._0xef004b38.orthographicSize;
        this._0x22b8dfbe = this._0xd462f668 * this._0xef004b38.aspect;
        float _0x56c08d40 = this._0xef004b38.transform.position.x;
        float _0xfb5f3447 = this._0xef004b38.transform.position.y;
        _0xbba7df1f = _0x56c08d40 - this._0x22b8dfbe / 2;
        _0xfb92e866 = _0x56c08d40 + this._0x22b8dfbe / 2;
        _0x65cbca8a = _0xfb5f3447 + this._0xd462f668 / 2;
        _0xa16a4e87 = _0xfb5f3447 - this._0xd462f668 / 2;
        this._0xcf4eb7ac = new Vector3(_0xbba7df1f, _0xa16a4e87, 0);
        this._0xe9d06450 = new Vector3(_0x56c08d40, _0xa16a4e87, 0);
        this._0xa3573b52 = new Vector3(_0xfb92e866, _0xa16a4e87, 0);
        this._0x4563dcb9 = new Vector3(_0xbba7df1f, _0xfb5f3447, 0);
        this._0xd2c29e25 = new Vector3(_0x56c08d40, _0xfb5f3447, 0);
        this._0x195da514 = new Vector3(_0xfb92e866, _0xfb5f3447, 0);
        this._0x9016a8fa = new Vector3(_0xbba7df1f, _0x65cbca8a, 0);
        this._0x3b2fa18b = new Vector3(_0x56c08d40, _0x65cbca8a, 0);
        this._0x7fce1e07 = new Vector3(_0xfb92e866, _0x65cbca8a, 0);
    }

    private Vector3 _0x3b2fa18b { get; set; }
}