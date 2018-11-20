﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace XUUI.UGUIAdapter
{
    public class DropdownAdapter : MonoBehaviour, DataConsumer<int>, DataProducer<int>
    {
        public Dropdown Target;

        public string BindTo;

        public Action<int> OnValueChange { get; set; }

        public int Value
        {
            set
            {
                Target.value = value;
            }
        }

        void Start()
        {
            Target.onValueChanged.AddListener((val) =>
            {
                if (OnValueChange != null)
                {
                    OnValueChange(val);
                }
            });
        }
    }
}
