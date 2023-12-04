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

        protected override void OnClick()
        {
            if (PublicBoard.Instance.Vacant)
            {
                _spriteRenderer.sprite = doNotDisturbSprite;
                PublicBoard.Instance.Vacant = false;
            }
        }
    }
}