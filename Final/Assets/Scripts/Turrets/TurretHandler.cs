using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretHandler : MonoBehaviour
{
    protected TurretState currState;

    [SerializeField] private GameObject laser;

    protected void Start()
    {
        UpdateState(new TargetLost());
    }

    public void UpdateState(TurretState nextState)
    {
        if(nextState != null)
        {
            nextState.ExitState();
        }
        this.currState = nextState;
        nextState.EnterState(this);
        

    }

    private void OnTriggerEnter(Collider other)
    {
            currState.OnTriggerEnter(other);
    }

    private void OnTriggerExit(Collider other)
    {

    }

    public void Fire()
    {
        StartCoroutine(spawnLaser());
        IEnumerator spawnLaser()
        {
            yield return new WaitForSeconds(2);
            yield return null;

            GetComponent<AudioSource>().Play();
            Instantiate(laser, transform.position, Quaternion.identity);
        }
    }
}