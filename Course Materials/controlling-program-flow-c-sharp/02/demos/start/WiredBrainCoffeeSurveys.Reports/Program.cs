using System;
using System.Collections.Generic;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<string>();
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;

            GenerateTasksReport(tasks, responseRate);

        }

        private static void GenerateTasksReport(List<string> tasks, double responseRate)
        {
            bool isCoffeeScoreLower = Q1Results.CoffeeScore > Q1Results.FoodScore;

            if (isCoffeeScoreLower)
            {
                tasks.Add("Investigate Coffee ingredients and quality");
            }

            if (responseRate < 0.33)
            {
                tasks.Add("Poor rate. investigate");
            }
            else if (responseRate >= 0.33 && responseRate < 0.66)
            {
                tasks.Add("Send a free coffee");
            }
            else
            {
                tasks.Add("Send a coupon");
            }

            switch (Q1Results.AreaToImprove)
            {
                case "Rewards Program":
                    tasks.Add("Investigate Rewards Program");
                    break;
                case "Mobile Site":
                    tasks.Add("Create an App");
                    break;
                case "Clenliness":
                    tasks.Add("Contact cleaning company");
                    break;
                default:
                    tasks.Add("Investigate further");
                    break;


            }
        }
    }
}
