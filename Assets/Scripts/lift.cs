using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift : MonoBehaviour
{
    public GameObject player;
    public float speed=-1f;
    private int flag=0;

    void Start()
    {
        player=GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if(transform.position.y<=-0.45||transform.position.y>=4.55){
            StartCoroutine(EnterGameObject());
        }
        if(transform.position.y<4.55&&flag==0)
        transform.position += Vector3.up * Time.deltaTime * speed;
        if(transform.position.y>-0.45&&flag==1)
        transform.position += Vector3.up * Time.deltaTime * speed * -1f;
    }

    IEnumerator EnterGameObject()
    {
        yield return new WaitForSeconds(3.0f);
        if(transform.position.y>=4.55&&flag==0)
            flag=1;
        if(transform.position.y<=-0.45&&flag==1)
            flag=0;
    }
}
