﻿using System;
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
        public string phoneNumber;
        public UnityEvent phoneEvent;
        [SerializeField] private bool phoneHasBeingTriggered;

        [Title("Address")]
        public bool hasHomeAddress;
        public string homeAddress;
        public UnityEvent homeAddressEvent;
        [SerializeField] private bool homeAddressHasBeingTriggered;

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

        public bool HasPhone
        {
            get => hasPhone;
            set => hasPhone = value;
        }

        public bool HasHomeAddress
        {
            get => hasHomeAddress;
            set => hasHomeAddress = value;
        }

        public void ExecuteBlock(string blockName) => FlowchartManager.ExecuteBlock(blockName);

        private void OnEnable()
        {
            HasPhone = false;
            HasHomeAddress = false;
            PhoneHasBeingTriggered = false;
            HomeAddressHasBeingTriggered = false;
        }
    }
}