﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

public class EventObject<T> {

    public class TEvent : UnityEvent<T> {}

    public TEvent OnChanged = new TEvent();

    private T obj;

    public T val {
        get {
            return obj;
        }
        set {
            if (!obj.Equals(value)) {
                obj = value;
                OnChanged.Invoke(obj);
            }
        }
    }
}