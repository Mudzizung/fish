﻿/***
  *Title:""��Ŀ
  *Description:
  *		����:
  *Author:D
  *Data:2018.03.18
  *
  *
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Web : MonoBehaviour
{
    public float durationTime;
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.SendMessage("TakeDanage", damage);
    }
}

