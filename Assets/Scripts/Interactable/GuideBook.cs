using SO;

namespace Interactable
{
    public class GuideBook : InteractableItem
    {
        protected override void OnValidClick()
        {

        }

        protected override bool JudgeInteractState() => PublicBoard.Instance.Interactable;
    }
}