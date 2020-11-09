﻿// Copyright (c) 2019 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace BookApp.Domain.Books
{
    public class CosmosBook 
    {
        public int BookId { get; set; }

        public string Title { get; set; }
        public DateTime PublishedOn { get; set; }
        public bool EstimatedDate { get;  set; }
        public int YearPublished { get; set; }
        public decimal OrgPrice { get; set; }
        public decimal ActualPrice { get; set; }
        public string PromotionalText { get; set; }
        public string AuthorsOrdered { get; set; }
        public int ReviewsCount { get; set; }
        public double ReviewsAverageVotes { get; set; }

        public List<CosmosTag> Tags { get; set; }
    }

}