using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMove : MonoBehaviour
{
    [SerializeField] private float speed = 30;

    public Vector3 Direction
    {
        get; set;
    }

    Rigidbody rig;

    // Start is called before the first frame update
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //transform.Translate(Direction*speed*Time.deltaTime, Space.World);
        rig.velocity = new Vector3(-speed, 0, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hostile"))
        {
            Destroy(this.gameObject);
        }
    }
}
