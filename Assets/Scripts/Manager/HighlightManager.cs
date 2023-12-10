using Hmxs.Toolkit.Base.Singleton;
using Interactable;
using SO;
using UnityEngine;

namespace Manager
{
    public class HighlightManager : SingletonMono<HighlightManager>
    {
        [SerializeField] private InteractableItem phone;
        [SerializeField] private InteractableItem signBoard;
        [SerializeField] private InteractableItem noteBook;
        [SerializeField] private InteractableItem guideBook;

        protected override void OnInstanceCreate(HighlightManager instance) { }

        public void RefreshHighlightState()
        {
            foreach (var data in PublicBoard.Instance.availableData)
            {
                if (data.hasPhone && !data.PhoneHasBeingTriggered)
                {
                    phone.HighlightOn();
                    noteBook.HighlightOn();
                }
                if (data.hasHomeAddress && !data.HomeAddressHasBeingTriggered)
                    noteBook.HighlightOn();
            }

            guideBook.HighlightOff();

            if (PublicBoard.Instance.currentBlockIndex < PublicBoard.Instance.blockFlow.Count)
                signBoard.HighlightOn();
            else
                signBoard.HighlightOff();
        }

        public void SetNoteAndGuide(bool state)
        {
            if (!state)
            {
                noteBook.HighlightOff();
                guideBook.HighlightOff();
                signBoard.HighlightOff();
            }
            else
            {
                if (PublicBoard.Instance.availableData.Count > 0) noteBook.HighlightOn();
                guideBook.HighlightOn();
            }
        }
    }
}