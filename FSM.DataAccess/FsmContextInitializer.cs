using FSM.Model.Enums;
using FSM.Model.ModelObjects;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FSM.DataAccess
{
    public class FsmContextInitializer
    {
        public static void Seed(IApplicationBuilder builder)
        {
            using (var context = builder.ApplicationServices.GetRequiredService<FsmContext>())
            {
                context.Database.EnsureCreated();
                if(context.StatisticalCategories.Any())
                {
                    return;
                }

                // Seed statistical categories
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "All Time Appearances",
                    CategoryCode = "ATApp",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "All Time Goals",
                    CategoryCode = "ATGls",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "All Time League Appearances",
                    CategoryCode = "ATLgeApps",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "All Time League Goals",
                    CategoryCode = "ATLgeGls",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Appearances",
                    CategoryCode = "Apps",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Assists",
                    CategoryCode = "Ast",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Aerial Challenges Won",
                    CategoryCode = "AerR",
                    Format = CategoryFormat.Percentage
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Aerial Challenges Won Per 90",
                    CategoryCode = "AerW/90",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryCode = "AerW",
                    CategoryName = "Aerial Challenges Won",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Assists Per 90",
                    CategoryCode = "Asts/90",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryCode = "Mins/Gl",
                    CategoryName = "Minutes Per Goal",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Average Rating",
                    CategoryCode = "AvRat",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryCode = "CleanSheets",
                    CategoryName = "Clean Sheets",
                    Format = CategoryFormat.OptionalNumber
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Conceded Per 90",
                    CategoryCode = "Con/90",
                    Format = CategoryFormat.OptionalRatio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Crosses Attempted",
                    CategoryCode = "CrA",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Crosses Completed Percentage",
                    CategoryCode = "CrC/A",
                    Format = CategoryFormat.Percentage
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Crosses Completed",
                    CategoryCode = "CrC",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Crosses Completed Per 90",
                    CategoryCode = "CrossC/90",
                    Format = CategoryFormat.Ratio
                });                
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Distance Covered (miles)",
                    CategoryCode = "Distance",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Distance Covered Per 90 (miles)",
                    CategoryCode = "Dist/90",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Dribbles Completed",
                    CategoryCode = "Drb",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Dribbles Completed Per Game",
                    CategoryCode = "DrbPG",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Games Won Percentage",
                    CategoryCode = "Gwin",
                    Format = CategoryFormat.Percentage
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Key Aerial Challenges",
                    CategoryCode = "KAer",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Key Passes",
                    CategoryCode = "KPas",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Key Passes Per Game",
                    CategoryCode = "KPPG",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Key Tackles",
                    CategoryCode = "KTck",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Minutes Played",
                    CategoryCode = "Mins",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Mistakes",
                    CategoryCode = "Mstks",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Mistakes Leading To Goals",
                    CategoryCode = "GlMst",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Mistakes Per Game",
                    CategoryCode = "Mst/G",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Offsides",
                    CategoryCode = "Off",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Pass Attempts",
                    CategoryCode = "PasA",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Pass Attempts Per 90",
                    CategoryCode = "PsA/90",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Pass Completed Percentage",
                    CategoryCode = "PasR",
                    Format = CategoryFormat.Percentage
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Passes Completed",
                    CategoryCode = "PsC",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Passes Completed Per 90",
                    CategoryCode = "PsC/90",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Penalty Kicks Attempted",
                    CategoryCode = "Pens",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Penalty Kicks Scored",
                    CategoryCode = "PensScored",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Penalty Kick Conversion Percentage",
                    CategoryCode = "Pen/R",
                    Format = CategoryFormat.Percentage
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Points Per Game",
                    CategoryCode = "Pts/Gm",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Saves Held",
                    CategoryCode = "Svh",
                    Format = CategoryFormat.OptionalNumber
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Saves Parried",
                    CategoryCode = "Svp",
                    Format = CategoryFormat.OptionalNumber
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Saves Tipped",
                    CategoryCode = "Svt",
                    Format = CategoryFormat.OptionalNumber
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Shot Attempts",
                    CategoryCode = "Shots",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Shots On Target",
                    CategoryCode = "ShT",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Shots On Target Per 90",
                    CategoryCode = "ShT/90",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Shots On Target Ratio",
                    CategoryCode = "Sh T",
                    Format = CategoryFormat.Percentage
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Shot Attempts Per 90",
                    CategoryCode = "Shot/90",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Tackle Attempts",
                    CategoryCode = "TckA",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Tackles Won",
                    CategoryCode = "TckW",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Tackle Won Percentage",
                    CategoryCode = "TckR",
                    Format = CategoryFormat.Percentage
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Tackles Per Game",
                    CategoryCode = "Tck",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Non Penalty Goals Per Game",
                    CategoryCode = "Non Penalty Goals",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Interceptions",
                    CategoryCode = "Itc",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Interceptions + Tackles Per Game",
                    CategoryCode = "Int+Tackles",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Interceptions Per 90",
                    CategoryCode = "Int/90",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Shots Per Goal",
                    CategoryCode = "Sh/Gl",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Shots On Target Per Goal",
                    CategoryCode = "ShT/Gl",
                    Format = CategoryFormat.Ratio
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Total Minutes",
                    CategoryCode = "Mins,",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Yellow Cards",
                    CategoryCode = "Yel",
                    Format = CategoryFormat.Number
                });
                context.StatisticalCategories.Add(new StatisticalCategory
                {
                    CategoryName = "Red Cards",
                    CategoryCode = "Red",
                    Format = CategoryFormat.Number
                });
                
                context.SaveChangesWithDate();
            }
        }
    }
}
