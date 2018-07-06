﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSSTDEvaluation;
using CSSTDModels;

#region "Data structures"
/*
        namespace CSSTDModels
        {
            [Description("Sample product descriptive document used for Document DB APIs and search")]
            public class ProductDocument
            {
                [Description("Arbitrary key - set to a GUID")]
                public string ID { get; set; }

                [Description("Industry designation, currently 'Training' or 'Swimming'")]
                public string Industry { get; set; }

                [Description("Name of the product")]
                public string Name { get; set; }

                [Description("Pricing tier, currently 'Basic' or 'Premium'")]
                public string Tier { get; set; }

                [Description("Product description, primarily in Latin with a little English embedded for searching.")]
                public string Description { get; set; }

            }
        }
 * */
#endregion

namespace CSSTDSolution.Models
{
    public class SearchContext : ISearchContext
    {
        public SearchContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        public void CreateIndex()
        {
            throw new NotImplementedException();
        }

        public List<ProductDocument> GetDocuments(string Industry)
        {
            throw new NotImplementedException();
        }
    }
}