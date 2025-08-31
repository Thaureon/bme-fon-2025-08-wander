using UnityEngine;

public class Movement25D : MonoBehaviour
{
    public float Speed = 10;

    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        rb.position += new Vector3(Speed * horizontal, 0, Speed * vertical) * Time.deltaTime;

    }
}
