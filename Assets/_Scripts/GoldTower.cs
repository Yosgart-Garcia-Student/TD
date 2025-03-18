using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TowerDefense;

namespace TowerDefense
{
    public class GoldTower : MonoBehaviour
    {
        public Tower_SO towerType;

        void Start()
        {
            StartCoroutine(SpawnGold());
        }

        IEnumerator SpawnGold()
        {
            while(true)
            {
                Player.AddGold(towerType.damage);
            
                yield return new WaitForSeconds(towerType.fireRate);
            }
        }
    }
}
