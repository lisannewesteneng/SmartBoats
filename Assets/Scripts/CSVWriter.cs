using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVWriter : MonoBehaviour
{
    string filename = "";

    TextWriter tw;

    void Awake()
    {
        filename = Application.dataPath + "/data.csv";
    }

    void Update()
    {
        
    }

    public void BeginFile(bool geneticAlgorithm, bool uniformCrossover, float mutationFactor, float mutationChance, int boatParentSize, int pirateParentSize, float simulationTimer)
    {
        tw = new StreamWriter(filename, false);
        tw.WriteLine("General settings: ; ; ");
        tw.WriteLine("Genetic Algorithm:;" + geneticAlgorithm.ToString());
        tw.WriteLine("Uniform crossover:;" + uniformCrossover.ToString());
        tw.WriteLine("MutationFactor:;" + mutationFactor);
        tw.WriteLine("Mutation Chance:;" + mutationChance);
        tw.WriteLine("Boat Parent Size:;" + boatParentSize);
        tw.WriteLine("Pirate Parent Size:;" + pirateParentSize);
        tw.WriteLine("Simulation Timer:;" + simulationTimer);
        tw.WriteLine("");
        tw.WriteLine("Generation;Boat points;Pirate points");
        tw.Close();
    }

    public void WriteData(int generationCount, float boatPoints, float piratePoints)
    {
        tw = new StreamWriter(filename, true);
        tw.WriteLine(generationCount + ";" + boatPoints + ";" + piratePoints);
        tw.Close();
    }

    public void EndFile()
    {
        tw.Close();
    }


}
