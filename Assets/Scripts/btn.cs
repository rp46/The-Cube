using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn : MonoBehaviour
{
    public bool enter = true;
    public GameObject player;
    Collider coll;
    private BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = this.GetComponent<BoxCollider>();
        boxCollider.isTrigger = true;
        player=GameObject.FindWithTag("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            boxCollider.isTrigger = false;
            player.transform.localScale-=new Vector3(0.5f,0.5f,0.5f);
        }
    }
}
