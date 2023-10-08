using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementHandler : MonoBehaviour
{

    [SerializeField] float speed = 4;
    [SerializeField] float sprint = 8;
    public GameObject player;
    private Vector3 center;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))//temp change the speed while the left shift is held down
        {
            speed = sprint;
        }
        else
        {
            speed = 2;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(2 * (speed * Time.deltaTime), 0, 0);
        }
        if (Input.GetKey(KeyCode.A)) // might want the ability to roam further on the map
        {
            transform.position -= new Vector3(2 * (speed * Time.deltaTime), 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 2 * (speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, 2 * (speed * Time.deltaTime));
        }


        
        //if (true)
        //{
        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        transform.RotateAround(player.transform.position, Vector3.up, pos.x);
        transform.RotateAround(player.transform.position, Vector3.right, -pos.y);

        //}
    }

    void getInput()
    {


    }

}