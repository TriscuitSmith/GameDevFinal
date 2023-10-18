using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostilePortalHandler : MonoBehaviour
{

    public GameObject hostileUnit;

    // Start is called before the first frame update
    void Start()
    {
        spawnHostilesHandler();
    }

    void spawnHostilesHandler()
    {
        StartCoroutine(spawnHostiles());
        IEnumerator spawnHostiles()
        {
            yield return new WaitForSeconds(6);
            while (true)
            {
                Instantiate(hostileUnit, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>();
                yield return new WaitForSeconds(1);

            }
            yield return null;
        }
    }
}
