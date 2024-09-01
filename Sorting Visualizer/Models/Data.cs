namespace Sorting_Visualizer.Models
{
    public class Data
    {
        public Data.Point Coord { get; set; }
        public int Value { get; set; }

        public string Color { get; set; }

        public Data (Data.Point Coord, int Value)
        {
            this.Coord = Coord;
            this.Value = Value;
            this.Color = "black";
        }

        public struct Point(int x = 0, int y = 0)
        {
            public int X { get; set; } = x;
            public int Y { get; set; } = y;

            public readonly void PrintCoord()
            {
                Console.WriteLine($"Point coordinates: X = {X}, Y = {Y}");
            }
        } // Data.Point point = new Data.Point(0, 0);
        
        public static void Swap(ref Data d1, ref Data d2) {
            (d1.Value, d2.Value) = (d2.Value, d1.Value);
        }

        public static void ShuffleValues(Data[] dataArray)
        {
            // Ensure the array is not null and contains elements
            if (dataArray == null || dataArray.Length == 0)
            {
                throw new ArgumentException("Data array cannot be null or empty.");
            }

            // Create a list of unique random values
            Random random = new Random();
            int[]? uniqueValues = Enumerable.Range(1, dataArray.Length).OrderBy(x => random.Next()).ToArray();

            // Assign the randomized values to the Data objects
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i].Color = "black";
                dataArray[i].Value = uniqueValues[i];
            }
        }

        public static void Highlight(ref Data d, string color) {
            d.Color = color;
        }
    }
}