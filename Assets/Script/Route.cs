using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour
{
    public bool move;
    void Update()
    {
        RouteMove();
    }

    void RouteMove()
    {
        if (move == false)
        {
            move = true;
            StartCoroutine(Way());

        }
    }
    IEnumerator Way()
    {
        yield return new WaitForSeconds(1.5f*Time.deltaTime);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y-10);
        move = false;
    }

  
}
