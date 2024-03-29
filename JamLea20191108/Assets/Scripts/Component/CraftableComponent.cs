﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftableComponent : ATransportableElement
    {

    [SerializeField]
    private IngredientDisplay _ingredientDisplay = null;
    [SerializeField]
    private SpriteRenderer _sprite = null;

    public Resources GetResource()
    {
        return _ingredientDisplay.Resource;
    }

    [ExecuteInEditMode]
    protected override void Awake()
    {
        base.Awake();

        this._sprite.sprite = _ingredientDisplay.Sprite;
    }
}