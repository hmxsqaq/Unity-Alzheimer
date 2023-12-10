using System;
using Manager;
using SO;
using UnityEngine;

namespace UI
{
    public class GuideBookUIController : MonoBehaviour
    {
        [SerializeField] private GameObject page1;
        [SerializeField] private GameObject page2;

        private void OnEnable()
        {
            PublicBoard.Instance.Interactable = false;
            DialogPauseManager.Instance.PauseManager();
            BackButton();
        }

        private void OnDisable()
        {
            PublicBoard.Instance.Interactable = true;
            DialogPauseManager.Instance.ResumeManager();
        }

        public void NextButton()
        {
            page1.SetActive(false);
            page2.SetActive(true);
        }

        public void BackButton()
        {
            page1.SetActive(true);
            page2.SetActive(false);
        }

        public void Close() => gameObject.SetActive(false);
    }
}