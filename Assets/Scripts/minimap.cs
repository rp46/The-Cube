using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.FindWithTag("Player");
        offset=transform.position+player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=new Vector3(player.transform.position.x+offset.x,offset.y,player.transform.position.z+offset.z);
    }
}
