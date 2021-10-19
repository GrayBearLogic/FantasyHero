using UnityEngine;

public class RotateToCursor : MonoBehaviour
{
    public float ignoreRadius = 0.2f;
    private void LateUpdate()
    {
        var mouse = Input.mousePosition;
        var mouseRay = Camera.main.ScreenPointToRay(new Vector3(mouse.x, mouse.y, 0));
        var plane = new Plane(Vector3.up, Vector3.zero);

        if (plane.Raycast(mouseRay, out var entry))
        {
            var point = mouseRay.GetPoint(entry);
            if(Vector3.Distance(transform.position, point) > ignoreRadius)
                transform.LookAt( point, Vector3.up );      
        }      
    }
}
