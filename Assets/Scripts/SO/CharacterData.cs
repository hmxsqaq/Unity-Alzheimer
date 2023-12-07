using System;
using Hmxs.Toolkit.Flow.FungusTools;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace SO
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "ScriptableObject/CharacterData", order = 0)]
    public class CharacterData : ScriptableObject
    {
        public string characterName;

        public int age;

        [Title("Phone")]
        public bool hasPhone;
        [ShowIf("hasPhone")] public string phoneNumber;
        [ShowIf("hasPhone")] public UnityEvent phoneEvent;
        [ShowIf("hasPhone")] [SerializeField] private bool phoneHasBeingTriggered;

        [Title("Address")]
        public bool hasHomeAddress;
        [ShowIf("hasHomeAddress")] public string homeAddress;
        [ShowIf("hasHomeAddress")] public UnityEvent homeAddressEvent;
        [ShowIf("hasHomeAddress")] [SerializeField] private bool homeAddressHasBeingTriggered;

        [Multiline(15)]
        public string introduction;

        [PreviewField(150, ObjectFieldAlignment.Center)]
        public Sprite characterSprite;

        public bool PhoneHasBeingTriggered
        {
            get => phoneHasBeingTriggered;
            set => phoneHasBeingTriggered = value;
        }

        public bool HomeAddressHasBeingTriggered
        {
            get => homeAddressHasBeingTriggered;
            set => homeAddressHasBeingTriggered = value;
        }

        public void ExecuteBlock(string blockName) => FlowchartManager.ExecuteBlock(blockName);

        private void OnEnable()
        {
            PhoneHasBeingTriggered = false;
            HomeAddressHasBeingTriggered = false;
        }
    }
}