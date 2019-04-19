using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
    public GameObject spike1;
    public GameObject spike2;
    public GameObject spike3;
    public GameObject spike4;

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
