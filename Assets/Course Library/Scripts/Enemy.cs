using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public float height = 1f;
    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector3 (startPos.x, newY, startPos.z);
    }
}
