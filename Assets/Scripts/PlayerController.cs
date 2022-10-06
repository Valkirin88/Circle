using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10.0f;
    private Vector2 _touchTransform;
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    do
        //    { transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), _speed * Time.deltaTime); }
        //    while (transform.position != Camera.main.ScreenToWorldPoint(Input.mousePosition));
        //}


        if (Input.touchCount > 0)
        {
            while (_touchTransform.position != transform.position)
            {
                transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position), _speed * Time.deltaTime);
            }
        }

    }
}

