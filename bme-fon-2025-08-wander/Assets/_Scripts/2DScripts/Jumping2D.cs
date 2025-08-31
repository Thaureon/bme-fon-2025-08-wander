using UnityEngine;

public class Jumping2D : MonoBehaviour
{
    public float JumpStrength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForceY(JumpStrength * 100);
        }
    }
}
