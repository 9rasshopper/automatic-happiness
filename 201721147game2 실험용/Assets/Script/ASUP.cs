using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASUP : item
{
    public override void RunItem()
    {
        GameObject playerObject = GameObject.Find("Player");
        PlayerAttack PlayerAttack = playerObject.GetComponent<PlayerAttack>();
        
        PlayerAttack.cooltime -= 1.0f;

        DestroyObject();
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }

    

    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            RunItem();
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