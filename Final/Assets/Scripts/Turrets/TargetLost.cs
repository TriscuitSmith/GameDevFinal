using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLost : TurretState
{
    [SerializeField] private bool setFlag = false;

    public override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            setFlag= true;
        }


        if (other.CompareTag("Hostile") && setFlag == true)
        {
            //Debug.Log("Fire!");
            //GetComponent<AudioSource>().Play();
            //Instantiate(laser, transform.position, Quaternion.identity);
            parent.Fire();
            
            //parent.UpdateState(new TargetFound());
        }
    }
}
