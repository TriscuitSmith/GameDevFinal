using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            Destroy(this.gameObject);
            SceneManager.LoadScene("LossScreen");
        }
        if (other.gameObject.CompareTag("Projectile"))
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("Player"))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            Destroy(this.gameObject);
            SceneManager.LoadScene("LossScreen");
        }
    }
}
