using Assets._Scripts;

using UnityEngine;

public class Crouching2D : MonoBehaviour
{
    public bool Crouching = false;

    private Movement2D _movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _movement = GetComponent<Movement2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Crouching = true;

            _movement.Speed /= 2;
            var currentScale = gameObject.transform.localScale;
            gameObject.transform.localScale = new Vector3(currentScale.x, currentScale.y / 2, currentScale.z);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Crouching = false;

            _movement.Speed *= 2;
            var currentScale = gameObject.transform.localScale;
            gameObject.transform.localScale = new Vector3(currentScale.x, currentScale.y * 2, currentScale.z);
        }
    }
}
