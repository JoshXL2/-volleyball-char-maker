using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterCustomizer : MonoBehaviour
{
    [Header("Skin")]
    public SkinnedMeshRenderer bodyRenderer;
    public Material[] skinMaterials;
    private int skinIndex;

    [Header("Hair")]
    public GameObject[] hairStyles;
    private int hairIndex;

    [Header("Hats")]
    public GameObject[] hats;
    private int hatIndex;

    [Header("Tops")]
    public GameObject[] tops;
    private int topIndex;

    [Header("Bottoms")]
    public GameObject[] bottoms;
    private int bottomIndex;

    [Header("Shoes")]
    public GameObject[] shoes;
    private int shoesIndex;

    void Start()
    {
        UpdateAll();
    }

    // ===== SKIN =====
    public void NextSkin()
    {
        skinIndex = (skinIndex + 1) % skinMaterials.Length;
        ApplySkin();
    }

    public void PreviousSkin()
    {
        skinIndex--;
        if (skinIndex < 0) skinIndex = skinMaterials.Length - 1;
        ApplySkin();
    }

    void ApplySkin()
    {
        bodyRenderer.material = skinMaterials[skinIndex];
    }

    // ===== HAIR =====
    public void NextHair()
    {
        hairIndex = (hairIndex + 1) % hairStyles.Length;
        SetActive(hairStyles, hairIndex);
    }

    public void PreviousHair()
    {
        hairIndex--;
        if (hairIndex < 0) hairIndex = hairStyles.Length - 1;
        SetActive(hairStyles, hairIndex);
    }

    // ===== HATS =====
    public void NextHat()
    {
        hatIndex = (hatIndex + 1) % hats.Length;
        SetActive(hats, hatIndex);
    }

    public void PreviousHat()
    {
        hatIndex--;
        if (hatIndex < 0) hatIndex = hats.Length - 1;
        SetActive(hats, hatIndex);
    }

    // ===== TOPS =====
    public void NextTop()
    {
        topIndex = (topIndex + 1) % tops.Length;
        SetActive(tops, topIndex);
    }

    public void PreviousTop()
    {
        topIndex--;
        if (topIndex < 0) topIndex = tops.Length - 1;
        SetActive(tops, topIndex);
    }

    // ===== BOTTOMS =====
    public void NextBottoms()
    {
        bottomIndex = (bottomIndex + 1) % bottoms.Length;
        SetActive(bottoms, bottomIndex);
    }

    public void PreviousBottoms()
    {
        bottomIndex--;
        if (bottomIndex < 0) bottomIndex = bottoms.Length - 1;
        SetActive(bottoms, bottomIndex);
    }

    // ===== SHOES =====
    public void NextShoes()
    {
        shoesIndex = (shoesIndex + 1) % shoes.Length;
        SetActive(shoes, shoesIndex);
    }

    public void PreviousShoes()
    {
        shoesIndex--;
        if (shoesIndex < 0) shoesIndex = shoes.Length - 1;
        SetActive(shoes, shoesIndex);
    }

    // ===== HELPERS =====
    void SetActive(GameObject[] objects, int index)
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(i == index);
        }
    }

    void UpdateAll()
    {
        ApplySkin();
        SetActive(hairStyles, hairIndex);
        SetActive(hats, hatIndex);
        SetActive(tops, topIndex);
        SetActive(bottoms, bottomIndex);
        SetActive(shoes, shoesIndex);
    }
}