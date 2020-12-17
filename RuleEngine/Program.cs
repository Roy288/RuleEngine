using RuleEngine.Entities;
using RuleEngine.Entities.Rules;
using RuleEngine.Rules;
using RuleEngine.Services;
using System;
using System.Collections.Generic;

namespace RuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {


        


            //setup our DI
            //var serviceProvider = new ServiceCollection()
            //   
            //    .AddTransient<IRule, ActivateMembershipRule>()
            //    .AddTransient<IRule, FreeFirstAidVideoRule>()
            //    .AddTransient<IRule, GenerateCommisionPaymentRule>()
            //    .AddTransient<IRule, GenerateDuplicatePackingSlipRule>()
            //    .AddTransient<IRule, GeneratePackingSlipRule>()
            //    .AddTransient<IRule, UpgradeMembershipRule>()
            //    .BuildServiceProvider();



           



           

            var ruleEvaluator = new RuleEvaluator(new List<IRule>
            {
                new ActivateMembershipRule(),
                new UpgradeMembershipRule(),
                new FreeFirstAidVideoRule(),
                new GenerateCommisionPaymentRule(),
                new GeneratePackingSlipRule(),
                new GenerateDuplicatePackingSlipRule()
            });

            ruleEvaluator.Evaluate(new Payment
            {
                Products = new List<Product>
            {
                new Product{
                    Name ="A physical product",
                    Category = new ProductCategory
                    {
                        Type = ProductType.Physical,
                        Name = Guid.NewGuid().ToString()
                    },

                },
                new Product{
                    Name = "Learning to Ski",
                    Category = new ProductCategory
                    {
                        Type = ProductType.Abstract,
                        Name = "Video"
                    }
                },

                new Product{
                    Name = "A Book",
                    Category = new ProductCategory
                    {
                        Type = ProductType.Abstract,
                        Name = "Book"
                    },
                }
            }
            });

        }
    }
}
