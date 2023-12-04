using System;
using HighlightPlus2D;
using Sirenix.OdinInspector;
using SO;
using UnityEngine;

namespace Interactable
{
    [RequireComponent(typeof(HighlightEffect2D), typeof(Collider2D))]
    public abstract class InteractableItem : MonoBehaviour
    {
        [SerializeField] [ReadOnly] private HighlightEffect2D highlight;

        protected virtual void Start()
        {
            highlight = GetComponent<HighlightEffect2D>();
        }

        private void OnMouseOver()
        {
            if (PublicBoard.Instance.Interactable)
                highlight.highlighted = true;
        }

        private void OnMouseExit()
        {
            highlight.highlighted = false;
        }

        private void OnMouseDown()
        {
            if (PublicBoard.Instance.Interactable)
                OnClick();
        }

        protected abstract void OnClick();
    }
}