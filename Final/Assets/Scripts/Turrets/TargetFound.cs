using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFound : TurretState
{
    public override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hostile"))
        {
            Debug.Log("Lost!");
            
        }
    }
}
