using UnityEngine;

public static class HelperUtilities
{
    public static Camera mainCamera;

    public static Vector3 GetMouseWorldPosition()
    {
        if ( mainCamera == null )
            mainCamera = Camera.main;

        Vector3 mousePosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mousePosition);

        Physics.Raycast(ray, out RaycastHit raycastHit);
        Vector3 position = raycastHit.point;
        return position;

    }
}
