using midclasstestsoln.Models;

using System.Collections.Generic;

namespace midclasstestsoln.MockData
{
    public class Wine_collection
    {
        public static IEnumerable<Wine_models> Wine_collections()
        {
            var wines = new List<Wine_models>()
            {
                new Wine_models()
                {
                    Name = "Red Wine",
                    Collection_year = 2010,
                    Wine_Type = Wine_type_definition.alcoholic,
                    Description = "Red wines are made from black grapes fermented with the grape skins (which is where the red colour of the wine comes from), seeds, and stems.",
                    Price = 15000.00,
                    Collection_location = "First shelf; first row"

                },
                new Wine_models()
                {
                    Name = "Rose Wine",
                    Collection_year = 2012,
                    Wine_Type = Wine_type_definition.alcoholic,
                    Description = "It's color created when the juice of black grapes is fermented with the skins for a very short period of time, from a few hours to a few days until the juice turns colour.",
                    Price = 25000.00,
                    Collection_location = "First shelf; second row"

                },
                new Wine_models()
                {
                    Name = "Baileys Irish Cream",
                    Collection_year = 2015,
                    Wine_Type = Wine_type_definition.alcoholic,
                    Description = "Baileys Irish Cream is an Irish cream liqueur, an alcoholic drink flavoured with cream, cocoa and Irish whiskey.",
                    Price = 18000.00,
                    Collection_location = "first shelf; first row"

                },
                new Wine_models()
                {
                    Name = "Hand on Heart",
                    Collection_year = 2017,
                    Wine_Type = Wine_type_definition.Non_alcoholic,
                    Description = "Dark berry and vanilla notes with hints of coffee and tobacco make this NA cabernet a lush pairing for savory meats and cheeses",
                    Price = 9000.00,
                    Collection_location = "Second shelf; first row"

                },
                new Wine_models()
                {
                    Name = "Pierre Zēro Rosé",
                    Collection_year = 2017,
                    Wine_Type = Wine_type_definition.Non_alcoholic,
                    Description = "This zero-proof French bottle brings all of those berry and stonefruit flavors we love from rosé, without the buzz.",
                    Price = 8500.00,
                    Collection_location = "Second shelf; third row"

                }
            };
            return wines;
        }

        
                 
    }

}
