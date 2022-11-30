// COLOR DATA PRACTICE

#nullable disable

// Import JSON module
using System.Text.Json;

// Load Color Data from File
string dataStr = File.ReadAllText("color-data.json");
List<Color> colorData = JsonSerializer.Deserialize<List<Color>>(dataStr);

// Verify Contents of colorData
foreach (Color color in colorData)
{
    Console.WriteLine(color);
}

class Color
{
    // Properties
    public string Name { get; set; }
    public string Hex { get; set; }
    public string Family { get; set; }
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }
    public int Brightness { get; set; }

    public Color(string name, string hex, string family, int r, int g, int b, int brightness)
    {
        this.Name = name;
        this.Hex = hex;
        this.Family = family;
        this.R = r;
        this.G = g;
        this.B = b;
        this.Brightness = brightness;
    }

    public override string ToString()
    {
        return $"{this.Name} #{this.Hex} {this.Family} ({this.R}, {this.G}, {this.B}) {this.Brightness}";
    }
}