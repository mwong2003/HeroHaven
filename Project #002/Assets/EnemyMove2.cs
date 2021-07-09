using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove2 : MonoBehaviour
{
    public float speed;
    public bool MoveUp;

    // Update is called once per frame
    void Update()
    {
        if(MoveUp)
        {
            transform.Translate(0, 2*Time.deltaTime*speed, 0);
            transform.localScale = new Vector2(5, 5);
        }
        else
        {
            transform.Translate(0, -2*Time.deltaTime*speed, 0);
            transform.localScale = new Vector2(5, -5);
        }
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("VTurn"))
        {
            if(MoveUp)
            {
                MoveUp = false;
            }
            else
            {
                MoveUp = true;
            }
        }
    }
}
