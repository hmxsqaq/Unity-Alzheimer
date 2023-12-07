using HighlightPlus2D;
using Sirenix.OdinInspector;
using SO;
using UnityEngine;

namespace Interactable
{
    [RequireComponent(typeof(HighlightEffect2D), typeof(Collider2D))]
    public abstract class InteractableItem : MonoBehaviour
    {
        [SerializeField] [ReadOnly] protected HighlightEffect2D highlight;

        protected virtual void Start()
        {
            highlight = GetComponent<HighlightEffect2D>();
        }

        private void OnMouseOver() => highlight.highlighted = JudgeInteractState();

        private void OnMouseExit() => highlight.highlighted = false;

        private void OnMouseDown()
        {
            if (JudgeInteractState())
                OnValidClick();
        }

        protected abstract void OnValidClick();

        protected abstract bool JudgeInteractState();

        public void HighlightOn() => highlight.highlighted = true;
        public void HighlightOff() => highlight.highlighted = false;
    }
}