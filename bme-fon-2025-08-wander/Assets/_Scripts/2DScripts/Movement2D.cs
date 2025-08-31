using UnityEngine;

namespace Assets._Scripts
{
    public class Movement2D : MonoBehaviour
    {
        public float Speed = 10;
        public float CurrentSpeed = 0;
        public float Acceleration = 0.2f;
        public float MovingSpeed = 0;

        private Rigidbody2D rb;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            rb.freezeRotation = true;
        }

        // Update is called once per frame
        void Update()
        {
            var direction = Input.GetAxis("Horizontal");

            rb.position += new Vector2(Speed * direction, 0) * Time.deltaTime;
        }
    }
}
