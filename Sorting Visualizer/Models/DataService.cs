using Sorting_Visualizer.Models;
using System.Text.Json;

public class DataService
{
    public static Data[] DataList { get; private set; } = [];

    public event Action? OnChange;

    public void SetData(Data[] newData)
    {
        DataList = newData;
        Update();
    }

    public void Update() => OnChange?.Invoke();

    public static string GetDataListJson() {
        return JsonSerializer.Serialize(DataList);
    }
}