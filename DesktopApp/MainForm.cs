using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.WinControls.UI;

namespace DesktopApp
{
    
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public MainForm()
        {
            InitializeComponent();

            List<Tennis> list = new List<Tennis>
            {
                new Tennis("D1", "Sunny", "Hot", "High", "Weak", "No"),
                new Tennis("D2", "Sunny", "Hot", "High", "Strong", "No"),
                new Tennis("D3", "Overcast", "Hot", "High", "Weak", "Yes"),
                new Tennis("D4", "Rain", "Mild", "High", "Weak", "Yes"),
                new Tennis("D5", "Rain", "Cool", "Normal", "Weak", "Yes"),
                new Tennis("D6", "Rain", "Cool", "Normal", "Strong", "No"),
                new Tennis("D7", "Overcast", "Cool", "Normal", "Strong", "Yes"),
                new Tennis("D8", "Sunny", "Mild", "High", "Weak", "No"),
                new Tennis("D9", "Sunny", "Cool", "Normal", "Weak", "Yes"),
                new Tennis("D10", "Rain", "Mild", "Normal", "Weak", "Yes"),
                new Tennis("D11", "Sunny", "Mild", "Normal", "Strong", "Yes"),
                new Tennis("D12", "Overcast", "Mild", "High", "Strong", "Yes"),
                new Tennis("D13", "Overcast", "Hot", "Normal", "Weak", "Yes"),
                new Tennis("D14", "Rain", "Mild", "High", "Strong", "No"),
            };

            OriginalDataGridView.DataSource = list;
            OriginalDataGridView.AutoSizeColumnsMode =GridViewAutoSizeColumnsMode.Fill;
            OriginalDataGridView.BestFitColumns();
            MainFunction(list);
            CartTree.ExpandAll();
            CartTree.ExpandAnimation= ExpandAnimation.Opacity;
        }

        private void MainFunction(List<Tennis> list, RadTreeNode node = null)
        {
            var mainEntropy = Entropy(list.Count(m => m.PlayTennis == "Yes"), list.Count(m => m.PlayTennis == "No"));
            List<double> entropiesList = new List<double>();
            foreach (var propertyInfo in typeof(Tennis).GetProperties())
            {
                if (propertyInfo.Name != "PlayTennis")
                {
                    entropiesList.Add(mainEntropy - EntropyTwoAttribute(list.GroupBy(c => c.GetType().GetProperty(propertyInfo.Name).GetValue(c, null).ToString())));
                }
            }
            if (entropiesList.Any(m => m > 0))
            {
                foreach (var propertyInfo in typeof(Tennis).GetProperties())
                {
                    if (propertyInfo.Name != "PlayTennis")
                    {
                        var grouped =
                            list.GroupBy(c => c.GetType().GetProperty(propertyInfo.Name).GetValue(c, null).ToString());
                        if (entropiesList.OrderByDescending(m => m).FirstOrDefault() ==
                            mainEntropy -
                            EntropyTwoAttribute(grouped))
                        {
                            if (node == null)
                            {
                                node = CartTree.Nodes.Add(propertyInfo.Name);
                            }
                            else
                            {
                                node = node.Nodes.Add(propertyInfo.Name);
                            }

                            foreach (var group in grouped)
                            {
                                var nextNode = node.Nodes.Add(group.Key);
                                MainFunction(group.ToList(), nextNode);
                            }
                        }
                    }
                }
            }
            else
            {
                node.Nodes.Add(list.All(m => m.PlayTennis == list.FirstOrDefault().PlayTennis)
                    ? list.FirstOrDefault().PlayTennis : "Undefined");
            }
        }
        private static double EntropyTwoAttribute(IEnumerable<IGrouping<string, Tennis>> groupedList)
        {
            double result = 0;
            foreach (var group in groupedList)
            {
                var temp = ((double)group.Count() / groupedList.Sum(m => m.Count())) * Entropy(group.Count(m => m.PlayTennis == "Yes"), group.Count(m => m.PlayTennis == "No"));
                if (temp > 0)
                {
                    result += temp;
                }
            }
            return result;
        }

        private static double Entropy(int valueA, int valueB)
        {
            var probA = (double)valueA / (valueA + valueB);
            var probB = (double)valueB / (valueA + valueB);
            return LogHelper(probA) + LogHelper(probB);
        }

        private static double Entropy(List<int> values)
        {
            double result = 0;
            foreach (var value in values)
            {
                result += LogHelper((double)value / values.Sum());
            }
            return result;
        }

        private static double LogHelper(double value)
        {
            return (-1) * (value * Math.Log(value, 2));
        }
    }
}
