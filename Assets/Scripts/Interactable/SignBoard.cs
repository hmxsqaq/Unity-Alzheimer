using SO;
using UnityEngine;

namespace Interactable
{
    public class SignBoard : InteractableItem
    {
        [SerializeField] private Sprite doNotDisturbSprite;
        [SerializeField] private Sprite vacantSprite;

        private SpriteRenderer _spriteRenderer;

        protected override void Start()
        {
            base.Start();
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        protected override void OnMouseOver()
        {
            highlight.highlighted = PublicBoard.Instance.Interactable && PublicBoard.Instance.Vacant;
        }

        protected override void OnValidClick()
        {
            if (PublicBoard.Instance.Vacant) _spriteRenderer.sprite = doNotDisturbSprite;
        }

        public void ChangeToVacantSprite() => _spriteRenderer.sprite = vacantSprite;
    }
}