using UnityEngine;

[RequireComponent(typeof(RotateByScreen))]
public class RotateByScreenTest : MonoBehaviour
{
    public RotateByScreen rbs = null;

    private Vector3? rbsSp = null;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var screenPos = Input.mousePosition;
            if (rbsSp == null)
            {
                rbsSp = Camera.main.WorldToScreenPoint(rbs.transform.position);
            }

            rbs.Rotate(screenPos - rbsSp.Value);
        }
    }
}
