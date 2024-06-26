using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Villager
{
    public GameObject arrowPrefab;
    public Transform spawnPoint;
    public float delay = 0.46f;

    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Invoke("spawnArrow", delay);
    }

    void spawnArrow()
    {
        Instantiate(arrowPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    public override ChestType CanOpen()
    {
        return ChestType.Archer;
    }
}
