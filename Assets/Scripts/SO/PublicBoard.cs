using System;
using System.Collections.Generic;
using Hmxs.Toolkit.Base.Singleton;
using Sirenix.OdinInspector;
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "SOSingleton/PublicMethod", fileName = "PublicMethod")]
    public class PublicBoard : SingletonScriptableObject<PublicBoard>
    {
        [Title("GlobalState")]
        [SerializeField] private bool interactable;
        [SerializeField] private bool vacant = true;

        [Title("CharacterDataState")]
        public List<CharacterData> availableData = new();
        [ReadOnly] public int currentDataIndex;

        [Title("GameFlowState")]
        public List<string> blockFlow = new();
        public int currentBlockIndex;

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

        public void AddNote(CharacterData data)
        {
            if (availableData.Contains(data))
                return;
            availableData.Add(data);
        }

        public void RemoveNote(CharacterData data)
        {
            if (availableData.Contains(data))
                availableData.Remove(data);
        }

        [Button]
        private void Reset()
        {
            Interactable = true;
            Vacant = true;
            availableData = new List<CharacterData>();
            currentDataIndex = 0;
            currentBlockIndex = 0;
        }
#if UNITY_EDITOR

#else
        private void OnEnable() => Reset();
#endif
    }
}