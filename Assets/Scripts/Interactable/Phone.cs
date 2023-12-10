using SO;
using UI;
using UnityEngine;

namespace Interactable
{
    public class Phone : InteractableItem
    {
        [SerializeField] private PhoneUIController phoneUIController;

        protected override void OnValidClick()
        {
            HighlightOff();
            phoneUIController.gameObject.SetActive(true);
        }

        protected override bool JudgeInteractState() => PublicBoard.Instance.Interactable &&
                                                        PublicBoard.Instance.Vacant &&
                                                        PublicBoard.Instance.availableData.Find(data => data.hasPhone) != null;
    }
}