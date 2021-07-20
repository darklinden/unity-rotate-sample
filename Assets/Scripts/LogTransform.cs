using UnityEngine;

public class LogTransform : MonoBehaviour
{
    public void Log()
    {
        Debug.Log("localPosition" + transform.localPosition);
        Debug.Log("localRotation" + transform.localRotation);
        Debug.Log("position" + transform.position);
        Debug.Log("rotation" + transform.rotation);
    }
}
