using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    [SerializeField] float mouseSpeed = 2;
    private Vector3 center;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (true)
        {
            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - center);

            transform.RotateAround(transform.position, transform.right, -pos.y * mouseSpeed);
            transform.RotateAround(transform.position, Vector3.up, pos.x * mouseSpeed);
        }
    }
}
