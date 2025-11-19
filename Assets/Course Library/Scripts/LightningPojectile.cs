using UnityEngine;

public class LightningPojectile : MonoBehaviour
{
    public float speed = 40.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void Initialize(Transform target)
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {

    }
}

    
