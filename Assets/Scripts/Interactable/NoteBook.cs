using SO;
using UI;
using UnityEngine;

namespace Interactable
{
    public class NoteBook : InteractableItem
    {
        [SerializeField] private NoteBookUIController noteBookUI;

        protected override void OnValidClick() => noteBookUI.gameObject.SetActive(true);

        protected override bool JudgeInteractState() => PublicBoard.Instance.Interactable && PublicBoard.Instance.availableData.Count > 0;
    }
}