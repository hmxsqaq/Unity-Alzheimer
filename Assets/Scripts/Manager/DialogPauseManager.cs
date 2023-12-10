using Fungus;
using Hmxs.Toolkit.Base.Singleton;
using Interactable;
using SO;
using UnityEngine;

namespace Manager
{
    public class DialogPauseManager : SingletonMono<DialogPauseManager>
    {
        [SerializeField] private DialogInput npcDialogInput;
        [SerializeField] private DialogInput playerDialogInput;

        [SerializeField] private GameObject npcDialogPanel;
        [SerializeField] private GameObject playerDialogPanel;

        private bool _isPausing = false;
        private bool _isDisable = false;

        public void SetManagerState(bool state)
        {
            _isDisable = !state;
            SetDialog(state);
        }

        public void PauseManager() => _isDisable = true;

        public void ResumeManager() => _isDisable = false;

        protected override void OnInstanceCreate(DialogPauseManager instance) { }

        private void SetDialogInput(bool state)
        {
            npcDialogInput.enabled = state;
            playerDialogInput.enabled = state;
        }

        private void SetDialog(bool state)
        {
            HighlightManager.Instance.SetNoteAndGuide(!state);
            npcDialogPanel.SetActive(state);
            playerDialogPanel.SetActive(state);
            SetDialogInput(state);
        }

        private void Update()
        {
            if (PublicBoard.Instance.Vacant || _isDisable) return;

            if (Input.GetMouseButtonUp(1))
            {
                PublicBoard.Instance.Interactable = !_isPausing;
                SetDialog(_isPausing);
                _isPausing = !_isPausing;
            }
        }
    }
}