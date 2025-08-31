using UnityEngine;

public class Movement3D : MonoBehaviour
{
    public float Speed = 10;
    public float TurnSpeed = 5;

    private Vector3 _forward;

    private Rigidbody _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        _forward = gameObject.transform.forward.normalized;

        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        _rb.position += _forward * Speed * vertical * Time.deltaTime;

        if (horizontal != 0) 
        {
            transform.Rotate(new Vector3(0, horizontal * TurnSpeed * Time.deltaTime, 0));
        }
    }
}
