using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public float delay1;
    public float delay2;
    public GameObject daggerPrefab;
    public Transform spawnPoint;

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Invoke("spawnDagger", delay1);
        Invoke("spawnDagger", delay2);
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = 8f;
        Invoke("resetSpeed", 0.5f);
    }

    void spawnDagger()
    {
        Instantiate(daggerPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    void resetSpeed()
    {
        destination = transform.position;
        speed = 3f;
    }
}
