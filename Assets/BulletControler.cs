using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletController : MonoBehaviour

{
    private Rigidbody rb;
    public float velocity;
    public Vector3 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=gameObject.GetComponent<Rigidbody>();
        rb.linearVelocity = new Vector3(0, 0, velocity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
