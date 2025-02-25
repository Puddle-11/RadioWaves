using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField] private float zDepth;
    private void Update()
    {
        transform.position = MouseWorldPosition();
        Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDepth);
        GetComponent<SpriteRenderer>().color = new Color(screenPos.x/(float)Screen.width, screenPos.y / (float)Screen.height, 1,0.5f);
    }
    public Vector3 MouseWorldPosition()
    {
        Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDepth);

        return Camera.main.ScreenToWorldPoint(screenPos);

    }
}
