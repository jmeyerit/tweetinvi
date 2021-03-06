﻿namespace Tweetinvi.Core.Parameters
{
    /// <summary>
    /// https://dev.twitter.com/rest/reference/get/users/search
    /// </summary>
    public interface IUserSearchParameters : ICustomRequestParameters
    {
        /// <summary>
        /// Query to search for people
        /// </summary>
        string SearchQuery { get; set; }

        /// <summary>
        /// Page of result to retrieve
        /// </summary>
        int Page { get; set; }

        /// <summary>
        /// Number of Users to Retrieve.
        /// Cannot be more than 1000 as per the documentation.
        /// </summary>
        int MaximumNumberOfResults { get; set; }

        /// <summary>
        /// User Entities properties will be set
        /// </summary>
        bool IncludeEntities { get; set; }
    }

    public class UserSearchParameters : CustomRequestParameters, IUserSearchParameters
    {
        public UserSearchParameters(string query)
        {
            MaximumNumberOfResults = TweetinviConsts.SEARCH_USERS_COUNT;
            SearchQuery = query;
            IncludeEntities = true;
            Page = 0;
        }

        public string SearchQuery { get; set; }

        public int Page { get; set; }

        public int MaximumNumberOfResults { get; set; }

        public bool IncludeEntities { get; set; }
    }
}
