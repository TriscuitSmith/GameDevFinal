using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    [SerializeField] private GameObject laser;a

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Ray ray = Camera.main.ScreenPointToRay;
            GetComponent<AudioSource>().Play();
            Instantiate(laser, transform.position, Quaternion.identity);
        }
        
    }
}
