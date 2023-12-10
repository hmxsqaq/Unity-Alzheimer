using SO;
using UI;
using UnityEngine;

namespace Interactable
{
    public class GuideBook : InteractableItem
    {
        [SerializeField] private GuideBookUIController guideBookUI;

        protected override void OnValidClick()
        {
            HighlightOff();
            guideBookUI.gameObject.SetActive(true);
        }

        protected override bool JudgeInteractState() => PublicBoard.Instance.Interactable;
    }
}