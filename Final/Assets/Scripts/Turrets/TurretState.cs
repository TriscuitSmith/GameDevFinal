using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TurretState
{
    protected TurretHandler parent;

    public virtual void EnterState(TurretHandler parent)
    {
        this.parent = parent;
    }

    public virtual void ExitState()
    {
        
    }
    public virtual void OnTriggerEnter(Collider other)
    {
        
    }
}
