using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TowerDefense
{
    [RequireComponent(typeof(Button))]
    public class TowerButton : MonoBehaviour
    {
        Button button;
        Player player;
        public GameObject towerPrefab;

        private void Awake()
        {
            button = GetComponent<Button>();
            player = FindAnyObjectByType<Player>();

            button.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            player.towerPrefab = towerPrefab;
        }
    }
}
