using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace Word
{
    public class WordCheck : MonoBehaviour
    {
        [SerializeField] private Desired_Word word;
        [SerializeField] private Image img;
        [SerializeField] private TMP_InputField inputField;

        void Awake()
        {
            inputField.characterLimit = 100;
            inputField.onSubmit.AddListener(TextCheckHandler);
        }

        private void TextCheckHandler(string arg0)
        {
            if (arg0 == word.UpperCase || arg0 == word.LowerCase || arg0 == word.Capitilised)
            {
                img.color = Color.green;
                return;
            }

            img.color = Color.red;
        }

    }
}

