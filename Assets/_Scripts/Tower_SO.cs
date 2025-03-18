using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TowerDefense;

namespace TowerDefense
{
    [CreateAssetMenu]
    public class Tower_SO : ScriptableObject
    {
        public float fireRate = 1f;
        public int damage = 1;
        public int cost = 10;

        public static int GetCost(GameObject gameObject)
        {
            Tower tower = gameObject.GetComponent<Tower>();
            if(tower) return tower.towerType.cost;

            GoldTower towerG = gameObject.GetComponent<GoldTower>();
            return towerG.towerType.cost;
            
        }
    }
}
