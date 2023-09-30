using TMPro;
using UnityEngine;

namespace TimeSwitchSystem.Scripts
{

    public class EnvironStateUI : MonoBehaviour, IEnvironStateUI
    {
        private EnvironStateInput environStateInput;
        public TextMeshProUGUI promptUIText;


        void Start()
        {
            environStateInput = GetComponent<EnvironStateInput>();
            InfoText();
        }

        void InfoText()
        {
            promptUIText.text = "Press" + " " + environStateInput.key + " " + "to switch between the Present, Past and the Future";
        }

        public void PresentText()
        {
            promptUIText.text = "PRESENT DAY";//For clarity purposes
        }


        public void FutureText()
        {
            promptUIText.text = "WELCOME TO THE FUTURE";//For clarity purposes
        }


        public void PastText()
        {
            promptUIText.text = "WELCOME TO THE PAST";//For clarity purposes
        }
    }
}
