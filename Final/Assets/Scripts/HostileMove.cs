using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostileMove : MonoBehaviour
{

    Rigidbody rig;
    
    // Start is called before the first frame update
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Start()
    {
        rig.velocity = new Vector3(0, 0, 5);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FriendlyPortal"))
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("Projectile"))
        {
            Destroy(this.gameObject);
        }
    }
}
