using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerArchitecture;

public class Computer
{
    private string model;
    private int capacity;
    private List<CPU> multiprocessor;

    public string Model { get; set; }
    public int Capacity { get; set; }
    public List<CPU> Multiprocessor => this.multiprocessor;
    public int Count => this.multiprocessor.Count;

    public Computer(string model, int capacity)
    {
        this.Model = model;
        this.Capacity = capacity;
        this.multiprocessor = new List<CPU>();
    }

    public void Add(CPU cpu)
    {
        if (this.Count < this.Capacity)
        {
            this.multiprocessor.Add(cpu);
        }
    }

    public bool Remove(string brand)
    {
        var cpuToRemove = this.multiprocessor.FirstOrDefault(x => x.Brand == brand);
        if (cpuToRemove != default)
        {
            this.multiprocessor.Remove(cpuToRemove);
            return true;
        }
        return false;
    }

    public CPU MostPowerful() => this.multiprocessor
            .OrderByDescending(x => x.Frequency)
            .FirstOrDefault();

    public CPU GetCPU(string brand) => this.multiprocessor.FirstOrDefault(x => x.Brand == brand);

    public string Report()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"CPUs in the Computer {this.Model}:");

        foreach (var item in this.multiprocessor)
        {
            sb.AppendLine($"{item.ToString()}");
        }

        return sb.ToString().TrimEnd();
    }
}