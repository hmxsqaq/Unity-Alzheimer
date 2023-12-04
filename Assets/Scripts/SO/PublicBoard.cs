using System;
using Hmxs.Toolkit.Base.Singleton;
using Sirenix.OdinInspector;
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "SOSingleton/PublicMethod", fileName = "PublicMethod")]
    public class PublicBoard : SingletonScriptableObject<PublicBoard>
    {
        [SerializeField] private bool interactable;
        [SerializeField] private bool vacant = true;

        public bool Interactable
        {
            get => interactable;
            set => interactable = value;
        }

        public bool Vacant
        {
            get => vacant;
            set => vacant = value;
        }
    }
}