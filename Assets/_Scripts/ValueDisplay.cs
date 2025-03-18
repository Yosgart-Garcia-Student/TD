using UnityEngine;
using UnityEngine.Events;
using TMPro;

namespace TowerDefense
{
    [RequireComponent(typeof(TMP_Text))]
    public class ValueDisplay : MonoBehaviour
    {
        public static UnityEvent<string, object> OnValueChanged = new UnityEvent<string, object>();
        [SerializeField] private string valueName = "";
        private TMP_Text displayText;


        void Awake()
        {
            displayText = GetComponent<TMP_Text>();
            OnValueChanged.AddListener(ValueChanged);
        }

        void ValueChanged(string valueName, object value)
        {
            if (this.valueName == valueName)
            {
                displayText.text = value.ToString();
            }
        }
    }
}
