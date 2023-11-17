using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialGenerator : MonoBehaviour
{
    private List<ItemMaterial> materialList = new List<ItemMaterial>();

    private const string materialError0 = "Material List is empty";
    private const string materialError1 = "Material is null";

    void Start()
    {
        InstanceMaterials();
    }

    void InstanceMaterials()
    {
        CopperMaterial copperMaterial = new GameObject("CopperObject").
                                        AddComponent<CopperMaterial>();
        IronMaterial ironMaterial = new GameObject("IronObject").
                                    AddComponent<IronMaterial>();
        SteelMaterial steelMaterial = new GameObject("SteelObject").
                                      AddComponent<SteelMaterial>();
        InvarMaterial invarMaterial = new GameObject("InvarObject").
                                      AddComponent<InvarMaterial>();
        HighAlloyMaterial highAlloyMaterial = new GameObject("HighAlloyObject").
                                              AddComponent<HighAlloyMaterial>();
        ValeriumMaterial valeriumMaterial = new GameObject("ValeriumObject").
                                            AddComponent<ValeriumMaterial>();
        PhariumMaterial phariumMaterial = new GameObject("PhariumObject").
                                          AddComponent<PhariumMaterial>();
        MaleveriumMaterial maleveriumMaterial = new GameObject("MaleveriumObject").
                                                AddComponent<MaleveriumMaterial>();
        materialList.Add(copperMaterial);
        materialList.Add(ironMaterial);
        materialList.Add(steelMaterial);
        materialList.Add(invarMaterial);
        materialList.Add(highAlloyMaterial);
        materialList.Add(valeriumMaterial);
        materialList.Add(phariumMaterial);
        materialList.Add(maleveriumMaterial);
    }

    public string GetMaterial()
    {
        return GenerateMaterial();
    }

    string GenerateMaterial()
    {
        if (materialList.Count > 0)
        {
            int index = UnityEngine.Random.Range(0, materialList.Count);
            ItemMaterial material = materialList[index];
            if (material != null)
            {
                string materialName = material.MaterialName;
                return materialName;
            }
            else
            {
                Debug.LogError(String.Format("{0}", materialError1));
            return null;
            }
        }
        else
        {
            Debug.LogError(String.Format("{0}", materialError0));
            return null;
        }
    }
}
