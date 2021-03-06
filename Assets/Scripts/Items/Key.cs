using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private GameObject player;
    private PlayerItem pItem;

    // public float coolTime;
    public bool readyToUse;
    private float curTime;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pItem = player.GetComponent<PlayerItem>();

        // coolTime = 5f;
        readyToUse = false;
        curTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;

        if (curTime < 2f)
        {
            transform.Translate(0, 0.5f * Time.deltaTime, 0);
        }
        else if (curTime >= 2f)
        {
            transform.Translate(0, -0.5f * Time.deltaTime, 0);
            if (curTime >= 4f)
            {
                curTime = 0f;
            }
        }
        if (pItem.hasKey)
        {
            this.transform.localScale = new Vector3(0, 0, 0);
            readyToUse = true;

        }
    }
}
