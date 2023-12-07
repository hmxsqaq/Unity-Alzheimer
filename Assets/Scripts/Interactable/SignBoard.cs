using Hmxs.Toolkit.Flow.FungusTools;
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

        protected override void OnValidClick()
        {
            _spriteRenderer.sprite = doNotDisturbSprite;
            FlowchartManager.ExecuteBlock(PublicBoard.Instance.blockFlow[PublicBoard.Instance.currentBlockIndex]);
            if (PublicBoard.Instance.currentBlockIndex < PublicBoard.Instance.blockFlow.Count - 1)
                PublicBoard.Instance.currentBlockIndex++;
        }

        protected override bool JudgeInteractState() => PublicBoard.Instance.Interactable && PublicBoard.Instance.Vacant;

        public void ChangeToVacantSprite() => _spriteRenderer.sprite = vacantSprite;
    }
}