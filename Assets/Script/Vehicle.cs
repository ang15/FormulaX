using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Vehicle: MonoBehaviour
{
    public GameObject finish;
    public GameObject level;
    private int amount;
    [SerializeField]
    private Text amountText;
    [SerializeField]
    private bool move;
    [SerializeField]
    private float speedTime;
    void Update()
    {
        amountText.text = "" + amount;
    }


    public void Move()
    {
        speedTime = Random.Range(0.3f, 0.5f);
        if (move == true)
        {
            move = false;
            StartCoroutine(Up());
        }
    }

    private IEnumerator Up()
    {
        yield return new WaitForSeconds(speedTime * Time.deltaTime);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y + 16f);
        move = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="finish")
        {
            finish.SetActive(true);
            level.SetActive(false);
        }
    }
}
