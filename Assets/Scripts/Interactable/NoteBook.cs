using SO;

namespace Interactable
{
    public class NoteBook : InteractableItem
    {
        protected override void OnMouseOver()
        {
            highlight.highlighted = PublicBoard.Instance.Interactable;
        }

        protected override void OnValidClick()
        {

        }
    }
}