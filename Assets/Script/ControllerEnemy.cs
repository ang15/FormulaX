using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerEnemy : MonoBehaviour
{
    [SerializeField]
    private GameObject finishbad;

    [SerializeField]
    private GameObject level;
    private bool move;
    private float score;

    private void Start()
    {
        move = true;

    }

    private void Update()
    {


        score = Random.Range(0.3f, 0.5f);
       if (move == true)
        {
            move = false;
            StartCoroutine(Up());
        }
    }

    private IEnumerator Up()
    {
        yield return new WaitForSeconds(score * Time.deltaTime);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y + 0.6f);
        move = true;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "finishBad")
        {
            finishbad.SetActive(true);
            level.SetActive(false);
        }
    }
}
