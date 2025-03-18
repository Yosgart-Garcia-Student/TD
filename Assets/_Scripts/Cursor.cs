using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public class Cursor : MonoBehaviour
    {
        Vector3Int GetTargetTile()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                UnityEngine.Cursor.visible = false;
                Vector3Int targetTile = Grid.WorldToGrid(hit.point + hit.normal * 0.5f);
                return targetTile;
            }

            UnityEngine.Cursor.visible = true;
            return new Vector3Int(-4, 1, 2); 
        }

        void Update()
        {
            transform.position = GetTargetTile();
        }
    }
}

