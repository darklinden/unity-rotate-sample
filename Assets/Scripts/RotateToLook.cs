using UnityEngine;

public class RotateToLook : MonoBehaviour
{

    public Transform normalUp;
    public Transform planeUp;
    public Transform normalBack;
    public Transform lookTo;
    public Transform wtf;

    public void Look()
    {
        wtf.position = GetIntersectWithLineAndPlane(normalBack.position, lookTo.position - normalBack.position, normalUp.position, Vector3.zero);

        // ————————————————
        // 版权声明：本文为CSDN博主「iwgd1」的原创文章，遵循CC 4.0 BY - SA版权协议，转载请附上原文出处链接及本声明。
        // 原文链接：https://blog.csdn.net/u011711053/article/details/71057162
        float angle = Vector3.Angle(planeUp.position, wtf.position); //求出两向量之间的夹角
        Vector3 normal = Vector3.Cross(planeUp.position, wtf.position);//叉乘求出法线向量
        angle *= Mathf.Sign(Vector3.Dot(normal, normalUp.position));  // 求法线向量与物体上方向向量点乘，结果为1或-1，修正旋转方向

        transform.localRotation = Quaternion.Euler(0, angle, 0);

        Debug.Log(angle);
    }

    /// <summary>
    /// 计算直线与平面的交点
    /// </summary>
    /// <param name="point">直线上某一点</param>
    /// <param name="direct">直线的方向</param>
    /// <param name="planeNormal">垂直于平面的的向量</param>
    /// <param name="planePoint">平面上的任意一点</param>
    /// <returns></returns>
    private Vector3 GetIntersectWithLineAndPlane(Vector3 point, Vector3 direct, Vector3 planeNormal, Vector3 planePoint)
    {
        float d = Vector3.Dot(planePoint - point, planeNormal) / Vector3.Dot(direct.normalized, planeNormal);
        return d * direct.normalized + point;
    }
}
