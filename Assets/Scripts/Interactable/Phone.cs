using SO;

namespace Interactable
{
    public class Phone : InteractableItem
    {
        protected override void OnMouseOver()
        {
            highlight.highlighted = PublicBoard.Instance.Interactable && PublicBoard.Instance.Vacant;
        }

        protected override void OnValidClick()
        {

        }
    }
}