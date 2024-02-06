namespace WhiteLagoon.Web.ViewModels
{
    public class LineChartVM
    {
        public List<ChartDate> Series { get; set; }
        public string[]  Categories { get; set; }
    }
    public class ChartDate
    {
        public string Name { get; set; }
        public int Data { get; set; }
    }
}
