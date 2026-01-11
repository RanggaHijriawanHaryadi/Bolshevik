using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject player;
    private float minx = -4.24f;
    private float maxx = 4.15f;
    private float miny = -2.72f;
    private float maxy = 1.71f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float clampedX = Mathf.Clamp(player.transform.position.x, minx, maxx);
        float clampedY = Mathf.Clamp(player.transform.position.y, miny, maxy);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}
