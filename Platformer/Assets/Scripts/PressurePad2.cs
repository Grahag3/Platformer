using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        {
            StartCoroutine(break_blocker());
        }
    }

    IEnumerator break_blocker()
    {
        GameObject[] blockers = GameObject.FindGameObjectsWithTag("Blocker 2");

        foreach (var item in blockers)
        {
            yield return new WaitForSeconds(1.0f);
            Destroy(item);
        }
    }

}
