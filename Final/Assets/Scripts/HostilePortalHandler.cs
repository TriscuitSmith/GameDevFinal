using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HostilePortalHandler : MonoBehaviour
{

    public GameObject hostileUnit;
    private bool roundStart;
    private bool gameWon;
    private int counter;

    void Start()
    {
        this.roundStart = false;
        this.counter = 0;
        this.gameWon = false;
    }

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKey(KeyCode.Return) && roundStart == false)
        {
            spawnHostilesHandler();
            roundStart = true;
        }
        else if (gameWon == true)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            SceneManager.LoadScene("WinScreen");
        }
    }

    void spawnHostilesHandler()
    {
        StartCoroutine(spawnHostiles());
        IEnumerator spawnHostiles()
        {
            yield return new WaitForSeconds(3);
            while (true)
            {
                if (counter == 15)
                {
                    yield return new WaitForSeconds(5);
                    gameWon = true;
                    break;
                }
                if(counter < 15)
                {
                    counter++;
                    Instantiate(hostileUnit, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>();
                    yield return new WaitForSeconds(1);
                }

            }
            yield return null;
        }
    }
}
