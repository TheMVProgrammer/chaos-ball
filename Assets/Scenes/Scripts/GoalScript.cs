using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    void OnTriggerEnter (Collider collider)
    {
        GameObject collideWith = collider.gameObject;
        if(gameObject.CompareTag(collideWith.tag))
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collideWith);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
