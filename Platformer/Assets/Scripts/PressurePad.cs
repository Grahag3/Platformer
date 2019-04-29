using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        {
            StartCoroutine(break_blocker());
            Sounds.play_sound("Press");
        }
    }

    IEnumerator break_blocker()
    {
        GameObject[] blockers = GameObject.FindGameObjectsWithTag("Blocker");

        foreach (var item in blockers) { 
        yield return new WaitForSeconds(.5f);
        Destroy(item);
        }
    }
}
