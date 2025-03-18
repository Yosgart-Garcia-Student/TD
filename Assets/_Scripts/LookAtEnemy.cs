using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TowerDefense;

public class LookAtEnemy : MonoBehaviour
{
    public GameObject thing;
    private Tower tower;

    void Start()
    {
        tower = GetComponent<Tower>();
    }

    void Update()
    {
        if(tower.enemyTarget) thing.transform.LookAt(tower.enemyTarget.transform);
    }
}
