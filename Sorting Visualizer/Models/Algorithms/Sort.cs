using Microsoft.VisualBasic;
using Sorting_Visualizer.Models;

namespace Sorting_Visualizer.Models.Algorithms
{
    public class Sort
    {
        private readonly DataService dataService;
        private CancellationToken token;

        public Sort(DataService dataService, CancellationToken token)
        {
            this.dataService = dataService;
            this.token = token;
        }

        public async Task BubbleSort(Data[] dataList)
        {
            Boolean hasSwapped;

            for (int i = 0; i < dataList.Length - 1; i++)
            {
                hasSwapped = false;
                for (int j = 0; j < dataList.Length - i - 1; j++)
                {
                    token.ThrowIfCancellationRequested();

                    if (dataList[j].Value > dataList[j + 1].Value)
                    {
                        await Task.Yield();
                        await Task.Delay(1);
                        Data.Swap(ref dataList[j], ref dataList[j + 1]);
                        dataService.SetData(dataList);
                        hasSwapped = true;
                    }
                }

                if (!hasSwapped) return;
            }
        }

        public static void InsertionSort()
        {

        }

        public static void SelectionSort()
        {

        }

        public static void ShellSort()
        {

        }

        public static void MergeSort()
        {

        }

        public static void QuickSort()
        {

        }
    }
}