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
            HighlightOff();
            _spriteRenderer.sprite = doNotDisturbSprite;
            FlowchartManager.ExecuteBlock(PublicBoard.Instance.blockFlow[PublicBoard.Instance.currentBlockIndex]);
            PublicBoard.Instance.currentBlockIndex++;
        }

        protected override bool JudgeInteractState() => PublicBoard.Instance.Interactable &&
                                                        PublicBoard.Instance.Vacant &&
                                                        PublicBoard.Instance.currentBlockIndex < PublicBoard.Instance.blockFlow.Count;

        public void ChangeToVacantSprite() => _spriteRenderer.sprite = vacantSprite;
    }
}