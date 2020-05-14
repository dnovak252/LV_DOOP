using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service) 
        { 
            this.analyticsService = service; 
        }
        private double[][] ConvertData(Dataset dataset)
        {
            List<List<double>> data = new List<List<double>>(dataset.GetData());
            double[][] convertedArray = data.Select(item => item.ToArray()).ToArray();
            return convertedArray;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
             double[][] data = this.ConvertData(dataset);
             return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);}
        }
}
